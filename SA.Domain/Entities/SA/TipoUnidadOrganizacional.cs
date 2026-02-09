using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

/// <summary>
/// Almacena las sedes, divisiones, áreas o unidades organizacionales pertenecientes a la IES, incluyendo convenios
/// </summary>
public partial class TipoUnidadOrganizacional
{
    public int TipoUnidadOrganizacionalId { get; set; }

    public string CodigoIes { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public virtual ICollection<ActividadesCalendario> ActividadesCalendarios { get; set; } = new List<ActividadesCalendario>();

    public virtual ICollection<UnidadOrganizacional> UnidadOrganizacionals { get; set; } = new List<UnidadOrganizacional>();
}
