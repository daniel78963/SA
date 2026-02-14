using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

public partial class DepartamentosCrm
{
    public int DepartamentoId { get; set; }

    public string Nombre { get; set; } = null!;

    public int PaisId { get; set; }

    public string? Codigo { get; set; }

    public string? CodigoPais { get; set; }

    public string? DescripcionPais { get; set; }

    public string? CodigoSnies { get; set; }

    public virtual ICollection<MunicipiosCrm> MunicipiosCrms { get; set; } = new List<MunicipiosCrm>();

    public virtual PaisesCrm Pais { get; set; } = null!;
}
