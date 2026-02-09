using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

/// <summary>
/// Contiene las diferentes liquidaciones que se han generado para una inscripción
/// </summary>
public partial class Liquidacione
{
    /// <summary>
    /// Consecutivo generado por el sistema
    /// </summary>
    public int LiquidacionId { get; set; }

    /// <summary>
    /// Contiene los diferentes tipos de liquidaciónes que se han generado para una inscripción: liquidación por pago de inscripción, matrícula y adiciones.
    /// </summary>
    public int TiposLiquidacionId { get; set; }

    /// <summary>
    /// Corresponde al Identificador de la inscripción, de la matrícula
    /// </summary>
    public int InscripcionId { get; set; }

    /// <summary>
    /// Fecha en la que se genera la liquidación
    /// </summary>
    public DateTime? FechaGeneracion { get; set; }

    /// <summary>
    /// Valor asociado a la liquidación generada
    /// </summary>
    public int? Valor { get; set; }

    /// <summary>
    /// Consecutivo que almacena el estado de la inscripción:  Pendiente de pago, pagada
    /// </summary>
    public int EstadoId { get; set; }

    /// <summary>
    /// Fecha en la que se paga el valor de la inscripción
    /// </summary>
    public DateOnly? FechaPago { get; set; }

    public int? EntrevistaId { get; set; }

    public string? ConceptoErp { get; set; }

    public int? PeriodoId { get; set; }

    public int? MatriculaId { get; set; }

    public decimal? Cobros { get; set; }

    public decimal? Iva { get; set; }

    public decimal? Descuentos { get; set; }

    public decimal? DescuentoComercial { get; set; }

    public decimal? Total { get; set; }

    public string? SEstado { get; set; }

    public string? SMensaje { get; set; }

    public DateOnly? ProntoPagoFechaVencimiento { get; set; }

    public decimal? ProntoPagoDescuentoPorcentaje { get; set; }

    public decimal? ProntoPagoDescuento { get; set; }

    public DateOnly? OrdinarioFechaVencimiento { get; set; }

    public DateOnly? ExtemporaneoFechaVencimiento { get; set; }

    public decimal? ExtemporaneoIncrementoPorcentaje { get; set; }

    public decimal? ExtemporaneoIncremento { get; set; }

    public string? SFuente { get; set; }

    public string? SIdentificador { get; set; }

    public string? SNumDocumento { get; set; }

    public string? SEstadoFactura { get; set; }

    public string? SMensajeFactura { get; set; }

    public string? SFuenteFactura { get; set; }

    public string? SIdentificadorFactura { get; set; }

    public string? SNumDocumentoFactura { get; set; }

    public DateTime? FechaGeneracionFactura { get; set; }

    public DateTime? ExtemporaneoDosFechaVencimiento { get; set; }

    public decimal? ExtemporaneoDosIncrementoPorcentaje { get; set; }

    public decimal? ExtemporaneoDosIncremento { get; set; }

    public int? RequestId { get; set; }

    public string? ProcessUrl { get; set; }

    public DateTime? FechaRequest { get; set; }

    public string? Reference { get; set; }

    public string? Usuario { get; set; }

    public DateTime? FechaModificacion { get; set; }

    public DateOnly? ProntoPagoUnoFechaVencimiento { get; set; }

    public decimal? ProntoPagoUnoDescuentoPorcentaje { get; set; }

    public decimal? ProntoPagoUnoDescuento { get; set; }

    public DateOnly? ProntoPagoDosFechaVencimiento { get; set; }

    public decimal? ProntoPagoDosDescuentoPorcentaje { get; set; }

    public decimal? ProntoPagoDosDescuento { get; set; }

    public string? SLMovimiento { get; set; }

    public virtual Estado Estado { get; set; } = null!;

    public virtual Inscripcione Inscripcion { get; set; } = null!;

    public virtual Matricula? Matricula { get; set; }

    public virtual Periodo? Periodo { get; set; }

    public virtual ICollection<RecaudosDetalle> RecaudosDetalles { get; set; } = new List<RecaudosDetalle>();

    public virtual TiposLiquidacion TiposLiquidacion { get; set; } = null!;
}
