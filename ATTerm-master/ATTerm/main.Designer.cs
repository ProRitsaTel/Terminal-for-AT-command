namespace ATTerm
{
    partial class Form1
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
            if (disposing && (components != null))
            {
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbBaud = new System.Windows.Forms.ComboBox();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.cmbPort = new System.Windows.Forms.ComboBox();
            this.txtResults = new System.Windows.Forms.TextBox();
            this.txtResultsHex = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnConnectToServer = new System.Windows.Forms.Button();
            this.txtConnectToServer = new System.Windows.Forms.TextBox();
            this.btnDisconectFromServer = new System.Windows.Forms.Button();
            this.txtDisconect = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnSendCmd = new System.Windows.Forms.Button();
            this.txtSendCmd = new System.Windows.Forms.TextBox();
            this.btnSendCycle = new System.Windows.Forms.Button();
            this.txtSend = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtToSend = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cycleMode = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbBaud);
            this.groupBox1.Controls.Add(this.btnDisconnect);
            this.groupBox1.Controls.Add(this.cmbPort);
            this.groupBox1.Location = new System.Drawing.Point(15, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(240, 102);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Com Port";
            // 
            // cmbBaud
            // 
            this.cmbBaud.FormattingEnabled = true;
            this.cmbBaud.Location = new System.Drawing.Point(113, 65);
            this.cmbBaud.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbBaud.Name = "cmbBaud";
            this.cmbBaud.Size = new System.Drawing.Size(121, 24);
            this.cmbBaud.TabIndex = 3;
            this.toolTip1.SetToolTip(this.cmbBaud, "connection baud rate ");
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(5, 22);
            this.btnDisconnect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(101, 23);
            this.btnDisconnect.TabIndex = 1;
            this.btnDisconnect.Text = "Connect";
            this.toolTip1.SetToolTip(this.btnDisconnect, "Serial Port connect/disconnect");
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // cmbPort
            // 
            this.cmbPort.FormattingEnabled = true;
            this.cmbPort.Location = new System.Drawing.Point(113, 21);
            this.cmbPort.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbPort.Name = "cmbPort";
            this.cmbPort.Size = new System.Drawing.Size(121, 24);
            this.cmbPort.TabIndex = 0;
            this.toolTip1.SetToolTip(this.cmbPort, "Com port used");
            // 
            // txtResults
            // 
            this.txtResults.Location = new System.Drawing.Point(471, 41);
            this.txtResults.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtResults.Multiline = true;
            this.txtResults.Name = "txtResults";
            this.txtResults.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResults.Size = new System.Drawing.Size(371, 470);
            this.txtResults.TabIndex = 3;
            this.txtResults.TextChanged += new System.EventHandler(this.txtResults_TextChanged);
            // 
            // txtResultsHex
            // 
            this.txtResultsHex.Font = new System.Drawing.Font("Arial", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultsHex.Location = new System.Drawing.Point(471, 533);
            this.txtResultsHex.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtResultsHex.Multiline = true;
            this.txtResultsHex.Name = "txtResultsHex";
            this.txtResultsHex.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResultsHex.Size = new System.Drawing.Size(371, 149);
            this.txtResultsHex.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(467, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Received:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(467, 514);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Received (HEX):";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnConnectToServer
            // 
            this.btnConnectToServer.Location = new System.Drawing.Point(15, 194);
            this.btnConnectToServer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConnectToServer.Name = "btnConnectToServer";
            this.btnConnectToServer.Size = new System.Drawing.Size(132, 39);
            this.btnConnectToServer.TabIndex = 32;
            this.btnConnectToServer.Text = "Сonnect to server";
            this.toolTip1.SetToolTip(this.btnConnectToServer, "Execute command");
            this.btnConnectToServer.UseVisualStyleBackColor = true;
            this.btnConnectToServer.Click += new System.EventHandler(this.btnAT_Click);
            // 
            // txtConnectToServer
            // 
            this.txtConnectToServer.Location = new System.Drawing.Point(160, 203);
            this.txtConnectToServer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtConnectToServer.Name = "txtConnectToServer";
            this.txtConnectToServer.Size = new System.Drawing.Size(307, 22);
            this.txtConnectToServer.TabIndex = 33;
            this.txtConnectToServer.Text = "AT+CIPSTART=\"TCP\",\"128.65.23.18\",23000";
            this.toolTip1.SetToolTip(this.txtConnectToServer, "AT command to execute");
            this.txtConnectToServer.TextChanged += new System.EventHandler(this.txtConnectToServer_TextChanged);
            // 
            // btnDisconectFromServer
            // 
            this.btnDisconectFromServer.Location = new System.Drawing.Point(15, 256);
            this.btnDisconectFromServer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDisconectFromServer.Name = "btnDisconectFromServer";
            this.btnDisconectFromServer.Size = new System.Drawing.Size(132, 44);
            this.btnDisconectFromServer.TabIndex = 34;
            this.btnDisconectFromServer.Text = "Disconect from server";
            this.toolTip1.SetToolTip(this.btnDisconectFromServer, "Execute command");
            this.btnDisconectFromServer.UseVisualStyleBackColor = true;
            this.btnDisconectFromServer.Click += new System.EventHandler(this.btnAT_Click);
            // 
            // txtDisconect
            // 
            this.txtDisconect.Location = new System.Drawing.Point(160, 265);
            this.txtDisconect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDisconect.Name = "txtDisconect";
            this.txtDisconect.Size = new System.Drawing.Size(307, 22);
            this.txtDisconect.TabIndex = 35;
            this.txtDisconect.Text = "AT+CIPCLOSE";
            this.toolTip1.SetToolTip(this.txtDisconect, "AT command to execute");
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(15, 318);
            this.btnSend.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(132, 36);
            this.btnSend.TabIndex = 36;
            this.btnSend.Text = "Send";
            this.toolTip1.SetToolTip(this.btnSend, "Execute command");
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnAT_Click);
            // 
            // btnSendCmd
            // 
            this.btnSendCmd.Location = new System.Drawing.Point(15, 134);
            this.btnSendCmd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSendCmd.Name = "btnSendCmd";
            this.btnSendCmd.Size = new System.Drawing.Size(132, 39);
            this.btnSendCmd.TabIndex = 38;
            this.btnSendCmd.Text = "Send Command";
            this.toolTip1.SetToolTip(this.btnSendCmd, "Execute command");
            this.btnSendCmd.UseVisualStyleBackColor = true;
            this.btnSendCmd.Click += new System.EventHandler(this.btnAT_Click);
            // 
            // txtSendCmd
            // 
            this.txtSendCmd.Location = new System.Drawing.Point(160, 143);
            this.txtSendCmd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSendCmd.Multiline = true;
            this.txtSendCmd.Name = "txtSendCmd";
            this.txtSendCmd.Size = new System.Drawing.Size(307, 26);
            this.txtSendCmd.TabIndex = 39;
            this.txtSendCmd.Text = "AT";
            this.toolTip1.SetToolTip(this.txtSendCmd, "AT command to execute");
            this.txtSendCmd.TextChanged += new System.EventHandler(this.txtSendCmd_TextChanged);
            // 
            // btnSendCycle
            // 
            this.btnSendCycle.Enabled = false;
            this.btnSendCycle.Location = new System.Drawing.Point(15, 379);
            this.btnSendCycle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSendCycle.Name = "btnSendCycle";
            this.btnSendCycle.Size = new System.Drawing.Size(132, 36);
            this.btnSendCycle.TabIndex = 46;
            this.btnSendCycle.Text = "Send cycle";
            this.toolTip1.SetToolTip(this.btnSendCycle, "Execute command");
            this.btnSendCycle.UseVisualStyleBackColor = true;
            this.btnSendCycle.Click += new System.EventHandler(this.btnAT_Click);
            // 
            // txtSend
            // 
            this.txtSend.Location = new System.Drawing.Point(160, 324);
            this.txtSend.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSend.Name = "txtSend";
            this.txtSend.Size = new System.Drawing.Size(307, 22);
            this.txtSend.TabIndex = 47;
            this.txtSend.Text = "AT+CIPSEND=1";
            this.toolTip1.SetToolTip(this.txtSend, "AT command to execute");
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(223, 385);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(4);
            this.txtQuantity.Multiline = true;
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(243, 24);
            this.txtQuantity.TabIndex = 33;
            this.txtQuantity.Text = "10";
            // 
            // txtToSend
            // 
            this.txtToSend.Location = new System.Drawing.Point(223, 439);
            this.txtToSend.Margin = new System.Windows.Forms.Padding(4);
            this.txtToSend.Multiline = true;
            this.txtToSend.Name = "txtToSend";
            this.txtToSend.Size = new System.Drawing.Size(244, 24);
            this.txtToSend.TabIndex = 34;
            this.txtToSend.Text = "10";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(300, 36);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 39);
            this.button1.TabIndex = 35;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(153, 389);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 48;
            this.label3.Text = "Quantity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(139, 443);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 49;
            this.label4.Text = "How many";
            // 
            // cycleMode
            // 
            this.cycleMode.AutoSize = true;
            this.cycleMode.Location = new System.Drawing.Point(24, 438);
            this.cycleMode.Margin = new System.Windows.Forms.Padding(4);
            this.cycleMode.Name = "cycleMode";
            this.cycleMode.Size = new System.Drawing.Size(99, 21);
            this.cycleMode.TabIndex = 50;
            this.cycleMode.Text = "СycleMode";
            this.cycleMode.UseVisualStyleBackColor = true;
            this.cycleMode.CheckedChanged += new System.EventHandler(this.cycleMode_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 689);
            this.Controls.Add(this.cycleMode);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSendCmd);
            this.Controls.Add(this.txtSendCmd);
            this.Controls.Add(this.txtSend);
            this.Controls.Add(this.txtConnectToServer);
            this.Controls.Add(this.btnConnectToServer);
            this.Controls.Add(this.txtDisconect);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnDisconectFromServer);
            this.Controls.Add(this.txtToSend);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.btnSendCycle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtResultsHex);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtResults);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "AT Command Application";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbBaud;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.ComboBox cmbPort;
        private System.Windows.Forms.TextBox txtResults;
        private System.Windows.Forms.TextBox txtResultsHex;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtToSend;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnConnectToServer;
        private System.Windows.Forms.TextBox txtConnectToServer;
        private System.Windows.Forms.Button btnDisconectFromServer;
        private System.Windows.Forms.TextBox txtDisconect;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnSendCmd;
        private System.Windows.Forms.TextBox txtSendCmd;
        private System.Windows.Forms.Button btnSendCycle;
        private System.Windows.Forms.TextBox txtSend;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox cycleMode;
    }
}

