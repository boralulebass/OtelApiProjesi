using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelProject.DataAccessLayer.Migrations
{
    public partial class mig_mes2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MessageCategory2ID",
                table: "Contacts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "MessageCategories",
                columns: table => new
                {
                    MessageCategory2ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MessageCategory2Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MessageCategories", x => x.MessageCategory2ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_MessageCategory2ID",
                table: "Contacts",
                column: "MessageCategory2ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Contacts_MessageCategories_MessageCategory2ID",
                table: "Contacts",
                column: "MessageCategory2ID",
                principalTable: "MessageCategories",
                principalColumn: "MessageCategory2ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contacts_MessageCategories_MessageCategory2ID",
                table: "Contacts");

            migrationBuilder.DropTable(
                name: "MessageCategories");

            migrationBuilder.DropIndex(
                name: "IX_Contacts_MessageCategory2ID",
                table: "Contacts");

            migrationBuilder.DropColumn(
                name: "MessageCategory2ID",
                table: "Contacts");
        }
    }
}
