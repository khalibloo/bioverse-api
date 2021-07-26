using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace bioverse.Migrations
{
    public partial class AddIPRange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ip_range",
                table: "firewall_rule");

            migrationBuilder.CreateTable(
                name: "ip_range",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    range = table.Column<string>(type: "text", nullable: false),
                    firewall_rule_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_ip_range", x => x.id);
                    table.ForeignKey(
                        name: "fk_ip_range_firewall_rule_firewall_rule_id",
                        column: x => x.firewall_rule_id,
                        principalTable: "firewall_rule",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "ix_ip_range_firewall_rule_id",
                table: "ip_range",
                column: "firewall_rule_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ip_range");

            migrationBuilder.AddColumn<string>(
                name: "ip_range",
                table: "firewall_rule",
                type: "text",
                nullable: true);
        }
    }
}
