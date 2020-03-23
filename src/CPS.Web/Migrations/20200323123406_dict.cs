using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CPS.Web.Migrations
{
    public partial class dict : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Dict_ArticleType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cn = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    CreatedTime = table.Column<DateTime>(nullable: false),
                    LastUpdaterId = table.Column<int>(nullable: true),
                    LastUpdatedTime = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dict_ArticleType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Dict_VehicleType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cn = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Load = table.Column<int>(nullable: false),
                    Capacity = table.Column<int>(nullable: false),
                    CreatedTime = table.Column<DateTime>(nullable: false),
                    LastUpdaterId = table.Column<int>(nullable: true),
                    LastUpdatedTime = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dict_VehicleType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Dict_WorkerCategory",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cn = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    CreatedTime = table.Column<DateTime>(nullable: false),
                    LastUpdaterId = table.Column<int>(nullable: true),
                    LastUpdatedTime = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dict_WorkerCategory", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Dict_ArticleType");

            migrationBuilder.DropTable(
                name: "Dict_VehicleType");

            migrationBuilder.DropTable(
                name: "Dict_WorkerCategory");
        }
    }
}
