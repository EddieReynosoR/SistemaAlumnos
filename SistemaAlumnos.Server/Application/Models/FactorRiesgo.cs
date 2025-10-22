using System;
using System.Collections.Generic;

namespace SistemaAlumnos.Server.Application.Models;

public partial class FactorRiesgo
{
    public int IdFactor { get; set; }

    public string Descripcion { get; set; } = null!;

    public string? Categoria { get; set; }

    public virtual ICollection<RiesgoEstudiante> RiesgoEstudiantes { get; set; } = new List<RiesgoEstudiante>();
}
