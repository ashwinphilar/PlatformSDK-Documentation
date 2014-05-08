using System;
using System.Security.Cryptography.X509Certificates;
using SecureMessagingApiClient.SendMessageServiceReference;

namespace SecureMessagingApiClient.Helpers
{
    /// <summary>
    /// Acts as a Proxy between UI for making SendMessageService calls
    /// </summary>
    public static class SendMessageHelper
    {

        #region Public

        /// <summary>
        /// Calls the Post method of Send Message Service
        /// </summary>
        /// <param name="message">Message for Transmission</param>
        /// <param name="certificate">Client Certificate</param>
        /// <returns>Guid of Queued Message.</returns>
        public static Guid Post(messagerequest message, X509Certificate2 certificate)
        {
            using (var client = getSendMessageClient(certificate))
            {
                return client.post(message);
            }
        }
        
        #endregion
        
        #region Private

        /// <summary>
        /// Instantiate Send Message Client with User Provided Certificate and Password.
        /// </summary>
        private static sendMessageClient getSendMessageClient(X509Certificate2 certificate)
        {
            var client = new sendMessageClient();
            client.ClientCredentials.ClientCertificate.Certificate = certificate;

            return client;
        }

        #endregion

    }
}
