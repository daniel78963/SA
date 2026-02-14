using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

public partial class Nota
{
    public int NotaId { get; set; }

    public int InscritosGrupoId { get; set; }

    public int PeriododId { get; set; }

    public int SeguimientoId { get; set; }

    public decimal Nota1 { get; set; }

    public string? Usuario { get; set; }

    public DateTime? FechaCreacion { get; set; }

    public virtual InscritosxGruposxAsignatura InscritosGrupo { get; set; } = null!;

    public virtual ICollection<NovedadesNotasDetalle> NovedadesNotasDetalles { get; set; } = new List<NovedadesNotasDetalle>();

    public virtual Periodo Periodod { get; set; } = null!;

    public virtual ProgramacionEvaluacion Seguimiento { get; set; } = null!;
}
