namespace SecureMessagingApiClient
{
    partial class CertificateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CertificateForm));
            this.gbCertificate = new System.Windows.Forms.GroupBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.lblPassword = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.lblCertificate = new System.Windows.Forms.Label();
            this.tbCertificate = new System.Windows.Forms.TextBox();
            this.fdCertificate = new System.Windows.Forms.OpenFileDialog();
            this.gbCertificate.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbCertificate
            // 
            this.gbCertificate.Controls.Add(this.btnOK);
            this.gbCertificate.Controls.Add(this.lblPassword);
            this.gbCertificate.Controls.Add(this.tbPassword);
            this.gbCertificate.Controls.Add(this.btnBrowse);
            this.gbCertificate.Controls.Add(this.lblCertificate);
            this.gbCertificate.Controls.Add(this.tbCertificate);
            this.gbCertificate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbCertificate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gbCertificate.Location = new System.Drawing.Point(0, 0);
            this.gbCertificate.Margin = new System.Windows.Forms.Padding(2);
            this.gbCertificate.Name = "gbCertificate";
            this.gbCertificate.Padding = new System.Windows.Forms.Padding(2);
            this.gbCertificate.Size = new System.Drawing.Size(462, 128);
            this.gbCertificate.TabIndex = 20;
            this.gbCertificate.TabStop = false;
            this.gbCertificate.Text = "Client Certificate";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(306, 60);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 27);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(12, 65);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(69, 17);
            this.lblPassword.TabIndex = 11;
            this.lblPassword.Text = "Password";
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(86, 62);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(2);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(206, 22);
            this.tbPassword.TabIndex = 2;
            this.tbPassword.UseSystemPasswordChar = true;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(306, 19);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(2);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 31);
            this.btnBrowse.TabIndex = 1;
            this.btnBrowse.Text = "Browse...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // lblCertificate
            // 
            this.lblCertificate.AutoSize = true;
            this.lblCertificate.Location = new System.Drawing.Point(12, 28);
            this.lblCertificate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCertificate.Name = "lblCertificate";
            this.lblCertificate.Size = new System.Drawing.Size(71, 17);
            this.lblCertificate.TabIndex = 8;
            this.lblCertificate.Text = "Certificate";
            // 
            // tbCertificate
            // 
            this.tbCertificate.Location = new System.Drawing.Point(86, 25);
            this.tbCertificate.Margin = new System.Windows.Forms.Padding(2);
            this.tbCertificate.Name = "tbCertificate";
            this.tbCertificate.ReadOnly = true;
            this.tbCertificate.Size = new System.Drawing.Size(206, 22);
            this.tbCertificate.TabIndex = 0;
            // 
            // CertificateForm
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(462, 128);
            this.ControlBox = false;
            this.Controls.Add(this.gbCertificate);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Location", global::SecureMessagingApiClient.Properties.Settings.Default, "Centered", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = global::SecureMessagingApiClient.Properties.Settings.Default.Centered;
            this.Name = "CertificateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Select Client Certificate";
            this.TopMost = true;
            this.gbCertificate.ResumeLayout(false);
            this.gbCertificate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCertificate;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label lblCertificate;
        private System.Windows.Forms.TextBox tbCertificate;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.OpenFileDialog fdCertificate;
    }
}