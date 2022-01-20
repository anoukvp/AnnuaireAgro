using Microsoft.EntityFrameworkCore.Migrations;

namespace AnnuaireAgro.Migrations
{
    public partial class v2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Collaborateur",
                table: "Collaborateur");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Collaborateur",
                newName: "SiteId");

            migrationBuilder.AlterColumn<int>(
                name: "SiteId",
                table: "Collaborateur",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "IdCollaborateur",
                table: "Collaborateur",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "ServiceID",
                table: "Collaborateur",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Collaborateur",
                table: "Collaborateur",
                column: "IdCollaborateur");

            migrationBuilder.CreateIndex(
                name: "IX_Collaborateur_ServiceID",
                table: "Collaborateur",
                column: "ServiceID");

            migrationBuilder.CreateIndex(
                name: "IX_Collaborateur_SiteId",
                table: "Collaborateur",
                column: "SiteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Collaborateur_Service_ServiceID",
                table: "Collaborateur",
                column: "ServiceID",
                principalTable: "Service",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Collaborateur_Site_SiteId",
                table: "Collaborateur",
                column: "SiteId",
                principalTable: "Site",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Collaborateur_Service_ServiceID",
                table: "Collaborateur");

            migrationBuilder.DropForeignKey(
                name: "FK_Collaborateur_Site_SiteId",
                table: "Collaborateur");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Collaborateur",
                table: "Collaborateur");

            migrationBuilder.DropIndex(
                name: "IX_Collaborateur_ServiceID",
                table: "Collaborateur");

            migrationBuilder.DropIndex(
                name: "IX_Collaborateur_SiteId",
                table: "Collaborateur");

            migrationBuilder.DropColumn(
                name: "IdCollaborateur",
                table: "Collaborateur");

            migrationBuilder.DropColumn(
                name: "ServiceID",
                table: "Collaborateur");

            migrationBuilder.RenameColumn(
                name: "SiteId",
                table: "Collaborateur",
                newName: "Id");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Collaborateur",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Collaborateur",
                table: "Collaborateur",
                column: "Id");
        }
    }
}
