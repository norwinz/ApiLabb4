﻿// <auto-generated />
using ApiLabb4.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ApiLabb4.Migrations
{
    [DbContext(typeof(ApiLabb4Context))]
    [Migration("20220407162205_update")]
    partial class update
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.23")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ApiLabb4.Models.Interest", b =>
                {
                    b.Property<int>("interestId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Titel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("personId")
                        .HasColumnType("int");

                    b.HasKey("interestId");

                    b.HasIndex("personId");

                    b.ToTable("Interests");
                });

            modelBuilder.Entity("ApiLabb4.Models.Person", b =>
                {
                    b.Property<int>("personId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phonenumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("personId");

                    b.ToTable("Persons");
                });

            modelBuilder.Entity("ApiLabb4.Models.WebSite", b =>
                {
                    b.Property<int>("WebSiteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("SiteURL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("interestId")
                        .HasColumnType("int");

                    b.HasKey("WebSiteId");

                    b.HasIndex("interestId");

                    b.ToTable("WebSites");
                });

            modelBuilder.Entity("ApiLabb4.Models.Interest", b =>
                {
                    b.HasOne("ApiLabb4.Models.Person", "Person")
                        .WithMany("Interests")
                        .HasForeignKey("personId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ApiLabb4.Models.WebSite", b =>
                {
                    b.HasOne("ApiLabb4.Models.Interest", "Interest")
                        .WithMany("WebSites")
                        .HasForeignKey("interestId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
