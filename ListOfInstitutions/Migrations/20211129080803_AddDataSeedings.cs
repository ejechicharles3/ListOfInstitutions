using Microsoft.EntityFrameworkCore.Migrations;

namespace ListOfInstitutions.Migrations
{
    public partial class AddDataSeedings : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Name", "ShortName" },
                values: new object[,]
                {
                    { 1, "Nigeria", "NG" },
                    { 2, "United State Of America", "USA" },
                    { 3, "South Africa", "SA" },
                    { 4, "Canada", "CA" }
                });

            migrationBuilder.InsertData(
                table: "Schools",
                columns: new[] { "Id", "Address", "CountryId", "Name", "Rating" },
                values: new object[,]
                {
                    { 1, "FCT, Abuja", 1, "Open University", 4.5 },
                    { 2, "Cambridge", 2, "Massachusetts Institute of Technology", 5.0 },
                    { 3, "Preller St, Muckleneuk, Pretoria, 0002, South Africa", 3, "University of South Africa", 4.5 },
                    { 4, "Ontario, Canada", 4, "University of Toronto", 5.4000000000000004 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
