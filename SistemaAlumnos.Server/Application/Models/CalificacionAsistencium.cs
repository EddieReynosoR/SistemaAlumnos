using System;
using System.Collections.Generic;

namespace SistemaAlumnos.Server.Application.Models;

public partial class CalificacionAsistencium
{
    public int Id { get; set; }

    public int IdEstudiante { get; set; }

    public int IdMateria { get; set; }

    public byte Unidad { get; set; }

    public int Asistencia { get; set; }

    public decimal? Calificacion { get; set; }

    public string Estatus { get; set; } = null!;

    public virtual Estudiante IdEstudianteNavigation { get; set; } = null!;

    public virtual Materium IdMateriaNavigation { get; set; } = null!;
}
