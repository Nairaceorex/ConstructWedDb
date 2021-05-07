using Microsoft.EntityFrameworkCore.Migrations;

namespace ConstructWedDb.Migrations
{
    public partial class init4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Staff_Brigade_BrigadeID",
                table: "Staff");

            migrationBuilder.DropForeignKey(
                name: "FK_Staff_Brigade_BrigadeID1",
                table: "Staff");

            migrationBuilder.DropForeignKey(
                name: "FK_Staff_Brigade_BrigadeID2",
                table: "Staff");

            migrationBuilder.DropIndex(
                name: "IX_Staff_BrigadeID",
                table: "Staff");

            migrationBuilder.DropIndex(
                name: "IX_Staff_BrigadeID1",
                table: "Staff");

            migrationBuilder.DropIndex(
                name: "IX_Staff_BrigadeID2",
                table: "Staff");

            migrationBuilder.DropColumn(
                name: "BrigadeID",
                table: "Staff");

            migrationBuilder.DropColumn(
                name: "BrigadeID1",
                table: "Staff");

            migrationBuilder.DropColumn(
                name: "BrigadeID2",
                table: "Staff");

            migrationBuilder.CreateIndex(
                name: "IX_Brigade_Staff1ID",
                table: "Brigade",
                column: "Staff1ID");

            migrationBuilder.CreateIndex(
                name: "IX_Brigade_Staff2ID",
                table: "Brigade",
                column: "Staff2ID");

            migrationBuilder.CreateIndex(
                name: "IX_Brigade_Staff3ID",
                table: "Brigade",
                column: "Staff3ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Brigade_Staff_Staff1ID",
                table: "Brigade",
                column: "Staff1ID",
                principalTable: "Staff",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Brigade_Staff_Staff2ID",
                table: "Brigade",
                column: "Staff2ID",
                principalTable: "Staff",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Brigade_Staff_Staff3ID",
                table: "Brigade",
                column: "Staff3ID",
                principalTable: "Staff",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Brigade_Staff_Staff1ID",
                table: "Brigade");

            migrationBuilder.DropForeignKey(
                name: "FK_Brigade_Staff_Staff2ID",
                table: "Brigade");

            migrationBuilder.DropForeignKey(
                name: "FK_Brigade_Staff_Staff3ID",
                table: "Brigade");

            migrationBuilder.DropIndex(
                name: "IX_Brigade_Staff1ID",
                table: "Brigade");

            migrationBuilder.DropIndex(
                name: "IX_Brigade_Staff2ID",
                table: "Brigade");

            migrationBuilder.DropIndex(
                name: "IX_Brigade_Staff3ID",
                table: "Brigade");

            migrationBuilder.AddColumn<long>(
                name: "BrigadeID",
                table: "Staff",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "BrigadeID1",
                table: "Staff",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "BrigadeID2",
                table: "Staff",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Staff_BrigadeID",
                table: "Staff",
                column: "BrigadeID");

            migrationBuilder.CreateIndex(
                name: "IX_Staff_BrigadeID1",
                table: "Staff",
                column: "BrigadeID1");

            migrationBuilder.CreateIndex(
                name: "IX_Staff_BrigadeID2",
                table: "Staff",
                column: "BrigadeID2");

            migrationBuilder.AddForeignKey(
                name: "FK_Staff_Brigade_BrigadeID",
                table: "Staff",
                column: "BrigadeID",
                principalTable: "Brigade",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Staff_Brigade_BrigadeID1",
                table: "Staff",
                column: "BrigadeID1",
                principalTable: "Brigade",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Staff_Brigade_BrigadeID2",
                table: "Staff",
                column: "BrigadeID2",
                principalTable: "Brigade",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
