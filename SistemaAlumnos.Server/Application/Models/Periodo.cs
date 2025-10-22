using System;
using System.Collections.Generic;

namespace SistemaAlumnos.Server.Application.Models;

public partial class Periodo
{
    public int IdPeriodo { get; set; }

    public string Nombre { get; set; } = null!;

    public DateOnly FechaInicio { get; set; }

    public DateOnly FechaFin { get; set; }

    public virtual ICollection<Materium> Materia { get; set; } = new List<Materium>();

    public virtual ICollection<RiesgoEstudiante> RiesgoEstudiantes { get; set; } = new List<RiesgoEstudiante>();
}
