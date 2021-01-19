
namespace WinTorControl
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtHost = new System.Windows.Forms.TextBox();
            this.btnMakeConnection = new System.Windows.Forms.Button();
            this.numPort = new System.Windows.Forms.NumericUpDown();
            this.gbxConnect = new System.Windows.Forms.GroupBox();
            this.btnSaveConfig = new System.Windows.Forms.Button();
            this.btnopeFile = new System.Windows.Forms.Button();
            this.txtHashedPassword = new System.Windows.Forms.TextBox();
            this.gbxComment = new System.Windows.Forms.GroupBox();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.btnCommand = new System.Windows.Forms.Button();
            this.txtCommands = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rtbEvents = new System.Windows.Forms.RichTextBox();
            this.rtbMessages = new System.Windows.Forms.RichTextBox();
            this.gbEvents = new System.Windows.Forms.GroupBox();
            this.btnClearEvents = new System.Windows.Forms.Button();
            this.btnSetEvent = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.btnClearLogs = new System.Windows.Forms.Button();
            this.btnClearMessages = new System.Windows.Forms.Button();
            this.gbSignal = new System.Windows.Forms.GroupBox();
            this.btnSignal = new System.Windows.Forms.Button();
            this.cmbSignals = new System.Windows.Forms.ComboBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numPort)).BeginInit();
            this.gbxConnect.SuspendLayout();
            this.gbxComment.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gbEvents.SuspendLayout();
            this.gbSignal.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtHost
            // 
            this.txtHost.Location = new System.Drawing.Point(11, 39);
            this.txtHost.Name = "txtHost";
            this.txtHost.PlaceholderText = "Ip or host";
            this.txtHost.Size = new System.Drawing.Size(157, 23);
            this.txtHost.TabIndex = 6;
            // 
            // btnMakeConnection
            // 
            this.btnMakeConnection.Location = new System.Drawing.Point(255, 39);
            this.btnMakeConnection.Name = "btnMakeConnection";
            this.btnMakeConnection.Size = new System.Drawing.Size(116, 23);
            this.btnMakeConnection.TabIndex = 5;
            this.btnMakeConnection.Text = "Start connection";
            this.btnMakeConnection.UseVisualStyleBackColor = true;
            this.btnMakeConnection.Click += new System.EventHandler(this.btnMakeConnection_Click);
            // 
            // numPort
            // 
            this.numPort.Location = new System.Drawing.Point(174, 39);
            this.numPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numPort.Name = "numPort";
            this.numPort.Size = new System.Drawing.Size(75, 23);
            this.numPort.TabIndex = 3;
            this.numPort.Value = new decimal(new int[] {
            9051,
            0,
            0,
            0});
            // 
            // gbxConnect
            // 
            this.gbxConnect.Controls.Add(this.btnSaveConfig);
            this.gbxConnect.Controls.Add(this.btnopeFile);
            this.gbxConnect.Controls.Add(this.txtHashedPassword);
            this.gbxConnect.Controls.Add(this.txtHost);
            this.gbxConnect.Controls.Add(this.btnMakeConnection);
            this.gbxConnect.Controls.Add(this.numPort);
            this.gbxConnect.Location = new System.Drawing.Point(12, 8);
            this.gbxConnect.Name = "gbxConnect";
            this.gbxConnect.Size = new System.Drawing.Size(390, 100);
            this.gbxConnect.TabIndex = 12;
            this.gbxConnect.TabStop = false;
            this.gbxConnect.Text = "connect to tor";
            // 
            // btnSaveConfig
            // 
            this.btnSaveConfig.Location = new System.Drawing.Point(294, 68);
            this.btnSaveConfig.Name = "btnSaveConfig";
            this.btnSaveConfig.Size = new System.Drawing.Size(77, 23);
            this.btnSaveConfig.TabIndex = 9;
            this.btnSaveConfig.Text = "save";
            this.toolTip1.SetToolTip(this.btnSaveConfig, "Save connection configuration");
            this.btnSaveConfig.UseVisualStyleBackColor = true;
            this.btnSaveConfig.Click += new System.EventHandler(this.btnSaveConfig_Click);
            // 
            // btnopeFile
            // 
            this.btnopeFile.Location = new System.Drawing.Point(174, 68);
            this.btnopeFile.Name = "btnopeFile";
            this.btnopeFile.Size = new System.Drawing.Size(114, 23);
            this.btnopeFile.TabIndex = 8;
            this.btnopeFile.Text = "Authentication file";
            this.btnopeFile.UseVisualStyleBackColor = true;
            this.btnopeFile.Click += new System.EventHandler(this.btnopeFile_Click);
            // 
            // txtHashedPassword
            // 
            this.txtHashedPassword.Location = new System.Drawing.Point(11, 68);
            this.txtHashedPassword.Name = "txtHashedPassword";
            this.txtHashedPassword.PasswordChar = '*';
            this.txtHashedPassword.PlaceholderText = "hashed password";
            this.txtHashedPassword.Size = new System.Drawing.Size(157, 23);
            this.txtHashedPassword.TabIndex = 7;
            // 
            // gbxComment
            // 
            this.gbxComment.Controls.Add(this.btnDisconnect);
            this.gbxComment.Controls.Add(this.btnCommand);
            this.gbxComment.Controls.Add(this.txtCommands);
            this.gbxComment.Enabled = false;
            this.gbxComment.Location = new System.Drawing.Point(12, 114);
            this.gbxComment.Name = "gbxComment";
            this.gbxComment.Size = new System.Drawing.Size(390, 135);
            this.gbxComment.TabIndex = 13;
            this.gbxComment.TabStop = false;
            this.gbxComment.Text = "commands ";
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(11, 106);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(116, 23);
            this.btnDisconnect.TabIndex = 9;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // btnCommand
            // 
            this.btnCommand.Location = new System.Drawing.Point(255, 106);
            this.btnCommand.Name = "btnCommand";
            this.btnCommand.Size = new System.Drawing.Size(116, 23);
            this.btnCommand.TabIndex = 8;
            this.btnCommand.Text = "command";
            this.btnCommand.UseVisualStyleBackColor = true;
            this.btnCommand.Click += new System.EventHandler(this.btnCommand_Click);
            // 
            // txtCommands
            // 
            this.txtCommands.Location = new System.Drawing.Point(11, 22);
            this.txtCommands.Multiline = true;
            this.txtCommands.Name = "txtCommands";
            this.txtCommands.PlaceholderText = "Write tor control command";
            this.txtCommands.Size = new System.Drawing.Size(360, 82);
            this.txtCommands.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.rtbEvents);
            this.panel1.Controls.Add(this.rtbMessages);
            this.panel1.Location = new System.Drawing.Point(0, 329);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 119);
            this.panel1.TabIndex = 14;
            // 
            // rtbEvents
            // 
            this.rtbEvents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbEvents.Location = new System.Drawing.Point(0, 0);
            this.rtbEvents.Name = "rtbEvents";
            this.rtbEvents.ReadOnly = true;
            this.rtbEvents.Size = new System.Drawing.Size(485, 119);
            this.rtbEvents.TabIndex = 0;
            this.rtbEvents.Text = "";
            // 
            // rtbMessages
            // 
            this.rtbMessages.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbMessages.Location = new System.Drawing.Point(491, 0);
            this.rtbMessages.Name = "rtbMessages";
            this.rtbMessages.ReadOnly = true;
            this.rtbMessages.Size = new System.Drawing.Size(309, 119);
            this.rtbMessages.TabIndex = 1;
            this.rtbMessages.Text = "";
            // 
            // gbEvents
            // 
            this.gbEvents.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbEvents.Controls.Add(this.btnClearEvents);
            this.gbEvents.Controls.Add(this.btnSetEvent);
            this.gbEvents.Controls.Add(this.checkedListBox1);
            this.gbEvents.Enabled = false;
            this.gbEvents.Location = new System.Drawing.Point(408, 8);
            this.gbEvents.MinimumSize = new System.Drawing.Size(150, 0);
            this.gbEvents.Name = "gbEvents";
            this.gbEvents.Size = new System.Drawing.Size(380, 241);
            this.gbEvents.TabIndex = 15;
            this.gbEvents.TabStop = false;
            this.gbEvents.Text = "event listeners";
            // 
            // btnClearEvents
            // 
            this.btnClearEvents.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearEvents.Location = new System.Drawing.Point(136, 209);
            this.btnClearEvents.Name = "btnClearEvents";
            this.btnClearEvents.Size = new System.Drawing.Size(116, 23);
            this.btnClearEvents.TabIndex = 11;
            this.btnClearEvents.Text = "Clear";
            this.btnClearEvents.UseVisualStyleBackColor = true;
            this.btnClearEvents.Click += new System.EventHandler(this.btnClearEvents_Click);
            // 
            // btnSetEvent
            // 
            this.btnSetEvent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSetEvent.Location = new System.Drawing.Point(258, 209);
            this.btnSetEvent.Name = "btnSetEvent";
            this.btnSetEvent.Size = new System.Drawing.Size(116, 23);
            this.btnSetEvent.TabIndex = 10;
            this.btnSetEvent.Text = "Set Events";
            this.btnSetEvent.UseVisualStyleBackColor = true;
            this.btnSetEvent.Click += new System.EventHandler(this.btnSetEvent_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(3, 19);
            this.checkedListBox1.MinimumSize = new System.Drawing.Size(150, 150);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(374, 184);
            this.checkedListBox1.TabIndex = 0;
            // 
            // btnClearLogs
            // 
            this.btnClearLogs.Location = new System.Drawing.Point(408, 300);
            this.btnClearLogs.Name = "btnClearLogs";
            this.btnClearLogs.Size = new System.Drawing.Size(127, 23);
            this.btnClearLogs.TabIndex = 16;
            this.btnClearLogs.Text = "clear events log";
            this.btnClearLogs.UseVisualStyleBackColor = true;
            this.btnClearLogs.Click += new System.EventHandler(this.btnClearLogs_Click);
            // 
            // btnClearMessages
            // 
            this.btnClearMessages.Location = new System.Drawing.Point(408, 271);
            this.btnClearMessages.Name = "btnClearMessages";
            this.btnClearMessages.Size = new System.Drawing.Size(127, 23);
            this.btnClearMessages.TabIndex = 16;
            this.btnClearMessages.Text = "clear messages";
            this.btnClearMessages.UseVisualStyleBackColor = true;
            this.btnClearMessages.Click += new System.EventHandler(this.btnClearMessages_Click);
            // 
            // gbSignal
            // 
            this.gbSignal.Controls.Add(this.btnSignal);
            this.gbSignal.Controls.Add(this.cmbSignals);
            this.gbSignal.Enabled = false;
            this.gbSignal.Location = new System.Drawing.Point(12, 255);
            this.gbSignal.Name = "gbSignal";
            this.gbSignal.Size = new System.Drawing.Size(390, 68);
            this.gbSignal.TabIndex = 17;
            this.gbSignal.TabStop = false;
            this.gbSignal.Text = "Signal";
            // 
            // btnSignal
            // 
            this.btnSignal.Location = new System.Drawing.Point(255, 26);
            this.btnSignal.Name = "btnSignal";
            this.btnSignal.Size = new System.Drawing.Size(116, 23);
            this.btnSignal.TabIndex = 9;
            this.btnSignal.Text = "signal";
            this.btnSignal.UseVisualStyleBackColor = true;
            this.btnSignal.Click += new System.EventHandler(this.btnSignal_Click);
            // 
            // cmbSignals
            // 
            this.cmbSignals.FormattingEnabled = true;
            this.cmbSignals.Location = new System.Drawing.Point(21, 27);
            this.cmbSignals.Name = "cmbSignals";
            this.cmbSignals.Size = new System.Drawing.Size(228, 23);
            this.cmbSignals.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbSignal);
            this.Controls.Add(this.btnClearMessages);
            this.Controls.Add(this.btnClearLogs);
            this.Controls.Add(this.gbxConnect);
            this.Controls.Add(this.gbxComment);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gbEvents);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Windows Tor Control";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numPort)).EndInit();
            this.gbxConnect.ResumeLayout(false);
            this.gbxConnect.PerformLayout();
            this.gbxComment.ResumeLayout(false);
            this.gbxComment.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.gbEvents.ResumeLayout(false);
            this.gbSignal.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtHost;
        private System.Windows.Forms.Button btnMakeConnection;
        private System.Windows.Forms.NumericUpDown numPort;
        private System.Windows.Forms.GroupBox gbxConnect;
        private System.Windows.Forms.TextBox txtHashedPassword;
        private System.Windows.Forms.GroupBox gbxComment;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Button btnCommand;
        private System.Windows.Forms.TextBox txtCommands;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox rtbMessages;
        private System.Windows.Forms.RichTextBox rtbEvents;
        private System.Windows.Forms.GroupBox gbEvents;
        private System.Windows.Forms.Button btnClearEvents;
        private System.Windows.Forms.Button btnSetEvent;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button btnClearLogs;
        private System.Windows.Forms.Button btnClearMessages;
        private System.Windows.Forms.GroupBox gbSignal;
        private System.Windows.Forms.ComboBox cmbSignals;
        private System.Windows.Forms.Button btnSignal;
        private System.Windows.Forms.Button btnopeFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnSaveConfig;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

