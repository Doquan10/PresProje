﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PresProje.Models;

#nullable disable

namespace PresProje.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("PresProje.Models.Deneme", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Deneme");
                });

            modelBuilder.Entity("PresProje.Models.deneme_pres", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("ACIKLAMA")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HAT")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HATA_KODU")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HATA_TANIMI")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IS_EMRI")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MESAI")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OPERASYON_SAYISI")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OPERATOR_SAYISI")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PARCA_NO")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PRES")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PROJE_IS_EMRI")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SURE_DK")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("URETIM_TARIH")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VARDIYA")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VURUS")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("deneme_pres");
                });

            modelBuilder.Entity("PresProje.Models.HAT_PRES", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Hat")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pres")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("HAT_PRES");
                });

            modelBuilder.Entity("PresProje.Models.Hata_Listesi", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("HataKodu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HataTanimi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Hata_Listesi");
                });

            modelBuilder.Entity("PresProje.Models.PARCA_LISTESI", b =>
                {
                    b.Property<string>("Malzeme")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Malzeme");

                    b.ToTable("PARCA_LISTESI");
                });

            modelBuilder.Entity("PresProje.Models.PRES_PROD", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("ACIKLAMA")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HAT")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HATA_KODU")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HATA_TANIMI")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IS_EMRI")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MESAI")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OPERASYON_SAYISI")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OPERATOR_SAYISI")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PARCA_NO")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PRES")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PROJE_IS_EMRI")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SURE_DK")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("URETIM_TARIH")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VARDIYA")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VURUS")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("PRES_PROD");
                });

            modelBuilder.Entity("PresProje.Models.Users", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<bool>("KeepLoggedIn")
                        .HasColumnType("bit");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
