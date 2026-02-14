using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

public partial class SolicitudesCancelacion
{
    public int SolicitudCancelacionId { get; set; }

    public int InscripcionId { get; set; }

    public int PeriodoId { get; set; }

    public int EstadoSolicitudId { get; set; }

    public DateTime FechaGeneracion { get; set; }

    public DateTime? FechaAprobacion { get; set; }

    public bool Solicitud { get; set; }

    public int NumeroCreditos { get; set; }

    public int? LiquidacionId { get; set; }

    public string? UsuarioSolicitud { get; set; }

    public string? UsuarioAprobacion { get; set; }

    public string? Observaciones { get; set; }

    public string? TipoCancelacion { get; set; }

    public bool? RevisionBienestar { get; set; }

    public string? ObservacionesBienestar { get; set; }

    public string? UsuarioBienestar { get; set; }

    public DateTime? FechaBienestar { get; set; }

    public bool? Asentada { get; set; }

    public string? UsuarioAsentada { get; set; }

    public DateTime? FechaAsentada { get; set; }

    public virtual Estado EstadoSolicitud { get; set; } = null!;

    public virtual Inscripcione Inscripcion { get; set; } = null!;

    public virtual Periodo Periodo { get; set; } = null!;

    public virtual ICollection<SolicitudesCancelacionesDetalle> SolicitudesCancelacionesDetalles { get; set; } = new List<SolicitudesCancelacionesDetalle>();
}
