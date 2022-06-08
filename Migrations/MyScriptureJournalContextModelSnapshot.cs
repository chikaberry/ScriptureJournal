﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyScriptureJournal.Data;

namespace MyScriptureJournal.Migrations
{
    [DbContext(typeof(MyScriptureJournalContext))]
    partial class MyScriptureJournalContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.17");

            modelBuilder.Entity("MyScriptureJournal.Cannon.Scripture", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Book")
                        .HasColumnType("TEXT");

                    b.Property<string>("Chapter")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DateAdded")
                        .HasColumnType("TEXT");

                    b.Property<string>("Notes")
                        .HasColumnType("TEXT");

                    b.Property<string>("Verse")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("Scripture");
                });
#pragma warning restore 612, 618
        }
    }
}
