using System;
using System.Windows.Forms;

namespace SecureMessagingApiClient.Modules
{
    /// <summary>
    /// User Control is for reusability of Messages in Windows Forms.
    /// The Control can be drag and dropped from the Toolbox.
    /// </summary>
    public partial class MessageControl : UserControl
    {

        #region Properties

        /// <summary>
        /// From of Message
        /// </summary>
        public string From { get { return tbFrom.Text; } set { tbFrom.Text = value; } }

        /// <summary>
        /// To of Message
        /// </summary>
        public string To { get { return tbTo.Text; } set { tbTo.Text = value; } }

        /// <summary>
        /// CC of Message
        /// </summary>
        public string CC { get { return tbCC.Text; } set { tbCC.Text = value; } }

        /// <summary>
        /// Subject of Message
        /// </summary>
        public string Subject { get { return tbSubject.Text; } set { tbSubject.Text = value; } }

        /// <summary>
        /// Body of Message
        /// </summary>
        public string Body { get { return tbBody.Text; } set { tbBody.Text = value; } }

        /// <summary>
        /// Message Id of Message
        /// </summary>
        public string MessageId { get { return tbMessageId.Text; } set { tbMessageId.Text = value; } }

        /// <summary>
        /// Handles Enabling of MessageId TextBox
        /// </summary>
        public bool MessageIdEnabled { get { return tbMessageId.Enabled; } set { tbMessageId.Enabled = value; } }

        #endregion

        #region Constructors

        public MessageControl()
        {
            InitializeComponent();
        }

        #endregion

        #region Public

        /// <summary>
        /// Clear contents of Message Control
        /// </summary>
        public void ClearForm()
        {
            tbFrom.Text = string.Empty;
            tbTo.Text = string.Empty;
            tbCC.Text = string.Empty;
            tbSubject.Text = string.Empty;
            tbBody.Text = string.Empty;
            tbMessageId.Text = string.Empty;
        }

        #endregion

        #region Private

        /// <summary>
        /// Clear all Visible fields Text
        /// </summary>
        private void btnClearMessage_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        #endregion

    }
}
