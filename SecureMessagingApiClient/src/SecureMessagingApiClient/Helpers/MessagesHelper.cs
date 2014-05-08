using System.Security.Cryptography.X509Certificates;
using SecureMessagingApiClient.MessagesServiceReference;

namespace SecureMessagingApiClient.Helpers
{
    public static class MessagesHelper
    {
        #region Public 

        /// <summary>
        /// Calls the Get method of the Messages Service
        /// </summary>
        /// <param name="request">request string</param>
        /// <param name="certificate">Client Certificate</param>
        public static messagelistresponse Get(string request, X509Certificate2 certificate)
        {
            using (var client = getMessagesClient(certificate))
            {
                return client.get(request);
            }
        }

        #endregion

        #region Private

        /// <summary>
        /// Instantiate Messages Client with User Provided Certificate and Password.
        /// </summary>
        private static messagesClient getMessagesClient(X509Certificate2 certificate)
        {
            var client = new messagesClient();
            client.ClientCredentials.ClientCertificate.Certificate = certificate;

            return client;
        }

        #endregion

    }

}
