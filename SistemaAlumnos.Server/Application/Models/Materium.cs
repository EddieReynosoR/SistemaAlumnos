using System;
using System.Collections.Generic;

namespace SistemaAlumnos.Server.Application.Models;

public partial class Materium
{
    public int IdMateria { get; set; }

    public string Nombre { get; set; } = null!;

    public int IdDocente { get; set; }

    public int IdPeriodo { get; set; }

    public int IdCarrera { get; set; }

    public virtual ICollection<CalificacionAsistencium> CalificacionAsistencia { get; set; } = new List<CalificacionAsistencium>();

    public virtual Carrera IdCarreraNavigation { get; set; } = null!;

    public virtual Docente IdDocenteNavigation { get; set; } = null!;

    public virtual Periodo IdPeriodoNavigation { get; set; } = null!;
}
