using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BackEnd.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserID = table.Column<uint>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Username = table.Column<string>(maxLength: 200, nullable: false),
                    Password = table.Column<string>(maxLength: 200, nullable: false),
                    Name = table.Column<string>(maxLength: 200, nullable: false),
                    Email = table.Column<string>(maxLength: 256, nullable: false),
                    PaymentEmail = table.Column<string>(maxLength: 200, nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    LastUpdatedAt = table.Column<DateTime>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserID);
                });

            migrationBuilder.CreateTable(
                name: "Garages",
                columns: table => new
                {
                    GarageID = table.Column<uint>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    GarageName = table.Column<string>(maxLength: 200, nullable: false),
                    Description = table.Column<string>(maxLength: 1000, nullable: false),
                    ImagePath = table.Column<string>(nullable: true),
                    PaymentEmail = table.Column<string>(maxLength: 256, nullable: false),
                    BasePrice = table.Column<double>(type: "double(5, 2)", nullable: false),
                    Hourly_Rate = table.Column<double>(nullable: false),
                    UserID = table.Column<uint>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    LastUpdatedAt = table.Column<DateTime>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Garages", x => x.GarageID);
                    table.ForeignKey(
                        name: "FK_Garages_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PhoneNumbers",
                columns: table => new
                {
                    PhoneNumberID = table.Column<uint>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Number = table.Column<string>(maxLength: 15, nullable: false),
                    UserID = table.Column<uint>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    LastUpdatedAt = table.Column<DateTime>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhoneNumbers", x => x.PhoneNumberID);
                    table.ForeignKey(
                        name: "FK_PhoneNumbers_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    AddressID = table.Column<uint>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Latitude = table.Column<double>(nullable: false),
                    Longitude = table.Column<double>(nullable: false),
                    LineOne = table.Column<string>(maxLength: 200, nullable: false),
                    LineTwo = table.Column<string>(maxLength: 200, nullable: false),
                    County = table.Column<string>(maxLength: 200, nullable: false),
                    PostCode = table.Column<string>(maxLength: 10, nullable: false),
                    GarageID = table.Column<uint>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    LastUpdatedAt = table.Column<DateTime>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.AddressID);
                    table.ForeignKey(
                        name: "FK_Addresses_Garages_GarageID",
                        column: x => x.GarageID,
                        principalTable: "Garages",
                        principalColumn: "GarageID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Invoices",
                columns: table => new
                {
                    InvoiceID = table.Column<uint>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserID = table.Column<uint>(nullable: false),
                    Hours = table.Column<double>(nullable: false),
                    Parts = table.Column<double>(nullable: false),
                    Recovery_Fee = table.Column<double>(nullable: true),
                    GarageID = table.Column<uint>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    LastUpdatedAt = table.Column<DateTime>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Invoices", x => x.InvoiceID);
                    table.ForeignKey(
                        name: "FK_Invoices_Garages_GarageID",
                        column: x => x.GarageID,
                        principalTable: "Garages",
                        principalColumn: "GarageID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Invoices_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    ReviewID = table.Column<uint>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Rating = table.Column<double>(type: "double(2, 1)", nullable: false),
                    Body = table.Column<string>(maxLength: 500, nullable: true),
                    GarageID = table.Column<uint>(nullable: false),
                    UserID = table.Column<uint>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    LastUpdatedAt = table.Column<DateTime>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.ReviewID);
                    table.ForeignKey(
                        name: "FK_Reviews_Garages_GarageID",
                        column: x => x.GarageID,
                        principalTable: "Garages",
                        principalColumn: "GarageID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reviews_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserID", "Email", "Name", "Password", "PaymentEmail", "Username" },
                values: new object[] { 1u, "admin@sapphiregarage.co.uk", "Sapphire Garage", "sapphire", "payment@sapphiregarage.co.uk", "sapphiregarage" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserID", "Email", "Name", "Password", "PaymentEmail", "Username" },
                values: new object[] { 21u, "ro.gorczan1@hotmail.com", "Mercedes E Armstrong", "emerc", "ro.gorczan1@hotmail.com", "armstrong" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserID", "Email", "Name", "Password", "PaymentEmail", "Username" },
                values: new object[] { 20u, "maggie2004@hotmail.com", "James N Jordan", "jnj", "maggie2004@hotmail.com", "jordy" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserID", "Email", "Name", "Password", "PaymentEmail", "Username" },
                values: new object[] { 19u, "keanu_ernse1@yahoo.com", "Donna R Hayes", "sunvalley", "keanu_ernse1@yahoo.com", "hayes" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserID", "Email", "Name", "Password", "PaymentEmail", "Username" },
                values: new object[] { 18u, "macy1983@yahoo.com", "Geneva S Gonzalez", "maystreet", "macy1983@yahoo.com", "gonzalez" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserID", "Email", "Name", "Password", "PaymentEmail", "Username" },
                values: new object[] { 17u, "destiny1972@gmail.com", "Joyce B Ray", "apric", "destiny1972@gmail.com", "bray" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserID", "Email", "Name", "Password", "PaymentEmail", "Username" },
                values: new object[] { 16u, "fidel_oko5@hotmail.com", "Clifford D Phillips", "angie", "fidel_oko5@hotmail.com", "fideloko" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserID", "Email", "Name", "Password", "PaymentEmail", "Username" },
                values: new object[] { 15u, "jordy2015@gmail.com", "Joy J Witt", "witty", "jordy2015@gmail.com", "joyj" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserID", "Email", "Name", "Password", "PaymentEmail", "Username" },
                values: new object[] { 14u, "kareem2017@yahoo.com", "Jacqulyn J Mooney", "never", "kareem2017@yahoo.com", "mooney" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserID", "Email", "Name", "Password", "PaymentEmail", "Username" },
                values: new object[] { 13u, "sydney1983@yahoo.com", "Kenneth C Surratt", "libra", "sydney1983@yahoo.com", "surratt" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserID", "Email", "Name", "Password", "PaymentEmail", "Username" },
                values: new object[] { 22u, "reyes2004@yahoo.com", "Refugio L Porter", "lport", "reyes2004@yahoo.com", "refugio" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserID", "Email", "Name", "Password", "PaymentEmail", "Username" },
                values: new object[] { 12u, "olaf.volkma6@gmail.com", "William L Chester", "olaf", "olaf.volkma6@gmail.com", "volkma" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserID", "Email", "Name", "Password", "PaymentEmail", "Username" },
                values: new object[] { 10u, "hello@zcarsautoservices.com", "Z Cars Auto Services", "zcars", "payment@zcarsautoservices.com", "Z Cars" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserID", "Email", "Name", "Password", "PaymentEmail", "Username" },
                values: new object[] { 9u, "everall@aeverallgarage.com", "A Everall", "everall", "payment@aeverallgarage.com", "aeverall" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserID", "Email", "Name", "Password", "PaymentEmail", "Username" },
                values: new object[] { 8u, "brad@bradfordgarage.co.uk", "Bradford Garage", "bradg", "payment@bradfordgarage.co.uk", "bradfordgarage" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserID", "Email", "Name", "Password", "PaymentEmail", "Username" },
                values: new object[] { 7u, "admin@plattlanegarage.co.uk", "Platt Lange", "platt", "payment@plattlanegarage.co.uk", "plattlane" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserID", "Email", "Name", "Password", "PaymentEmail", "Username" },
                values: new object[] { 6u, "charlie@birchlanegarage.com", "Birch Lane Garage", "birch", "payment@birchlanegarage.com", "birchlane" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserID", "Email", "Name", "Password", "PaymentEmail", "Username" },
                values: new object[] { 5u, "hello@mot-test-manchester.co.uk", "DC Motors", "dc", "payment@mot-test-manchester.co.uk", "dcmotors" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserID", "Email", "Name", "Password", "PaymentEmail", "Username" },
                values: new object[] { 4u, "duffy@duffymotors.co.uk", "Duffy Motors", "duffy", "admin@duffymotors.co.uk", "duffymotors" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserID", "Email", "Name", "Password", "PaymentEmail", "Username" },
                values: new object[] { 3u, "hello@jemsgarage.co.uk", "EMS GARAGE", "ems", "ems@emsgarage.co.uk", "emsgarage" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserID", "Email", "Name", "Password", "PaymentEmail", "Username" },
                values: new object[] { 2u, "john@queensgarage.com", "Queens Garage", "queens", "admin@queensgarage.com", "queensgarage" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserID", "Email", "Name", "Password", "PaymentEmail", "Username" },
                values: new object[] { 11u, "joy.heidenrei@gmail.com", "Kurt K Koski", "joy", "joy.heidenrei@gmail.com", "heidenrei" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserID", "Email", "Name", "Password", "PaymentEmail", "Username" },
                values: new object[] { 23u, "damion_powlows@hotmail.com", "Cindy A Butts", "powlows", "damion_powlows@hotmail.com", "cindya" });

            migrationBuilder.InsertData(
                table: "Garages",
                columns: new[] { "GarageID", "BasePrice", "Description", "GarageName", "Hourly_Rate", "ImagePath", "PaymentEmail", "UserID" },
                values: new object[] { 1u, 80.0, "Manchester's Leading Accident Repair Centre. Sapphire Garage was founded 25 years ago in one small unit on a trading estate in East Manchester.", "Sapphire Garage", 20.0, "http://www.sapphiregarage.co.uk/wp-content/uploads/2017/05/sapphire_garage_logo.png", "payment@sapphiregarage.co.uk", 1u });

            migrationBuilder.InsertData(
                table: "Garages",
                columns: new[] { "GarageID", "BasePrice", "Description", "GarageName", "Hourly_Rate", "ImagePath", "PaymentEmail", "UserID" },
                values: new object[] { 10u, 55.0, "Best Auto services in town.", "Z Cars Auto Services", 33.0, "http://placehold.it/32x32", "payment@zcarsautoservices.com", 10u });

            migrationBuilder.InsertData(
                table: "Garages",
                columns: new[] { "GarageID", "BasePrice", "Description", "GarageName", "Hourly_Rate", "ImagePath", "PaymentEmail", "UserID" },
                values: new object[] { 8u, 79.0, "Established since 1920, Bradford Garage Ltd has been owned by the Spence family since 1963.", "Bradford Garage", 24.0, "http://placehold.it/32x32", "payment@bradfordgarage.co.uk", 8u });

            migrationBuilder.InsertData(
                table: "Garages",
                columns: new[] { "GarageID", "BasePrice", "Description", "GarageName", "Hourly_Rate", "ImagePath", "PaymentEmail", "UserID" },
                values: new object[] { 7u, 87.0, "We are one of the leading car repair garages serving customers in Manchester. All mechanic services are performed by highly qualified mechanics.", "Platt Lane Garage", 27.0, "http://placehold.it/32x32", "payment@plattlanegarage.co.uk", 7u });

            migrationBuilder.InsertData(
                table: "Garages",
                columns: new[] { "GarageID", "BasePrice", "Description", "GarageName", "Hourly_Rate", "ImagePath", "PaymentEmail", "UserID" },
                values: new object[] { 6u, 74.0, "Small team of dedicated mechanics with long track record of excellent service and recovery", "Birch Lane Garage", 32.0, "http://placehold.it/32x32", "charlie@birchlanegarage.com", 6u });

            migrationBuilder.InsertData(
                table: "Garages",
                columns: new[] { "GarageID", "BasePrice", "Description", "GarageName", "Hourly_Rate", "ImagePath", "PaymentEmail", "UserID" },
                values: new object[] { 5u, 90.0, "DC Motor Engineers Garage is a premium MOT Testing Centre, car servicing and repair facility. Based in the centre of Manchester, 2 minutes walk from oxford road station and the University, our garage offers an unparalleled service.", "DC Motor Engineers", 21.0, "http://placehold.it/32x32", "payment@mot-test-manchester.co.uk", 5u });

            migrationBuilder.InsertData(
                table: "Garages",
                columns: new[] { "GarageID", "BasePrice", "Description", "GarageName", "Hourly_Rate", "ImagePath", "PaymentEmail", "UserID" },
                values: new object[] { 9u, 40.0, "Local garage with excellent services", "A Everall Garage", 19.0, "http://placehold.it/32x32", "payment@aeverallgarage.com", 9u });

            migrationBuilder.InsertData(
                table: "Garages",
                columns: new[] { "GarageID", "BasePrice", "Description", "GarageName", "Hourly_Rate", "ImagePath", "PaymentEmail", "UserID" },
                values: new object[] { 3u, 60.0, "Alternator and Starter Motor specialists. Servicing vehicles in Salford and Greater Manchester for over 35 years.", "EMS GARAGE", 26.0, "http://placehold.it/32x32", "payment@emsgarage.co.uk", 3u });

            migrationBuilder.InsertData(
                table: "Garages",
                columns: new[] { "GarageID", "BasePrice", "Description", "GarageName", "Hourly_Rate", "ImagePath", "PaymentEmail", "UserID" },
                values: new object[] { 2u, 50.0, "Local garage run by two mechanics", "Queens Garage", 21.0, "http://placehold.it/32x32", "admin@queensgarage.com", 2u });

            migrationBuilder.InsertData(
                table: "Garages",
                columns: new[] { "GarageID", "BasePrice", "Description", "GarageName", "Hourly_Rate", "ImagePath", "PaymentEmail", "UserID" },
                values: new object[] { 4u, 68.0, "One of the largest independent Service Centres and MOT Stations in Manchester City Centre.", "Duffy Motors", 38.0, "https://duffymotors.co.uk/wp-content/themes/duffy/library/img/logo.png", "payment@duffymotors.co.uk", 4u });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberID", "Number", "UserID" },
                values: new object[] { 4u, "0161 834 4168", 4u });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberID", "Number", "UserID" },
                values: new object[] { 21u, "903-882-6027", 21u });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberID", "Number", "UserID" },
                values: new object[] { 20u, "801-936-6137", 20u });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberID", "Number", "UserID" },
                values: new object[] { 19u, "509-728-9569", 19u });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberID", "Number", "UserID" },
                values: new object[] { 18u, "606-289-0588", 18u });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberID", "Number", "UserID" },
                values: new object[] { 17u, "937-443-8221", 17u });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberID", "Number", "UserID" },
                values: new object[] { 16u, "714-923-1921", 16u });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberID", "Number", "UserID" },
                values: new object[] { 15u, "210-659-1915", 15u });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberID", "Number", "UserID" },
                values: new object[] { 14u, "313-962-1315", 14u });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberID", "Number", "UserID" },
                values: new object[] { 13u, "703-720-4438", 13u });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberID", "Number", "UserID" },
                values: new object[] { 12u, "703-467-0416", 12u });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberID", "Number", "UserID" },
                values: new object[] { 10u, "07973 341794", 10u });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberID", "Number", "UserID" },
                values: new object[] { 1u, "0161 202 8600", 1u });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberID", "Number", "UserID" },
                values: new object[] { 9u, "0161 835 1699", 9u });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberID", "Number", "UserID" },
                values: new object[] { 22u, "352-419-8539", 22u });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberID", "Number", "UserID" },
                values: new object[] { 8u, "0161 370 5664", 8u });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberID", "Number", "UserID" },
                values: new object[] { 7u, "0161 225 4224", 7u });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberID", "Number", "UserID" },
                values: new object[] { 2u, "0161 203 4180", 2u });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberID", "Number", "UserID" },
                values: new object[] { 6u, "0161 224 6633", 6u });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberID", "Number", "UserID" },
                values: new object[] { 5u, "0161 273 4244", 5u });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberID", "Number", "UserID" },
                values: new object[] { 3u, "0161 792 2824", 3u });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberID", "Number", "UserID" },
                values: new object[] { 11u, "205-807-0833", 11u });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberID", "Number", "UserID" },
                values: new object[] { 23u, " 903-440-3569", 23u });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "AddressID", "County", "GarageID", "Latitude", "LineOne", "LineTwo", "Longitude", "PostCode" },
                values: new object[] { 1u, "Greater Manchester", 1u, 53.499447799999999, "Quantum Park", "Monsall Rd", -2.2026933, "M40 8FY" });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "AddressID", "County", "GarageID", "Latitude", "LineOne", "LineTwo", "Longitude", "PostCode" },
                values: new object[] { 6u, "Greater Manchester", 6u, 53.470544599999997, "21 Textile St", "", -2.1930223999999998, "M12 5DJ" });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "AddressID", "County", "GarageID", "Latitude", "LineOne", "LineTwo", "Longitude", "PostCode" },
                values: new object[] { 3u, "Greater Manchester", 3u, 53.501179299999997, "7 Firth Cl", "Salford", -2.2608823, "M7 2YD" });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "AddressID", "County", "GarageID", "Latitude", "LineOne", "LineTwo", "Longitude", "PostCode" },
                values: new object[] { 7u, "Greater Manchester", 7u, 53.446658999999997, "334-336 Platt Ln", "", -2.2387429999999999, "M14 7DA" });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "AddressID", "County", "GarageID", "Latitude", "LineOne", "LineTwo", "Longitude", "PostCode" },
                values: new object[] { 8u, "Greater Manchester", 8u, 53.476317299999998, "70 Edge Ln", "Droylsden", -2.1619087000000001, "M43 6BA" });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "AddressID", "County", "GarageID", "Latitude", "LineOne", "LineTwo", "Longitude", "PostCode" },
                values: new object[] { 5u, "Greater Manchester", 5u, 53.474063200000003, "45 York St", "", -2.2389632000000002, "M1 7DE" });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "AddressID", "County", "GarageID", "Latitude", "LineOne", "LineTwo", "Longitude", "PostCode" },
                values: new object[] { 9u, "Greater Manchester", 9u, 53.485469700000003, "3 Blackfriars Rd", "Salford", -2.2507649999999999, "M3 7AQ" });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "AddressID", "County", "GarageID", "Latitude", "LineOne", "LineTwo", "Longitude", "PostCode" },
                values: new object[] { 4u, "Greater Manchester", 4u, 53.475851200000001, "16-17 Watson St", "", -2.2485708999999998, "M3 4LP" });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "AddressID", "County", "GarageID", "Latitude", "LineOne", "LineTwo", "Longitude", "PostCode" },
                values: new object[] { 2u, "Greater Manchester", 2u, 53.501983299999999, "Queens Rd", "", -2.2276524000000002, "M8 0RB" });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "AddressID", "County", "GarageID", "Latitude", "LineOne", "LineTwo", "Longitude", "PostCode" },
                values: new object[] { 10u, "Greater Manchester", 10u, 53.493595499999998, "3 Collingham St", "", -2.2351911000000002, "M8 8RQ" });

            migrationBuilder.InsertData(
                table: "Invoices",
                columns: new[] { "InvoiceID", "GarageID", "Hours", "Parts", "Recovery_Fee", "UserID" },
                values: new object[] { 12u, 10u, 1.0, 4.0, null, 17u });

            migrationBuilder.InsertData(
                table: "Invoices",
                columns: new[] { "InvoiceID", "GarageID", "Hours", "Parts", "Recovery_Fee", "UserID" },
                values: new object[] { 6u, 6u, 1.3999999999999999, 0.0, 100.0, 14u });

            migrationBuilder.InsertData(
                table: "Invoices",
                columns: new[] { "InvoiceID", "GarageID", "Hours", "Parts", "Recovery_Fee", "UserID" },
                values: new object[] { 13u, 10u, 1.0, 4.0, null, 18u });

            migrationBuilder.InsertData(
                table: "Invoices",
                columns: new[] { "InvoiceID", "GarageID", "Hours", "Parts", "Recovery_Fee", "UserID" },
                values: new object[] { 14u, 10u, 1.7, 30.0, null, 18u });

            migrationBuilder.InsertData(
                table: "Invoices",
                columns: new[] { "InvoiceID", "GarageID", "Hours", "Parts", "Recovery_Fee", "UserID" },
                values: new object[] { 16u, 5u, 1.0, 0.0, 90.0, 19u });

            migrationBuilder.InsertData(
                table: "Invoices",
                columns: new[] { "InvoiceID", "GarageID", "Hours", "Parts", "Recovery_Fee", "UserID" },
                values: new object[] { 7u, 5u, 0.90000000000000002, 10.0, null, 15u });

            migrationBuilder.InsertData(
                table: "Invoices",
                columns: new[] { "InvoiceID", "GarageID", "Hours", "Parts", "Recovery_Fee", "UserID" },
                values: new object[] { 11u, 9u, 1.2, 2.7000000000000002, 100.0, 17u });

            migrationBuilder.InsertData(
                table: "Invoices",
                columns: new[] { "InvoiceID", "GarageID", "Hours", "Parts", "Recovery_Fee", "UserID" },
                values: new object[] { 10u, 8u, 1.0, 0.0, 120.0, 16u });

            migrationBuilder.InsertData(
                table: "Invoices",
                columns: new[] { "InvoiceID", "GarageID", "Hours", "Parts", "Recovery_Fee", "UserID" },
                values: new object[] { 8u, 6u, 0.69999999999999996, 0.0, null, 15u });

            migrationBuilder.InsertData(
                table: "Invoices",
                columns: new[] { "InvoiceID", "GarageID", "Hours", "Parts", "Recovery_Fee", "UserID" },
                values: new object[] { 15u, 2u, 1.5, 12.0, null, 19u });

            migrationBuilder.InsertData(
                table: "Invoices",
                columns: new[] { "InvoiceID", "GarageID", "Hours", "Parts", "Recovery_Fee", "UserID" },
                values: new object[] { 3u, 2u, 1.2, 5.0, null, 13u });

            migrationBuilder.InsertData(
                table: "Invoices",
                columns: new[] { "InvoiceID", "GarageID", "Hours", "Parts", "Recovery_Fee", "UserID" },
                values: new object[] { 1u, 1u, 1.0, 0.0, null, 12u });

            migrationBuilder.InsertData(
                table: "Invoices",
                columns: new[] { "InvoiceID", "GarageID", "Hours", "Parts", "Recovery_Fee", "UserID" },
                values: new object[] { 2u, 2u, 0.69999999999999996, 20.0, null, 12u });

            migrationBuilder.InsertData(
                table: "Invoices",
                columns: new[] { "InvoiceID", "GarageID", "Hours", "Parts", "Recovery_Fee", "UserID" },
                values: new object[] { 9u, 3u, 1.0, 5.6799999999999997, null, 16u });

            migrationBuilder.InsertData(
                table: "Invoices",
                columns: new[] { "InvoiceID", "GarageID", "Hours", "Parts", "Recovery_Fee", "UserID" },
                values: new object[] { 5u, 3u, 2.0, 40.0, null, 14u });

            migrationBuilder.InsertData(
                table: "Invoices",
                columns: new[] { "InvoiceID", "GarageID", "Hours", "Parts", "Recovery_Fee", "UserID" },
                values: new object[] { 4u, 3u, 0.59999999999999998, 12.0, null, 13u });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "ReviewID", "Body", "GarageID", "Rating", "UserID" },
                values: new object[] { 23u, "Took too long, felt like wasted time", 8u, 2.0, 23u });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "ReviewID", "Body", "GarageID", "Rating", "UserID" },
                values: new object[] { 24u, "Brilliant professional and friendly service, at very reasonable prices.", 9u, 5.0, 22u });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "ReviewID", "Body", "GarageID", "Rating", "UserID" },
                values: new object[] { 25u, "Competent mechanics. Don't try and do loads of unnecessary work. A good job at a good price", 9u, 4.0, 12u });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "ReviewID", "Body", "GarageID", "Rating", "UserID" },
                values: new object[] { 26u, "Acceptable service", 9u, 3.0, 11u });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "ReviewID", "Body", "GarageID", "Rating", "UserID" },
                values: new object[] { 27u, "10/10 quality service.", 9u, 5.0, 15u });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "ReviewID", "Body", "GarageID", "Rating", "UserID" },
                values: new object[] { 29u, "Used this garage on several occasions, first class service. The Staff are always very pleasant and helpful.", 9u, 4.0, 17u });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "ReviewID", "Body", "GarageID", "Rating", "UserID" },
                values: new object[] { 22u, "Proper family honest garage service, quick response and friendly.", 8u, 4.0, 22u });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "ReviewID", "Body", "GarageID", "Rating", "UserID" },
                values: new object[] { 3u, "Said would take an hour but ended up three, took too long", 1u, 2.0, 16u });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "ReviewID", "Body", "GarageID", "Rating", "UserID" },
                values: new object[] { 2u, "Fixed on site quickly", 1u, 5.0, 14u });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "ReviewID", "Body", "GarageID", "Rating", "UserID" },
                values: new object[] { 1u, "Very fast serivce and got on the road quickly", 1u, 5.0, 11u });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "ReviewID", "Body", "GarageID", "Rating", "UserID" },
                values: new object[] { 30u, "Took too long to arrive, said would be 30 minutes but it was hour and half, unacceptable", 10u, 1.0, 16u });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "ReviewID", "Body", "GarageID", "Rating", "UserID" },
                values: new object[] { 31u, "Good place for quick recovery", 10u, 4.0, 15u });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "ReviewID", "Body", "GarageID", "Rating", "UserID" },
                values: new object[] { 28u, "A great service as always. A huge THANK YOU.", 9u, 4.0, 18u });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "ReviewID", "Body", "GarageID", "Rating", "UserID" },
                values: new object[] { 21u, "Lovely friendly guys! Fast and efficient service. Thanks very much.", 8u, 5.0, 21u });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "ReviewID", "Body", "GarageID", "Rating", "UserID" },
                values: new object[] { 9u, "Quick arrival and mechanic very nice", 4u, 4.0, 11u });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "ReviewID", "Body", "GarageID", "Rating", "UserID" },
                values: new object[] { 8u, "Excellent service, quick response", 3u, 5.0, 17u });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "ReviewID", "Body", "GarageID", "Rating", "UserID" },
                values: new object[] { 10u, "Said could fix car on site but had they had to tow it back to their garage", 4u, 1.0, 12u });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "ReviewID", "Body", "GarageID", "Rating", "UserID" },
                values: new object[] { 11u, "Speedy service and on road quickly", 4u, 5.0, 13u });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "ReviewID", "Body", "GarageID", "Rating", "UserID" },
                values: new object[] { 12u, "Super fast service but quite dear", 4u, 4.0, 14u });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "ReviewID", "Body", "GarageID", "Rating", "UserID" },
                values: new object[] { 7u, "Good service but pricey", 3u, 3.0, 14u });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "ReviewID", "Body", "GarageID", "Rating", "UserID" },
                values: new object[] { 13u, "Great service", 5u, 4.0, 20u });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "ReviewID", "Body", "GarageID", "Rating", "UserID" },
                values: new object[] { 6u, "Far too long waiting for them", 2u, 2.0, 19u });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "ReviewID", "Body", "GarageID", "Rating", "UserID" },
                values: new object[] { 32u, "Very friendly staff, quick response", 10u, 5.0, 19u });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "ReviewID", "Body", "GarageID", "Rating", "UserID" },
                values: new object[] { 14u, "Arrived quickly but took long time fixing car", 6u, 2.0, 14u });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "ReviewID", "Body", "GarageID", "Rating", "UserID" },
                values: new object[] { 15u, "Arrived ten minutes later than they said and took while to get car running", 6u, 3.0, 15u });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "ReviewID", "Body", "GarageID", "Rating", "UserID" },
                values: new object[] { 16u, "Too slow and pricey, would not recommend", 6u, 1.0, 16u });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "ReviewID", "Body", "GarageID", "Rating", "UserID" },
                values: new object[] { 5u, "Great service and prices. Very good Staff", 2u, 4.0, 22u });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "ReviewID", "Body", "GarageID", "Rating", "UserID" },
                values: new object[] { 17u, "Top work on my van", 7u, 5.0, 17u });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "ReviewID", "Body", "GarageID", "Rating", "UserID" },
                values: new object[] { 18u, "Super fast service and fixed within minutes", 7u, 5.0, 18u });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "ReviewID", "Body", "GarageID", "Rating", "UserID" },
                values: new object[] { 19u, "Friendly & helpful service with quick resolution.", 7u, 4.0, 19u });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "ReviewID", "Body", "GarageID", "Rating", "UserID" },
                values: new object[] { 4u, "Slow arriving but fixed car quickly", 2u, 3.0, 12u });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "ReviewID", "Body", "GarageID", "Rating", "UserID" },
                values: new object[] { 20u, "Overpriced", 8u, 1.0, 20u });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "ReviewID", "Body", "GarageID", "Rating", "UserID" },
                values: new object[] { 33u, "Amazingly fast service, got on road again in no time", 10u, 5.0, 20u });

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_GarageID",
                table: "Addresses",
                column: "GarageID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Garages_UserID",
                table: "Garages",
                column: "UserID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_GarageID",
                table: "Invoices",
                column: "GarageID");

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_UserID",
                table: "Invoices",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_PhoneNumbers_UserID",
                table: "PhoneNumbers",
                column: "UserID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_GarageID",
                table: "Reviews",
                column: "GarageID");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_UserID",
                table: "Reviews",
                column: "UserID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropTable(
                name: "Invoices");

            migrationBuilder.DropTable(
                name: "PhoneNumbers");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "Garages");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
