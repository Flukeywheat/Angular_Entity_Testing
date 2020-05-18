﻿// <auto-generated />
using AspNetCoreDemo.Models.NavBarControls;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace AspNetCoreDemo.Migrations
{
    [DbContext(typeof(NavBarCategoryContext))]
    partial class NavBarCategoryContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("AspNetCoreDemo.Models.NavBarControls.navBarCategory", b =>
                {
                    b.Property<int>("NavBarCategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar (100)");

                    b.HasKey("NavBarCategoryId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("AspNetCoreDemo.Models.NavBarControls.navBarDropDownItem", b =>
                {
                    b.Property<int>("NavBarDropDownItemiD")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar (100)");

                    b.Property<int>("NavBarCategoryId")
                        .HasColumnType("integer");

                    b.Property<string>("relativePath")
                        .IsRequired()
                        .HasColumnType("varchar (100)");

                    b.HasKey("NavBarDropDownItemiD");

                    b.HasIndex("NavBarCategoryId");

                    b.ToTable("navBarDropDownItem");
                });

            modelBuilder.Entity("AspNetCoreDemo.Models.NavBarControls.navBarDropDownItem", b =>
                {
                    b.HasOne("AspNetCoreDemo.Models.NavBarControls.navBarCategory", null)
                        .WithMany("DropDownItem")
                        .HasForeignKey("NavBarCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
