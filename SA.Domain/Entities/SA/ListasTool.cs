using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

public partial class ListasTool
{
    public int ListaToolId { get; set; }

    public string Nombre { get; set; } = null!;

    public virtual ICollection<ListasToolDetail> ListasToolDetails { get; set; } = new List<ListasToolDetail>();
}
