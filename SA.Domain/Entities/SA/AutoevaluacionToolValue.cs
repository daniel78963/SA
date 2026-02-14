using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

public partial class AutoevaluacionToolValue
{
    public int AutoevaluacionToolValuesId { get; set; }

    public int? CalificacionToolId { get; set; }

    public string Usuario { get; set; } = null!;

    public DateTime FechaCreacion { get; set; }

    public string? Observaciones { get; set; }

    public string UserCreated { get; set; } = null!;

    public int? GrupoId { get; set; }

    public int? PeriodoId { get; set; }

    public virtual ICollection<AutoevaluacionToolValuesDetail> AutoevaluacionToolValuesDetails { get; set; } = new List<AutoevaluacionToolValuesDetail>();

    public virtual ICollection<AutoevaluacionToolValuexPrograma> AutoevaluacionToolValuexProgramas { get; set; } = new List<AutoevaluacionToolValuexPrograma>();

    public virtual CalificacionTool? CalificacionTool { get; set; }

    public virtual Grupo? Grupo { get; set; }

    public virtual Periodo? Periodo { get; set; }
}
