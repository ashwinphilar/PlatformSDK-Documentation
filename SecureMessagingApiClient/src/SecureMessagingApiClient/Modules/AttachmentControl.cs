using System;
using System.IO;
using System.Windows.Forms;
using SecureMessagingApiClient.SendMessageServiceReference;

namespace SecureMessagingApiClient.Modules
{
    /// <summary>
    /// User Control is for reusability of Attachments in Windows Forms.
    /// The Control can be drag and dropped from the Toolbox.
    /// </summary>
    public partial class AttachmentControl : UserControl
    {
        #region Properties

        /// <summary>
        /// Return Array of Attachments from User Input.
        /// </summary>
        public attachmentrequest[] Attachments
        {
            get
            {
                return new []{
                               getAttachment(tbAttachment1.Text),
                               getAttachment(tbAttachment2.Text),
                               getAttachment(tbAttachment3.Text)
                             };
            }
        }

        #endregion
        
        #region Constructors

        public AttachmentControl()
        {
            InitializeComponent();
        }

        #endregion

        #region Private

        /// <summary>
        /// Get Attachment to Upload
        /// </summary>
        /// <param name="filePath">Path of File Attachment</param>
        /// <returns>Attachment</returns>
        private attachmentrequest getAttachment(string filePath)
        {
            // Return Null if No Attachment has been added.
            if (String.IsNullOrEmpty(filePath)) return null;

            // Read the file and return the byte[]
            byte[] buffer;
            using (var fs = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                buffer = new byte[fs.Length];
                fs.Read(buffer, 0, (int)fs.Length);
            }

            return new attachmentrequest { Content = buffer, FileName = Path.GetFileName(filePath) };
        }

        /// <summary>
        /// One-click to remove all attachments
        /// </summary>
        private void btnClearAttachments_Click(object sender, EventArgs e)
        {
            tbAttachment1.Text = string.Empty;
            tbAttachment2.Text = string.Empty;
            tbAttachment3.Text = string.Empty;
        }

        /// <summary>
        /// Load Attachment 1 on Click
        /// </summary>
        private void btnBrowse1_Click(object sender, EventArgs e)
        {
            setAttachment(tbAttachment1);
        }

        /// <summary>
        /// Load Attachment 2 on Click
        /// </summary>
        private void btnBrowse2_Click(object sender, EventArgs e)
        {
            setAttachment(tbAttachment2);
        }

        /// <summary>
        /// Load Attachment 3 on Click
        /// </summary>
        private void btnBrowse3_Click(object sender, EventArgs e)
        {
            setAttachment(tbAttachment3);
        }

        /// <summary>
        /// If FileDialog Result is OK, set the appropriate TextBox with File Path
        /// </summary>
        private void setAttachment(TextBox textBox)
        {
            var result = fdAttachment.ShowDialog();
            if (result == DialogResult.OK)
                textBox.Text = fdAttachment.FileName;
        }

        #endregion
        
    }
}
