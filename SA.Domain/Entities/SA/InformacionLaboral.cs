using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

public partial class InformacionLaboral
{
    public int InformacionLaboralId { get; set; }

    public int PersonaId { get; set; }

    public int? EstadoLaboral { get; set; }

    public string? Empresa { get; set; }

    public string? Cargo { get; set; }

    public string? Telefono { get; set; }

    public string? JefeInmediato { get; set; }

    public int? TipoTrabajoId { get; set; }

    public string? RangoIngreso { get; set; }

    public int? Duracion { get; set; }

    public DateOnly FechaIngreso { get; set; }

    public virtual Duracion? DuracionNavigation { get; set; }

    public virtual Persona Persona { get; set; } = null!;

    public virtual TiposTrabajo? TipoTrabajo { get; set; }
}
