using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using NationBuilderGame.Models;

namespace NationBuilderGame.Migrations
{
    [DbContext(typeof(NationBuilderContext))]
    partial class NationBuilderContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2");

            modelBuilder.Entity("NationBuilderGame.Models.Event", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Events");
                });

            modelBuilder.Entity("NationBuilderGame.Models.Nation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Capital");

                    b.Property<int>("EconomyId");

                    b.Property<int>("GovernmentId");

                    b.Property<string>("Name");

                    b.Property<int>("Resources");

                    b.Property<int>("Stability");

                    b.HasKey("Id");

                    b.ToTable("Nations");
                });
        }
    }
}
