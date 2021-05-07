using Microsoft.EntityFrameworkCore.Migrations;

namespace ConstructWedDb.Migrations
{
    public partial class init6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateIndex(
                name: "IX_Order_BrigadeID",
                table: "Order",
                column: "BrigadeID");

            migrationBuilder.CreateIndex(
                name: "IX_Order_CustomerID",
                table: "Order",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_Order_StaffID",
                table: "Order",
                column: "StaffID");

            migrationBuilder.CreateIndex(
                name: "IX_Order_TypeOfJobID",
                table: "Order",
                column: "TypeOfJobID");

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Brigade_BrigadeID",
                table: "Order",
                column: "BrigadeID",
                principalTable: "Brigade",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Customer_CustomerID",
                table: "Order",
                column: "CustomerID",
                principalTable: "Customer",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Staff_StaffID",
                table: "Order",
                column: "StaffID",
                principalTable: "Staff",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Order_TypeOfJob_TypeOfJobID",
                table: "Order",
                column: "TypeOfJobID",
                principalTable: "TypeOfJob",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Order_Brigade_BrigadeID",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_Customer_CustomerID",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_Staff_StaffID",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_TypeOfJob_TypeOfJobID",
                table: "Order");

            migrationBuilder.DropIndex(
                name: "IX_Order_BrigadeID",
                table: "Order");

            migrationBuilder.DropIndex(
                name: "IX_Order_CustomerID",
                table: "Order");

            migrationBuilder.DropIndex(
                name: "IX_Order_StaffID",
                table: "Order");

            migrationBuilder.DropIndex(
                name: "IX_Order_TypeOfJobID",
                table: "Order");

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
    }
}
