using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

public partial class ResultadosEvaluacione
{
    public int ResultadoEvaluacionesId { get; set; }

    public int EncabezadoResultadosId { get; set; }

    public int PreguntaEvaluacionId { get; set; }

    public int EscalaId { get; set; }

    public virtual EncabezadoResultado EncabezadoResultados { get; set; } = null!;

    public virtual EscalaResultado Escala { get; set; } = null!;

    public virtual PreguntasxEvaluacion PreguntaEvaluacion { get; set; } = null!;
}
