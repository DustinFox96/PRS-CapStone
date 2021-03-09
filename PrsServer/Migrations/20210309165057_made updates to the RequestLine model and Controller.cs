using Microsoft.EntityFrameworkCore.Migrations;

namespace PrsServer.Migrations
{
    public partial class madeupdatestotheRequestLinemodelandController : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_RequestLines_ProductId",
                table: "RequestLines",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_RequestLines_Products_ProductId",
                table: "RequestLines",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RequestLines_Products_ProductId",
                table: "RequestLines");

            migrationBuilder.DropIndex(
                name: "IX_RequestLines_ProductId",
                table: "RequestLines");
        }
    }
}
