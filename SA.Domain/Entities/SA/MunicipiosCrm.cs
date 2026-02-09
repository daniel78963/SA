using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

public partial class MunicipiosCrm
{
    public int MunicipioId { get; set; }

    public string Descripcion { get; set; } = null!;

    public int DepartamentoId { get; set; }

    public string? Codigo { get; set; }

    public string? CodigoDpta { get; set; }

    public string? DescripcionDpta { get; set; }

    public string? CodigoPais { get; set; }

    public string? DescripcionPais { get; set; }

    public virtual ICollection<BarriosCrm> BarriosCrms { get; set; } = new List<BarriosCrm>();

    public virtual DepartamentosCrm Departamento { get; set; } = null!;

    public virtual ICollection<PersonasCrm> PersonasCrms { get; set; } = new List<PersonasCrm>();
}
