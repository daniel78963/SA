using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

public partial class ListasToolDetail
{
    public int ListaToolDetailsId { get; set; }

    public string Texto { get; set; } = null!;

    public int? Peso { get; set; }

    public int ListaToolId { get; set; }

    public virtual ListasTool ListaTool { get; set; } = null!;
}
