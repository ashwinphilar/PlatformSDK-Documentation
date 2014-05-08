using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using SecureMessagingApiClient.MessageReceivedServiceReference;

namespace SecureMessagingApiClient.Helpers
{
    public static class MessageReceivedHelper
    {
        /// <summary>
        /// Calls the Post method of the MessageReceived Service
        /// </summary>
        /// <param name="messageId">Id of Message to Mark Received</param>
        /// <param name="certificate">Client Certificate</param>
        /// <returns>True if Successful</returns>
        public static bool Post(Guid messageId, X509Certificate2 certificate)
        {
            using (var client = getMessagesClient(certificate))
            {
                return client.post(messageId);
            }
        }

        #region Private

        /// <summary>
        /// Instantiate MessageReceived Client with User Provided Certificate and Password.
        /// </summary>
        private static messageReceivedClient getMessagesClient(X509Certificate2 certificate)
        {
            var client = new messageReceivedClient();
            client.ClientCredentials.ClientCertificate.Certificate = certificate;

            return client;
        }

        #endregion
    }
}
