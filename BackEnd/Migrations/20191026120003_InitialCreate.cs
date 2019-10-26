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
                    CreatedAt = table.Column<DateTime>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastUpdatedAt = table.Column<DateTime>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP")
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
                    UserID = table.Column<uint>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastUpdatedAt = table.Column<DateTime>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP")
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
                    CreatedAt = table.Column<DateTime>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastUpdatedAt = table.Column<DateTime>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP")
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
                    CreatedAt = table.Column<DateTime>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastUpdatedAt = table.Column<DateTime>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP")
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
                    GarageID = table.Column<uint>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastUpdatedAt = table.Column<DateTime>(nullable: false, defaultValueSql: "NOW()")
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
                    CreatedAt = table.Column<DateTime>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastUpdatedAt = table.Column<DateTime>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP")
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
                values: new object[] { 1u, "reillyholden@jamnation.com", "cillum", "amet", "reillyholden@jamnation.com", "cupidatat" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserID", "Email", "Name", "Password", "PaymentEmail", "Username" },
                values: new object[] { 2u, "reillyholden@jamnation.com", "labore", "et", "reillyholden@jamnation.com", "labore" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserID", "Email", "Name", "Password", "PaymentEmail", "Username" },
                values: new object[] { 3u, "reillyholden@jamnation.com", "ut", "aliqua", "reillyholden@jamnation.com", "dolore" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserID", "Email", "Name", "Password", "PaymentEmail", "Username" },
                values: new object[] { 4u, "reillyholden@jamnation.com", "dolor", "in", "reillyholden@jamnation.com", "veniam" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserID", "Email", "Name", "Password", "PaymentEmail", "Username" },
                values: new object[] { 5u, "reillyholden@jamnation.com", "esse", "mollit", "reillyholden@jamnation.com", "consectetur" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserID", "Email", "Name", "Password", "PaymentEmail", "Username" },
                values: new object[] { 6u, "reillyholden@jamnation.com", "consectetur", "voluptate", "reillyholden@jamnation.com", "consequat" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserID", "Email", "Name", "Password", "PaymentEmail", "Username" },
                values: new object[] { 7u, "reillyholden@jamnation.com", "pariatur", "ut", "reillyholden@jamnation.com", "officia" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserID", "Email", "Name", "Password", "PaymentEmail", "Username" },
                values: new object[] { 8u, "reillyholden@jamnation.com", "irure", "in", "reillyholden@jamnation.com", "nostrud" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserID", "Email", "Name", "Password", "PaymentEmail", "Username" },
                values: new object[] { 9u, "reillyholden@jamnation.com", "laborum", "cillum", "reillyholden@jamnation.com", "anim" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserID", "Email", "Name", "Password", "PaymentEmail", "Username" },
                values: new object[] { 10u, "reillyholden@jamnation.com", "user only", "woooo", "reillyholden@jamnation.com", "no garage" });

            migrationBuilder.InsertData(
                table: "Garages",
                columns: new[] { "GarageID", "BasePrice", "Description", "GarageName", "ImagePath", "PaymentEmail", "UserID" },
                values: new object[] { 1u, 66.0, @"Cupidatat est occaecat esse aute mollit qui commodo. Ea consequat reprehenderit labore laborum excepteur. Sint do non voluptate velit adipisicing incididunt occaecat tempor velit.
", "commodo", "http://placehold.it/32x32", "reillyholden@jamnation.com", 1u });

            migrationBuilder.InsertData(
                table: "Garages",
                columns: new[] { "GarageID", "BasePrice", "Description", "GarageName", "ImagePath", "PaymentEmail", "UserID" },
                values: new object[] { 9u, 98.0, @"Voluptate excepteur non cupidatat veniam amet. Qui nisi dolor excepteur sit minim cillum. Aliqua commodo ullamco commodo exercitation nostrud dolor fugiat consequat eu consequat do adipisicing. In adipisicing dolore ut magna cillum dolor id.
", "ut", "http://placehold.it/32x32", "reillyholden@jamnation.com", 9u });

            migrationBuilder.InsertData(
                table: "Garages",
                columns: new[] { "GarageID", "BasePrice", "Description", "GarageName", "ImagePath", "PaymentEmail", "UserID" },
                values: new object[] { 2u, 81.0, @"Magna ipsum voluptate Lorem esse sunt in consequat consequat laborum qui consequat excepteur cupidatat ea. Cillum elit id occaecat eiusmod tempor consectetur laboris voluptate anim tempor ea veniam. Proident eu do pariatur laborum ad reprehenderit nostrud exercitation eu magna enim. Enim nulla enim consequat dolore sint id eiusmod fugiat deserunt.
", "sunt", "http://placehold.it/32x32", "reillyholden@jamnation.com", 2u });

            migrationBuilder.InsertData(
                table: "Garages",
                columns: new[] { "GarageID", "BasePrice", "Description", "GarageName", "ImagePath", "PaymentEmail", "UserID" },
                values: new object[] { 3u, 43.0, @"In velit mollit exercitation nulla deserunt cillum incididunt ipsum. Aliquip veniam elit mollit qui reprehenderit sint esse excepteur voluptate ex amet magna occaecat Lorem. Enim dolore sint cillum deserunt consectetur laborum commodo commodo commodo id.
", "duis", "http://placehold.it/32x32", "reillyholden@jamnation.com", 3u });

            migrationBuilder.InsertData(
                table: "Garages",
                columns: new[] { "GarageID", "BasePrice", "Description", "GarageName", "ImagePath", "PaymentEmail", "UserID" },
                values: new object[] { 8u, 79.0, @"Ipsum voluptate elit nisi exercitation Lorem id proident in anim deserunt. Cillum cillum elit minim veniam cupidatat deserunt ea aute do ex non excepteur Lorem. Cupidatat cupidatat Lorem non officia non consequat do et ipsum aliquip. Fugiat ullamco ullamco magna et incididunt dolor. Veniam ipsum voluptate voluptate ad Lorem reprehenderit laborum dolor sit anim pariatur ex. Ex in consequat cupidatat qui ad velit tempor sunt duis culpa ea elit Lorem minim. Adipisicing consectetur pariatur enim velit veniam sit do enim consectetur.
", "esse", "http://placehold.it/32x32", "reillyholden@jamnation.com", 8u });

            migrationBuilder.InsertData(
                table: "Garages",
                columns: new[] { "GarageID", "BasePrice", "Description", "GarageName", "ImagePath", "PaymentEmail", "UserID" },
                values: new object[] { 4u, 68.0, @"Mollit et irure officia sint. Sit nisi aliquip proident sunt exercitation elit. Incididunt aliquip ut pariatur eiusmod est dolore ullamco amet aliqua. Dolore enim sint nulla ipsum magna in laborum. Laboris id commodo eiusmod eiusmod mollit aliquip occaecat Lorem officia laborum amet aute cillum ex. Amet amet esse duis qui id et proident sunt dolor occaecat Lorem officia aliqua. Fugiat nisi aute mollit eiusmod do elit sunt excepteur do id mollit cillum.
", "aliquip", "http://placehold.it/32x32", "reillyholden@jamnation.com", 4u });

            migrationBuilder.InsertData(
                table: "Garages",
                columns: new[] { "GarageID", "BasePrice", "Description", "GarageName", "ImagePath", "PaymentEmail", "UserID" },
                values: new object[] { 5u, 56.0, @"Qui esse irure occaecat deserunt veniam ea eiusmod adipisicing. Do ipsum id irure ipsum officia mollit nulla. Minim culpa ipsum sint adipisicing non sint do et. Et ipsum cillum nulla incididunt do Lorem incididunt id deserunt sit. Occaecat anim nostrud elit duis in ex. Ex veniam do aliqua nostrud dolor.
", "sunt", "http://placehold.it/32x32", "reillyholden@jamnation.com", 5u });

            migrationBuilder.InsertData(
                table: "Garages",
                columns: new[] { "GarageID", "BasePrice", "Description", "GarageName", "ImagePath", "PaymentEmail", "UserID" },
                values: new object[] { 7u, 87.0, @"Qui qui veniam velit aliqua reprehenderit velit id labore. Commodo minim eu ad dolor ipsum aute occaecat est amet laboris amet. In ipsum Lorem officia ipsum irure ex labore est duis incididunt.
", "in", "http://placehold.it/32x32", "reillyholden@jamnation.com", 7u });

            migrationBuilder.InsertData(
                table: "Garages",
                columns: new[] { "GarageID", "BasePrice", "Description", "GarageName", "ImagePath", "PaymentEmail", "UserID" },
                values: new object[] { 6u, 74.0, @"Lorem Lorem qui Lorem eiusmod consequat et deserunt ea fugiat consectetur eu in id. Ipsum ea non tempor laboris ad ad pariatur mollit exercitation in officia ut fugiat enim. Aute in irure tempor excepteur fugiat labore. Nisi Lorem laborum commodo minim commodo occaecat ullamco fugiat nostrud. Aliquip enim culpa aliquip veniam aute aliqua velit Lorem officia anim et enim id. Ad nisi reprehenderit velit voluptate sunt est nisi enim occaecat anim proident.
", "sunt", "http://placehold.it/32x32", "reillyholden@jamnation.com", 6u });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberID", "Number", "UserID" },
                values: new object[] { 8u, "(861) 568-2968", 8u });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberID", "Number", "UserID" },
                values: new object[] { 7u, "(951) 538-2988", 7u });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberID", "Number", "UserID" },
                values: new object[] { 5u, "(892) 539-2626", 5u });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberID", "Number", "UserID" },
                values: new object[] { 9u, "(832) 409-3078", 9u });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberID", "Number", "UserID" },
                values: new object[] { 4u, "(866) 517-3903", 4u });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberID", "Number", "UserID" },
                values: new object[] { 3u, "(816) 448-2524", 3u });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberID", "Number", "UserID" },
                values: new object[] { 2u, "(920) 558-2158", 2u });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberID", "Number", "UserID" },
                values: new object[] { 1u, "(933) 548-2349", 1u });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberID", "Number", "UserID" },
                values: new object[] { 6u, "(975) 562-3728", 6u });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberID", "Number", "UserID" },
                values: new object[] { 10u, "(848749-3078", 10u });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "AddressID", "County", "GarageID", "Latitude", "LineOne", "LineTwo", "Longitude", "PostCode" },
                values: new object[] { 1u, " Colorado", 1u, 53.475851200000001, "159 Irving Street", "proident", 2.2485708999999998, "sunt" });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "AddressID", "County", "GarageID", "Latitude", "LineOne", "LineTwo", "Longitude", "PostCode" },
                values: new object[] { 9u, " Nebraska", 9u, 53.4942244, "250 Fleet Stree", "ipsum", -2.2551477000000002, "sit" });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "AddressID", "County", "GarageID", "Latitude", "LineOne", "LineTwo", "Longitude", "PostCode" },
                values: new object[] { 2u, " Wisconsin", 2u, 53.475602199999997, "909 Louisa Street", "quis", -2.2225212999999999, "do" });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "AddressID", "County", "GarageID", "Latitude", "LineOne", "LineTwo", "Longitude", "PostCode" },
                values: new object[] { 8u, " Alaska", 8u, 53.466488900000002, "755 Kings Place", "laborum", -2.2729343000000002, "officia" });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "AddressID", "County", "GarageID", "Latitude", "LineOne", "LineTwo", "Longitude", "PostCode" },
                values: new object[] { 3u, " Texas", 3u, 53.485472899999998, "885 Oxford Walk", "laborum", -2.2507703000000001, "in" });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "AddressID", "County", "GarageID", "Latitude", "LineOne", "LineTwo", "Longitude", "PostCode" },
                values: new object[] { 7u, " Puerto Rico", 7u, 53.468149500000003, "566 Clay Street", "dolore", -2.2400612, "some" });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "AddressID", "County", "GarageID", "Latitude", "LineOne", "LineTwo", "Longitude", "PostCode" },
                values: new object[] { 4u, " Arizona", 4u, 53.490228700000003, "217 Dunne Place", "exercitation", -2.2347950999999999, "laboris" });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "AddressID", "County", "GarageID", "Latitude", "LineOne", "LineTwo", "Longitude", "PostCode" },
                values: new object[] { 6u, " North Dakota", 6u, 53.4928265, "255 Bedell Lane", "irure", -2.2374451, "id" });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "AddressID", "County", "GarageID", "Latitude", "LineOne", "LineTwo", "Longitude", "PostCode" },
                values: new object[] { 5u, " Virgin Islands", 5u, 53.482580599999999, "165 Kimball Street", "nostrud", -2.2415631999999999, "duis" });

            migrationBuilder.InsertData(
                table: "Invoices",
                columns: new[] { "InvoiceID", "GarageID", "UserID" },
                values: new object[] { 8u, 8u, 8u });

            migrationBuilder.InsertData(
                table: "Invoices",
                columns: new[] { "InvoiceID", "GarageID", "UserID" },
                values: new object[] { 7u, 7u, 7u });

            migrationBuilder.InsertData(
                table: "Invoices",
                columns: new[] { "InvoiceID", "GarageID", "UserID" },
                values: new object[] { 6u, 6u, 6u });

            migrationBuilder.InsertData(
                table: "Invoices",
                columns: new[] { "InvoiceID", "GarageID", "UserID" },
                values: new object[] { 9u, 9u, 9u });

            migrationBuilder.InsertData(
                table: "Invoices",
                columns: new[] { "InvoiceID", "GarageID", "UserID" },
                values: new object[] { 5u, 5u, 5u });

            migrationBuilder.InsertData(
                table: "Invoices",
                columns: new[] { "InvoiceID", "GarageID", "UserID" },
                values: new object[] { 4u, 4u, 4u });

            migrationBuilder.InsertData(
                table: "Invoices",
                columns: new[] { "InvoiceID", "GarageID", "UserID" },
                values: new object[] { 3u, 3u, 3u });

            migrationBuilder.InsertData(
                table: "Invoices",
                columns: new[] { "InvoiceID", "GarageID", "UserID" },
                values: new object[] { 2u, 2u, 2u });

            migrationBuilder.InsertData(
                table: "Invoices",
                columns: new[] { "InvoiceID", "GarageID", "UserID" },
                values: new object[] { 1u, 1u, 1u });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "ReviewID", "Body", "GarageID", "Rating", "UserID" },
                values: new object[] { 5u, " y4ez y4ez yz y4 ", 5u, 4.0, 5u });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "ReviewID", "Body", "GarageID", "Rating", "UserID" },
                values: new object[] { 3u, "rtyezm4y4y", 3u, 2.0, 3u });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "ReviewID", "Body", "GarageID", "Rating", "UserID" },
                values: new object[] { 6u, " y4ezy 4e y4e ", 6u, 1.0, 6u });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "ReviewID", "Body", "GarageID", "Rating", "UserID" },
                values: new object[] { 2u, "4an6a6n", 2u, 5.0, 2u });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "ReviewID", "Body", "GarageID", "Rating", "UserID" },
                values: new object[] { 7u, " y4dz y4e yea54i54a", 7u, 4.0, 7u });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "ReviewID", "Body", "GarageID", "Rating", "UserID" },
                values: new object[] { 1u, "4ma66ma436m", 1u, 5.0, 1u });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "ReviewID", "Body", "GarageID", "Rating", "UserID" },
                values: new object[] { 8u, " 4e 4ez y5u54amamyt", 8u, 3.0, 8u });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "ReviewID", "Body", "GarageID", "Rating", "UserID" },
                values: new object[] { 4u, " y4ezy4ez e4z y4ez yz", 4u, 3.0, 4u });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "ReviewID", "Body", "GarageID", "Rating", "UserID" },
                values: new object[] { 9u, "ersliror3sru3oj", 9u, 4.0, 9u });

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
