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
    public partial class ErrorForm : Form
    {
        /// <summary>
        /// Separates Multiple Inner Exceptions
        /// </summary>
        private const string Separator = "\r\n----------------------------------------------------------------------------------------------------------------\r\n";

        #region Constructors

        public ErrorForm()
        {
            InitializeComponent();
        }

        public ErrorForm(Exception exception) : this()
        {
            tbMessage.Text = concatInnerExceptions(exception);
        }

        #endregion

        #region Private

        /// <summary>
        /// Concatenate all exceptions
        /// </summary>
        private string concatInnerExceptions(Exception exception)
        {
            var sb = new StringBuilder(string.Format("\r\nType: {0} \r\nMessage: {1} \r\nStackTrace: {2} {3}", exception.GetType(), exception.Message, exception.StackTrace, Separator));
            
            //Recursive Call if we have nested Inner Exceptions)
            if (exception.InnerException != null) sb.AppendLine(concatInnerExceptions(exception.InnerException));

            return sb.ToString();
        }

        #endregion

    }
}
