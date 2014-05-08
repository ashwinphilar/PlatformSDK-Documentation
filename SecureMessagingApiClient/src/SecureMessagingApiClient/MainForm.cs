using System;
using System.Windows.Forms;

namespace SecureMessagingApiClient
{
    public partial class MainForm : Form
    {
        #region Fields

        /// <summary>
        /// SendMessageForm MdiChild for calling SendMessage Service
        /// </summary>
        private SendMessageForm _sendMessageForm;

        /// <summary>
        /// MessagesForm MdiChild for calling Messages Service
        /// </summary>
        private MessagesForm _messagesForm;

        /// <summary>
        /// Certificate Form for importing Client Certificate
        /// </summary>
        private CertificateForm _certificateForm;

        #endregion

        #region Properties

        /// <summary>
        /// Client Certificate used for Verification
        /// </summary>
        public string CertificateFileName { get { return _certificateForm.CertificateFileName; } }

        /// <summary>
        /// Client Certificate Password used for Verification
        /// </summary>
        public string CertificatePassword { get { return _certificateForm.CertificatePassword; } }

        #endregion

        #region Constructors

        public MainForm()
        {
            InitializeComponent();
            showCertificateForm();
        }

        #endregion

        #region Private
        
        /// <summary>
        /// Show Certificate Form
        /// </summary>
        private void showCertificateForm()
        {
            //If Certificate Form is not instantiated, Instantiate
            if (_certificateForm == null)
                _certificateForm = new CertificateForm { MdiParent = this };

            _certificateForm.Show();
        }

        /// <summary>
        /// Show Certificate Form
        /// </summary>
        private void selectCertificateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showCertificateForm();
            _certificateForm.Focus();
        }

        /// <summary>
        /// Show Send Message Client Form
        /// </summary>
        private void btnSendMessage_Click(object sender, EventArgs e)
        {
            //If Send Message Form is not instantiated, Instantiate
            if ((_sendMessageForm == null) || (!_sendMessageForm.Visible))
                _sendMessageForm = new SendMessageForm { MdiParent = this };

            _sendMessageForm.Show();
            _sendMessageForm.Focus();
        }

        /// <summary>
        /// Show Messages Client
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMessages_Click(object sender, EventArgs e)
        {
            //If Messages Form is not instantiated, Instantiate
            if ((_messagesForm == null) || (!_messagesForm.Visible))
                _messagesForm = new MessagesForm { MdiParent = this };

            _messagesForm.Show();
            _messagesForm.Focus();
        }

        /// <summary>
        /// This is a workaround to MS's oversized icon issue in the menu bar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuStrip_ItemAdded(object sender, ToolStripItemEventArgs e)
        {
            if (e.Item.Text == "") e.Item.Visible = false;
        }

        #endregion

    }
}
