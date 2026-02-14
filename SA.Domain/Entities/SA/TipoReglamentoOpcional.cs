using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

public partial class TipoReglamentoOpcional
{
    public int TipoReglamentoId { get; set; }

    public string CodigoIes { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public virtual ICollection<Ie> Ies { get; set; } = new List<Ie>();
}
