#region

using System;
using System.Linq;
using System.ServiceModel;
using System.Threading.Tasks;
using AnotherCRM.Common;
using MyPhonePlugins;

#endregion

namespace AnotherCRM.Integration
{
	[CRMPluginLoader, ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Single, InstanceContextMode = InstanceContextMode.Single)]
	public class Plugin3CX : IMakeCallService
	{
		private static Plugin3CX _instance;
		private IMyPhoneCallHandler _callHandler;
		private ServiceHost _host;
		private ChannelFactory<IIncomingCallService> _incomingCallChannelFactory;
		
		[CRMPluginInitializer]
		public static void Loader(IMyPhoneCallHandler callHandler)
		{
			_instance = new Plugin3CX(callHandler);
		}

		[CRMPluginDispose]
		public static void Disposer()
		{
			_instance.Dispose();
		}

		private Plugin3CX(IMyPhoneCallHandler callHandler)
		{
			_callHandler = callHandler;
			callHandler.OnCallStatusChanged += callHandler_OnCallStatusChanged;

			_host = new ServiceHost(this);
			_host.AddServiceEndpoint(typeof(IMakeCallService), new NetNamedPipeBinding(NetNamedPipeSecurityMode.None), "net.pipe://localhost/MakeCallService");
			_host.Open();

			_incomingCallChannelFactory = new ChannelFactory<IIncomingCallService>(new NetNamedPipeBinding(NetNamedPipeSecurityMode.None), "net.pipe://localhost/IncomingCallService");
			IIncomingCallService incomingCallService = _incomingCallChannelFactory.CreateChannel();
			incomingCallService.Hello();
			incomingCallService.StatusChanged(Status());
		}

		private void Dispose()
		{
			IIncomingCallService incomingCallService = _incomingCallChannelFactory.CreateChannel();
			incomingCallService.Goodbye();
			_host.Close(TimeSpan.FromMilliseconds(500));
		}

		public void MakeCall(string destination)
		{
			Task.Factory.StartNew(() =>
			{
				_instance._callHandler.MakeCall(destination, MakeCallOptions.None);
			});
		}

		public void HangUp(string callid)
		{
			Task.Factory.StartNew(() => {
				_instance._callHandler.DropCall(callid);
			});
		}

		public bool Hello()
		{
			return true;
		}

		public CRMCallStatus Status()
		{
			return _callHandler.ActiveCalls.Any() ? new CRMCallStatus(_callHandler.ActiveCalls[0].CallID, _callHandler.ActiveCalls[0].State) : new CRMCallStatus(string.Empty, CallState.Undefined);
		}

		private void callHandler_OnCallStatusChanged(object sender, CallStatus callinfo)
		{
			IIncomingCallService incomingCallService = _incomingCallChannelFactory.CreateChannel();
			//MessageBox.Show(callinfo.State.ToString());
			incomingCallService.StatusChanged(new CRMCallStatus(callinfo.CallID, callinfo.State));
			if (callinfo.State != CallState.Ringing) return;
			incomingCallService.IncomingCall(callinfo.OtherPartyNumber);

			//if (!callinfo.Incoming || callinfo.State != CallState.Ringing) return;

			//MessageBox.Show(callinfo.CallID);
			//MessageBox.Show(callinfo.Originator);
			//MessageBox.Show(callinfo.OriginatorName);

			//MessageBox.Show(callinfo.OtherPartyNumber);
			//MessageBox.Show(callinfo.OtherPartyName);

			//IIncomingCallService callbackChannel = OperationContext.Current.GetCallbackChannel<IIncomingCallService>();
			//callbackChannel.IncomingCall(callinfo.OtherPartyNumber);
		}
	}
}