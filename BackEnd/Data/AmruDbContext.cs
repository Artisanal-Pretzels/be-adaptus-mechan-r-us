using System.Collections.Generic;
using BackEnd.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace BackEnd.Data
{

  public class AmruDbContext : DbContext
  {
    public AmruDbContext(DbContextOptions<AmruDbContext> options) : base(options) { }

    public DbSet<User> Users { get; set; }
    public DbSet<PhoneNumber> PhoneNumbers { get; set; }

    public DbSet<Garage> Garages { get; set; }

    public DbSet<Review> Reviews { get; set; }

    public DbSet<Address> Addresses { get; set; }

    public DbSet<Invoice> Invoices { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      base.OnModelCreating (modelBuilder);

      modelBuilder.Entity<User> ().ToTable ("Users");
      modelBuilder.Entity<PhoneNumber> ().ToTable ("PhoneNumbers");
      modelBuilder.Entity<Garage> ().ToTable ("Garages");
      modelBuilder.Entity<Review> ().ToTable ("Reviews");
      modelBuilder.Entity<Address> ().ToTable ("Addresses");
      modelBuilder.Entity<Invoice> ().ToTable ("Invoices");

      modelBuilder.Entity<User> (entity =>
      {
        entity.Property (e => e.CreatedAt).ValueGeneratedOnAdd ();
        entity.Property (e => e.LastUpdatedAt).ValueGeneratedOnAddOrUpdate ();

        entity.Property(e => e.CreatedAt).Metadata.SetBeforeSaveBehavior(PropertySaveBehavior.Ignore);
        entity.Property(e => e.CreatedAt).Metadata.SetAfterSaveBehavior(PropertySaveBehavior.Ignore);
        entity.Property(e => e.LastUpdatedAt).Metadata.SetBeforeSaveBehavior(PropertySaveBehavior.Ignore);
        entity.Property(e => e.LastUpdatedAt).Metadata.SetBeforeSaveBehavior(PropertySaveBehavior.Ignore);
      });

      modelBuilder.Entity<PhoneNumber> (entity =>
      {
        entity.Property (e => e.CreatedAt).ValueGeneratedOnAdd ();
        entity.Property (e => e.LastUpdatedAt).ValueGeneratedOnAddOrUpdate ();

        entity.Property(e => e.CreatedAt).Metadata.SetBeforeSaveBehavior(PropertySaveBehavior.Ignore);
        entity.Property(e => e.CreatedAt).Metadata.SetAfterSaveBehavior(PropertySaveBehavior.Ignore);
        entity.Property(e => e.LastUpdatedAt).Metadata.SetBeforeSaveBehavior(PropertySaveBehavior.Ignore);
        entity.Property(e => e.LastUpdatedAt).Metadata.SetBeforeSaveBehavior(PropertySaveBehavior.Ignore);
      });

      modelBuilder.Entity<Garage> (entity =>
      {
        entity.Property (e => e.CreatedAt).ValueGeneratedOnAdd ();
        entity.Property (e => e.LastUpdatedAt).ValueGeneratedOnAddOrUpdate ();

        entity.Property(e => e.CreatedAt).Metadata.SetBeforeSaveBehavior(PropertySaveBehavior.Ignore);
        entity.Property(e => e.CreatedAt).Metadata.SetAfterSaveBehavior(PropertySaveBehavior.Ignore);
        entity.Property(e => e.LastUpdatedAt).Metadata.SetBeforeSaveBehavior(PropertySaveBehavior.Ignore);
        entity.Property(e => e.LastUpdatedAt).Metadata.SetBeforeSaveBehavior(PropertySaveBehavior.Ignore);
      });

      modelBuilder.Entity<Review> (entity =>
      {
        entity.Property (e => e.CreatedAt).ValueGeneratedOnAdd ();
        entity.Property (e => e.LastUpdatedAt).ValueGeneratedOnAddOrUpdate ();

        entity.Property(e => e.CreatedAt).Metadata.SetBeforeSaveBehavior(PropertySaveBehavior.Ignore);
        entity.Property(e => e.CreatedAt).Metadata.SetAfterSaveBehavior(PropertySaveBehavior.Ignore);
        entity.Property(e => e.LastUpdatedAt).Metadata.SetBeforeSaveBehavior(PropertySaveBehavior.Ignore);
        entity.Property(e => e.LastUpdatedAt).Metadata.SetBeforeSaveBehavior(PropertySaveBehavior.Ignore);
      });

      modelBuilder.Entity<Address> (entity =>
      {
        entity.Property (e => e.CreatedAt).ValueGeneratedOnAdd ();
        entity.Property (e => e.LastUpdatedAt).ValueGeneratedOnAddOrUpdate ();

        entity.Property(e => e.CreatedAt).Metadata.SetBeforeSaveBehavior(PropertySaveBehavior.Ignore);
        entity.Property(e => e.CreatedAt).Metadata.SetAfterSaveBehavior(PropertySaveBehavior.Ignore);
        entity.Property(e => e.LastUpdatedAt).Metadata.SetBeforeSaveBehavior(PropertySaveBehavior.Ignore);
        entity.Property(e => e.LastUpdatedAt).Metadata.SetBeforeSaveBehavior(PropertySaveBehavior.Ignore);
      });

      modelBuilder.Entity<Invoice> (entity =>
      {
        entity.Property (e => e.CreatedAt).ValueGeneratedOnAdd ();
        entity.Property (e => e.LastUpdatedAt).ValueGeneratedOnAddOrUpdate ();

        entity.Property(e => e.CreatedAt).Metadata.SetBeforeSaveBehavior(PropertySaveBehavior.Ignore);
        entity.Property(e => e.CreatedAt).Metadata.SetAfterSaveBehavior(PropertySaveBehavior.Ignore);
        entity.Property(e => e.LastUpdatedAt).Metadata.SetBeforeSaveBehavior(PropertySaveBehavior.Ignore);
        entity.Property(e => e.LastUpdatedAt).Metadata.SetBeforeSaveBehavior(PropertySaveBehavior.Ignore);
      });

      IEnumerable<User> users = DataLoader.LoadJson<User> ("Users");
      IEnumerable<PhoneNumber> phoneNumbers = DataLoader.LoadJson<PhoneNumber> ("PhoneNumbers");
      IEnumerable<Garage> garages = DataLoader.LoadJson<Garage> ("Garages");
      IEnumerable<Review> reviews = DataLoader.LoadJson<Review> ("Reviews");
      IEnumerable<Address> addresses = DataLoader.LoadJson<Address> ("Addresses");
      IEnumerable<Invoice> invoices = DataLoader.LoadJson<Invoice> ("Invoices");

      modelBuilder.Entity<User> ().HasData (users);
      modelBuilder.Entity<PhoneNumber> ().HasData (phoneNumbers);
      modelBuilder.Entity<Garage> ().HasData (garages);
      modelBuilder.Entity<Review> ().HasData (reviews);
      modelBuilder.Entity<Address> ().HasData (addresses);
      modelBuilder.Entity<Invoice> ().HasData (invoices);

    }
  }
}