using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Work_4.Models;

public partial class AppContext : DbContext
{
    #region Конструкторы
    public AppContext() { }
    public AppContext(DbContextOptions<AppContext> options) : base(options) { }
    #endregion

    #region Свойства таблиц
    public virtual DbSet<AnimeTitle> AnimeTitles { get; set; }
    public virtual DbSet<AnimeType> AnimeTypes { get; set; }
    public virtual DbSet<Genre> Genres { get; set; }
    public virtual DbSet<User> Users { get; set; }
    #endregion

    #region Методы
    // Переопределение методов
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=animeTitles;Username=postgres;Password=1111");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AnimeTitle>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("animeTitles_pkey");

            entity.ToTable("animeTitles");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CountOfSeries).HasColumnName("countOfSeries");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Duration).HasColumnName("duration");
            entity.Property(e => e.IdAnimeType).HasColumnName("idAnimeType");
            entity.Property(e => e.IdUser).HasColumnName("idUser");
            entity.Property(e => e.IsComplete).HasColumnName("isComplete");
            entity.Property(e => e.OriginalName).HasColumnName("originalName");
            entity.Property(e => e.Poster).HasColumnName("poster");
            entity.Property(e => e.Studio).HasColumnName("studio");
            entity.Property(e => e.TitleName).HasColumnName("titleName");
            entity.Property(e => e.YearOfRealise).HasColumnName("yearOfRealise");
            
            entity.HasOne(d => d.IdAnimeTypeNavigation).WithMany(p => p.AnimeTitles)
                .HasForeignKey(d => d.IdAnimeType)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_titles_types");

            entity.HasOne(d => d.IdGenreNavigation).WithMany(p => p.AnimeTitles)
                .HasForeignKey(d => d.IdGenre)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_titles_genres");

            entity.HasOne(d => d.IdUserNavigation).WithMany(p => p.AnimeTitles)
                .HasForeignKey(d => d.IdUser)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_titles_users");
        });

        modelBuilder.Entity<AnimeType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("animeTypes_pkey");

            entity.ToTable("animeTypes");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AnimeOfType).HasColumnName("animeOfType");
        });

        modelBuilder.Entity<Genre>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("genres_pkey");

            entity.ToTable("genres");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.GenreName).HasColumnName("genreName");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("users_pkey");

            entity.ToTable("users");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DateOfRegistration).HasColumnName("dateOfRegistration");
            entity.Property(e => e.FirstName).HasColumnName("firstName");
            entity.Property(e => e.LastName).HasColumnName("lastName");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    #endregion
}
