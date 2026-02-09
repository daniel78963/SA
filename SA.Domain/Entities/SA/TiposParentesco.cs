using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

public partial class TiposParentesco
{
    public int ParentescoId { get; set; }

    public string CodigoIes { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public virtual ICollection<Familiare> Familiares { get; set; } = new List<Familiare>();
}
