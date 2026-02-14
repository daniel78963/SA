using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

public partial class EntrevistasAsignada
{
    public int EntrevistaAsignadaId { get; set; }

    public int DisponibilidadEntrevistaId { get; set; }

    public int AspiranteId { get; set; }

    public string Periodo { get; set; } = null!;

    public virtual DisponibilidadEntrevista DisponibilidadEntrevista { get; set; } = null!;
}
