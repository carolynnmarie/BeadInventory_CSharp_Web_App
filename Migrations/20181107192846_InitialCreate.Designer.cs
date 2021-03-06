﻿// <auto-generated />
using BeadDotNetApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BeadDotNetApp.Migrations
{
    [DbContext(typeof(BeadContext))]
    [Migration("20181107192846_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024");

            modelBuilder.Entity("BeadDotNetApp.Models.Bead", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Brand");

                    b.Property<string>("Color");

                    b.Property<string>("Material");

                    b.Property<double>("PricePoint");

                    b.Property<int>("Quantity");

                    b.Property<string>("Shape");

                    b.Property<int>("SizeMM");

                    b.HasKey("ID");

                    b.ToTable("Bead");
                });
#pragma warning restore 612, 618
        }
    }
}
