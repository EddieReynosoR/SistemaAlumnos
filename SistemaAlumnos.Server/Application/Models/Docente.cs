using System;
using System.Collections.Generic;

namespace SistemaAlumnos.Server.Application.Models;

public partial class Docente
{
    public int IdDocente { get; set; }

    public string Nombre { get; set; } = null!;

    public string ApellidoPaterno { get; set; } = null!;

    public string ApellidoMaterno { get; set; } = null!;

    public string Usuario { get; set; } = null!;

    public string Contrasena { get; set; } = null!;

    public virtual ICollection<Materium> Materia { get; set; } = new List<Materium>();
}
