using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

public partial class TiposEstado
{
    public int TipoEstadoId { get; set; }

    public string Descripcion { get; set; } = null!;

    public virtual ICollection<Estado> Estados { get; set; } = new List<Estado>();
}
