using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

public partial class TiposCalificacionTool
{
    public int TipoCalificacionToolId { get; set; }

    public string? Nombre { get; set; }

    public virtual ICollection<CalificacionTool> CalificacionTools { get; set; } = new List<CalificacionTool>();
}
