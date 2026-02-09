using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

public partial class ViewNotasAlumno
{
    public int InscripcionId { get; set; }

    public int GrupoId { get; set; }

    public int PersonaId { get; set; }

    public string Identificacion { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public decimal Nota { get; set; }

    public decimal PorcentajeEvaluacion { get; set; }

    public DateTime FechaEvaluacion { get; set; }
}
