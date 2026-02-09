using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

public partial class Fase
{
    public int FaseId { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Descripcion { get; set; }

    public int CalificacionToolId { get; set; }

    public virtual ICollection<AutoevaluacionToolValuesDetail> AutoevaluacionToolValuesDetails { get; set; } = new List<AutoevaluacionToolValuesDetail>();

    public virtual CalificacionTool CalificacionTool { get; set; } = null!;

    public virtual ICollection<CalificacionToolValuesDetail> CalificacionToolValuesDetails { get; set; } = new List<CalificacionToolValuesDetail>();
}
