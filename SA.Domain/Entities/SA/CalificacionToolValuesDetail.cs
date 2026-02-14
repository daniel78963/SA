using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

public partial class CalificacionToolValuesDetail
{
    public int CalificacionToolValuesDetailsId { get; set; }

    public int CalificacionToolValuesId { get; set; }

    public int PreguntaId { get; set; }

    public int FaseId { get; set; }

    public string? Resultado { get; set; }

    public int? EscalaId { get; set; }

    public virtual CalificacionToolValue CalificacionToolValues { get; set; } = null!;

    public virtual EscalasResultado? Escala { get; set; }

    public virtual Fase Fase { get; set; } = null!;

    public virtual Pregunta Pregunta { get; set; } = null!;
}
