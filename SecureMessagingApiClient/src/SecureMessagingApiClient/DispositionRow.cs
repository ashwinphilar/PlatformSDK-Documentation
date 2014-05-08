using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SecureMessagingApiClient.MessagesServiceReference;

namespace SecureMessagingApiClient
{
    /// <summary>
    /// For binding of DataGridView for MessagesForm
    /// </summary>
    public class DispositionRow
    {
        /// <summary>
        /// Recipient of a Message
        /// </summary>
        public string Recipient { get; set; }

        /// <summary>
        /// Indicates Successful Disposal
        /// </summary>
        public string Disposed { get; set; }
    }
}
