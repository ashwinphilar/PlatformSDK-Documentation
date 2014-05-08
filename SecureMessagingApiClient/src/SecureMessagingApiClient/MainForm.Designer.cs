namespace SecureMessagingApiClient
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.certificateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectCertificateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendMessageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.messagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.AutoSize = false;
            this.menuStrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.certificateToolStripMenuItem,
            this.selectClientToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(698, 26);
            this.menuStrip.TabIndex = 21;
            this.menuStrip.ItemAdded += new System.Windows.Forms.ToolStripItemEventHandler(this.menuStrip_ItemAdded);
            // 
            // certificateToolStripMenuItem
            // 
            this.certificateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectCertificateToolStripMenuItem});
            this.certificateToolStripMenuItem.Name = "certificateToolStripMenuItem";
            this.certificateToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.certificateToolStripMenuItem.Text = "Select Certificate";
            // 
            // selectCertificateToolStripMenuItem
            // 
            this.selectCertificateToolStripMenuItem.Name = "selectCertificateToolStripMenuItem";
            this.selectCertificateToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.selectCertificateToolStripMenuItem.Text = "Client Certificate";
            this.selectCertificateToolStripMenuItem.Click += new System.EventHandler(this.selectCertificateToolStripMenuItem_Click);
            // 
            // selectClientToolStripMenuItem
            // 
            this.selectClientToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sendMessageToolStripMenuItem,
            this.messagesToolStripMenuItem});
            this.selectClientToolStripMenuItem.Name = "selectClientToolStripMenuItem";
            this.selectClientToolStripMenuItem.Size = new System.Drawing.Size(97, 22);
            this.selectClientToolStripMenuItem.Text = "Select Client";
            // 
            // sendMessageToolStripMenuItem
            // 
            this.sendMessageToolStripMenuItem.Name = "sendMessageToolStripMenuItem";
            this.sendMessageToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.sendMessageToolStripMenuItem.Text = "Send Message";
            this.sendMessageToolStripMenuItem.Click += new System.EventHandler(this.btnSendMessage_Click);
            // 
            // messagesToolStripMenuItem
            // 
            this.messagesToolStripMenuItem.Name = "messagesToolStripMenuItem";
            this.messagesToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.messagesToolStripMenuItem.Text = "Messages";
            this.messagesToolStripMenuItem.Click += new System.EventHandler(this.btnMessages_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Location = new System.Drawing.Point(0, 729);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(698, 22);
            this.statusStrip.TabIndex = 23;
            this.statusStrip.Text = "statusStrip1";
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(698, 751);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Secure Messaging Api Client";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem certificateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectCertificateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendMessageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem messagesToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip;

    }
}

