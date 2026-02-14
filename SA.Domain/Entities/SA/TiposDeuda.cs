using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

public partial class TiposDeuda
{
    public int TipoDeudaId { get; set; }

    public string Nombre { get; set; } = null!;

    public virtual ICollection<Deuda> Deuda { get; set; } = new List<Deuda>();
}
