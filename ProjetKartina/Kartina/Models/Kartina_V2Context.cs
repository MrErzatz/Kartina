using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Kartina.Models
{
    public partial class Kartina_V2Context : DbContext
    {
        public Kartina_V2Context()
        {
        }

        public Kartina_V2Context(DbContextOptions<Kartina_V2Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Adresse> Adresse { get; set; }
        public virtual DbSet<Cadre> Cadre { get; set; }
        public virtual DbSet<CadreFinition> CadreFinition { get; set; }
        public virtual DbSet<Commande> Commande { get; set; }
        public virtual DbSet<Finition> Finition { get; set; }
        public virtual DbSet<Format> Format { get; set; }
        public virtual DbSet<FormatFinition> FormatFinition { get; set; }
        public virtual DbSet<LigneCommande> LigneCommande { get; set; }
        public virtual DbSet<Orientation> Orientation { get; set; }
        public virtual DbSet<Photo> Photo { get; set; }
        public virtual DbSet<PhotoFormat> PhotoFormat { get; set; }
        public virtual DbSet<ProfilUtilisateur> ProfilUtilisateur { get; set; }
        public virtual DbSet<Statut> Statut { get; set; }
        public virtual DbSet<Tag> Tag { get; set; }
        public virtual DbSet<Theme> Theme { get; set; }
        public virtual DbSet<ThemePhoto> ThemePhoto { get; set; }
        public virtual DbSet<ThemeTag> ThemeTag { get; set; }
        public virtual DbSet<Utilisateur> Utilisateur { get; set; }

        // Unable to generate entity type for table 'dbo.PhotoTag'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=M2IFORM-IHV4J4L\\SQLEXPRESS;Database=Kartina_V2;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Adresse>(entity =>
            {
                entity.HasKey(e => e.IdAdresse);

                entity.Property(e => e.IdAdresse).HasColumnName("idAdresse");

                entity.Property(e => e.CodePostal).HasColumnName("codePostal");

                entity.Property(e => e.Pays)
                    .HasColumnName("pays")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Rue)
                    .HasColumnName("rue")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TypeAdresse)
                    .HasColumnName("typeAdresse")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Ville)
                    .HasColumnName("ville")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Cadre>(entity =>
            {
                entity.HasKey(e => e.IdCadre);

                entity.Property(e => e.IdCadre).HasColumnName("idCadre");

                entity.Property(e => e.NomCadre)
                    .IsRequired()
                    .HasColumnName("nomCadre")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CadreFinition>(entity =>
            {
                entity.HasKey(e => new { e.IdCadre, e.IdFinition });

                entity.Property(e => e.IdCadre).HasColumnName("idCadre");

                entity.Property(e => e.IdFinition).HasColumnName("idFinition");

                entity.HasOne(d => d.IdCadreNavigation)
                    .WithMany(p => p.CadreFinition)
                    .HasForeignKey(d => d.IdCadre)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CadreFinition_Cadre");

                entity.HasOne(d => d.IdFinitionNavigation)
                    .WithMany(p => p.CadreFinition)
                    .HasForeignKey(d => d.IdFinition)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CadreFinition_Finition");
            });

            modelBuilder.Entity<Commande>(entity =>
            {
                entity.HasKey(e => e.IdCommande);

                entity.Property(e => e.IdCommande).HasColumnName("idCommande");

                entity.Property(e => e.DateCommande)
                    .HasColumnName("dateCommande")
                    .HasColumnType("date");

                entity.Property(e => e.IdStatut).HasColumnName("idStatut");

                entity.Property(e => e.IdUtilisateur).HasColumnName("idUtilisateur");

                entity.Property(e => e.NumeroCommande).HasColumnName("numeroCommande");

                entity.Property(e => e.PrixCommande).HasColumnName("prixCommande");

                entity.Property(e => e.StatutCommande)
                    .IsRequired()
                    .HasColumnName("statutCommande")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdStatutNavigation)
                    .WithMany(p => p.Commande)
                    .HasForeignKey(d => d.IdStatut)
                    .HasConstraintName("FK_Commande_Statut");
            });

            modelBuilder.Entity<Finition>(entity =>
            {
                entity.HasKey(e => e.IdFinition);

                entity.Property(e => e.IdFinition).HasColumnName("idFinition");

                entity.Property(e => e.NomFinition)
                    .IsRequired()
                    .HasColumnName("nomFinition")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Format>(entity =>
            {
                entity.HasKey(e => e.IdFormat);

                entity.Property(e => e.IdFormat).HasColumnName("idFormat");

                entity.Property(e => e.NomFormat)
                    .HasColumnName("nomFormat")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FormatFinition>(entity =>
            {
                entity.HasKey(e => new { e.IdFormat, e.IdFinition });

                entity.Property(e => e.IdFormat).HasColumnName("idFormat");

                entity.Property(e => e.IdFinition).HasColumnName("idFinition");

                entity.HasOne(d => d.IdFinitionNavigation)
                    .WithMany(p => p.FormatFinition)
                    .HasForeignKey(d => d.IdFinition)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FormatFinition_Finition");

                entity.HasOne(d => d.IdFormatNavigation)
                    .WithMany(p => p.FormatFinition)
                    .HasForeignKey(d => d.IdFormat)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FormatFinition_Format");
            });

            modelBuilder.Entity<LigneCommande>(entity =>
            {
                entity.HasKey(e => new { e.IdPhoto, e.IdCommande, e.IdFormat, e.IdFinition, e.IdCadre });

                entity.Property(e => e.IdPhoto).HasColumnName("idPhoto");

                entity.Property(e => e.IdCommande).HasColumnName("idCommande");

                entity.Property(e => e.IdFormat).HasColumnName("idFormat");

                entity.Property(e => e.IdFinition).HasColumnName("idFinition");

                entity.Property(e => e.IdCadre).HasColumnName("idCadre");

                entity.Property(e => e.Prix).HasColumnName("prix");

                entity.Property(e => e.Quantite).HasColumnName("quantite");

                entity.HasOne(d => d.IdCadreNavigation)
                    .WithMany(p => p.LigneCommande)
                    .HasForeignKey(d => d.IdCadre)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LigneCommande_Cadre");

                entity.HasOne(d => d.IdCommandeNavigation)
                    .WithMany(p => p.LigneCommande)
                    .HasForeignKey(d => d.IdCommande)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LigneCommande_Commande");

                entity.HasOne(d => d.IdFinitionNavigation)
                    .WithMany(p => p.LigneCommande)
                    .HasForeignKey(d => d.IdFinition)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LigneCommande_Finition");

                entity.HasOne(d => d.IdFormatNavigation)
                    .WithMany(p => p.LigneCommande)
                    .HasForeignKey(d => d.IdFormat)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LigneCommande_Format");

                entity.HasOne(d => d.IdPhotoNavigation)
                    .WithMany(p => p.LigneCommande)
                    .HasForeignKey(d => d.IdPhoto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LigneCommande_Photo");
            });

            modelBuilder.Entity<Orientation>(entity =>
            {
                entity.HasKey(e => e.IdOrientation);

                entity.Property(e => e.IdOrientation).HasColumnName("idOrientation");

                entity.Property(e => e.NomOrientation)
                    .IsRequired()
                    .HasColumnName("nomOrientation")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Photo>(entity =>
            {
                entity.HasKey(e => e.IdPhoto);

                entity.Property(e => e.IdPhoto).HasColumnName("idPhoto");

                entity.Property(e => e.DateDepose)
                    .HasColumnName("dateDepose")
                    .HasColumnType("date");

                entity.Property(e => e.DescriptionPhoto)
                    .HasColumnName("descriptionPhoto")
                    .IsUnicode(false);

                entity.Property(e => e.HauteurPhoto).HasColumnName("hauteurPhoto");

                entity.Property(e => e.IdFormat).HasColumnName("idFormat");

                entity.Property(e => e.IdOrientation).HasColumnName("idOrientation");

                entity.Property(e => e.IdTheme).HasColumnName("idTheme");

                entity.Property(e => e.IdUtilisateur).HasColumnName("idUtilisateur");

                entity.Property(e => e.LargeurPhoto).HasColumnName("largeurPhoto");

                entity.Property(e => e.PrixPhoto).HasColumnName("prixPhoto");

                entity.Property(e => e.TitrePhoto)
                    .IsRequired()
                    .HasColumnName("titrePhoto")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdOrientationNavigation)
                    .WithMany(p => p.Photo)
                    .HasForeignKey(d => d.IdOrientation)
                    .HasConstraintName("FK_Photo_Orientation");

                entity.HasOne(d => d.IdUtilisateurNavigation)
                    .WithMany(p => p.Photo)
                    .HasForeignKey(d => d.IdUtilisateur)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Photo_Utilisateur");
            });

            modelBuilder.Entity<PhotoFormat>(entity =>
            {
                entity.HasKey(e => new { e.IdPhoto, e.IdFormat });

                entity.Property(e => e.IdPhoto).HasColumnName("idPhoto");

                entity.Property(e => e.IdFormat).HasColumnName("idFormat");

                entity.HasOne(d => d.IdFormatNavigation)
                    .WithMany(p => p.PhotoFormat)
                    .HasForeignKey(d => d.IdFormat)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PhotoFormat_Format");

                entity.HasOne(d => d.IdPhotoNavigation)
                    .WithMany(p => p.PhotoFormat)
                    .HasForeignKey(d => d.IdPhoto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PhotoFormat_Photo1");
            });

            modelBuilder.Entity<ProfilUtilisateur>(entity =>
            {
                entity.HasKey(e => e.IdProfilUtilisateur);

                entity.Property(e => e.IdProfilUtilisateur).HasColumnName("idProfilUtilisateur");

                entity.Property(e => e.TypeProfil)
                    .IsRequired()
                    .HasColumnName("typeProfil")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Statut>(entity =>
            {
                entity.HasKey(e => e.IdStatut);

                entity.Property(e => e.IdStatut).HasColumnName("idStatut");

                entity.Property(e => e.NomStatut)
                    .HasColumnName("nomStatut")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Tag>(entity =>
            {
                entity.HasKey(e => e.IdTag);

                entity.Property(e => e.IdTag).HasColumnName("idTag");

                entity.Property(e => e.NomTag)
                    .IsRequired()
                    .HasColumnName("nomTag")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Theme>(entity =>
            {
                entity.HasKey(e => e.IdTheme);

                entity.Property(e => e.IdTheme).HasColumnName("idTheme");

                entity.Property(e => e.TitreTheme)
                    .IsRequired()
                    .HasColumnName("titreTheme")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ThemePhoto>(entity =>
            {
                entity.HasKey(e => new { e.IdPhoto, e.IdTheme });

                entity.Property(e => e.IdPhoto).HasColumnName("idPhoto");

                entity.Property(e => e.IdTheme).HasColumnName("idTheme");

                entity.HasOne(d => d.IdPhotoNavigation)
                    .WithMany(p => p.ThemePhoto)
                    .HasForeignKey(d => d.IdPhoto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ThemePhoto_Photo");

                entity.HasOne(d => d.IdThemeNavigation)
                    .WithMany(p => p.ThemePhoto)
                    .HasForeignKey(d => d.IdTheme)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ThemePhoto_Theme");
            });

            modelBuilder.Entity<ThemeTag>(entity =>
            {
                entity.HasKey(e => new { e.IdTheme, e.IdTag });

                entity.Property(e => e.IdTheme).HasColumnName("idTheme");

                entity.Property(e => e.IdTag).HasColumnName("idTag");
            });

            modelBuilder.Entity<Utilisateur>(entity =>
            {
                entity.HasKey(e => e.IdUtilisateur);

                entity.Property(e => e.IdUtilisateur).HasColumnName("idUtilisateur");

                entity.Property(e => e.Civilité)
                    .HasColumnName("civilité")
                    .HasMaxLength(10);

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(10);

                entity.Property(e => e.IdAdresse).HasColumnName("idAdresse");

                entity.Property(e => e.IdProfilUtilisateur).HasColumnName("idProfilUtilisateur");

                entity.Property(e => e.MotPass)
                    .HasColumnName("motPass")
                    .HasMaxLength(10);

                entity.Property(e => e.Nom)
                    .HasColumnName("nom")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Prenom)
                    .HasColumnName("prenom")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Telephone)
                    .HasColumnName("telephone")
                    .HasMaxLength(10);

                entity.HasOne(d => d.IdAdresseNavigation)
                    .WithMany(p => p.Utilisateur)
                    .HasForeignKey(d => d.IdAdresse)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Utilisateur_Adresse");

                entity.HasOne(d => d.IdProfilUtilisateurNavigation)
                    .WithMany(p => p.Utilisateur)
                    .HasForeignKey(d => d.IdProfilUtilisateur)
                    .HasConstraintName("FK_Utilisateur_ProfilUtilisateur");
            });
        }
    }
}
