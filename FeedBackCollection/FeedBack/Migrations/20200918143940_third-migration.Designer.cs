﻿// <auto-generated />
using System;
using FeedBack.DbContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FeedBack.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20200918143940_third-migration")]
    partial class thirdmigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FeedBack.Model.Comments", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Description");

                    b.Property<int>("DisLike");

                    b.Property<int>("Like");

                    b.Property<int?>("PostId");

                    b.HasKey("Id");

                    b.HasIndex("PostId");

                    b.ToTable("Commentses");
                });

            modelBuilder.Entity("FeedBack.Model.Post", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<DateTime?>("Time");

                    b.Property<string>("User");

                    b.HasKey("Id");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("FeedBack.Model.Comments", b =>
                {
                    b.HasOne("FeedBack.Model.Post")
                        .WithMany("Commentses")
                        .HasForeignKey("PostId");
                });
#pragma warning restore 612, 618
        }
    }
}
