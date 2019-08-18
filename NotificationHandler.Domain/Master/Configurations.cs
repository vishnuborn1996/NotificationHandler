namespace NotificationHandler.Domain
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Configurations : Entity
    {
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
        /// Gets or sets the port.
        /// </summary>
        /// <value>
        /// The port.
        /// </value>
        public string Port { get; set; }

        /// <summary>
        /// Gets or sets the email.
        /// </summary>
        /// <value>
        /// The email.
        /// </value>
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets the password.
        /// </summary>
        /// <value>
        /// The password.
        /// </value>
        public string Password { get; set; }

        /// <summary>
        /// Gets or sets the host.
        /// </summary>
        /// <value>
        /// The host.
        /// </value>
        public string Host { get; set; }
    }
}
