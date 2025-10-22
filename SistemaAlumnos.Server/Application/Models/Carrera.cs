using System;
using System.Collections.Generic;

namespace SistemaAlumnos.Server.Application.Models;

public partial class Carrera
{
    public int IdCarrera { get; set; }

    public string Nombre { get; set; } = null!;

    public virtual ICollection<Estudiante> Estudiantes { get; set; } = new List<Estudiante>();

    public virtual ICollection<Materium> Materia { get; set; } = new List<Materium>();
}
