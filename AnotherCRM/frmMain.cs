#region

using System;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.ServiceModel;
using System.Windows.Forms;
using AnotherCRM.Common;
using MyPhonePlugins;

#endregion

namespace AnotherCRM
{
	[ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Single, InstanceContextMode = InstanceContextMode.Single)]
	public partial class frmMain : Form, IIncomingCallService
	{
		private ChannelFactory<IMakeCallService> _makeCallChannelFactory;
		private ServiceHost _host;
		private CRMCallStatus _status;

		public frmMain()
		{
			InitializeComponent();
		}

		private void frmMain_Load(object sender, EventArgs e)
		{
			_host = new ServiceHost(this);
			_host.AddServiceEndpoint(typeof(IIncomingCallService), new NetNamedPipeBinding(NetNamedPipeSecurityMode.None), "net.pipe://localhost/IncomingCallService");
			_host.Open();

			if (!Process.GetProcessesByName("3CXWin8Phone").Any()) {
				string path3CX = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData), @"3CXPhone for Windows\PhoneApp\3CXWin8Phone.exe");
				if (File.Exists(path3CX)) {
					ProcessStartInfo startInfo = new ProcessStartInfo(path3CX) {
						WindowStyle = ProcessWindowStyle.Minimized
					};
					Process.Start(startInfo);
				}
			}

			_makeCallChannelFactory = new ChannelFactory<IMakeCallService>(new NetNamedPipeBinding(NetNamedPipeSecurityMode.None), "net.pipe://localhost/MakeCallService");

			IMakeCallService makeCallService = _makeCallChannelFactory.CreateChannel();
			lbl3CX.Visible = makeCallService.Hello();
			StatusChanged(makeCallService.Status());
		}

		private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
		{
			_host.Close(TimeSpan.FromMilliseconds(500));
		}

		public void IncomingCall(string number)
		{
			ListViewItem item = new ListViewItem(DateTime.Now.ToString(CultureInfo.InvariantCulture));
			item.SubItems.Add(number);
			lstCalls.Items.Add(item);
		}

		public void StatusChanged(CRMCallStatus status)
		{
			_status = status;
			lblCallState.Text = string.Format("Status: {0}", _status.State);
			lblCallState.Visible = true;
			ValidateCall();
			cmdHangUp.Enabled = (_status.State != CallState.Ended & _status.State != CallState.Undefined);
		}

		public bool Hello()
		{
			lbl3CX.Visible = true;
			return true;
		}

		public void Goodbye()
		{
			lbl3CX.Visible = false;
			lblCallState.Visible = false;
		}

		private void cmdCall_Click(object sender, EventArgs e)
		{
			IMakeCallService makeCallService = _makeCallChannelFactory.CreateChannel();
			makeCallService.MakeCall(txtNumber.Text.Trim());
		}

		private void cmdHangUp_Click(object sender, EventArgs e)
		{
			IMakeCallService makeCallService = _makeCallChannelFactory.CreateChannel();
			makeCallService.HangUp(_status.CallId);
		}

		private void txtNumber_TextChanged(object sender, EventArgs e)
		{
			ValidateCall();
		}

		private void ValidateCall()
		{
			cmdCall.Enabled = !string.IsNullOrEmpty(txtNumber.Text.Trim()) && (_status.State == CallState.Ended | _status.State == CallState.Undefined);
		}
	}
}