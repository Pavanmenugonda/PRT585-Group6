﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StudentsAPI.Data;

#nullable disable

namespace StudentsAPI.Migrations
{
    [DbContext(typeof(StudentsDbContext))]
    [Migration("20230727125419_1st Migration")]
    partial class _1stMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("StudentsAPI.Data.Student", b =>
                {
                    b.ToTable("Students");
                });
#pragma warning restore 612, 618
        }
    }
}
