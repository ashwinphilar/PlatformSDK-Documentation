using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using SecureMessagingApiClient.MessageDisposedServiceReference;

namespace SecureMessagingApiClient.Helpers
{
    public static class MessageDisposedHelper
    {
        /// <summary>
        /// Calls the Post method of the MessageDisposed Service
        /// </summary>
        /// <param name="messageId">MessageId of the message to be marked as Disposed</param>
        /// <param name="address">Recipient Address Related to Disposition</param>
        /// <param name="dispositionType">Disposition Type</param>
        /// <param name="certificate">Client Certificate</param>
        /// <returns>True if Successful</returns>
        public static bool Post(Guid messageId, address address, dispositionType dispositionType, X509Certificate2 certificate)
        {
            using (var client = getMessagesClient(certificate))
            {
                return client.post(messageId, address, dispositionType);
            }
        }

        #region Private

        /// <summary>
        /// Instantiate MessageDisposed Client with User Provided Certificate and Password.
        /// </summary>
        private static messageDisposedClient getMessagesClient(X509Certificate2 certificate)
        {
            var client = new messageDisposedClient();
            client.ClientCredentials.ClientCertificate.Certificate = certificate;

            return client;
        }

        #endregion
    }
}
