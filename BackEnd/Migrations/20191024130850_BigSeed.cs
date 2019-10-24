using Microsoft.EntityFrameworkCore.Migrations;

namespace BackEnd.Migrations
{
    public partial class BigSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberID",
                keyValue: 1,
                column: "Number",
                value: "(933) 548-2349");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 1,
                columns: new[] { "Email", "Name", "Password", "PaymentEmail", "Username" },
                values: new object[] { "reillyholden@jamnation.com", "cillum", "amet", "reillyholden@jamnation.com", "cupidatat" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserID", "Email", "Name", "Password", "PaymentEmail", "Username" },
                values: new object[] { 2, "reillyholden@jamnation.com", "labore", "et", "reillyholden@jamnation.com", "labore" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserID", "Email", "Name", "Password", "PaymentEmail", "Username" },
                values: new object[] { 3, "reillyholden@jamnation.com", "ut", "aliqua", "reillyholden@jamnation.com", "dolore" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserID", "Email", "Name", "Password", "PaymentEmail", "Username" },
                values: new object[] { 4, "reillyholden@jamnation.com", "dolor", "in", "reillyholden@jamnation.com", "veniam" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserID", "Email", "Name", "Password", "PaymentEmail", "Username" },
                values: new object[] { 5, "reillyholden@jamnation.com", "esse", "mollit", "reillyholden@jamnation.com", "consectetur" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserID", "Email", "Name", "Password", "PaymentEmail", "Username" },
                values: new object[] { 6, "reillyholden@jamnation.com", "consectetur", "voluptate", "reillyholden@jamnation.com", "consequat" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserID", "Email", "Name", "Password", "PaymentEmail", "Username" },
                values: new object[] { 7, "reillyholden@jamnation.com", "pariatur", "ut", "reillyholden@jamnation.com", "officia" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserID", "Email", "Name", "Password", "PaymentEmail", "Username" },
                values: new object[] { 8, "reillyholden@jamnation.com", "irure", "in", "reillyholden@jamnation.com", "nostrud" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserID", "Email", "Name", "Password", "PaymentEmail", "Username" },
                values: new object[] { 9, "reillyholden@jamnation.com", "laborum", "cillum", "reillyholden@jamnation.com", "anim" });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberID", "Number", "UserID" },
                values: new object[,]
                {
                    { 2, "(920) 558-2158", 2 },
                    { 3, "(816) 448-2524", 3 },
                    { 4, "(866) 517-3903", 4 },
                    { 5, "(892) 539-2626", 5 },
                    { 6, "(975) 562-3728", 6 },
                    { 7, "(951) 538-2988", 7 },
                    { 8, "(861) 568-2968", 8 },
                    { 9, "(832) 409-3078", 9 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 9);

            migrationBuilder.UpdateData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberID",
                keyValue: 1,
                column: "Number",
                value: "01939493");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 1,
                columns: new[] { "Email", "Name", "Password", "PaymentEmail", "Username" },
                values: new object[] { "someone@something.com", "Emile", "1234", "someone@paymenow.com", "spanner" });
        }
    }
}
