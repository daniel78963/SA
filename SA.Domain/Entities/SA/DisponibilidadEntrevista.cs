using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

public partial class DisponibilidadEntrevista
{
    public int DisponibilidadEntrevistaId { get; set; }

    public int PersonaId { get; set; }

    public DateTime Horario { get; set; }

    public string Estado { get; set; } = null!;

    public string Periodo { get; set; } = null!;

    public virtual ICollection<EntrevistasAsignada> EntrevistasAsignada { get; set; } = new List<EntrevistasAsignada>();
}
