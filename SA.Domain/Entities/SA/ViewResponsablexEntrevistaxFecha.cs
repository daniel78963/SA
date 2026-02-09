using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

public partial class ViewResponsablexEntrevistaxFecha
{
    public int PersonaId { get; set; }

    public DateTime? FechaInicio { get; set; }

    public DateTime? FechaFin { get; set; }

    public int EstadoId { get; set; }
}
