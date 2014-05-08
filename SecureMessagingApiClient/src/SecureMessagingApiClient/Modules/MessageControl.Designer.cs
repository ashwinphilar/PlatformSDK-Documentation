namespace SecureMessagingApiClient.Modules
{
    partial class MessageControl
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
            this.lblBody = new System.Windows.Forms.Label();
            this.tbBody = new System.Windows.Forms.TextBox();
            this.btnClearMessage = new System.Windows.Forms.Button();
            this.lblMessageId = new System.Windows.Forms.Label();
            this.tbMessageId = new System.Windows.Forms.TextBox();
            this.lblSubject = new System.Windows.Forms.Label();
            this.tbSubject = new System.Windows.Forms.TextBox();
            this.lblCC = new System.Windows.Forms.Label();
            this.tbCC = new System.Windows.Forms.TextBox();
            this.lblFrom = new System.Windows.Forms.Label();
            this.tbFrom = new System.Windows.Forms.TextBox();
            this.lblTo = new System.Windows.Forms.Label();
            this.tbTo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblBody
            // 
            this.lblBody.AutoSize = true;
            this.lblBody.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblBody.Location = new System.Drawing.Point(15, 225);
            this.lblBody.Name = "lblBody";
            this.lblBody.Size = new System.Drawing.Size(40, 17);
            this.lblBody.TabIndex = 43;
            this.lblBody.Text = "Body";
            // 
            // tbBody
            // 
            this.tbBody.Location = new System.Drawing.Point(18, 244);
            this.tbBody.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbBody.MaxLength = 64001;
            this.tbBody.Multiline = true;
            this.tbBody.Name = "tbBody";
            this.tbBody.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbBody.Size = new System.Drawing.Size(642, 184);
            this.tbBody.TabIndex = 37;
            // 
            // btnClearMessage
            // 
            this.btnClearMessage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnClearMessage.Location = new System.Drawing.Point(422, 176);
            this.btnClearMessage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClearMessage.Name = "btnClearMessage";
            this.btnClearMessage.Size = new System.Drawing.Size(123, 34);
            this.btnClearMessage.TabIndex = 32;
            this.btnClearMessage.TabStop = false;
            this.btnClearMessage.Text = "Clear Message";
            this.btnClearMessage.UseVisualStyleBackColor = true;
            this.btnClearMessage.Click += new System.EventHandler(this.btnClearMessage_Click);
            // 
            // lblMessageId
            // 
            this.lblMessageId.AutoSize = true;
            this.lblMessageId.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblMessageId.Location = new System.Drawing.Point(15, 186);
            this.lblMessageId.Name = "lblMessageId";
            this.lblMessageId.Size = new System.Drawing.Size(80, 17);
            this.lblMessageId.TabIndex = 42;
            this.lblMessageId.Text = "Message Id";
            // 
            // tbMessageId
            // 
            this.tbMessageId.Location = new System.Drawing.Point(98, 183);
            this.tbMessageId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbMessageId.Name = "tbMessageId";
            this.tbMessageId.Size = new System.Drawing.Size(303, 22);
            this.tbMessageId.TabIndex = 36;
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSubject.Location = new System.Drawing.Point(15, 146);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(55, 17);
            this.lblSubject.TabIndex = 41;
            this.lblSubject.Text = "Subject";
            // 
            // tbSubject
            // 
            this.tbSubject.Location = new System.Drawing.Point(98, 143);
            this.tbSubject.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSubject.MaxLength = 256;
            this.tbSubject.Name = "tbSubject";
            this.tbSubject.Size = new System.Drawing.Size(303, 22);
            this.tbSubject.TabIndex = 35;
            // 
            // lblCC
            // 
            this.lblCC.AutoSize = true;
            this.lblCC.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCC.Location = new System.Drawing.Point(15, 105);
            this.lblCC.Name = "lblCC";
            this.lblCC.Size = new System.Drawing.Size(26, 17);
            this.lblCC.TabIndex = 40;
            this.lblCC.Text = "CC";
            // 
            // tbCC
            // 
            this.tbCC.Location = new System.Drawing.Point(98, 101);
            this.tbCC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbCC.Name = "tbCC";
            this.tbCC.Size = new System.Drawing.Size(303, 22);
            this.tbCC.TabIndex = 34;
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblFrom.Location = new System.Drawing.Point(15, 26);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(40, 17);
            this.lblFrom.TabIndex = 39;
            this.lblFrom.Text = "From";
            // 
            // tbFrom
            // 
            this.tbFrom.Location = new System.Drawing.Point(98, 23);
            this.tbFrom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbFrom.Name = "tbFrom";
            this.tbFrom.Size = new System.Drawing.Size(303, 22);
            this.tbFrom.TabIndex = 31;
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTo.Location = new System.Drawing.Point(15, 63);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(25, 17);
            this.lblTo.TabIndex = 38;
            this.lblTo.Text = "To";
            // 
            // tbTo
            // 
            this.tbTo.Location = new System.Drawing.Point(98, 60);
            this.tbTo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbTo.Name = "tbTo";
            this.tbTo.Size = new System.Drawing.Size(303, 22);
            this.tbTo.TabIndex = 33;
            // 
            // MessageControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblBody);
            this.Controls.Add(this.tbBody);
            this.Controls.Add(this.btnClearMessage);
            this.Controls.Add(this.lblMessageId);
            this.Controls.Add(this.tbMessageId);
            this.Controls.Add(this.lblSubject);
            this.Controls.Add(this.tbSubject);
            this.Controls.Add(this.lblCC);
            this.Controls.Add(this.tbCC);
            this.Controls.Add(this.lblFrom);
            this.Controls.Add(this.tbFrom);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.tbTo);
            this.Name = "MessageControl";
            this.Size = new System.Drawing.Size(675, 450);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBody;
        private System.Windows.Forms.TextBox tbBody;
        private System.Windows.Forms.Button btnClearMessage;
        private System.Windows.Forms.Label lblMessageId;
        private System.Windows.Forms.TextBox tbMessageId;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.TextBox tbSubject;
        private System.Windows.Forms.Label lblCC;
        private System.Windows.Forms.TextBox tbCC;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.TextBox tbFrom;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.TextBox tbTo;

    }
}
