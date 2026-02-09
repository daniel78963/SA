using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

public partial class TiposRelacion
{
    public int TiposRelacionId { get; set; }

    public string? Descripcion { get; set; }

    public virtual ICollection<AsignaturasRelacionada> AsignaturasRelacionada { get; set; } = new List<AsignaturasRelacionada>();
}
