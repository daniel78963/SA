using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

public partial class EscalasResultado
{
    public int EscalaId { get; set; }

    public string Abreviatura { get; set; } = null!;

    public string? Descripcion { get; set; }

    public string Equivalencia { get; set; } = null!;

    public int CalificacionToolId { get; set; }

    public int? PreguntaId { get; set; }

    public string? DireccionRespuestas { get; set; }

    public virtual ICollection<AutoevaluacionToolValuesDetail> AutoevaluacionToolValuesDetails { get; set; } = new List<AutoevaluacionToolValuesDetail>();

    public virtual CalificacionTool CalificacionTool { get; set; } = null!;

    public virtual ICollection<CalificacionToolValuesDetail> CalificacionToolValuesDetails { get; set; } = new List<CalificacionToolValuesDetail>();

    public virtual Pregunta? Pregunta { get; set; }
}
