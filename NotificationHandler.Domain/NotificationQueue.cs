namespace NotificationHandler.Domain
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The queue for emails.
    /// </summary>
    /// <seealso cref="NotificationHandler.Domain.Entity" />
    public class NotificationQueue : Entity
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NotificationQueue"/> class.
        /// </summary>
        public NotificationQueue()
        {
            Attachments = new HashSet<Attachments>();
        }

        /// <summary>
        /// Gets or sets the applications.
        /// </summary>
        /// <value>
        /// The applications.
        /// </value>
        public Applications Applications { get; set; }

        /// <summary>
        /// Gets or sets the applications identifier.
        /// </summary>
        /// <value>
        /// The applications identifier.
        /// </value>
        public Guid ApplicationsId { get; set; }

        /// <summary>
        /// Gets or sets the recievers address.
        /// </summary>
        /// <value>
        /// The recievers address.
        /// </value>
        public string RecieversAddress { get; set; }

        /// <summary>
        /// Gets or sets the subject.
        /// </summary>
        /// <value>
        /// The subject.
        /// </value>
        public string Subject { get; set; }

        /// <summary>
        /// Gets or sets the body.
        /// </summary>
        /// <value>
        /// The body.
        /// </value>
        public string Body { get; set; }

        /// <summary>
        /// Gets or sets the attachments.
        /// </summary>
        /// <value>
        /// The attachments.
        /// </value>
        public ICollection<Attachments> Attachments { get; set; }
    }
}
