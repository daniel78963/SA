using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

public partial class PaisFronteraCrm
{
    public int PaisFronteraId { get; set; }

    public byte[] Descripcion { get; set; } = null!;

    public int PaisId { get; set; }

    public virtual PaisesCrm Pais { get; set; } = null!;
}
