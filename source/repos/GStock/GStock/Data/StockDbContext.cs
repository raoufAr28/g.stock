using System;
using System.Collections.Generic;
using GStock.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace GStock.Data;

public partial class StockDbContext : DbContext
{
    public StockDbContext()
    {
    }

    public StockDbContext(DbContextOptions<StockDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<TableCategorie> TableCategories { get; set; }

    public virtual DbSet<TableClient> TableClients { get; set; }

    public virtual DbSet<TableCommande> TableCommandes { get; set; }

    public virtual DbSet<TableDetailsCommande> TableDetailsCommandes { get; set; }

    public virtual DbSet<TableEmployee> TableEmployees { get; set; }

    public virtual DbSet<TableProduit> TableProduits { get; set; }

    public virtual DbSet<TableUtilisateur> TableUtilisateurs { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=DESKTOP-1P2EIRV\\SQLEXPRESS;Initial Catalog=GESTION_DE_STOCK;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TableCategorie>(entity =>
        {
            entity.HasKey(e => e.IdCategorie);

            entity.ToTable("table_categorie");

            entity.Property(e => e.IdCategorie).HasColumnName("ID_Categorie");
            entity.Property(e => e.NomCategorie)
                .HasMaxLength(255)
                .IsFixedLength()
                .HasColumnName("Nom_Categorie");
        });

        modelBuilder.Entity<TableClient>(entity =>
        {
            entity.HasKey(e => e.IdClient);

            entity.ToTable("table_client");

            entity.Property(e => e.IdClient).HasColumnName("ID_Client");
            entity.Property(e => e.AdressClient)
                .HasMaxLength(255)
                .IsFixedLength()
                .HasColumnName("Adress_Client");
            entity.Property(e => e.EmailClient)
                .HasMaxLength(255)
                .IsFixedLength()
                .HasColumnName("Email_Client");
            entity.Property(e => e.NomClient)
                .HasMaxLength(255)
                .IsFixedLength()
                .HasColumnName("Nom_Client");
            entity.Property(e => e.PrenomClient)
                .HasMaxLength(255)
                .IsFixedLength()
                .HasColumnName("Prenom_Client");
            entity.Property(e => e.TelephoneClient)
                .HasMaxLength(255)
                .IsFixedLength()
                .HasColumnName("Telephone_Client");
            entity.Property(e => e.VilleClient)
                .HasMaxLength(255)
                .IsFixedLength()
                .HasColumnName("Ville_Client");
        });

        modelBuilder.Entity<TableCommande>(entity =>
        {
            entity.HasKey(e => e.IdCommande);

            entity.ToTable("table_commande");

            entity.Property(e => e.IdCommande).HasColumnName("ID_Commande");
            entity.Property(e => e.DateCommande)
                .HasColumnType("datetime")
                .HasColumnName("Date_Commande");
            entity.Property(e => e.IdClient).HasColumnName("ID_Client");

            entity.HasOne(d => d.IdClientNavigation).WithMany(p => p.TableCommandes)
                .HasForeignKey(d => d.IdClient)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_table_commande_table_client");
        });

        modelBuilder.Entity<TableDetailsCommande>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("table_detailsCommande");

            entity.Property(e => e.IdCommande).HasColumnName("ID_Commande");
            entity.Property(e => e.IdProduit).HasColumnName("ID_Produit");
            entity.Property(e => e.Quantite)
                .HasMaxLength(10)
                .IsFixedLength();

            entity.HasOne(d => d.IdCommandeNavigation).WithMany()
                .HasForeignKey(d => d.IdCommande)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_table_detailsCommande_table_commande");

            entity.HasOne(d => d.IdProduitNavigation).WithMany()
                .HasForeignKey(d => d.IdProduit)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_table_detailsCommande_table_produit");
        });

        modelBuilder.Entity<TableEmployee>(entity =>
        {
            entity.HasKey(e => e.NomEmployee);

            entity.ToTable("table_employee");

            entity.Property(e => e.NomEmployee)
                .HasMaxLength(255)
                .IsFixedLength()
                .HasColumnName("Nom_employee");
            entity.Property(e => e.MotDePasse)
                .HasMaxLength(255)
                .IsFixedLength()
                .HasColumnName("mot_de_passe");
        });

        modelBuilder.Entity<TableProduit>(entity =>
        {
            entity.HasKey(e => e.IdProduit);

            entity.ToTable("table_produit");

            entity.Property(e => e.IdProduit).HasColumnName("ID_Produit");
            entity.Property(e => e.IdCategorie).HasColumnName("ID_Categorie");
            entity.Property(e => e.ImageProduit)
                .HasColumnType("image")
                .HasColumnName("Image_Produit");
            entity.Property(e => e.NomProduit)
                .HasMaxLength(255)
                .IsFixedLength()
                .HasColumnName("Nom_Produit");
            entity.Property(e => e.PrixProduit)
                .HasMaxLength(255)
                .IsFixedLength()
                .HasColumnName("Prix_Produit");
            entity.Property(e => e.QuantiteProduit).HasColumnName("Quantite_Produit");

            entity.HasOne(d => d.IdCategorieNavigation).WithMany(p => p.TableProduits)
                .HasForeignKey(d => d.IdCategorie)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_table_produit_table_categorie");
        });

        modelBuilder.Entity<TableUtilisateur>(entity =>
        {
            entity.HasKey(e => e.NomUtilisateur);

            entity.ToTable("table_utilisateur");

            entity.Property(e => e.NomUtilisateur)
                .HasMaxLength(255)
                .IsFixedLength()
                .HasColumnName("Nom_utilisateur");
            entity.Property(e => e.MotDePasse)
                .HasMaxLength(255)
                .IsFixedLength()
                .HasColumnName("mot_de_passe");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
