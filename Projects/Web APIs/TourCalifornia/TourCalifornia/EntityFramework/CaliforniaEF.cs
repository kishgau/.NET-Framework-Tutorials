namespace TourCalifornia.EntityFramework
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class CaliforniaEF : DbContext
    {
        public CaliforniaEF()
            : base("name=CaliforniaEF")
        {
        }

        public virtual DbSet<AuthorizedApp> AuthorizedApps { get; set; }
        public virtual DbSet<Reservation> Reservations { get; set; }
        public virtual DbSet<Tour> Tours { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AuthorizedApp>()
                .Property(e => e.AppToken)
                .IsUnicode(false);

            modelBuilder.Entity<AuthorizedApp>()
                .Property(e => e.AppSecret)
                .IsUnicode(false);

            modelBuilder.Entity<Tour>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Tour>()
                .Property(e => e.Notes)
                .IsUnicode(false);

            modelBuilder.Entity<Tour>()
                .HasMany(e => e.Reservations)
                .WithRequired(e => e.Tour)
                .WillCascadeOnDelete(false);
        }
    }
}
