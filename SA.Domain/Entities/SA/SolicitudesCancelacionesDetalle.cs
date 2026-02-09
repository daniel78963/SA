using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

public partial class SolicitudesCancelacionesDetalle
{
    public int SolicitudCancelacionDetalleId { get; set; }

    public int? SolicitudCancelacionId { get; set; }

    public int? HistoricoNotaId { get; set; }

    public virtual SolicitudesCancelacion? SolicitudCancelacion { get; set; }
}
