using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Game.Data.Models
{
    public partial class GamesContext : DbContext
    {
        public GamesContext(DbContextOptions<GamesContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Countries> Countries { get; set; }
        public virtual DbSet<FilmTypes> FilmTypes { get; set; }
        public virtual DbSet<Films> Films { get; set; }
        public virtual DbSet<GameModes> GameModes { get; set; }
        public virtual DbSet<GameTypes> GameTypes { get; set; }
        public virtual DbSet<Lenguages> Lenguages { get; set; }
        public virtual DbSet<Persons> Persons { get; set; }
        public virtual DbSet<Platforms> Platforms { get; set; }
        public virtual DbSet<Series> Series { get; set; }
        public virtual DbSet<SeriesTypes> SeriesTypes { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<VideoGames> VideoGames { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Countries>(entity =>
            {
                entity.HasKey(e => e.CountryId);

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Modification).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Registration).HasColumnType("datetime");
            });

            modelBuilder.Entity<FilmTypes>(entity =>
            {
                entity.HasKey(e => e.FilmTypeId);

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Modification).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Registration).HasColumnType("datetime");
            });

            modelBuilder.Entity<Films>(entity =>
            {
                entity.HasKey(e => e.FilmId);

                entity.Property(e => e.Director)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.DistributedBy)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Duration).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.FilmTypes)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Image).IsUnicode(false);

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Lenguages)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Modification).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Registration).HasColumnType("datetime");

                entity.Property(e => e.Release).HasColumnType("date");

                entity.Property(e => e.Starring).IsUnicode(false);

                entity.Property(e => e.Subtitles)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.Films)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK_Films_Countries");
            });

            modelBuilder.Entity<GameModes>(entity =>
            {
                entity.HasKey(e => e.GameModeId);

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Modification).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Registration).HasColumnType("datetime");
            });

            modelBuilder.Entity<GameTypes>(entity =>
            {
                entity.HasKey(e => e.GameTypeId);

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Modification).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Registration).HasColumnType("datetime");
            });

            modelBuilder.Entity<Lenguages>(entity =>
            {
                entity.HasKey(e => e.LenguageId);

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Modification).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Registration).HasColumnType("datetime");
            });

            modelBuilder.Entity<Persons>(entity =>
            {
                entity.HasKey(e => e.PersonId);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Modification).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Registration).HasColumnType("datetime");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.Persons)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK_Persons_Countries");
            });

            modelBuilder.Entity<Platforms>(entity =>
            {
                entity.HasKey(e => e.PlatformId);

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Modification).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Registration).HasColumnType("datetime");
            });

            modelBuilder.Entity<Series>(entity =>
            {
                entity.HasKey(e => e.SerieId);

                entity.Property(e => e.Director)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.DistributedBy)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Duration).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Image).IsUnicode(false);

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Lenguages)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Modification).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Registration).HasColumnType("datetime");

                entity.Property(e => e.Release).HasColumnType("date");

                entity.Property(e => e.SerieTypes)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Starring).IsUnicode(false);

                entity.Property(e => e.Subtitles)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.Series)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK_Series_Countries");
            });

            modelBuilder.Entity<SeriesTypes>(entity =>
            {
                entity.HasKey(e => e.SerieTypeId);

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Modification).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Registration).HasColumnType("datetime");
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsAdmin)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Modification).HasColumnType("datetime");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Registration).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.PersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Users_Persons");
            });

            modelBuilder.Entity<VideoGames>(entity =>
            {
                entity.HasKey(e => e.VideoGameId);

                entity.Property(e => e.Developer)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Director)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.GameHours).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.GameModes)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.GameTypes)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Image).IsUnicode(false);

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsOnline).HasDefaultValueSql("((0))");

                entity.Property(e => e.Lenguages)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Modification).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Platforms)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Publisher)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Registration).HasColumnType("datetime");

                entity.Property(e => e.Release).HasColumnType("date");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
