using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

public partial class CentrosCostosCrmxArticulo
{
    public int CentroCostoCrmxArticuloId { get; set; }

    public int? CentroCostoId { get; set; }

    public int? Semestre { get; set; }

    public string? BecaCategoria { get; set; }

    public string? Articulo { get; set; }

    /// <summary>
    /// Es como se quiere que quede la descripción de la factura. Ej: DERECHOS DE MATRICULA SEMESTRE N° 1 - CLIENTES
    /// </summary>
    public string? DetalleArticulo { get; set; }

    /// <summary>
    /// La forma en como se hace el cobro es por creditos o matricula completa
    /// </summary>
    public string? Tipo { get; set; }

    public virtual CentrosCostosCrm? CentroCosto { get; set; }
}
