using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

public partial class EncabezadoResultado
{
    public int EncabezadoResultadosId { get; set; }

    public int EvaluacionDocenteId { get; set; }

    public int GrupoAsignaturaId { get; set; }

    public int PersonaId { get; set; }

    public DateTime FechaEvaluacion { get; set; }

    public virtual EvaluacionDocente EvaluacionDocente { get; set; } = null!;
}
