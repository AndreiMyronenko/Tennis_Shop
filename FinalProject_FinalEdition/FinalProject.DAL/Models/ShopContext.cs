namespace FinalProject.DAL.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ShopContext : DbContext
    {
        public ShopContext()
            : base("name=ShopContext")
        {
        }

        public virtual DbSet<Bag> Bag { get; set; }
        public virtual DbSet<Manufacturer> Manufacturer { get; set; }
        public virtual DbSet<Racquet> Racquet { get; set; }
        public virtual DbSet<RacquetString> RacquetString { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Bag>()
                .Property(e => e.Title)
                .IsUnicode(false);

            modelBuilder.Entity<Bag>()
                .Property(e => e.Photo)
                .IsUnicode(false);

            modelBuilder.Entity<Racquet>()
                .Property(e => e.Title)
                .IsUnicode(false);

            modelBuilder.Entity<Racquet>()
                .Property(e => e.Photo)
                .IsUnicode(false);

            modelBuilder.Entity<RacquetString>()
                .Property(e => e.Title)
                .IsUnicode(false);

            modelBuilder.Entity<RacquetString>()
                .Property(e => e.Color)
                .IsUnicode(false);

            modelBuilder.Entity<RacquetString>()
                .Property(e => e.Photo)
                .IsUnicode(false);
        }
    }
}
