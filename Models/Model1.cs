namespace ChatPusher.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Conversation> Conversation { get; set; }
        public virtual DbSet<Group> Group { get; set; }
        public virtual DbSet<User> User { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Conversation>()
                .Property(e => e.id)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Conversation>()
                .Property(e => e.group_id)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Conversation>()
                .Property(e => e.sender_id)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Conversation>()
                .Property(e => e.message)
                .IsUnicode(false);

            modelBuilder.Entity<Conversation>()
                .Property(e => e.duree)
                .IsUnicode(false);

            modelBuilder.Entity<Conversation>()
                .Property(e => e.receiver_id)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Group>()
                .Property(e => e.id)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Group>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<Group>()
                .Property(e => e.intro)
                .IsUnicode(false);

            modelBuilder.Entity<Group>()
                .Property(e => e.admin_ids)
                .IsUnicode(false);

            modelBuilder.Entity<Group>()
                .HasMany(e => e.Conversation)
                .WithOptional(e => e.Group)
                .HasForeignKey(e => e.group_id);

            modelBuilder.Entity<Group>()
                .HasMany(e => e.User)
                .WithMany(e => e.Group)
                .Map(m => m.ToTable("Groups_User").MapLeftKey("group_id").MapRightKey("user_id"));

            modelBuilder.Entity<User>()
                .Property(e => e.id)
                .HasPrecision(18, 0);

            modelBuilder.Entity<User>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Surname)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.phone)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.cofirmation_token)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Conversation)
                .WithOptional(e => e.User)
                .HasForeignKey(e => e.sender_id);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Conversation1)
                .WithOptional(e => e.User1)
                .HasForeignKey(e => e.receiver_id);

            modelBuilder.Entity<User>()
                .HasMany(e => e.User1)
                .WithMany(e => e.User2)
                .Map(m => m.ToTable("Contacts_user").MapLeftKey("user_id").MapRightKey("contact_id"));
        }
    }
}
