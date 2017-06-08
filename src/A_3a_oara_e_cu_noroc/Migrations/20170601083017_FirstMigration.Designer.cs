using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using A_3a_oara_e_cu_noroc.Model;

namespace A_3a_oara_e_cu_noroc.Migrations
{
    [DbContext(typeof(OurDbContext))]
    [Migration("20170601083017_FirstMigration")]
    partial class FirstMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("A_3a_oara_e_cu_noroc.Model.UserPw", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("parola")
                        .IsRequired();

                    b.Property<string>("username")
                        .IsRequired();

                    b.HasKey("UserID");

                    b.ToTable("UseriParole");
                });
        }
    }
}
