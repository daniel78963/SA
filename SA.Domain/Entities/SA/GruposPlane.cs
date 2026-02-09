using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

public partial class GruposPlane
{
    public int GrupoPlanId { get; set; }

    public int GrupoId { get; set; }

    public int? Sesion { get; set; }

    public int? Htp { get; set; }

    public int? Hti { get; set; }

    public string? Temas { get; set; }

    public int? TipoGrupoPlanId { get; set; }

    public DateTime? Fecha { get; set; }

    public decimal? Porcentaje { get; set; }

    public string? ActividadesTi { get; set; }

    public virtual Grupo Grupo { get; set; } = null!;

    public virtual ICollection<GruposPlanesxArchivo> GruposPlanesxArchivos { get; set; } = new List<GruposPlanesxArchivo>();

    public virtual TiposGruposPlane? TipoGrupoPlan { get; set; }
}
