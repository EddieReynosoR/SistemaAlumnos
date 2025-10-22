using System;
using System.Collections.Generic;

namespace SistemaAlumnos.Server.Application.Models;

public partial class Estudiante
{
    public int IdEstudiante { get; set; }

    public string NumeroControl { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public string ApellidoPaterno { get; set; } = null!;

    public string ApellidoMaterno { get; set; } = null!;

    public byte Semestre { get; set; }

    public int IdCarrera { get; set; }

    public virtual ICollection<CalificacionAsistencium> CalificacionAsistencia { get; set; } = new List<CalificacionAsistencium>();

    public virtual Carrera IdCarreraNavigation { get; set; } = null!;

    public virtual ICollection<RiesgoEstudiante> RiesgoEstudiantes { get; set; } = new List<RiesgoEstudiante>();
}
