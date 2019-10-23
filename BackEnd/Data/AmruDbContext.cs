using System.Collections.Generic;
using BackEnd.Models;
using Microsoft.EntityFrameworkCore;

namespace BackEnd.Data
{
    public class AmruDbContext : DbContext
    {
        public AmruDbContext (DbContextOptions<AmruDbContext> options) : base (options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<PhoneNumber> PhoneNumbers { get; set; }

        protected override void OnModelCreating (ModelBuilder modelBuilder)
        {
            base.OnModelCreating (modelBuilder);

            modelBuilder.Entity<User> ().ToTable ("Users");
            modelBuilder.Entity<PhoneNumber> ().ToTable ("PhoneNumbers");

            modelBuilder.Entity<User> (entity =>
            {
                entity.Property (e => e.CreatedAt).HasDefaultValueSql ("CURRENT_TIMESTAMP").ValueGeneratedOnAdd ();
                entity.Property (e => e.LastUpdatedAt).HasDefaultValueSql ("CURRENT_TIMESTAMP").ValueGeneratedOnAddOrUpdate ();
            });

            IEnumerable<User> users = DataLoader.LoadJson<User> ("Users");
            IEnumerable<PhoneNumber> phoneNumber = DataLoader.LoadJson<PhoneNumber> ("PhoneNumbers");

            modelBuilder.Entity<User> ().HasData (users);
            modelBuilder.Entity<PhoneNumber> ().HasData (phoneNumber);

        }
    }
}