namespace NotificationHandler.EntityFramework
{
    using Microsoft.EntityFrameworkCore;
    using NotificationHandler.Domain;
    using System;

    public class NotificationHandlerDbContext : DbContext
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NotificationHandlerDbContext"/> class.
        /// </summary>
        /// <param name="options">The options.</param>
        public NotificationHandlerDbContext(DbContextOptions<NotificationHandlerDbContext> options) : base(options)
        {
        }

        /// <summary>
        /// Gets the categories.
        /// </summary>
        /// <value>
        /// The categories.
        /// </value>
        public DbSet<Applications> Categories => this.Set<Applications>();

        /// <summary>
        /// Gets the configurations.
        /// </summary>
        /// <value>
        /// The configurations.
        /// </value>
        public DbSet<Configurations> Configurations => this.Set<Configurations>();

        /// <summary>
        /// Gets the notification queue.
        /// </summary>
        /// <value>
        /// The notification queue.
        /// </value>
        public DbSet<NotificationQueue> NotificationQueue => this.Set<NotificationQueue>();

        /// <summary>
        /// Gets the attachments.
        /// </summary>
        /// <value>
        /// The attachments.
        /// </value>
        public DbSet<Attachments> Attachments => this.Set<Attachments>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
