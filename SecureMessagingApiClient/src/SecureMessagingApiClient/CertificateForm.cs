using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SecureMessagingApiClient
{
    public partial class CertificateForm : Form
    {
        #region Properties

        /// <summary>
        /// Client Certificate used for Verification
        /// </summary>
        public string CertificateFileName { get { return tbCertificate.Text; } }

        /// <summary>
        /// Client Certificate Password used for Verification
        /// </summary>
        public string CertificatePassword { get { return tbPassword.Text; } }

        #endregion

        #region Constructors

        public CertificateForm()
        {
            InitializeComponent();
        }

        #endregion

        #region Private

        /// <summary>
        /// File Open Dialog for Loading Client Certificate
        /// </summary>
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            var result = fdCertificate.ShowDialog();
            if (result == DialogResult.OK)
                tbCertificate.Text = fdCertificate.FileName;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Visible = false;
        }

        #endregion

    }
}
