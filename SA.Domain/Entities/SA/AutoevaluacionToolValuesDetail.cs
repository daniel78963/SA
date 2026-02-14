using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

public partial class AutoevaluacionToolValuesDetail
{
    public int AutoevaluacionToolValuesDetailsId { get; set; }

    public int AutoevaluacionToolValuesId { get; set; }

    public int PreguntaId { get; set; }

    public int FaseId { get; set; }

    public string? Resultado { get; set; }

    public int? EscalaId { get; set; }

    public virtual AutoevaluacionToolValue AutoevaluacionToolValues { get; set; } = null!;

    public virtual EscalasResultado? Escala { get; set; }

    public virtual Fase Fase { get; set; } = null!;

    public virtual Pregunta Pregunta { get; set; } = null!;
}
