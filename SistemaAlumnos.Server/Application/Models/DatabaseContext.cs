using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace SistemaAlumnos.Server.Application.Models;

public partial class DatabaseContext : DbContext
{
    public DatabaseContext()
    {
    }

    public DatabaseContext(DbContextOptions<DatabaseContext> options)
        : base(options)
    {
    }

    public virtual DbSet<CalificacionAsistencium> CalificacionAsistencia { get; set; }

    public virtual DbSet<Carrera> Carreras { get; set; }

    public virtual DbSet<Docente> Docentes { get; set; }

    public virtual DbSet<Estudiante> Estudiantes { get; set; }

    public virtual DbSet<FactorRiesgo> FactorRiesgos { get; set; }

    public virtual DbSet<Materium> Materia { get; set; }

    public virtual DbSet<Periodo> Periodos { get; set; }

    public virtual DbSet<RiesgoEstudiante> RiesgoEstudiantes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlServer("Name=ConnectionStrings:DatabaseConnection");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CalificacionAsistencium>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Califica__3214EC07A4133A3D");

            entity.HasIndex(e => e.IdEstudiante, "IX_Calif_Estudiante");

            entity.HasIndex(e => e.IdMateria, "IX_Calif_Materia");

            entity.HasIndex(e => new { e.IdEstudiante, e.IdMateria, e.Unidad }, "UQ_Calif_Estudiante_Materia_Unidad").IsUnique();

            entity.Property(e => e.Calificacion).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.Estatus).HasMaxLength(30);

            entity.HasOne(d => d.IdEstudianteNavigation).WithMany(p => p.CalificacionAsistencia)
                .HasForeignKey(d => d.IdEstudiante)
                .HasConstraintName("FK_Calif_Estudiante");

            entity.HasOne(d => d.IdMateriaNavigation).WithMany(p => p.CalificacionAsistencia)
                .HasForeignKey(d => d.IdMateria)
                .HasConstraintName("FK_Calif_Materia");
        });

        modelBuilder.Entity<Carrera>(entity =>
        {
            entity.HasKey(e => e.IdCarrera).HasName("PK__Carrera__884A8F1FF4FA754B");

            entity.ToTable("Carrera");

            entity.Property(e => e.Nombre).HasMaxLength(120);
        });

        modelBuilder.Entity<Docente>(entity =>
        {
            entity.HasKey(e => e.IdDocente).HasName("PK__Docente__64A8726E293F8AB9");

            entity.ToTable("Docente");

            entity.HasIndex(e => e.Usuario, "UQ__Docente__E3237CF723266BCA").IsUnique();

            entity.Property(e => e.ApellidoMaterno).HasMaxLength(120);
            entity.Property(e => e.ApellidoPaterno).HasMaxLength(120);
            entity.Property(e => e.Contrasena).HasMaxLength(256);
            entity.Property(e => e.Nombre).HasMaxLength(120);
            entity.Property(e => e.Usuario).HasMaxLength(80);
        });

        modelBuilder.Entity<Estudiante>(entity =>
        {
            entity.HasKey(e => e.IdEstudiante).HasName("PK__Estudian__B5007C2408AEC9FF");

            entity.ToTable("Estudiante");

            entity.HasIndex(e => e.NumeroControl, "UQ__Estudian__DF3DFCBF5EF8DFA2").IsUnique();

            entity.Property(e => e.ApellidoMaterno).HasMaxLength(120);
            entity.Property(e => e.ApellidoPaterno).HasMaxLength(120);
            entity.Property(e => e.Nombre).HasMaxLength(120);
            entity.Property(e => e.NumeroControl).HasMaxLength(30);

            entity.HasOne(d => d.IdCarreraNavigation).WithMany(p => p.Estudiantes)
                .HasForeignKey(d => d.IdCarrera)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Estudiante_Carrera");
        });

        modelBuilder.Entity<FactorRiesgo>(entity =>
        {
            entity.HasKey(e => e.IdFactor).HasName("PK__FactorRi__8388623C7E873D9E");

            entity.ToTable("FactorRiesgo");

            entity.Property(e => e.Categoria).HasMaxLength(80);
            entity.Property(e => e.Descripcion).HasMaxLength(200);
        });

        modelBuilder.Entity<Materium>(entity =>
        {
            entity.HasKey(e => e.IdMateria).HasName("PK__Materia__EC174670F29F9413");

            entity.HasIndex(e => e.IdCarrera, "IX_Materia_Carrera");

            entity.HasIndex(e => e.IdPeriodo, "IX_Materia_Periodo");

            entity.Property(e => e.Nombre).HasMaxLength(120);

            entity.HasOne(d => d.IdCarreraNavigation).WithMany(p => p.Materia)
                .HasForeignKey(d => d.IdCarrera)
                .HasConstraintName("FK_Materia_Carrera");

            entity.HasOne(d => d.IdDocenteNavigation).WithMany(p => p.Materia)
                .HasForeignKey(d => d.IdDocente)
                .HasConstraintName("FK_Materia_Docente");

            entity.HasOne(d => d.IdPeriodoNavigation).WithMany(p => p.Materia)
                .HasForeignKey(d => d.IdPeriodo)
                .HasConstraintName("FK_Materia_Periodo");
        });

        modelBuilder.Entity<Periodo>(entity =>
        {
            entity.HasKey(e => e.IdPeriodo).HasName("PK__Periodo__B44699FE2A1689C5");

            entity.ToTable("Periodo");

            entity.Property(e => e.Nombre).HasMaxLength(80);
        });

        modelBuilder.Entity<RiesgoEstudiante>(entity =>
        {
            entity.HasKey(e => e.IdRiesgo).HasName("PK__RiesgoEs__5D6727882C11424A");

            entity.ToTable("RiesgoEstudiante");

            entity.HasIndex(e => e.IdEstudiante, "IX_Riesgo_Estudiante");

            entity.HasIndex(e => e.IdPeriodo, "IX_Riesgo_Periodo");

            entity.HasIndex(e => new { e.IdEstudiante, e.IdFactor, e.IdPeriodo }, "UQ_Riesgo_Estudiante_Factor_Periodo").IsUnique();

            entity.HasOne(d => d.IdEstudianteNavigation).WithMany(p => p.RiesgoEstudiantes)
                .HasForeignKey(d => d.IdEstudiante)
                .HasConstraintName("FK_Riesgo_Estudiante");

            entity.HasOne(d => d.IdFactorNavigation).WithMany(p => p.RiesgoEstudiantes)
                .HasForeignKey(d => d.IdFactor)
                .HasConstraintName("FK_Riesgo_Factor");

            entity.HasOne(d => d.IdPeriodoNavigation).WithMany(p => p.RiesgoEstudiantes)
                .HasForeignKey(d => d.IdPeriodo)
                .HasConstraintName("FK_Riesgo_Periodo");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
