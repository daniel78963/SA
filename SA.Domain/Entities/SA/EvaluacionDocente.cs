using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

public partial class EvaluacionDocente
{
    public int EvaluacionDocenteId { get; set; }

    public string Nombre { get; set; } = null!;

    /// <summary>
    /// 01-Activa, 02-Inactiva
    /// </summary>
    public string Estado { get; set; } = null!;

    public DateTime FechaInicio { get; set; }

    public DateTime FechaFin { get; set; }

    public string? Observaciones { get; set; }

    public virtual ICollection<EncabezadoResultado> EncabezadoResultados { get; set; } = new List<EncabezadoResultado>();

    public virtual ICollection<PreguntasxEvaluacion> PreguntasxEvaluacions { get; set; } = new List<PreguntasxEvaluacion>();
}
