using Microsoft.EntityFrameworkCore.Migrations;

namespace ConstructWedDb.Migrations
{
    public partial class init2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "TypeOfJobID",
                table: "Material");

            migrationBuilder.DropColumn(
                name: "TypeOfJobID1",
                table: "Material");

            migrationBuilder.DropColumn(
                name: "TypeOfJobID2",
                table: "Material");

            migrationBuilder.CreateIndex(
                name: "IX_TypeOfJob_Material1ID",
                table: "TypeOfJob",
                column: "Material1ID");

            migrationBuilder.CreateIndex(
                name: "IX_TypeOfJob_Material2ID",
                table: "TypeOfJob",
                column: "Material2ID");

            migrationBuilder.CreateIndex(
                name: "IX_TypeOfJob_Material3ID",
                table: "TypeOfJob",
                column: "Material3ID");

            migrationBuilder.AddForeignKey(
                name: "FK_TypeOfJob_Material_Material1ID",
                table: "TypeOfJob",
                column: "Material1ID",
                principalTable: "Material",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TypeOfJob_Material_Material2ID",
                table: "TypeOfJob",
                column: "Material2ID",
                principalTable: "Material",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TypeOfJob_Material_Material3ID",
                table: "TypeOfJob",
                column: "Material3ID",
                principalTable: "Material",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TypeOfJob_Material_Material1ID",
                table: "TypeOfJob");

            migrationBuilder.DropForeignKey(
                name: "FK_TypeOfJob_Material_Material2ID",
                table: "TypeOfJob");

            migrationBuilder.DropForeignKey(
                name: "FK_TypeOfJob_Material_Material3ID",
                table: "TypeOfJob");

            migrationBuilder.DropIndex(
                name: "IX_TypeOfJob_Material1ID",
                table: "TypeOfJob");

            migrationBuilder.DropIndex(
                name: "IX_TypeOfJob_Material2ID",
                table: "TypeOfJob");

            migrationBuilder.DropIndex(
                name: "IX_TypeOfJob_Material3ID",
                table: "TypeOfJob");

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
        }
    }
}
