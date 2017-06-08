using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;
using A_3a_oara_e_cu_noroc.Model;

namespace A_3a_oara_e_cu_noroc.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UseriParole",
                columns: table => new
                {
                    UserID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    parola = table.Column<string>(nullable: false),
                    username = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UseriParole", x => x.UserID);
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
                name: "UseriParole");

          
        }
    }
}
