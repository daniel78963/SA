using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

public partial class PaisesCrm
{
    public int PaisId { get; set; }

    public string Descripcion { get; set; } = null!;

    public string? Codigo { get; set; }

    public string? CodigoSnies { get; set; }

    public virtual ICollection<DepartamentosCrm> DepartamentosCrms { get; set; } = new List<DepartamentosCrm>();

    public virtual ICollection<PaisFronteraCrm> PaisFronteraCrms { get; set; } = new List<PaisFronteraCrm>();
}
