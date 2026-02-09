using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

public partial class CargaNombresTemporal
{
    public decimal? Identificacion { get; set; }

    public string? PrimerNombre { get; set; }

    public string? SegundoNombre { get; set; }

    public string? PrimerApellido { get; set; }

    public string? SegundoApellido { get; set; }
}
