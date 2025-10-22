using System;
using System.Collections.Generic;

namespace SistemaAlumnos.Server.Application.Models;

public partial class RiesgoEstudiante
{
    public int IdRiesgo { get; set; }

    public int IdEstudiante { get; set; }

    public int IdFactor { get; set; }

    public int IdPeriodo { get; set; }

    public virtual Estudiante IdEstudianteNavigation { get; set; } = null!;

    public virtual FactorRiesgo IdFactorNavigation { get; set; } = null!;

    public virtual Periodo IdPeriodoNavigation { get; set; } = null!;
}
