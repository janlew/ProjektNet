﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjektoNeto.Models;

namespace ProjektoNeto.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20200108205031_DodanieOpini")]
    partial class DodanieOpini
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ProjektoNeto.Models.Opinia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email");

                    b.Property<string>("NazwaUzytkownika");

                    b.Property<bool>("OczekujeOdpowiedzi");

                    b.Property<string>("Wiadomosc");

                    b.HasKey("Id");

                    b.ToTable("Opinie");
                });

            modelBuilder.Entity("ProjektoNeto.Models.Samochod", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Cena");

                    b.Property<bool>("JestSamochodemTygodnia");

                    b.Property<bool>("JestWCentrali");

                    b.Property<string>("Marka");

                    b.Property<string>("MiniaturkaUrl");

                    b.Property<string>("Moc");

                    b.Property<string>("Model");

                    b.Property<string>("Opis");

                    b.Property<string>("Pojemnosc");

                    b.Property<string>("Przebieg");

                    b.Property<string>("RodzajPaliwa");

                    b.Property<int>("RokProdukcji");

                    b.Property<string>("ZdjecieUrl");

                    b.HasKey("Id");

                    b.ToTable("Samochody");
                });
#pragma warning restore 612, 618
        }
    }
}
