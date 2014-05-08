namespace SecureMessagingApiClient
{
    partial class SendMessageForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SendMessageForm));
            this.gbActions = new System.Windows.Forms.GroupBox();
            this.btnPost = new System.Windows.Forms.Button();
            this.gbResults = new System.Windows.Forms.GroupBox();
            this.tbResults = new System.Windows.Forms.TextBox();
            this.tabMessage = new System.Windows.Forms.TabControl();
            this.tpMessage = new System.Windows.Forms.TabPage();
            this.messageControl = new SecureMessagingApiClient.Modules.MessageControl();
            this.tpAttachment = new System.Windows.Forms.TabPage();
            this.attachmentControl = new SecureMessagingApiClient.Modules.AttachmentControl();
            this.gbActions.SuspendLayout();
            this.gbResults.SuspendLayout();
            this.tabMessage.SuspendLayout();
            this.tpMessage.SuspendLayout();
            this.tpAttachment.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbActions
            // 
            this.gbActions.Controls.Add(this.btnPost);
            this.gbActions.Location = new System.Drawing.Point(5, 1);
            this.gbActions.Name = "gbActions";
            this.gbActions.Size = new System.Drawing.Size(683, 67);
            this.gbActions.TabIndex = 25;
            this.gbActions.TabStop = false;
            this.gbActions.Text = "Actions";
            // 
            // btnPost
            // 
            this.btnPost.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPost.Location = new System.Drawing.Point(12, 20);
            this.btnPost.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPost.Name = "btnPost";
            this.btnPost.Size = new System.Drawing.Size(80, 34);
            this.btnPost.TabIndex = 25;
            this.btnPost.Text = "Post";
            this.btnPost.UseVisualStyleBackColor = true;
            this.btnPost.Click += new System.EventHandler(this.btnPost_Click);
            // 
            // gbResults
            // 
            this.gbResults.Controls.Add(this.tbResults);
            this.gbResults.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gbResults.Location = new System.Drawing.Point(5, 555);
            this.gbResults.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbResults.Name = "gbResults";
            this.gbResults.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbResults.Size = new System.Drawing.Size(683, 142);
            this.gbResults.TabIndex = 26;
            this.gbResults.TabStop = false;
            this.gbResults.Text = "Results";
            // 
            // tbResults
            // 
            this.tbResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbResults.Location = new System.Drawing.Point(3, 17);
            this.tbResults.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbResults.Multiline = true;
            this.tbResults.Name = "tbResults";
            this.tbResults.ReadOnly = true;
            this.tbResults.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbResults.Size = new System.Drawing.Size(677, 123);
            this.tbResults.TabIndex = 0;
            this.tbResults.TabStop = false;
            // 
            // tabMessage
            // 
            this.tabMessage.Controls.Add(this.tpMessage);
            this.tabMessage.Controls.Add(this.tpAttachment);
            this.tabMessage.Location = new System.Drawing.Point(5, 74);
            this.tabMessage.Name = "tabMessage";
            this.tabMessage.SelectedIndex = 0;
            this.tabMessage.Size = new System.Drawing.Size(683, 476);
            this.tabMessage.TabIndex = 27;
            // 
            // tpMessage
            // 
            this.tpMessage.Controls.Add(this.messageControl);
            this.tpMessage.Location = new System.Drawing.Point(4, 25);
            this.tpMessage.Name = "tpMessage";
            this.tpMessage.Padding = new System.Windows.Forms.Padding(3);
            this.tpMessage.Size = new System.Drawing.Size(675, 447);
            this.tpMessage.TabIndex = 0;
            this.tpMessage.Text = "Message";
            this.tpMessage.UseVisualStyleBackColor = true;
            // 
            // messageControl
            // 
            this.messageControl.Body = "";
            this.messageControl.CC = "";
            this.messageControl.From = "";
            this.messageControl.Location = new System.Drawing.Point(0, 6);
            this.messageControl.MessageId = "";
            this.messageControl.MessageIdEnabled = true;
            this.messageControl.Name = "messageControl";
            this.messageControl.Size = new System.Drawing.Size(669, 438);
            this.messageControl.Subject = "";
            this.messageControl.TabIndex = 28;
            this.messageControl.To = "";
            // 
            // tpAttachment
            // 
            this.tpAttachment.Controls.Add(this.attachmentControl);
            this.tpAttachment.Location = new System.Drawing.Point(4, 25);
            this.tpAttachment.Name = "tpAttachment";
            this.tpAttachment.Padding = new System.Windows.Forms.Padding(3);
            this.tpAttachment.Size = new System.Drawing.Size(675, 447);
            this.tpAttachment.TabIndex = 1;
            this.tpAttachment.Text = "Attachments";
            this.tpAttachment.UseVisualStyleBackColor = true;
            // 
            // attachmentControl
            // 
            this.attachmentControl.Location = new System.Drawing.Point(-4, 6);
            this.attachmentControl.Name = "attachmentControl";
            this.attachmentControl.Size = new System.Drawing.Size(680, 148);
            this.attachmentControl.TabIndex = 24;
            // 
            // SendMessageForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(697, 706);
            this.Controls.Add(this.tabMessage);
            this.Controls.Add(this.gbResults);
            this.Controls.Add(this.gbActions);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SendMessageForm";
            this.Text = "Send Message Client";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.gbActions.ResumeLayout(false);
            this.gbResults.ResumeLayout(false);
            this.gbResults.PerformLayout();
            this.tabMessage.ResumeLayout(false);
            this.tpMessage.ResumeLayout(false);
            this.tpAttachment.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbActions;
        private System.Windows.Forms.Button btnPost;
        private System.Windows.Forms.GroupBox gbResults;
        private System.Windows.Forms.TextBox tbResults;
        private System.Windows.Forms.TabControl tabMessage;
        private System.Windows.Forms.TabPage tpMessage;
        private Modules.MessageControl messageControl;
        private System.Windows.Forms.TabPage tpAttachment;
        private Modules.AttachmentControl attachmentControl;


    }
}