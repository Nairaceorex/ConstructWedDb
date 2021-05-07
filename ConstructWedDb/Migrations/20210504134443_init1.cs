using Microsoft.EntityFrameworkCore.Migrations;

namespace ConstructWedDb.Migrations
{
    public partial class init1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AddColumn<long>(
                name: "TypeOfJobID",
                table: "Material",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "TypeOfJobID1",
                table: "Material",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "TypeOfJobID2",
                table: "Material",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Brigade",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Staff1ID = table.Column<long>(type: "bigint", nullable: true),
                    Staff2ID = table.Column<long>(type: "bigint", nullable: true),
                    Staff3ID = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brigade", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TypeOfJob",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Material1ID = table.Column<long>(type: "bigint", nullable: true),
                    Material2ID = table.Column<long>(type: "bigint", nullable: true),
                    Material3ID = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeOfJob", x => x.ID);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Material_TypeOfJobID",
                table: "Material",
                column: "TypeOfJobID");

            migrationBuilder.CreateIndex(
                name: "IX_Material_TypeOfJobID1",
                table: "Material",
                column: "TypeOfJobID1");

            migrationBuilder.CreateIndex(
                name: "IX_Material_TypeOfJobID2",
                table: "Material",
                column: "TypeOfJobID2");

            migrationBuilder.AddForeignKey(
                name: "FK_Material_TypeOfJob_TypeOfJobID",
                table: "Material",
                column: "TypeOfJobID",
                principalTable: "TypeOfJob",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Material_TypeOfJob_TypeOfJobID1",
                table: "Material",
                column: "TypeOfJobID1",
                principalTable: "TypeOfJob",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Material_TypeOfJob_TypeOfJobID2",
                table: "Material",
                column: "TypeOfJobID2",
                principalTable: "TypeOfJob",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Material_TypeOfJob_TypeOfJobID",
                table: "Material");

            migrationBuilder.DropForeignKey(
                name: "FK_Material_TypeOfJob_TypeOfJobID1",
                table: "Material");

            migrationBuilder.DropForeignKey(
                name: "FK_Material_TypeOfJob_TypeOfJobID2",
                table: "Material");

            migrationBuilder.DropForeignKey(
                name: "FK_Staff_Brigade_BrigadeID",
                table: "Staff");

            migrationBuilder.DropForeignKey(
                name: "FK_Staff_Brigade_BrigadeID1",
                table: "Staff");

            migrationBuilder.DropForeignKey(
                name: "FK_Staff_Brigade_BrigadeID2",
                table: "Staff");

            migrationBuilder.DropTable(
                name: "Brigade");

            migrationBuilder.DropTable(
                name: "TypeOfJob");

            migrationBuilder.DropIndex(
                name: "IX_Staff_BrigadeID",
                table: "Staff");

            migrationBuilder.DropIndex(
                name: "IX_Staff_BrigadeID1",
                table: "Staff");

            migrationBuilder.DropIndex(
                name: "IX_Staff_BrigadeID2",
                table: "Staff");

            migrationBuilder.DropIndex(
                name: "IX_Material_TypeOfJobID",
                table: "Material");

            migrationBuilder.DropIndex(
                name: "IX_Material_TypeOfJobID1",
                table: "Material");

            migrationBuilder.DropIndex(
                name: "IX_Material_TypeOfJobID2",
                table: "Material");

            migrationBuilder.DropColumn(
                name: "BrigadeID",
                table: "Staff");

            migrationBuilder.DropColumn(
                name: "BrigadeID1",
                table: "Staff");

            migrationBuilder.DropColumn(
                name: "BrigadeID2",
                table: "Staff");

            migrationBuilder.DropColumn(
                name: "TypeOfJobID",
                table: "Material");

            migrationBuilder.DropColumn(
                name: "TypeOfJobID1",
                table: "Material");

            migrationBuilder.DropColumn(
                name: "TypeOfJobID2",
                table: "Material");
        }
    }
}
