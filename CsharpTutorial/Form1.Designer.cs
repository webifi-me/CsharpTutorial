namespace CsharpTutorial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.webifiControl = new WebifiLib.WebifiControl();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSend = new System.Windows.Forms.TextBox();
            this.buttonSend = new System.Windows.Forms.Button();
            this.buttonSendDiscovery = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxRec = new System.Windows.Forms.TextBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxMessages = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // webifiControl
            // 
            this.webifiControl.ConnectName = "webifi";
            this.webifiControl.ConnectPassword = "12345678";
            this.webifiControl.Discoverable = true;
            this.webifiControl.DownloadRequestTimeout = 120;
            this.webifiControl.InstanceName = "Windows Interface";
            this.webifiControl.Location = new System.Drawing.Point(13, 13);
            this.webifiControl.Name = "webifiControl";
            this.webifiControl.NetworkNames = ((System.Collections.Generic.List<string>)(resources.GetObject("webifiControl.NetworkNames")));
            this.webifiControl.ShowControls = true;
            this.webifiControl.Size = new System.Drawing.Size(141, 143);
            this.webifiControl.TabIndex = 0;
            this.webifiControl.UseEncryption = false;
            this.webifiControl.UseWebsocket = true;
            this.webifiControl.ConnectionStatus += new WebifiLib.Webifi.connectionStatusDelegate(this.webifiControl_ConnectionStatus);
            this.webifiControl.DataReceived += new WebifiLib.WebifiControl.byteArrayReceivedDelegate(this.webifiControl_DataReceived);
            this.webifiControl.Error += new WebifiLib.Webifi.errorDelegate(this.webifiControl_Error);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Text to send:";
            // 
            // textBoxSend
            // 
            this.textBoxSend.Location = new System.Drawing.Point(12, 175);
            this.textBoxSend.Name = "textBoxSend";
            this.textBoxSend.Size = new System.Drawing.Size(382, 20);
            this.textBoxSend.TabIndex = 2;
            // 
            // buttonSend
            // 
            this.buttonSend.Enabled = false;
            this.buttonSend.Location = new System.Drawing.Point(13, 202);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(101, 28);
            this.buttonSend.TabIndex = 3;
            this.buttonSend.Text = "Send";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // buttonSendDiscovery
            // 
            this.buttonSendDiscovery.Enabled = false;
            this.buttonSendDiscovery.Location = new System.Drawing.Point(273, 202);
            this.buttonSendDiscovery.Name = "buttonSendDiscovery";
            this.buttonSendDiscovery.Size = new System.Drawing.Size(121, 28);
            this.buttonSendDiscovery.TabIndex = 4;
            this.buttonSendDiscovery.Text = "Send Discovery";
            this.buttonSendDiscovery.UseVisualStyleBackColor = true;
            this.buttonSendDiscovery.Click += new System.EventHandler(this.buttonSendDiscovery_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Text received:";
            // 
            // textBoxRec
            // 
            this.textBoxRec.Location = new System.Drawing.Point(12, 262);
            this.textBoxRec.Multiline = true;
            this.textBoxRec.Name = "textBoxRec";
            this.textBoxRec.Size = new System.Drawing.Size(382, 60);
            this.textBoxRec.TabIndex = 6;
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(13, 328);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(101, 28);
            this.buttonClear.TabIndex = 7;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 371);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Messages:";
            // 
            // textBoxMessages
            // 
            this.textBoxMessages.Location = new System.Drawing.Point(12, 387);
            this.textBoxMessages.Name = "textBoxMessages";
            this.textBoxMessages.Size = new System.Drawing.Size(382, 20);
            this.textBoxMessages.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 421);
            this.Controls.Add(this.textBoxMessages);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.textBoxRec);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonSendDiscovery);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.textBoxSend);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.webifiControl);
            this.Name = "Form1";
            this.Text = "Webifi Tutorial";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WebifiLib.WebifiControl webifiControl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSend;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.Button buttonSendDiscovery;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxRec;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxMessages;
    }
}

