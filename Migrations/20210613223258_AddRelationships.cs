using Microsoft.EntityFrameworkCore.Migrations;

namespace bioverse.Migrations
{
    public partial class AddRelationships : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "family_id",
                table: "species",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "ix_species_family_id",
                table: "species",
                column: "family_id");

            migrationBuilder.AddForeignKey(
                name: "fk_species_family_family_id",
                table: "species",
                column: "family_id",
                principalTable: "family",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_species_family_family_id",
                table: "species");

            migrationBuilder.DropIndex(
                name: "ix_species_family_id",
                table: "species");

            migrationBuilder.DropColumn(
                name: "family_id",
                table: "species");
        }
    }
}
