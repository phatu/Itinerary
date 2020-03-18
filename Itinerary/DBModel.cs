namespace Itinerary
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DBModel : DbContext
    {
        public DBModel()
            : base("name=DBModel")
        {
        }

        public virtual DbSet<Detail> Details { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Detail>()
                .Property(e => e.location)
                .IsUnicode(false);

            modelBuilder.Entity<Detail>()
                .Property(e => e.cost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Detail>()
                .Property(e => e.activity)
                .IsUnicode(false);

            modelBuilder.Entity<Detail>()
                .Property(e => e.toWear)
                .IsUnicode(false);

            modelBuilder.Entity<Detail>()
                .Property(e => e.toBring)
                .IsUnicode(false);
        }
    }
}
