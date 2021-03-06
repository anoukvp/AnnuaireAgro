// <auto-generated />
using System;
using AnnuaireAgro.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AnnuaireAgro.Migrations
{
    [DbContext(typeof(AnnuaireContext))]
    [Migration("20220131140501_first")]
    partial class first
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AnnuaireAgro.Models.Collaborateur", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasMaxLength(160)
                        .HasColumnType("nvarchar(160)");

                    b.Property<int>("FK_idService")
                        .HasColumnType("int");

                    b.Property<int>("FK_idSite")
                        .HasColumnType("int");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.Property<string>("Prenom")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.Property<string>("TelFixe")
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.Property<string>("TelPortable")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int?>("serviceId")
                        .HasColumnType("int");

                    b.Property<int?>("siteId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("serviceId");

                    b.HasIndex("siteId");

                    b.ToTable("Collaborateur");
                });

            modelBuilder.Entity("AnnuaireAgro.Models.Service", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.HasKey("Id");

                    b.ToTable("Service");
                });

            modelBuilder.Entity("AnnuaireAgro.Models.Site", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ville")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.HasKey("Id");

                    b.ToTable("Site");
                });

            modelBuilder.Entity("AnnuaireAgro.Models.Collaborateur", b =>
                {
                    b.HasOne("AnnuaireAgro.Models.Service", "service")
                        .WithMany("Collaborateur")
                        .HasForeignKey("serviceId");

                    b.HasOne("AnnuaireAgro.Models.Site", "site")
                        .WithMany("Collaborateur")
                        .HasForeignKey("siteId");

                    b.Navigation("service");

                    b.Navigation("site");
                });

            modelBuilder.Entity("AnnuaireAgro.Models.Service", b =>
                {
                    b.Navigation("Collaborateur");
                });

            modelBuilder.Entity("AnnuaireAgro.Models.Site", b =>
                {
                    b.Navigation("Collaborateur");
                });
#pragma warning restore 612, 618
        }
    }
}
