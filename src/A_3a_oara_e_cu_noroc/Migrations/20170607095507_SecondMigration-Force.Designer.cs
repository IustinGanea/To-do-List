﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using A_3a_oara_e_cu_noroc.Model;

namespace A_3a_oara_e_cu_noroc.Migrations
{
    [DbContext(typeof(OurDbContext))]
    [Migration("20170607095507_SecondMigration-Force")]
    partial class SecondMigrationForce
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("A_3a_oara_e_cu_noroc.Model.Iteme", b =>
                {
                    b.Property<int>("idElement")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("deadline");

                    b.Property<string>("descriere");

                    b.Property<string>("nume");

                    b.Property<bool>("terminat");

                    b.HasKey("idElement");

                    b.ToTable("ElementeLista");
                });

            
        }
    }
}
