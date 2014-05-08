using System;
using SecureMessagingApiClient.MessagesServiceReference;

namespace SecureMessagingApiClient
{
    /// <summary>
    /// For binding of DataGridView for MessagesForm
    /// </summary>
    public class MessageRow
    {
        /// <summary>
        /// Id of Message
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Indicates Message Received
        /// </summary>
        public string Received { get; set; }
    }
}
