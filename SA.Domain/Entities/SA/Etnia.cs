using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

public partial class Etnia
{
    public int EtniaId { get; set; }

    public string CodigoIes { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public virtual ICollection<InformacionAdicional> InformacionAdicionals { get; set; } = new List<InformacionAdicional>();
}
