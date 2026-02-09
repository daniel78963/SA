using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

public partial class HistorialInasistencium
{
    public int HistorialInasistenciaId { get; set; }

    public int InscritosGrupoId { get; set; }

    public int InscripcionId { get; set; }

    public DateTime FechaInasistencia { get; set; }

    public string? Usuario { get; set; }

    public DateTime? FechaModificacion { get; set; }

    public int? PeriodoId { get; set; }

    public virtual InscritosxGruposxAsignatura InscritosGrupo { get; set; } = null!;

    public virtual Periodo? Periodo { get; set; }
}
