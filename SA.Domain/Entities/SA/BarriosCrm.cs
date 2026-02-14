using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

public partial class BarriosCrm
{
    public int BarrioId { get; set; }

    public string? CodigoBarrio { get; set; }

    public string? DescripcionBarrio { get; set; }

    public string? CodigoMpio { get; set; }

    public string? DescripcionMpio { get; set; }

    public string? CodigoDpta { get; set; }

    public string? DescripcionDpta { get; set; }

    public string? CodigoPais { get; set; }

    public string? DescripcionPais { get; set; }

    public int? MunicipioId { get; set; }

    public virtual MunicipiosCrm? Municipio { get; set; }
}
