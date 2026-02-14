using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

public partial class CalificacionToolsxEntidadEducacion
{
    public int CalificacionToolsxEntidadEducacionId { get; set; }

    public int? CalificacionToolId { get; set; }

    public int? EntidadEducacionId { get; set; }

    public virtual CalificacionTool? CalificacionTool { get; set; }

    public virtual Ie? EntidadEducacion { get; set; }
}
