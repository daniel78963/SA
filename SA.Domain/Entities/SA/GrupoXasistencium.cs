using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

public partial class GrupoXasistencium
{
    public int GrupoXasistencia { get; set; }

    public int GrupoId { get; set; }

    public int EstudianteId { get; set; }

    public DateTime Fecha { get; set; }

    public string Concepto { get; set; } = null!;
}
