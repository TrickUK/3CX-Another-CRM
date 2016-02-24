namespace AnotherCRM
{
	partial class frmMain
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
			this.lstCalls = new System.Windows.Forms.ListView();
			this.colDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colNumbers = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.lbl3CX = new System.Windows.Forms.ToolStripStatusLabel();
			this.grpMakeCall = new System.Windows.Forms.GroupBox();
			this.cmdCall = new System.Windows.Forms.Button();
			this.txtNumber = new System.Windows.Forms.TextBox();
			this.lblNumber = new System.Windows.Forms.Label();
			this.lblCallState = new System.Windows.Forms.ToolStripStatusLabel();
			this.cmdHangUp = new System.Windows.Forms.Button();
			this.statusStrip1.SuspendLayout();
			this.grpMakeCall.SuspendLayout();
			this.SuspendLayout();
			// 
			// lstCalls
			// 
			this.lstCalls.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lstCalls.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colDate,
            this.colNumbers});
			this.lstCalls.Location = new System.Drawing.Point(12, 80);
			this.lstCalls.Margin = new System.Windows.Forms.Padding(3, 3, 3, 14);
			this.lstCalls.Name = "lstCalls";
			this.lstCalls.Size = new System.Drawing.Size(490, 296);
			this.lstCalls.TabIndex = 0;
			this.lstCalls.UseCompatibleStateImageBehavior = false;
			this.lstCalls.View = System.Windows.Forms.View.Details;
			// 
			// colDate
			// 
			this.colDate.Text = "Date";
			this.colDate.Width = 225;
			// 
			// colNumbers
			// 
			this.colNumbers.Text = "Incoming calls";
			this.colNumbers.Width = 225;
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbl3CX,
            this.lblCallState});
			this.statusStrip1.Location = new System.Drawing.Point(0, 390);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(514, 22);
			this.statusStrip1.TabIndex = 1;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// lbl3CX
			// 
			this.lbl3CX.Image = ((System.Drawing.Image)(resources.GetObject("lbl3CX.Image")));
			this.lbl3CX.Name = "lbl3CX";
			this.lbl3CX.Size = new System.Drawing.Size(80, 17);
			this.lbl3CX.Text = "3CX Active";
			this.lbl3CX.Visible = false;
			// 
			// grpMakeCall
			// 
			this.grpMakeCall.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.grpMakeCall.Controls.Add(this.cmdHangUp);
			this.grpMakeCall.Controls.Add(this.cmdCall);
			this.grpMakeCall.Controls.Add(this.txtNumber);
			this.grpMakeCall.Controls.Add(this.lblNumber);
			this.grpMakeCall.Location = new System.Drawing.Point(12, 9);
			this.grpMakeCall.Margin = new System.Windows.Forms.Padding(3, 0, 3, 8);
			this.grpMakeCall.Name = "grpMakeCall";
			this.grpMakeCall.Padding = new System.Windows.Forms.Padding(8);
			this.grpMakeCall.Size = new System.Drawing.Size(490, 60);
			this.grpMakeCall.TabIndex = 2;
			this.grpMakeCall.TabStop = false;
			this.grpMakeCall.Text = "Make Call:";
			// 
			// cmdCall
			// 
			this.cmdCall.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cmdCall.Enabled = false;
			this.cmdCall.Location = new System.Drawing.Point(323, 22);
			this.cmdCall.Name = "cmdCall";
			this.cmdCall.Size = new System.Drawing.Size(75, 23);
			this.cmdCall.TabIndex = 2;
			this.cmdCall.Text = "Call";
			this.cmdCall.UseVisualStyleBackColor = true;
			this.cmdCall.Click += new System.EventHandler(this.cmdCall_Click);
			// 
			// txtNumber
			// 
			this.txtNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtNumber.Location = new System.Drawing.Point(64, 24);
			this.txtNumber.Name = "txtNumber";
			this.txtNumber.Size = new System.Drawing.Size(253, 20);
			this.txtNumber.TabIndex = 1;
			this.txtNumber.TextChanged += new System.EventHandler(this.txtNumber_TextChanged);
			// 
			// lblNumber
			// 
			this.lblNumber.AutoSize = true;
			this.lblNumber.Location = new System.Drawing.Point(11, 27);
			this.lblNumber.Name = "lblNumber";
			this.lblNumber.Size = new System.Drawing.Size(47, 13);
			this.lblNumber.TabIndex = 0;
			this.lblNumber.Text = "Number:";
			// 
			// lblCallState
			// 
			this.lblCallState.Name = "lblCallState";
			this.lblCallState.Size = new System.Drawing.Size(506, 17);
			this.lblCallState.Spring = true;
			this.lblCallState.Text = "N/a";
			this.lblCallState.Visible = false;
			// 
			// cmdHangUp
			// 
			this.cmdHangUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cmdHangUp.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.cmdHangUp.Enabled = false;
			this.cmdHangUp.Location = new System.Drawing.Point(404, 22);
			this.cmdHangUp.Name = "cmdHangUp";
			this.cmdHangUp.Size = new System.Drawing.Size(75, 23);
			this.cmdHangUp.TabIndex = 3;
			this.cmdHangUp.Text = "Hang Up";
			this.cmdHangUp.UseVisualStyleBackColor = true;
			this.cmdHangUp.Click += new System.EventHandler(this.cmdHangUp_Click);
			// 
			// frmMain
			// 
			this.AcceptButton = this.cmdCall;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.cmdHangUp;
			this.ClientSize = new System.Drawing.Size(514, 412);
			this.Controls.Add(this.grpMakeCall);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.lstCalls);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(530, 450);
			this.Name = "frmMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Another CRM";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
			this.Load += new System.EventHandler(this.frmMain_Load);
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.grpMakeCall.ResumeLayout(false);
			this.grpMakeCall.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListView lstCalls;
		private System.Windows.Forms.ColumnHeader colDate;
		private System.Windows.Forms.ColumnHeader colNumbers;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel lbl3CX;
		private System.Windows.Forms.GroupBox grpMakeCall;
		private System.Windows.Forms.Button cmdCall;
		private System.Windows.Forms.TextBox txtNumber;
		private System.Windows.Forms.Label lblNumber;
		private System.Windows.Forms.ToolStripStatusLabel lblCallState;
		private System.Windows.Forms.Button cmdHangUp;
	}
}

