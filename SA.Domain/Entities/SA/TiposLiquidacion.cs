using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

/// <summary>
/// Almacena los diferentes conceptos usados para generar liquidaciones
/// </summary>
public partial class TiposLiquidacion
{
    public int TiposLiquidacionId { get; set; }

    public string CodigoIes { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public string? Fuente { get; set; }

    public virtual ICollection<Liquidacione> Liquidaciones { get; set; } = new List<Liquidacione>();
}
