using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

public partial class RecaudosDetalle
{
    public int RecaudoDetalleId { get; set; }

    public int? RecaudoId { get; set; }

    public string? RegistroDetalle { get; set; }

    public string? TipoRegistroDetalle { get; set; }

    public string? Secuencia { get; set; }

    public string? CodigoSucursal { get; set; }

    public decimal? ValorRecaudado { get; set; }

    public string? ReferenciaUsuario { get; set; }

    public string? DatosAdicionales { get; set; }

    public int? LiquidacionId { get; set; }

    public virtual Liquidacione? Liquidacion { get; set; }

    public virtual Recaudo? Recaudo { get; set; }
}
