using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

public partial class Recaudo
{
    public int RecaudoId { get; set; }

    /// <summary>
    /// 1: Convenios (archivos planos) 2: Web - Pasarela
    /// </summary>
    public int? TipoRecaudoId { get; set; }

    public int? PeriodoId { get; set; }

    public int? Iesid { get; set; }

    public int? BancoId { get; set; }

    public string? NombreArchivo { get; set; }

    public DateTime? Fecha { get; set; }

    public string? RegistroEncabezadoLote { get; set; }

    public string? TipoRegistroEncabezado { get; set; }

    public string? NitFacturadora { get; set; }

    public string? NumeroCuenta { get; set; }

    public string? TipoCuenta { get; set; }

    public DateTime? FechaRecaudo { get; set; }

    public string? RegistroControlLote { get; set; }

    public string? TipoRegistroControl { get; set; }

    public string? TotalRegistrosLote { get; set; }

    public decimal? ValorTotalRecaudadoLote { get; set; }

    public int? RequestId { get; set; }

    public string? ProcessUrl { get; set; }

    public DateTime? FechaRequest { get; set; }

    public string? Reference { get; set; }

    public string? Status { get; set; }

    public string? Message { get; set; }

    public DateTime? FechaStatus { get; set; }

    public string? ReasonStatus { get; set; }

    public string? Authorization { get; set; }

    public string? Franchise { get; set; }

    public string? InternalReference { get; set; }

    public string? IssuerName { get; set; }

    public string? Receipt { get; set; }

    public string? PaymentMethod { get; set; }

    public string? PaymentMethodName { get; set; }

    public string? PaymentStatus { get; set; }

    public string? PaymentMessage { get; set; }

    public DateTime? PaymentFechaStatus { get; set; }

    public string? PaymentReason { get; set; }

    public bool? Sincronizar { get; set; }

    public virtual Banco? Banco { get; set; }

    public virtual Ie? Ies { get; set; }

    public virtual Periodo? Periodo { get; set; }

    public virtual ICollection<RecaudosDetalle> RecaudosDetalles { get; set; } = new List<RecaudosDetalle>();
}
