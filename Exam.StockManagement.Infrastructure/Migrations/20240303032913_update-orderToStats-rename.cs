using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Exam.StockManagement.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class updateorderToStatsrename : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Products_ProductId",
                table: "Orders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Orders",
                table: "Orders");

            migrationBuilder.RenameTable(
                name: "Orders",
                newName: "Stats");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_ProductId",
                table: "Stats",
                newName: "IX_Stats_ProductId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Stats",
                table: "Stats",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Stats_Products_ProductId",
                table: "Stats",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Stats_Products_ProductId",
                table: "Stats");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Stats",
                table: "Stats");

            migrationBuilder.RenameTable(
                name: "Stats",
                newName: "Orders");

            migrationBuilder.RenameIndex(
                name: "IX_Stats_ProductId",
                table: "Orders",
                newName: "IX_Orders_ProductId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Orders",
                table: "Orders",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Products_ProductId",
                table: "Orders",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
