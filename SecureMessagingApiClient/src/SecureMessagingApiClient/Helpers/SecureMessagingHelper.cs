using System;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace SecureMessagingApiClient.Helpers
{
    /// <summary>
    /// Helper for Entire Solution
    /// </summary>
    public static class SecureMessagingHelper
    {
        /// <summary>
        /// Get Certificate with Password
        /// </summary>
        /// <param name="main">Main Form that has Certificate and Password</param>
        /// <returns>Client Side Certificate</returns>
        public static X509Certificate2 GetCertificate(MainForm main)
        {
            if (main.CertificateFileName == string.Empty || main.CertificatePassword == string.Empty)
                throw new Exception("Please provide valid Certificate and/or Password.");

            return new X509Certificate2(main.CertificateFileName, main.CertificatePassword);
        }

        /// <summary>
        /// Display Exception
        /// </summary>
        public static void ShowErrorForm(Exception exception)
        {
            using(var form = new ErrorForm(exception))
            {
                form.ShowDialog();
            }
        }
    }
}
