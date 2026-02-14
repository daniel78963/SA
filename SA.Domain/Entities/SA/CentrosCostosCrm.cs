using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

public partial class CentrosCostosCrm
{
    public int CentroCostoId { get; set; }

    public string? NombreCentroCostos { get; set; }

    public string? CodigoCentroCostos { get; set; }

    public int? ProgramaId { get; set; }

    public decimal? Valor { get; set; }

    public string? CodigoArticuloPrimerSemestre { get; set; }

    public string? CodigoArticuloSegundoSemestre { get; set; }

    public string? CodigoArticuloSeguroPrimerSemestre { get; set; }

    public string? CodigoArticuloSeguroSegundoSemestre { get; set; }

    public decimal? ValorSeguro { get; set; }

    public bool CobroSeguro { get; set; }

    public DateOnly? ProntoPagoFechaVencimiento { get; set; }

    public int? ProntoPagoDescuentoProcentaje { get; set; }

    public DateOnly? OrdinarioFechaVencimiento { get; set; }

    public DateOnly? ExtemporaneoFechaVencimiento { get; set; }

    public int? ExtemporaneoIncrementoProcentaje { get; set; }

    public string? CodigoArticuloExtemporaneoPrimerSemestre { get; set; }

    public string? CodigoArticuloExtemporaneoSegundoSemestre { get; set; }

    public DateOnly? ExtemporaneoDosFechaVencimiento { get; set; }

    public int? ExtemporaneoDosIncrementoProcentaje { get; set; }

    public string? CodigoArticuloExtemporaneoDosPrimerSemestre { get; set; }

    public string? CodigoArticuloExtemporaneoDosSegundoSemestre { get; set; }

    public string? KaNiCuentaBanco { get; set; }

    public string? CodigoArticuloProntoPagoPrimerSemestre { get; set; }

    public string? CodigoArticuloProntoPagoSegundoSemestre { get; set; }

    public DateOnly? ProntoPagoUnoFechaVencimiento { get; set; }

    public int? ProntoPagoUnoDescuentoProcentaje { get; set; }

    public string? CodigoArticuloProntoPagoUnoPrimerSemestre { get; set; }

    public string? CodigoArticuloProntoPagoUnoSegundoSemestre { get; set; }

    public DateOnly? ProntoPagoDosFechaVencimiento { get; set; }

    public int? ProntoPagoDosDescuentoProcentaje { get; set; }

    public string? CodigoArticuloProntoPagoDosPrimerSemestre { get; set; }

    public string? CodigoArticuloProntoPagoDosSegundoSemestre { get; set; }

    public int? EntidadEducacionId { get; set; }

    public virtual ICollection<CentrosCostosCrmxArticulo> CentrosCostosCrmxArticulos { get; set; } = new List<CentrosCostosCrmxArticulo>();

    public virtual Ie? EntidadEducacion { get; set; }

    public virtual Programa? Programa { get; set; }
}
