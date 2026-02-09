using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

public partial class CalificacionToolValuesxEgresado
{
    public int CalificacionToolValuesxEgresadoId { get; set; }

    public int? CalificacionToolValueId { get; set; }

    public int? AnoGraduacion { get; set; }

    public string? SituacionLaboral { get; set; }

    public string? TipoEmpresa { get; set; }

    public string? EntidadDondeLabora { get; set; }

    public string? Cargo { get; set; }

    public string? ActividadEmpresarial { get; set; }

    public bool? Posgrado { get; set; }

    public string? PosgradoDonde { get; set; }

    public virtual CalificacionToolValue? CalificacionToolValue { get; set; }
}
