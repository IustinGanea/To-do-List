using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;
using A_3a_oara_e_cu_noroc.Model;

namespace A_3a_oara_e_cu_noroc.Migrations
{
    public partial class SecondMigrationForce : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ElementeLista",
                columns: table => new
                {
                    idElement = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    deadline = table.Column<DateTime>(nullable: false),
                    descriere = table.Column<string>(nullable: true),
                    nume = table.Column<string>(nullable: true),
                    terminat = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ElementeLista", x => x.idElement);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            using (var db = new OurDbContext())
            {
                db.RemoveRange(db.UseriParole);
                db.SaveChanges();
            }
            migrationBuilder.DropTable(
                name: "ElementeLista");
        }
    }
}
