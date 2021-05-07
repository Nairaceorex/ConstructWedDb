using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ConstructWedDb.Migrations
{
    public partial class init5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "OrderID",
                table: "TypeOfJob",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "OrderID",
                table: "Staff",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "OrderID",
                table: "Customer",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "OrderID",
                table: "Brigade",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Price = table.Column<int>(type: "int", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CompletionMark = table.Column<bool>(type: "bit", nullable: false),
                    AboutPayment = table.Column<bool>(type: "bit", nullable: false),
                    CustomerID = table.Column<long>(type: "bigint", nullable: true),
                    TypeOfJobID = table.Column<long>(type: "bigint", nullable: true),
                    BrigadeID = table.Column<long>(type: "bigint", nullable: true),
                    StaffID = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TypeOfJob_OrderID",
                table: "TypeOfJob",
                column: "OrderID");

            migrationBuilder.CreateIndex(
                name: "IX_Staff_OrderID",
                table: "Staff",
                column: "OrderID");

            migrationBuilder.CreateIndex(
                name: "IX_Customer_OrderID",
                table: "Customer",
                column: "OrderID");

            migrationBuilder.CreateIndex(
                name: "IX_Brigade_OrderID",
                table: "Brigade",
                column: "OrderID");

            migrationBuilder.AddForeignKey(
                name: "FK_Brigade_Order_OrderID",
                table: "Brigade",
                column: "OrderID",
                principalTable: "Order",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Customer_Order_OrderID",
                table: "Customer",
                column: "OrderID",
                principalTable: "Order",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Staff_Order_OrderID",
                table: "Staff",
                column: "OrderID",
                principalTable: "Order",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TypeOfJob_Order_OrderID",
                table: "TypeOfJob",
                column: "OrderID",
                principalTable: "Order",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Brigade_Order_OrderID",
                table: "Brigade");

            migrationBuilder.DropForeignKey(
                name: "FK_Customer_Order_OrderID",
                table: "Customer");

            migrationBuilder.DropForeignKey(
                name: "FK_Staff_Order_OrderID",
                table: "Staff");

            migrationBuilder.DropForeignKey(
                name: "FK_TypeOfJob_Order_OrderID",
                table: "TypeOfJob");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropIndex(
                name: "IX_TypeOfJob_OrderID",
                table: "TypeOfJob");

            migrationBuilder.DropIndex(
                name: "IX_Staff_OrderID",
                table: "Staff");

            migrationBuilder.DropIndex(
                name: "IX_Customer_OrderID",
                table: "Customer");

            migrationBuilder.DropIndex(
                name: "IX_Brigade_OrderID",
                table: "Brigade");

            migrationBuilder.DropColumn(
                name: "OrderID",
                table: "TypeOfJob");

            migrationBuilder.DropColumn(
                name: "OrderID",
                table: "Staff");

            migrationBuilder.DropColumn(
                name: "OrderID",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "OrderID",
                table: "Brigade");
        }
    }
}
