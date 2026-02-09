using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

public partial class Calendario
{
    public int CalendarioId { get; set; }

    public DateTime FechaInicio { get; set; }

    public DateTime FechaCierre { get; set; }

    public string NombreCalendario { get; set; } = null!;

    public string TipoCalendario { get; set; } = null!;

    public string PeriodoAcademico { get; set; } = null!;

    public int? PeriodoId { get; set; }

    public virtual ICollection<ActividadesCalendario> ActividadesCalendarios { get; set; } = new List<ActividadesCalendario>();

    public virtual Periodo? Periodo { get; set; }
}
