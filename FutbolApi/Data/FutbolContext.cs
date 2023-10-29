using System;
using System.Collections.Generic;
using FutbolApi.Models;
using Microsoft.EntityFrameworkCore;

namespace FutbolApi.Context;

public partial class FutbolContext : DbContext
{
    public FutbolContext()
    {
    }

    public FutbolContext(DbContextOptions<FutbolContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Club> Clubs { get; set; }

    public virtual DbSet<Jugador> Jugadors { get; set; }

    public virtual DbSet<Liga> Ligas { get; set; }

    public virtual DbSet<Pais> Pais { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Club>(entity =>
        {
            entity.HasKey(e => e.ClubId).HasName("PK__Club__D35058C741A82641");

            entity.ToTable("Club");

            entity.Property(e => e.ClubId).HasColumnName("ClubID");
            entity.Property(e => e.AnioFundacion)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Entrenador)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Estadio)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.LigaId).HasColumnName("LigaID");
            entity.Property(e => e.Nombre)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.PaisId).HasColumnName("PaisID");
            entity.Property(e => e.Presidente)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.HasOne(d => d.Liga).WithMany(p => p.Clubs)
                .HasForeignKey(d => d.LigaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Club__LigaID__5165187F");

            entity.HasOne(d => d.Pais).WithMany(p => p.Clubs)
                .HasForeignKey(d => d.PaisId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Club__PaisID__5070F446");
        });

        modelBuilder.Entity<Jugador>(entity =>
        {
            entity.HasKey(e => e.JugadorId).HasName("PK__Jugador__4B575242240E415E");

            entity.ToTable("Jugador");

            entity.Property(e => e.JugadorId).HasColumnName("JugadorID");
            entity.Property(e => e.ClubId).HasColumnName("ClubID");
            entity.Property(e => e.Nombre)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Posicion)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.HasOne(d => d.Club).WithMany(p => p.Jugadors)
                .HasForeignKey(d => d.ClubId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Jugador__Numero__5441852A");
        });

        modelBuilder.Entity<Liga>(entity =>
        {
            entity.HasKey(e => e.LigaId).HasName("PK__Liga__05567B171A8CA2C9");

            entity.ToTable("Liga");

            entity.Property(e => e.LigaId).HasColumnName("LigaID");
            entity.Property(e => e.Nombre)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.PaisId).HasColumnName("PaisID");
            entity.Property(e => e.Temporada)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.HasOne(d => d.Pais).WithMany(p => p.Ligas)
                .HasForeignKey(d => d.PaisId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Liga__PaisID__4D94879B");
        });

        modelBuilder.Entity<Pais>(entity =>
        {
            entity.HasKey(e => e.PaisId).HasName("PK__Pais__B501E1A54CCE7C30");

            entity.Property(e => e.PaisId).HasColumnName("PaisID");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
