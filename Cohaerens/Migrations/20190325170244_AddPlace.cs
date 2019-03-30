using Microsoft.EntityFrameworkCore.Migrations;

namespace Cohaerens.Migrations
{
    public partial class AddPlace : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "PlaceId",
                table: "SysComs",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateIndex(
                name: "IX_SysComs_PlaceId",
                table: "SysComs",
                column: "PlaceId");

            migrationBuilder.AddForeignKey(
                name: "FK_SysComs_Places_PlaceId",
                table: "SysComs",
                column: "PlaceId",
                principalTable: "Places",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SysComs_Places_PlaceId",
                table: "SysComs");

            migrationBuilder.DropIndex(
                name: "IX_SysComs_PlaceId",
                table: "SysComs");

            migrationBuilder.DropColumn(
                name: "PlaceId",
                table: "SysComs");
        }
    }
}
