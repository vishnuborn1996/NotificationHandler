namespace NotificationHandler.Domain
{
    using System;

    public class Attachments : Entity
    {
        /// <summary>
        /// Gets or sets the notification queue.
        /// </summary>
        /// <value>
        /// The notification queue.
        /// </value>
        public NotificationQueue NotificationQueue { get; set; }

        /// <summary>
        /// Gets or sets the notification queue identifier.
        /// </summary>
        /// <value>
        /// The notification queue identifier.
        /// </value>
        public Guid NotificationQueueId { get; set; }

        /// <summary>
        /// Gets or sets the attachment.
        /// </summary>
        /// <value>
        /// The attachment.
        /// </value>
        public byte[] Attachment { get; set; }
    }
}
