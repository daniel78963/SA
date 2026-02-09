using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

public partial class RecaudosConfiguracionesSeccione
{
    public int RecaudoConfiguracionSeccionesId { get; set; }

    public int? RecaudoConfiguracionId { get; set; }

    public string? NombreSeccion { get; set; }

    public int? Orden { get; set; }

    public bool Activo { get; set; }

    /// <summary>
    /// Si es desconocido se coloca en 0 (cero)
    /// </summary>
    public int? CantidadLineas { get; set; }

    /// <summary>
    /// Separados por , Ej: 2,5,6,7
    /// </summary>
    public string? LineasSinImportancia { get; set; }

    public virtual RecaudosConfiguracione? RecaudoConfiguracion { get; set; }

    public virtual ICollection<RecaudosConfiguracionesSeccionesDetalle> RecaudosConfiguracionesSeccionesDetalles { get; set; } = new List<RecaudosConfiguracionesSeccionesDetalle>();
}
