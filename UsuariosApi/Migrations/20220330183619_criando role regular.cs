using Microsoft.EntityFrameworkCore.Migrations;

namespace UsuariosApi.Migrations
{
    public partial class criandoroleregular : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99999,
                column: "ConcurrencyStamp",
                value: "2522a644-ec15-4f7f-98d5-22d3aeb20f8d");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { 99997, "2c4e229b-6f70-4609-89f9-ffdc810df90d", "regular", "REGULAR" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 99999,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "94caebf5-ffbe-4989-9313-0c4315da93fa", "AQAAAAEAACcQAAAAEJ52bTeis7U9s1VAwRqQh1RXuFzbGkCamPpmTpqd+8bS2RgyHVZd+Cvb0fluUuJA7A==", "4f0e5df7-ed60-4970-8deb-2820ef28ab6f" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99997);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99999,
                column: "ConcurrencyStamp",
                value: "be9f40c4-5457-44cb-ba52-7443ddc861eb");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 99999,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2dfc8830-63dd-4f53-ae28-1f9473d613a1", "AQAAAAEAACcQAAAAEDsapjfj5Awbt02rAzBZ9rRJn04XRVNqJek18Nv0qmHpDqgcNgLd0+63EChjGWSd6g==", "c089d154-bd37-4310-85a6-788daadfff7d" });
        }
    }
}
