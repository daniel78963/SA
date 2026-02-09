using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

public partial class PreguntasxEvaluacion
{
    public int PreguntaEvaluacionId { get; set; }

    public int EvaluacionDocenteId { get; set; }

    public int PreguntaId { get; set; }

    public int EscalaId { get; set; }

    public virtual EscalaResultado Escala { get; set; } = null!;

    public virtual EvaluacionDocente EvaluacionDocente { get; set; } = null!;
}
