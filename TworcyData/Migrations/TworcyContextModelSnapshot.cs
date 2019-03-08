﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TworcyData;

namespace TworcyData.Migrations
{
    [DbContext(typeof(TworcyContext))]
    partial class TworcyContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.2-servicing-10034");

            modelBuilder.Entity("TworcyData.Models.Tworca", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Audio");

                    b.Property<string>("Bibliografia");

                    b.Property<string>("Biogram");

                    b.Property<bool>("Gotowe");

                    b.Property<string>("Imie")
                        .IsRequired();

                    b.Property<string>("Kontakt");

                    b.Property<string>("Nagrody");

                    b.Property<string>("Nazwisko")
                        .IsRequired();

                    b.Property<string>("Teksty");

                    b.Property<string>("Wystawy");

                    b.Property<string>("Zdjecie");

                    b.HasKey("Id");

                    b.ToTable("Tworcy");
                });

            modelBuilder.Entity("TworcyData.Models.Zdjecie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("TworcaId");

                    b.Property<string>("zdjecieUrl")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("TworcaId");

                    b.ToTable("Zdjecia");
                });

            modelBuilder.Entity("TworcyData.Models.Zdjecie", b =>
                {
                    b.HasOne("TworcyData.Models.Tworca", "Tworca")
                        .WithMany()
                        .HasForeignKey("TworcaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}