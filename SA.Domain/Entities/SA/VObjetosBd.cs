using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

public partial class VObjetosBd
{
    public string CTipo { get; set; } = null!;

    public string? SNombre { get; set; }

    public string STabla { get; set; } = null!;

    public string SUsuario { get; set; } = null!;
}
