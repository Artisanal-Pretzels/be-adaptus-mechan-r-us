// <auto-generated />
using System;
using BackEnd.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BackEnd.Migrations
{
  [DbContext (typeof (AmruDbContext))]
  partial class AmruDbContextModelSnapshot : ModelSnapshot
  {
    protected override void BuildModel (ModelBuilder modelBuilder)
    {
#pragma warning disable 612, 618
      modelBuilder
        .HasAnnotation ("ProductVersion", "3.0.0")
        .HasAnnotation ("Relational:MaxIdentifierLength", 64);

      modelBuilder.Entity ("BackEnd.Models.Address", b =>
      {
        b.Property<uint> ("AddressID")
          .ValueGeneratedOnAdd ()
          .HasColumnType ("int unsigned");

        b.Property<string> ("County")
          .IsRequired ()
          .HasColumnType ("varchar(200)")
          .HasMaxLength (200);

        b.Property<DateTime> ("CreatedAt")
          .ValueGeneratedOnAdd ()
          .HasColumnType ("datetime(6)")
          .HasDefaultValueSql ("CURRENT_TIMESTAMP");

        b.Property<uint> ("GarageID")
          .HasColumnType ("int unsigned");

        b.Property<DateTime> ("LastUpdatedAt")
          .ValueGeneratedOnAddOrUpdate ()
          .HasColumnType ("datetime(6)")
          .HasDefaultValueSql ("CURRENT_TIMESTAMP");

        b.Property<double> ("Latitude")
          .HasColumnType ("double");

        b.Property<string> ("LineOne")
          .IsRequired ()
          .HasColumnType ("varchar(200)")
          .HasMaxLength (200);

        b.Property<string> ("LineTwo")
          .IsRequired ()
          .HasColumnType ("varchar(200)")
          .HasMaxLength (200);

        b.Property<double> ("Longitude")
          .HasColumnType ("double");

        b.Property<string> ("PostCode")
          .IsRequired ()
          .HasColumnType ("varchar(10)")
          .HasMaxLength (10);

        b.HasKey ("AddressID");

        b.HasIndex ("GarageID")
          .IsUnique ();

        b.ToTable ("Addresses");

        b.HasData (
          new
          {
            AddressID = 1u,
              County = " Colorado",
              CreatedAt = new DateTime (1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
              GarageID = 1u,
              LastUpdatedAt = new DateTime (1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
              Latitude = -2.6945920000000001,
              LineOne = "159 Irving Street",
              LineTwo = "proident",
              Longitude = -14.284725999999999,
              PostCode = "sunt"
          },
          new
          {
            AddressID = 2u,
              County = " Wisconsin",
              CreatedAt = new DateTime (1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
              GarageID = 2u,
              LastUpdatedAt = new DateTime (1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
              Latitude = -1.662758,
              LineOne = "909 Louisa Street",
              LineTwo = "quis",
              Longitude = 39.233745999999996,
              PostCode = "do"
          },
          new
          {
            AddressID = 3u,
              County = " Texas",
              CreatedAt = new DateTime (1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
              GarageID = 3u,
              LastUpdatedAt = new DateTime (1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
              Latitude = -1.8960090000000001,
              LineOne = "885 Oxford Walk",
              LineTwo = "laborum",
              Longitude = -48.584065000000002,
              PostCode = "in"
          },
          new
          {
            AddressID = 4u,
              County = " Arizona",
              CreatedAt = new DateTime (1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
              GarageID = 4u,
              LastUpdatedAt = new DateTime (1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
              Latitude = 0.187475,
              LineOne = "217 Dunne Place",
              LineTwo = "exercitation",
              Longitude = 23.450187,
              PostCode = "laboris"
          },
          new
          {
            AddressID = 5u,
              County = " Virgin Islands",
              CreatedAt = new DateTime (1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
              GarageID = 5u,
              LastUpdatedAt = new DateTime (1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
              Latitude = -4.7580780000000003,
              LineOne = "165 Kimball Street",
              LineTwo = "nostrud",
              Longitude = -8.6560410000000001,
              PostCode = "duis"
          },
          new
          {
            AddressID = 6u,
              County = " North Dakota",
              CreatedAt = new DateTime (1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
              GarageID = 6u,
              LastUpdatedAt = new DateTime (1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
              Latitude = -2.6139230000000002,
              LineOne = "255 Bedell Lane",
              LineTwo = "irure",
              Longitude = -38.573397999999997,
              PostCode = "id"
          },
          new
          {
            AddressID = 7u,
              County = " Puerto Rico",
              CreatedAt = new DateTime (1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
              GarageID = 7u,
              LastUpdatedAt = new DateTime (1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
              Latitude = -3.4436460000000002,
              LineOne = "566 Clay Street",
              LineTwo = "dolore",
              Longitude = -16.477741000000002,
              PostCode = "some"
          },
          new
          {
            AddressID = 8u,
              County = " Alaska",
              CreatedAt = new DateTime (1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
              GarageID = 8u,
              LastUpdatedAt = new DateTime (1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
              Latitude = 0.37073800000000001,
              LineOne = "755 Kings Place",
              LineTwo = "laborum",
              Longitude = -35.696264999999997,
              PostCode = "officia"
          },
          new
          {
            AddressID = 9u,
              County = " Nebraska",
              CreatedAt = new DateTime (1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
              GarageID = 9u,
              LastUpdatedAt = new DateTime (1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
              Latitude = -2.8938299999999999,
              LineOne = "250 Fleet Street",
              LineTwo = "ipsum",
              Longitude = -22.981099,
              PostCode = "sit"
          });
      });

      modelBuilder.Entity ("BackEnd.Models.Garage", b =>
      {
        b.Property<uint> ("GarageID")
          .ValueGeneratedOnAdd ()
          .HasColumnType ("int unsigned");

        b.Property<double> ("BasePrice")
          .HasColumnType ("double(5, 2)");

        b.Property<DateTime> ("CreatedAt")
          .ValueGeneratedOnAdd ()
          .HasColumnType ("datetime(6)")
          .HasDefaultValueSql ("CURRENT_TIMESTAMP");

        b.Property<string> ("Description")
          .IsRequired ()
          .HasColumnType ("varchar(1000)")
          .HasMaxLength (1000);

        b.Property<string> ("GarageName")
          .IsRequired ()
          .HasColumnType ("varchar(200)")
          .HasMaxLength (200);

        b.Property<string> ("ImagePath")
          .HasColumnType ("longtext");

        b.Property<DateTime> ("LastUpdatedAt")
          .ValueGeneratedOnAddOrUpdate ()
          .HasColumnType ("datetime(6)")
          .HasDefaultValueSql ("CURRENT_TIMESTAMP");

        b.Property<string> ("PaymentEmail")
          .IsRequired ()
          .HasColumnType ("varchar(256)")
          .HasMaxLength (256);

        b.HasKey ("GarageID");

        b.ToTable ("Garages");

        b.HasData (
          new
          {
            GarageID = 1u,
              BasePrice = 66.0,
              CreatedAt = new DateTime (1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
              Description = @"Cupidatat est occaecat esse aute mollit qui commodo. Ea consequat reprehenderit labore laborum excepteur. Sint do non voluptate velit adipisicing incididunt occaecat tempor velit.
",
              GarageName = "commodo",
              ImagePath = "http://placehold.it/32x32",
              LastUpdatedAt = new DateTime (1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
              PaymentEmail = "reillyholden@jamnation.com"
          },
          new
          {
            GarageID = 2u,
              BasePrice = 81.0,
              CreatedAt = new DateTime (1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
              Description = @"Magna ipsum voluptate Lorem esse sunt in consequat consequat laborum qui consequat excepteur cupidatat ea. Cillum elit id occaecat eiusmod tempor consectetur laboris voluptate anim tempor ea veniam. Proident eu do pariatur laborum ad reprehenderit nostrud exercitation eu magna enim. Enim nulla enim consequat dolore sint id eiusmod fugiat deserunt.
",
              GarageName = "sunt",
              ImagePath = "http://placehold.it/32x32",
              LastUpdatedAt = new DateTime (1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
              PaymentEmail = "reillyholden@jamnation.com"
          },
          new
          {
            GarageID = 3u,
              BasePrice = 43.0,
              CreatedAt = new DateTime (1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
              Description = @"In velit mollit exercitation nulla deserunt cillum incididunt ipsum. Aliquip veniam elit mollit qui reprehenderit sint esse excepteur voluptate ex amet magna occaecat Lorem. Enim dolore sint cillum deserunt consectetur laborum commodo commodo commodo id.
",
              GarageName = "duis",
              ImagePath = "http://placehold.it/32x32",
              LastUpdatedAt = new DateTime (1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
              PaymentEmail = "reillyholden@jamnation.com"
          },
          new
          {
            GarageID = 4u,
              BasePrice = 68.0,
              CreatedAt = new DateTime (1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
              Description = @"Mollit et irure officia sint. Sit nisi aliquip proident sunt exercitation elit. Incididunt aliquip ut pariatur eiusmod est dolore ullamco amet aliqua. Dolore enim sint nulla ipsum magna in laborum. Laboris id commodo eiusmod eiusmod mollit aliquip occaecat Lorem officia laborum amet aute cillum ex. Amet amet esse duis qui id et proident sunt dolor occaecat Lorem officia aliqua. Fugiat nisi aute mollit eiusmod do elit sunt excepteur do id mollit cillum.
",
              GarageName = "aliquip",
              ImagePath = "http://placehold.it/32x32",
              LastUpdatedAt = new DateTime (1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
              PaymentEmail = "reillyholden@jamnation.com"
          },
          new
          {
            GarageID = 5u,
              BasePrice = 56.0,
              CreatedAt = new DateTime (1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
              Description = @"Qui esse irure occaecat deserunt veniam ea eiusmod adipisicing. Do ipsum id irure ipsum officia mollit nulla. Minim culpa ipsum sint adipisicing non sint do et. Et ipsum cillum nulla incididunt do Lorem incididunt id deserunt sit. Occaecat anim nostrud elit duis in ex. Ex veniam do aliqua nostrud dolor.
",
              GarageName = "sunt",
              ImagePath = "http://placehold.it/32x32",
              LastUpdatedAt = new DateTime (1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
              PaymentEmail = "reillyholden@jamnation.com"
          },
          new
          {
            GarageID = 6u,
              BasePrice = 74.0,
              CreatedAt = new DateTime (1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
              Description = @"Lorem Lorem qui Lorem eiusmod consequat et deserunt ea fugiat consectetur eu in id. Ipsum ea non tempor laboris ad ad pariatur mollit exercitation in officia ut fugiat enim. Aute in irure tempor excepteur fugiat labore. Nisi Lorem laborum commodo minim commodo occaecat ullamco fugiat nostrud. Aliquip enim culpa aliquip veniam aute aliqua velit Lorem officia anim et enim id. Ad nisi reprehenderit velit voluptate sunt est nisi enim occaecat anim proident.
",
              GarageName = "sunt",
              ImagePath = "http://placehold.it/32x32",
              LastUpdatedAt = new DateTime (1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
              PaymentEmail = "reillyholden@jamnation.com"
          },
          new
          {
            GarageID = 7u,
              BasePrice = 87.0,
              CreatedAt = new DateTime (1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
              Description = @"Qui qui veniam velit aliqua reprehenderit velit id labore. Commodo minim eu ad dolor ipsum aute occaecat est amet laboris amet. In ipsum Lorem officia ipsum irure ex labore est duis incididunt.
",
              GarageName = "in",
              ImagePath = "http://placehold.it/32x32",
              LastUpdatedAt = new DateTime (1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
              PaymentEmail = "reillyholden@jamnation.com"
          },
          new
          {
            GarageID = 8u,
              BasePrice = 79.0,
              CreatedAt = new DateTime (1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
              Description = @"Ipsum voluptate elit nisi exercitation Lorem id proident in anim deserunt. Cillum cillum elit minim veniam cupidatat deserunt ea aute do ex non excepteur Lorem. Cupidatat cupidatat Lorem non officia non consequat do et ipsum aliquip. Fugiat ullamco ullamco magna et incididunt dolor. Veniam ipsum voluptate voluptate ad Lorem reprehenderit laborum dolor sit anim pariatur ex. Ex in consequat cupidatat qui ad velit tempor sunt duis culpa ea elit Lorem minim. Adipisicing consectetur pariatur enim velit veniam sit do enim consectetur.
",
              GarageName = "esse",
              ImagePath = "http://placehold.it/32x32",
              LastUpdatedAt = new DateTime (1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
              PaymentEmail = "reillyholden@jamnation.com"
          },
          new
          {
            GarageID = 9u,
              BasePrice = 98.0,
              CreatedAt = new DateTime (1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
              Description = @"Voluptate excepteur non cupidatat veniam amet. Qui nisi dolor excepteur sit minim cillum. Aliqua commodo ullamco commodo exercitation nostrud dolor fugiat consequat eu consequat do adipisicing. In adipisicing dolore ut magna cillum dolor id.
",
              GarageName = "ut",
              ImagePath = "http://placehold.it/32x32",
              LastUpdatedAt = new DateTime (1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
              PaymentEmail = "reillyholden@jamnation.com"
          });
      });

      modelBuilder.Entity ("BackEnd.Models.Invoice", b =>
      {
        b.Property<uint> ("InvoiceID")
          .ValueGeneratedOnAdd ()
          .HasColumnType ("int unsigned");

        b.Property<DateTime> ("CreatedAt")
          .ValueGeneratedOnAdd ()
          .HasColumnType ("datetime(6)")
          .HasDefaultValueSql ("CURRENT_TIMESTAMP");

        b.Property<uint> ("GarageID")
          .HasColumnType ("int unsigned");

        b.Property<DateTime> ("LastUpdatedAt")
          .ValueGeneratedOnAddOrUpdate ()
          .HasColumnType ("datetime(6)")
          .HasDefaultValueSql ("CURRENT_TIMESTAMP");

        b.Property<uint> ("UserID")
          .HasColumnType ("int unsigned");

        b.HasKey ("InvoiceID");

        b.HasIndex ("GarageID");

        b.HasIndex ("UserID");

        b.ToTable ("Invoices");

        b.HasData (
          new
          {
            InvoiceID = 1u,
              CreatedAt = new DateTime (1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
              GarageID = 1u,
              LastUpdatedAt = new DateTime (1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
              UserID = 1u
          },
          new
          {
            InvoiceID = 2u,
              CreatedAt = new DateTime (1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
              GarageID = 2u,
              LastUpdatedAt = new DateTime (1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
              UserID = 2u
          },
          new
          {
            InvoiceID = 3u,
              CreatedAt = new DateTime (1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
              GarageID = 3u,
              LastUpdatedAt = new DateTime (1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
              UserID = 3u
          },
          new
          {
            InvoiceID = 4u,
              CreatedAt = new DateTime (1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
              GarageID = 4u,
              LastUpdatedAt = new DateTime (1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
              UserID = 4u
          },
          new
          {
            InvoiceID = 5u,
              CreatedAt = new DateTime (1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
              GarageID = 5u,
              LastUpdatedAt = new DateTime (1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
              UserID = 5u
          },
          new
          {
            InvoiceID = 6u,
              CreatedAt = new DateTime (1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
              GarageID = 6u,
              LastUpdatedAt = new DateTime (1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
              UserID = 6u
          },
          new
          {
            InvoiceID = 7u,
              CreatedAt = new DateTime (1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
              GarageID = 7u,
              LastUpdatedAt = new DateTime (1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
              UserID = 7u
          },
          new
          {
            InvoiceID = 8u,
              CreatedAt = new DateTime (1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
              GarageID = 8u,
              LastUpdatedAt = new DateTime (1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
              UserID = 8u
          },
          new
          {
            InvoiceID = 9u,
              CreatedAt = new DateTime (1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
              GarageID = 9u,
              LastUpdatedAt = new DateTime (1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
              UserID = 9u
          });
      });

      modelBuilder.Entity ("BackEnd.Models.PhoneNumber", b =>
      {
        b.Property<uint> ("PhoneNumberID")
          .ValueGeneratedOnAdd ()
          .HasColumnType ("int unsigned");

        b.Property<DateTime> ("CreatedAt")
          .ValueGeneratedOnAdd ()
          .HasColumnType ("datetime(6)")
          .HasDefaultValueSql ("CURRENT_TIMESTAMP");

        b.Property<DateTime> ("LastUpdatedAt")
          .ValueGeneratedOnAddOrUpdate ()
          .HasColumnType ("datetime(6)")
          .HasDefaultValueSql ("CURRENT_TIMESTAMP");

        b.Property<string> ("Number")
          .IsRequired ()
          .HasColumnType ("varchar(15)")
          .HasMaxLength (15);

        b.Property<uint> ("UserID")
          .HasColumnType ("int unsigned");

        b.HasKey ("PhoneNumberID");

        b.HasIndex ("UserID")
          .IsUnique ();

        b.ToTable ("PhoneNumbers");

        b.HasData (
          new
          {
            PhoneNumberID = 1u,
              CreatedAt = new DateTime (1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
              LastUpdatedAt = new DateTime (1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
              Number = "(933) 548-2349",
              UserID = 1u
          },
          new
          {
            PhoneNumberID = 2u,
              CreatedAt = new DateTime (1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
              LastUpdatedAt = new DateTime (1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
              Number = "(920) 558-2158",
              UserID = 2u
          },
          new
          {
            PhoneNumberID = 3u,
              CreatedAt = new DateTime (1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
              LastUpdatedAt = new DateTime (1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
              Number = "(816) 448-2524",
              UserID = 3u
          },
          new
          {
            PhoneNumberID = 4u,
              CreatedAt = new DateTime (1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
              LastUpdatedAt = new DateTime (1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
              Number = "(866) 517-3903",
              UserID = 4u
          },
          new
          {
            PhoneNumberID = 5u,
              CreatedAt = new DateTime (1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
              LastUpdatedAt = new DateTime (1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
              Number = "(892) 539-2626",
              UserID = 5u
          },
          new
          {
            PhoneNumberID = 6u,
              CreatedAt = new DateTime (1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
              LastUpdatedAt = new DateTime (1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
              Number = "(975) 562-3728",
              UserID = 6u
          },
          new
          {
            PhoneNumberID = 7u,
              CreatedAt = new DateTime (1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
              LastUpdatedAt = new DateTime (1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
              Number = "(951) 538-2988",
              UserID = 7u
          },
          new
          {
            PhoneNumberID = 8u,
              CreatedAt = new DateTime (1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
              LastUpdatedAt = new DateTime (1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
              Number = "(861) 568-2968",
              UserID = 8u
          },
          new
          {
            PhoneNumberID = 9u,
              CreatedAt = new DateTime (1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
              LastUpdatedAt = new DateTime (1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
              Number = "(832) 409-3078",
              UserID = 9u
          });
      });

      modelBuilder.Entity ("BackEnd.Models.Review", b =>
      {
        b.Property<uint> ("ReviewID")
          .ValueGeneratedOnAdd ()
          .HasColumnType ("int unsigned");

        b.Property<string> ("Body")
          .HasColumnType ("varchar(500)")
          .HasMaxLength (500);

        b.Property<DateTime> ("CreatedAt")
          .ValueGeneratedOnAdd ()
          .HasColumnType ("datetime(6)")
          .HasDefaultValueSql ("CURRENT_TIMESTAMP");

        b.Property<uint> ("GarageID")
          .HasColumnType ("int unsigned");

        b.Property<DateTime> ("LastUpdatedAt")
          .ValueGeneratedOnAddOrUpdate ()
          .HasColumnType ("datetime(6)")
          .HasDefaultValueSql ("CURRENT_TIMESTAMP");

        b.Property<double> ("Rating")
          .HasColumnType ("double(2, 1)");

        b.Property<uint> ("UserID")
          .HasColumnType ("int unsigned");

        b.HasKey ("ReviewID");

        b.HasIndex ("GarageID");

        b.HasIndex ("UserID");

        b.ToTable ("Reviews");

        b.HasData (
          new
          {
            ReviewID = 1u,
              Body = "4ma66ma436m",
              CreatedAt = new DateTime (1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
              GarageID = 1u,
              LastUpdatedAt = new DateTime (1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
              Rating = 5.0,
              UserID = 1u
          },
          new
          {
            ReviewID = 2u,
              Body = "4an6a6n",
              CreatedAt = new DateTime (1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
              GarageID = 2u,
              LastUpdatedAt = new DateTime (1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
              Rating = 5.0,
              UserID = 2u
          },
          new
          {
            ReviewID = 3u,
              Body = "rtyezm4y4y",
              CreatedAt = new DateTime (1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
              GarageID = 3u,
              LastUpdatedAt = new DateTime (1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
              Rating = 2.0,
              UserID = 3u
          },
          new
          {
            ReviewID = 4u,
              Body = " y4ezy4ez e4z y4ez yz",
              CreatedAt = new DateTime (1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
              GarageID = 4u,
              LastUpdatedAt = new DateTime (1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
              Rating = 3.0,
              UserID = 4u
          },
          new
          {
            ReviewID = 5u,
              Body = " y4ez y4ez yz y4 ",
              CreatedAt = new DateTime (1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
              GarageID = 5u,
              LastUpdatedAt = new DateTime (1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
              Rating = 4.0,
              UserID = 5u
          },
          new
          {
            ReviewID = 6u,
              Body = " y4ezy 4e y4e ",
              CreatedAt = new DateTime (1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
              GarageID = 6u,
              LastUpdatedAt = new DateTime (1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
              Rating = 1.0,
              UserID = 6u
          },
          new
          {
            ReviewID = 7u,
              Body = " y4dz y4e yea54i54a",
              CreatedAt = new DateTime (1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
              GarageID = 7u,
              LastUpdatedAt = new DateTime (1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
              Rating = 4.0,
              UserID = 7u
          },
          new
          {
            ReviewID = 8u,
              Body = " 4e 4ez y5u54amamyt",
              CreatedAt = new DateTime (1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
              GarageID = 8u,
              LastUpdatedAt = new DateTime (1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
              Rating = 3.0,
              UserID = 8u
          },
          new
          {
            ReviewID = 9u,
              Body = "ersliror3sru3oj",
              CreatedAt = new DateTime (1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
              GarageID = 9u,
              LastUpdatedAt = new DateTime (1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
              Rating = 4.0,
              UserID = 9u
          });
      });

      modelBuilder.Entity ("BackEnd.Models.User", b =>
      {
        b.Property<uint> ("UserID")
          .ValueGeneratedOnAdd ()
          .HasColumnType ("int unsigned");

        b.Property<DateTime> ("CreatedAt")
          .ValueGeneratedOnAdd ()
          .HasColumnType ("datetime(6)")
          .HasDefaultValueSql ("CURRENT_TIMESTAMP");

        b.Property<string> ("Email")
          .IsRequired ()
          .HasColumnType ("varchar(256)")
          .HasMaxLength (256);

        b.Property<DateTime> ("LastUpdatedAt")
          .ValueGeneratedOnAddOrUpdate ()
          .HasColumnType ("datetime(6)")
          .HasDefaultValueSql ("CURRENT_TIMESTAMP");

        b.Property<string> ("Name")
          .IsRequired ()
          .HasColumnType ("varchar(200)")
          .HasMaxLength (200);

        b.Property<string> ("Password")
          .IsRequired ()
          .HasColumnType ("varchar(200)")
          .HasMaxLength (200);

        b.Property<string> ("PaymentEmail")
          .IsRequired ()
          .HasColumnType ("varchar(200)")
          .HasMaxLength (200);

        b.Property<string> ("Username")
          .IsRequired ()
          .HasColumnType ("varchar(200)")
          .HasMaxLength (200);

        b.HasKey ("UserID");

        b.ToTable ("Users");

        b.HasData (
          new
          {
            UserID = 1u,
              CreatedAt = new DateTime (1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
              Email = "reillyholden@jamnation.com",
              LastUpdatedAt = new DateTime (1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
              Name = "cillum",
              Password = "amet",
              PaymentEmail = "reillyholden@jamnation.com",
              Username = "cupidatat"
          },
          new
          {
            UserID = 2u,
              CreatedAt = new DateTime (1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
              Email = "reillyholden@jamnation.com",
              LastUpdatedAt = new DateTime (1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
              Name = "labore",
              Password = "et",
              PaymentEmail = "reillyholden@jamnation.com",
              Username = "labore"
          },
          new
          {
            UserID = 3u,
              CreatedAt = new DateTime (1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
              Email = "reillyholden@jamnation.com",
              LastUpdatedAt = new DateTime (1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
              Name = "ut",
              Password = "aliqua",
              PaymentEmail = "reillyholden@jamnation.com",
              Username = "dolore"
          },
          new
          {
            UserID = 4u,
              CreatedAt = new DateTime (1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
              Email = "reillyholden@jamnation.com",
              LastUpdatedAt = new DateTime (1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
              Name = "dolor",
              Password = "in",
              PaymentEmail = "reillyholden@jamnation.com",
              Username = "veniam"
          },
          new
          {
            UserID = 5u,
              CreatedAt = new DateTime (1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
              Email = "reillyholden@jamnation.com",
              LastUpdatedAt = new DateTime (1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
              Name = "esse",
              Password = "mollit",
              PaymentEmail = "reillyholden@jamnation.com",
              Username = "consectetur"
          },
          new
          {
            UserID = 6u,
              CreatedAt = new DateTime (1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
              Email = "reillyholden@jamnation.com",
              LastUpdatedAt = new DateTime (1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
              Name = "consectetur",
              Password = "voluptate",
              PaymentEmail = "reillyholden@jamnation.com",
              Username = "consequat"
          },
          new
          {
            UserID = 7u,
              CreatedAt = new DateTime (1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
              Email = "reillyholden@jamnation.com",
              LastUpdatedAt = new DateTime (1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
              Name = "pariatur",
              Password = "ut",
              PaymentEmail = "reillyholden@jamnation.com",
              Username = "officia"
          },
          new
          {
            UserID = 8u,
              CreatedAt = new DateTime (1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
              Email = "reillyholden@jamnation.com",
              LastUpdatedAt = new DateTime (1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
              Name = "irure",
              Password = "in",
              PaymentEmail = "reillyholden@jamnation.com",
              Username = "nostrud"
          },
          new
          {
            UserID = 9u,
              CreatedAt = new DateTime (1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
              Email = "reillyholden@jamnation.com",
              LastUpdatedAt = new DateTime (1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
              Name = "laborum",
              Password = "cillum",
              PaymentEmail = "reillyholden@jamnation.com",
              Username = "anim"
          });
      });

      modelBuilder.Entity ("BackEnd.Models.Address", b =>
      {
        b.HasOne ("BackEnd.Models.Garage", "Garage")
          .WithOne ("Address")
          .HasForeignKey ("BackEnd.Models.Address", "GarageID")
          .OnDelete (DeleteBehavior.Cascade)
          .IsRequired ();
      });

      modelBuilder.Entity ("BackEnd.Models.Invoice", b =>
      {
        b.HasOne ("BackEnd.Models.Garage", "Garage")
          .WithMany ("Invoice")
          .HasForeignKey ("GarageID")
          .OnDelete (DeleteBehavior.Cascade)
          .IsRequired ();

        b.HasOne ("BackEnd.Models.User", "User")
          .WithMany ("Invoice")
          .HasForeignKey ("UserID")
          .OnDelete (DeleteBehavior.Cascade)
          .IsRequired ();
      });

      modelBuilder.Entity ("BackEnd.Models.PhoneNumber", b =>
      {
        b.HasOne ("BackEnd.Models.User", "User")
          .WithOne ("PhoneNumber")
          .HasForeignKey ("BackEnd.Models.PhoneNumber", "UserID")
          .OnDelete (DeleteBehavior.Cascade)
          .IsRequired ();
      });

      modelBuilder.Entity ("BackEnd.Models.Review", b =>
      {
        b.HasOne ("BackEnd.Models.Garage", "Garage")
          .WithMany ("Review")
          .HasForeignKey ("GarageID")
          .OnDelete (DeleteBehavior.Cascade)
          .IsRequired ();

        b.HasOne ("BackEnd.Models.User", "User")
          .WithMany ("Review")
          .HasForeignKey ("UserID")
          .OnDelete (DeleteBehavior.Cascade)
          .IsRequired ();
      });
#pragma warning restore 612, 618
    }
  }
}
