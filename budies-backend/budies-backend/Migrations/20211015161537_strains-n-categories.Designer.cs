﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using budies_backend.Context;

namespace budies_backend.Migrations
{
    [DbContext(typeof(BudiesDBContext))]
    [Migration("20211015161537_strains-n-categories")]
    partial class strainsncategories
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("budies_backend.Models.Ailments", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)")
                        .HasColumnName("value");

                    b.HasKey("Id");

                    b.ToTable("Ailments");
                });

            modelBuilder.Entity("budies_backend.Models.Effects", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)")
                        .HasColumnName("value");

                    b.HasKey("Id");

                    b.ToTable("Effects");
                });

            modelBuilder.Entity("budies_backend.Models.Flavors", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)")
                        .HasColumnName("value");

                    b.HasKey("Id");

                    b.ToTable("Flavors");
                });

            modelBuilder.Entity("budies_backend.Models.Strains", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AilmentsID")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasMaxLength(600)
                        .HasColumnType("nvarchar(600)")
                        .HasColumnName("description");

                    b.Property<int>("EffectsID")
                        .HasColumnType("int");

                    b.Property<int>("FlavorID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("name");

                    b.Property<double>("Rating")
                        .HasMaxLength(5)
                        .HasColumnType("float")
                        .HasColumnName("rating");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)")
                        .HasColumnName("type");

                    b.HasKey("Id");

                    b.HasIndex("AilmentsID");

                    b.HasIndex("EffectsID");

                    b.HasIndex("FlavorID");

                    b.ToTable("Strains");
                });

            modelBuilder.Entity("budies_backend.Models.Strains", b =>
                {
                    b.HasOne("budies_backend.Models.Ailments", "Ailments")
                        .WithMany("Strains")
                        .HasForeignKey("AilmentsID")
                        .HasConstraintName("FK_Strains_Ailments")
                        .IsRequired();

                    b.HasOne("budies_backend.Models.Effects", "Effect")
                        .WithMany("Strains")
                        .HasForeignKey("EffectsID")
                        .HasConstraintName("FK_Strains_Effects")
                        .IsRequired();

                    b.HasOne("budies_backend.Models.Flavors", "Flavors")
                        .WithMany("Strains")
                        .HasForeignKey("FlavorID")
                        .HasConstraintName("FK_Strains_Flavors")
                        .IsRequired();

                    b.Navigation("Ailments");

                    b.Navigation("Effect");

                    b.Navigation("Flavors");
                });

            modelBuilder.Entity("budies_backend.Models.Ailments", b =>
                {
                    b.Navigation("Strains");
                });

            modelBuilder.Entity("budies_backend.Models.Effects", b =>
                {
                    b.Navigation("Strains");
                });

            modelBuilder.Entity("budies_backend.Models.Flavors", b =>
                {
                    b.Navigation("Strains");
                });
#pragma warning restore 612, 618
        }
    }
}
