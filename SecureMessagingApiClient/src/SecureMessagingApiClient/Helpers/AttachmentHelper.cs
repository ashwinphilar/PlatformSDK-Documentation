using System;
using System.Security.Cryptography.X509Certificates;
using SecureMessagingApiClient.AttachmentServiceReference;

namespace SecureMessagingApiClient.Helpers
{
    public static class AttachmentHelper
    {

        #region Public 

        /// <summary>
        /// Calls the Get method of the Attachment Service
        /// </summary>
        public static attachment Get(Guid messageId, Guid id, X509Certificate2 certificate)
        {
            using(var client = getAttachmentClient(certificate))
            {
                return client.get(messageId, id);
            }
        }

        #endregion

        #region Private

        /// <summary>
        /// Instantiate Messages Client with User Provided Certificate and Password.
        /// </summary>
        private static messageAttachmentClient getAttachmentClient(X509Certificate2 certificate)
        {
            var client = new messageAttachmentClient();
            client.ClientCredentials.ClientCertificate.Certificate = certificate;

            return client;
        }

        #endregion
    }
}
