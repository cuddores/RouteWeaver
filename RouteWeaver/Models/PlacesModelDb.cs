using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace RouteWeaver.Models
{
    public partial class PlacesModelDb : DbContext
    {
        public PlacesModelDb()
            : base("name=PlacesModelDb2")
        {
        }

        public virtual DbSet<Attraction> Attraction { get; set; }
        public virtual DbSet<AttractionReviews> AttractionReviews { get; set; }
        public virtual DbSet<AttractionType> AttractionType { get; set; }
        public virtual DbSet<Cities> Cities { get; set; }
        public virtual DbSet<Country> Country { get; set; }
        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<RoutePoint> RoutePoint { get; set; }
        public virtual DbSet<Routes> Routes { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Attraction>()
                .HasMany(e => e.AttractionReviews)
                .WithRequired(e => e.Attraction)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Attraction>()
                .HasMany(e => e.RoutePoint)
                .WithRequired(e => e.Attraction)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AttractionType>()
                .HasMany(e => e.Attraction)
                .WithRequired(e => e.AttractionType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Cities>()
                .HasMany(e => e.Attraction)
                .WithRequired(e => e.Cities)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Country>()
                .HasMany(e => e.Cities)
                .WithRequired(e => e.Country)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Roles>()
                .HasMany(e => e.Users)
                .WithRequired(e => e.Roles)
                .HasForeignKey(e => e.user_role_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Routes>()
                .HasMany(e => e.RoutePoint)
                .WithRequired(e => e.Routes)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.AttractionReviews)
                .WithRequired(e => e.Users)
                .WillCascadeOnDelete(false);
        }
    }
}
