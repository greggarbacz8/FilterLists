﻿// <auto-generated />
using FilterLists.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace FilterLists.Api.Migrations
{
    [DbContext(typeof(FilterListsDbContext))]
    [Migration("20171031235408_add Rules")]
    partial class addRules
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452");

            modelBuilder.Entity("FilterLists.Data.Entities.FilterList", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedDateUtc")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TIMESTAMP");

                    b.Property<string>("Description")
                        .HasMaxLength(4096);

                    b.Property<string>("DescriptionSourceUrl")
                        .HasMaxLength(2083);

                    b.Property<string>("DonateUrl")
                        .HasMaxLength(2083);

                    b.Property<string>("EmailAddress")
                        .HasMaxLength(126);

                    b.Property<string>("ForumUrl")
                        .HasMaxLength(2083);

                    b.Property<string>("HomeUrl")
                        .HasMaxLength(2083);

                    b.Property<string>("IssuesUrl")
                        .HasMaxLength(2083);

                    b.Property<int?>("MaintainerId");

                    b.Property<DateTime>("ModifiedDateUtc")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("TIMESTAMP");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(126);

                    b.Property<string>("ViewUrl")
                        .HasMaxLength(2083);

                    b.HasKey("Id");

                    b.HasIndex("MaintainerId");

                    b.ToTable("filterlists");
                });

            modelBuilder.Entity("FilterLists.Data.Entities.FilterListLanguage", b =>
                {
                    b.Property<int>("FilterListId");

                    b.Property<int>("LanguageId");

                    b.Property<DateTime>("CreatedDateUtc")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TIMESTAMP");

                    b.Property<DateTime>("ModifiedDateUtc")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("TIMESTAMP");

                    b.HasKey("FilterListId", "LanguageId");

                    b.HasIndex("LanguageId");

                    b.ToTable("filterlists_languages");
                });

            modelBuilder.Entity("FilterLists.Data.Entities.FilterListRule", b =>
                {
                    b.Property<int>("FilterListId");

                    b.Property<int>("RuleId");

                    b.Property<DateTime>("CreatedDateUtc")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TIMESTAMP");

                    b.Property<DateTime>("ModifiedDateUtc")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("TIMESTAMP");

                    b.HasKey("FilterListId", "RuleId");

                    b.HasIndex("RuleId");

                    b.ToTable("filterlists_rules");
                });

            modelBuilder.Entity("FilterLists.Data.Entities.FilterListSoftware", b =>
                {
                    b.Property<int>("FilterListId");

                    b.Property<int>("SoftwareId");

                    b.Property<DateTime>("CreatedDateUtc")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TIMESTAMP");

                    b.Property<DateTime>("ModifiedDateUtc")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("TIMESTAMP");

                    b.HasKey("FilterListId", "SoftwareId");

                    b.HasIndex("SoftwareId");

                    b.ToTable("filterlists_software");
                });

            modelBuilder.Entity("FilterLists.Data.Entities.Language", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedDateUtc")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TIMESTAMP");

                    b.Property<string>("Iso6391")
                        .HasMaxLength(2);

                    b.Property<string>("Iso6392")
                        .HasMaxLength(3);

                    b.Property<string>("Iso6392B")
                        .HasMaxLength(3);

                    b.Property<string>("Iso6392T")
                        .HasMaxLength(3);

                    b.Property<string>("Iso6393")
                        .HasMaxLength(3);

                    b.Property<string>("LocalName")
                        .HasMaxLength(126);

                    b.Property<DateTime>("ModifiedDateUtc")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("TIMESTAMP");

                    b.Property<string>("Name")
                        .HasMaxLength(126);

                    b.HasKey("Id");

                    b.ToTable("languages");
                });

            modelBuilder.Entity("FilterLists.Data.Entities.Maintainer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedDateUtc")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TIMESTAMP");

                    b.Property<string>("EmailAddress")
                        .HasMaxLength(126);

                    b.Property<string>("HomeUrl")
                        .HasMaxLength(2083);

                    b.Property<DateTime>("ModifiedDateUtc")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("TIMESTAMP");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(126);

                    b.Property<string>("TwitterHandle")
                        .HasMaxLength(126);

                    b.HasKey("Id");

                    b.ToTable("maintainers");
                });

            modelBuilder.Entity("FilterLists.Data.Entities.Rule", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedDateUtc")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TIMESTAMP");

                    b.Property<DateTime>("ModifiedDateUtc")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("TIMESTAMP");

                    b.Property<string>("Raw")
                        .HasMaxLength(2083);

                    b.HasKey("Id");

                    b.ToTable("rules");
                });

            modelBuilder.Entity("FilterLists.Data.Entities.Software", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedDateUtc")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TIMESTAMP");

                    b.Property<string>("DownloadUrl")
                        .HasMaxLength(2083);

                    b.Property<string>("HomeUrl")
                        .HasMaxLength(2083);

                    b.Property<DateTime>("ModifiedDateUtc")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("TIMESTAMP");

                    b.Property<string>("Name")
                        .HasMaxLength(126);

                    b.HasKey("Id");

                    b.ToTable("software");
                });

            modelBuilder.Entity("FilterLists.Data.Entities.FilterList", b =>
                {
                    b.HasOne("FilterLists.Data.Entities.Maintainer")
                        .WithMany("FilterLists")
                        .HasForeignKey("MaintainerId");
                });

            modelBuilder.Entity("FilterLists.Data.Entities.FilterListLanguage", b =>
                {
                    b.HasOne("FilterLists.Data.Entities.FilterList", "FilterList")
                        .WithMany("FilterListLanguages")
                        .HasForeignKey("FilterListId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("FilterLists.Data.Entities.Language", "Language")
                        .WithMany("FilterListLanguages")
                        .HasForeignKey("LanguageId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("FilterLists.Data.Entities.FilterListRule", b =>
                {
                    b.HasOne("FilterLists.Data.Entities.FilterList", "FilterList")
                        .WithMany("FilterListRules")
                        .HasForeignKey("FilterListId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("FilterLists.Data.Entities.Rule", "Rule")
                        .WithMany("FilterListRules")
                        .HasForeignKey("RuleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("FilterLists.Data.Entities.FilterListSoftware", b =>
                {
                    b.HasOne("FilterLists.Data.Entities.FilterList", "FilterList")
                        .WithMany("FilterListSoftware")
                        .HasForeignKey("FilterListId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("FilterLists.Data.Entities.Software", "Software")
                        .WithMany("FilterListSoftware")
                        .HasForeignKey("SoftwareId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
