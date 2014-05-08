using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using SecureMessagingApiClient.Helpers;
using SecureMessagingApiClient.SendMessageServiceReference;

namespace SecureMessagingApiClient
{
    public partial class SendMessageForm : Form
    {

        #region Constructors

        public SendMessageForm()
        {
            InitializeComponent();
            //Disable MessageId on MessageControl since it is not editable through this service.
            messageControl.MessageIdEnabled = false;
        }

        #endregion

        #region Service Calls

        /// <summary>
        /// Post Message from User Input
        /// </summary>
        private void btnPost_Click(object sender, EventArgs e)
        {
            //Create Message from Client Input
            var message = new messagerequest
            {
                From = new address { Type = addresstype.Direct, Value = messageControl.From },
                To = parseAddress(messageControl.To),
                CC = parseAddress(messageControl.CC),
                Subject = messageControl.Subject,
                Body = messageControl.Body,
                Attachments = attachmentControl.Attachments
            };

            Cursor = Cursors.WaitCursor;
            try
            {
                // Post service call
                var guid = SendMessageHelper.Post(message, getCertificate());

                //Update UI with returned guid
                tbResults.Text = string.Format("Successful Message Post.\r\nMessage Id = {0}", guid);
                messageControl.MessageId = guid.ToString();
            }
            catch (Exception exception)
            {
                tbResults.Text = string.Empty;
                SecureMessagingHelper.ShowErrorForm(exception);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        #endregion

        #region Private

        /// <summary>
        /// Parse ';' delimited string into an array of addresses. 
        /// </summary>
        /// <param name="text">';' delimited string.</param>
        /// <returns>Array of Addresses.</returns>
        private static address[] parseAddress(string text)
        {
            var addresses = text.Split(';');
            return addresses.Select(a => new address { Type = addresstype.Direct, Value = a.Trim() }).ToArray();
        }

        /// <summary>
        /// Retrieve Certificate from Parent Form
        /// </summary>
        /// <returns></returns>
        private X509Certificate2 getCertificate()
        {
            return SecureMessagingHelper.GetCertificate((MainForm)MdiParent);
        }
        
        #endregion
        
    }
}
