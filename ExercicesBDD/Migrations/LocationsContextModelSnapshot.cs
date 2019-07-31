﻿// <auto-generated />
using System;
using ExercicesBDD;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ExercicesBDD.Migrations
{
    [DbContext(typeof(LocationsContext))]
    partial class LocationsContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity("ExercicesBDD.Models.Categorie", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Libelle");

                    b.Property<float>("PrixKM");

                    b.HasKey("ID");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("ExercicesBDD.Models.Client", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Adresse");

                    b.Property<int>("CodePostal");

                    b.Property<DateTime>("DateNaissance");

                    b.Property<string>("Nom");

                    b.Property<string>("Prenom");

                    b.Property<string>("Ville");

                    b.HasKey("ID");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("ExercicesBDD.Models.Loue", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("ClientID");

                    b.Property<DateTime>("DateDebut");

                    b.Property<DateTime?>("DateFin");

                    b.Property<int>("NombreKm");

                    b.Property<int?>("VehiculeID");

                    b.HasKey("ID");

                    b.HasIndex("ClientID");

                    b.HasIndex("VehiculeID");

                    b.ToTable("Loues");
                });

            modelBuilder.Entity("ExercicesBDD.Models.Marque", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nom");

                    b.HasKey("ID");

                    b.ToTable("Marques");
                });

            modelBuilder.Entity("ExercicesBDD.Models.Vehicule", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("CategorieID");

                    b.Property<string>("Couleur");

                    b.Property<DateTime>("DateMiseEnService");

                    b.Property<string>("Immatriculation");

                    b.Property<int?>("MarqueID");

                    b.HasKey("ID");

                    b.HasIndex("CategorieID");

                    b.HasIndex("MarqueID");

                    b.ToTable("Vehicules");
                });

            modelBuilder.Entity("ExercicesBDD.Models.Loue", b =>
                {
                    b.HasOne("ExercicesBDD.Models.Client", "Client")
                        .WithMany("Loues")
                        .HasForeignKey("ClientID");

                    b.HasOne("ExercicesBDD.Models.Vehicule", "Vehicule")
                        .WithMany("Loues")
                        .HasForeignKey("VehiculeID");
                });

            modelBuilder.Entity("ExercicesBDD.Models.Vehicule", b =>
                {
                    b.HasOne("ExercicesBDD.Models.Categorie", "Categorie")
                        .WithMany("Vehicules")
                        .HasForeignKey("CategorieID");

                    b.HasOne("ExercicesBDD.Models.Marque", "Marque")
                        .WithMany("Vehicules")
                        .HasForeignKey("MarqueID");
                });
#pragma warning restore 612, 618
        }
    }
}
