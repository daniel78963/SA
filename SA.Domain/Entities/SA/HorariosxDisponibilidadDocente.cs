using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

public partial class HorariosxDisponibilidadDocente
{
    public int HorariosDisponibilidadDocenteId { get; set; }

    public int DiaId { get; set; }

    public DateTime HoraInicio { get; set; }

    public DateTime HoraFin { get; set; }

    public int DisponibilidadDocenteId { get; set; }

    public int PeriodoId { get; set; }

    public virtual Dia Dia { get; set; } = null!;

    public virtual DisponibilidadDocente DisponibilidadDocente { get; set; } = null!;

    public virtual Periodo Periodo { get; set; } = null!;
}
