namespace NotificationHandler.Domain
{
    using System.Collections.Generic;

    /// <summary>
    /// The Application that Requires email notifications
    /// </summary>
    /// <seealso cref="NotificationHandler.Domain.NamedEntity" />
    public class Applications : NamedEntity
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Applications"/> class.
        /// </summary>
        public Applications()
        {
            Configurations = new HashSet<Configurations>();
        }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        /// <value>
        /// The description.
        /// </value>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the configurations.
        /// </summary>
        /// <value>
        /// The configurations.
        /// </value>
        public ICollection<Configurations> Configurations { get; set; }
    }
}
