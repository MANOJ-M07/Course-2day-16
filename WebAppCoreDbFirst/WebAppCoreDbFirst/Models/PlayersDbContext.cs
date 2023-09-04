using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WebAppCoreDbFirst.Models;

public partial class PlayersDbContext : DbContext
{
    public PlayersDbContext()
    {
    }

    public PlayersDbContext(DbContextOptions<PlayersDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Player> Players { get; set; }

    public virtual DbSet<Team> Teams { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=LAPTOP-DLI2FL88;database=PlayersDb;trusted_connection=true;TrustServerCertificate=true;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Player>(entity =>
        {
            entity.HasKey(e => e.PlayerId).HasName("PK__Player__4A4E74C8B9865950");

            entity.ToTable("Player");

            entity.Property(e => e.PlayerId).ValueGeneratedNever();
            entity.Property(e => e.PlayerName).HasMaxLength(50);
            entity.Property(e => e.PlayerType).HasMaxLength(50);

            entity.HasOne(d => d.PlayerTeamNavigation).WithMany(p => p.Players)
                .HasForeignKey(d => d.PlayerTeam)
                .HasConstraintName("FK__Player__PlayerTe__3A81B327");
        });

        modelBuilder.Entity<Team>(entity =>
        {
            entity.HasKey(e => e.TeamId).HasName("PK__Team__123AE799286331E3");

            entity.ToTable("Team");

            entity.HasIndex(e => e.TeamName, "UQ__Team__4E21CAAC915E9846").IsUnique();

            entity.Property(e => e.TeamId).ValueGeneratedNever();
            entity.Property(e => e.TeamName).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
