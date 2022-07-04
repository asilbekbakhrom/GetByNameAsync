﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using bot.Data;

#nullable disable

namespace bot.Data.Migrations
{
    [DbContext(typeof(BotDbContext))]
    [Migration("20220704143011_UserConfigurationsAttached")]
    partial class UserConfigurationsAttached
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.6");

            modelBuilder.Entity("bot.Entity.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<long>("AccountId")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Blocked")
                        .HasColumnType("INTEGER");

                    b.Property<long>("ChatId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Firstname")
                        .HasMaxLength(16)
                        .HasColumnType("TEXT");

                    b.Property<DateTimeOffset>("JoinedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("LanguageCode")
                        .HasColumnType("TEXT");

                    b.Property<DateTimeOffset>("LastInteractionAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("Lastname")
                        .HasMaxLength(16)
                        .HasColumnType("TEXT");

                    b.Property<string>("Phone")
                        .HasMaxLength(15)
                        .HasColumnType("TEXT");

                    b.Property<string>("Username")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("AccountId")
                        .IsUnique();

                    b.HasIndex("ChatId")
                        .IsUnique();

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
