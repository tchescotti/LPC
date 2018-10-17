﻿// <auto-generated />
using Aula04_AppPeople_ef.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace AppPeople.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20180927175148_InitialMigrations")]
    partial class InitialMigrations
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452");

            modelBuilder.Entity("AppPeople.Models.Person", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("address");

                    b.Property<int?>("cityid");

                    b.Property<string>("name");

                    b.HasKey("id");

                    b.HasIndex("cityid");

                    b.ToTable("People");
                });

            modelBuilder.Entity("Aula05_AppPeople_ef_one_to_many.Models.City", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("name");

                    b.HasKey("id");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("AppPeople.Models.Person", b =>
                {
                    b.HasOne("Aula05_AppPeople_ef_one_to_many.Models.City", "city")
                        .WithMany("people")
                        .HasForeignKey("cityid");
                });
#pragma warning restore 612, 618
        }
    }
}