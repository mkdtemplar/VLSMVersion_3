using Microsoft.EntityFrameworkCore.Migrations;

namespace DatabaseContext.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Vlsmresults",
                columns: table => new
                {
                    id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    NetworkID = table.Column<string>(type: "VARCHAR (45)", nullable: true),
                    CIDR = table.Column<string>(type: "VARCHAR (45)", nullable: true),
                    SubnetMask = table.Column<string>(type: "VARCHAR (45)", nullable: true),
                    NumberOfHostsPerSubnet = table.Column<string>(type: "VARCHAR (45)", nullable: true),
                    NumberOfSubnets = table.Column<string>(type: "VARCHAR (45)", nullable: true),
                    RangeOfUsableIPaddresses = table.Column<string>(type: "VARCHAR (45)", nullable: true),
                    broadcastID = table.Column<string>(type: "VARCHAR (45)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vlsmresults", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Vlsmresults");
        }
    }
}
