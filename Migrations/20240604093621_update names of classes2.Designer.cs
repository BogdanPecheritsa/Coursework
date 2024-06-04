﻿// <auto-generated />
using System;
using CALLОМОЙСЬКИЙ.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CALLОМОЙСЬКИЙ.Migrations
{
    [DbContext(typeof(ProjectContext))]
    [Migration("20240604093621_update names of classes2")]
    partial class updatenamesofclasses2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0-preview.4.24267.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CALLОМОЙСЬКИЙ.Models.Domain.Calls", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CallerUserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("ReceiverUserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("UsersId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UsersId");

                    b.ToTable("Calls");
                });

            modelBuilder.Entity("CALLОМОЙСЬКИЙ.Models.Domain.Contacts", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ContactUserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("UsersId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UsersId");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("CALLОМОЙСЬКИЙ.Models.Domain.Messages", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ReceiverUserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("SenderUserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Timestamp")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("UsersId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UsersId");

                    b.ToTable("Messages");
                });

            modelBuilder.Entity("CALLОМОЙСЬКИЙ.Models.Domain.Users", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("CALLОМОЙСЬКИЙ.Models.Domain.Calls", b =>
                {
                    b.HasOne("CALLОМОЙСЬКИЙ.Models.Domain.Users", null)
                        .WithMany("Calls")
                        .HasForeignKey("UsersId");
                });

            modelBuilder.Entity("CALLОМОЙСЬКИЙ.Models.Domain.Contacts", b =>
                {
                    b.HasOne("CALLОМОЙСЬКИЙ.Models.Domain.Users", null)
                        .WithMany("Contacts")
                        .HasForeignKey("UsersId");
                });

            modelBuilder.Entity("CALLОМОЙСЬКИЙ.Models.Domain.Messages", b =>
                {
                    b.HasOne("CALLОМОЙСЬКИЙ.Models.Domain.Users", null)
                        .WithMany("Messages")
                        .HasForeignKey("UsersId");
                });

            modelBuilder.Entity("CALLОМОЙСЬКИЙ.Models.Domain.Users", b =>
                {
                    b.Navigation("Calls");

                    b.Navigation("Contacts");

                    b.Navigation("Messages");
                });
#pragma warning restore 612, 618
        }
    }
}
