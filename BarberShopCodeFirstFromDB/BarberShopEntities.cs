namespace BarberShopCodeFirstFromDB
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class BarberShopEntities : DbContext
    {
        public BarberShopEntities()
            : base("name=BarberShopConnection")
        {
        }

        public virtual DbSet<C__RefactorLog> C__RefactorLog { get; set; }
        public virtual DbSet<Appointment> Appointments { get; set; }
        public virtual DbSet<Barber> Barbers { get; set; }
        public virtual DbSet<Barber_Avail> Barber_Avail { get; set; }
        public virtual DbSet<Barber_shifts> Barber_shifts { get; set; }
        public virtual DbSet<Haircut> Haircuts { get; set; }
        public virtual DbSet<Shift> Shifts { get; set; }
        public virtual DbSet<Shop> Shops { get; set; }
        public virtual DbSet<Status> Status { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Appointment>()
                .Property(e => e.status_id)
                .IsFixedLength();

            modelBuilder.Entity<Appointment>()
                .Property(e => e.payment_status)
                .IsFixedLength();

            modelBuilder.Entity<Barber>()
                .Property(e => e.barber_name)
                .IsFixedLength();

            modelBuilder.Entity<Barber>()
                .Property(e => e.barber_email)
                .IsFixedLength();

            modelBuilder.Entity<Barber>()
                .Property(e => e.barber_contact)
                .IsFixedLength();

            modelBuilder.Entity<Barber>()
                .HasMany(e => e.Barber_shifts)
                .WithRequired(e => e.Barber)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Barber_shifts>()
                .HasMany(e => e.Barber_Avail)
                .WithOptional(e => e.Barber_shifts)
                .HasForeignKey(e => new { e.barber_id, e.shift_id });

            modelBuilder.Entity<Haircut>()
                .Property(e => e.picture)
                .IsFixedLength();

            modelBuilder.Entity<Haircut>()
                .Property(e => e.description)
                .IsFixedLength();

            modelBuilder.Entity<Shift>()
                .HasMany(e => e.Barber_shifts)
                .WithRequired(e => e.Shift)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Shop>()
                .Property(e => e.shop_name)
                .IsFixedLength();

            modelBuilder.Entity<Shop>()
                .Property(e => e.location)
                .IsFixedLength();

            modelBuilder.Entity<Shop>()
                .Property(e => e.postal_code)
                .IsFixedLength();

            modelBuilder.Entity<Status>()
                .Property(e => e.status_id)
                .IsFixedLength();

            modelBuilder.Entity<Status>()
                .Property(e => e.description)
                .IsFixedLength();

            modelBuilder.Entity<User>()
                .Property(e => e.user_name)
                .IsFixedLength();

            modelBuilder.Entity<User>()
                .Property(e => e.user_email)
                .IsFixedLength();

            modelBuilder.Entity<User>()
                .Property(e => e.user_contact)
                .IsFixedLength();
        }
    }
}
