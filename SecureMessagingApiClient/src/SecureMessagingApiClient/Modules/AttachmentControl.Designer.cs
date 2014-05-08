namespace SecureMessagingApiClient.Modules
{
    partial class AttachmentControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.fdAttachment = new System.Windows.Forms.OpenFileDialog();
            this.btnClearAttachments = new System.Windows.Forms.Button();
            this.btnBrowse3 = new System.Windows.Forms.Button();
            this.tbAttachment3 = new System.Windows.Forms.TextBox();
            this.btnBrowse2 = new System.Windows.Forms.Button();
            this.tbAttachment2 = new System.Windows.Forms.TextBox();
            this.btnBrowse1 = new System.Windows.Forms.Button();
            this.tbAttachment1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnClearAttachments
            // 
            this.btnClearAttachments.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnClearAttachments.Location = new System.Drawing.Point(439, 91);
            this.btnClearAttachments.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClearAttachments.Name = "btnClearAttachments";
            this.btnClearAttachments.Size = new System.Drawing.Size(148, 34);
            this.btnClearAttachments.TabIndex = 10;
            this.btnClearAttachments.TabStop = false;
            this.btnClearAttachments.Text = "Clear Attachments";
            this.btnClearAttachments.UseVisualStyleBackColor = true;
            this.btnClearAttachments.Click += new System.EventHandler(this.btnClearAttachments_Click);
            // 
            // btnBrowse3
            // 
            this.btnBrowse3.Location = new System.Drawing.Point(342, 97);
            this.btnBrowse3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBrowse3.Name = "btnBrowse3";
            this.btnBrowse3.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse3.TabIndex = 9;
            this.btnBrowse3.Text = "Browse...";
            this.btnBrowse3.UseVisualStyleBackColor = true;
            this.btnBrowse3.Click += new System.EventHandler(this.btnBrowse3_Click);
            // 
            // tbAttachment3
            // 
            this.tbAttachment3.Location = new System.Drawing.Point(20, 99);
            this.tbAttachment3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbAttachment3.Name = "tbAttachment3";
            this.tbAttachment3.ReadOnly = true;
            this.tbAttachment3.Size = new System.Drawing.Size(303, 22);
            this.tbAttachment3.TabIndex = 4;
            this.tbAttachment3.TabStop = false;
            // 
            // btnBrowse2
            // 
            this.btnBrowse2.Location = new System.Drawing.Point(342, 61);
            this.btnBrowse2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBrowse2.Name = "btnBrowse2";
            this.btnBrowse2.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse2.TabIndex = 8;
            this.btnBrowse2.Text = "Browse...";
            this.btnBrowse2.UseVisualStyleBackColor = true;
            this.btnBrowse2.Click += new System.EventHandler(this.btnBrowse2_Click);
            // 
            // tbAttachment2
            // 
            this.tbAttachment2.Location = new System.Drawing.Point(20, 63);
            this.tbAttachment2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbAttachment2.Name = "tbAttachment2";
            this.tbAttachment2.ReadOnly = true;
            this.tbAttachment2.Size = new System.Drawing.Size(303, 22);
            this.tbAttachment2.TabIndex = 5;
            this.tbAttachment2.TabStop = false;
            // 
            // btnBrowse1
            // 
            this.btnBrowse1.Location = new System.Drawing.Point(342, 26);
            this.btnBrowse1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBrowse1.Name = "btnBrowse1";
            this.btnBrowse1.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse1.TabIndex = 7;
            this.btnBrowse1.Text = "Browse...";
            this.btnBrowse1.UseVisualStyleBackColor = true;
            this.btnBrowse1.Click += new System.EventHandler(this.btnBrowse1_Click);
            // 
            // tbAttachment1
            // 
            this.tbAttachment1.Location = new System.Drawing.Point(20, 28);
            this.tbAttachment1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbAttachment1.Name = "tbAttachment1";
            this.tbAttachment1.ReadOnly = true;
            this.tbAttachment1.Size = new System.Drawing.Size(303, 22);
            this.tbAttachment1.TabIndex = 6;
            this.tbAttachment1.TabStop = false;
            // 
            // AttachmentControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnClearAttachments);
            this.Controls.Add(this.btnBrowse3);
            this.Controls.Add(this.tbAttachment3);
            this.Controls.Add(this.btnBrowse2);
            this.Controls.Add(this.tbAttachment2);
            this.Controls.Add(this.btnBrowse1);
            this.Controls.Add(this.tbAttachment1);
            this.Name = "AttachmentControl";
            this.Size = new System.Drawing.Size(686, 148);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog fdAttachment;
        private System.Windows.Forms.Button btnClearAttachments;
        private System.Windows.Forms.Button btnBrowse3;
        private System.Windows.Forms.TextBox tbAttachment3;
        private System.Windows.Forms.Button btnBrowse2;
        private System.Windows.Forms.TextBox tbAttachment2;
        private System.Windows.Forms.Button btnBrowse1;
        private System.Windows.Forms.TextBox tbAttachment1;
    }
}
