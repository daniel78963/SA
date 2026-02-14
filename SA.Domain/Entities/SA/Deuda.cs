using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

public partial class Deuda
{
    public int DeudaId { get; set; }

    public int PersonaId { get; set; }

    public DateTime? FechaDeuda { get; set; }

    public int? TipoDeudaId { get; set; }

    public string? Descripcion { get; set; }

    public DateTime? FechaPago { get; set; }

    public string? ObservacionPago { get; set; }

    public int? EstadoDeudaId { get; set; }

    public string? Documento { get; set; }

    public string? CodigoCcostos { get; set; }

    public string? NombreCcostos { get; set; }

    public string? CodigoArticulo { get; set; }

    public string? Articulo { get; set; }

    public decimal? Valor { get; set; }

    public decimal? Saldo { get; set; }

    public int? Iesid { get; set; }

    public int? PeriodoId { get; set; }

    public string? SEstado { get; set; }

    public string? SMensaje { get; set; }

    public string? SFuente { get; set; }

    public string? SIdentificador { get; set; }

    public string? SNumDocumento { get; set; }

    public string? Usuario { get; set; }

    public DateTime? FechaModificacion { get; set; }

    public int? InscripcionId { get; set; }

    public int? Cantidad { get; set; }

    public virtual Estado? EstadoDeuda { get; set; }

    public virtual Ie? Ies { get; set; }

    public virtual Inscripcione? Inscripcion { get; set; }

    public virtual Periodo? Periodo { get; set; }

    public virtual Persona Persona { get; set; } = null!;

    public virtual TiposDeuda? TipoDeuda { get; set; }
}
