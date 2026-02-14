using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

public partial class ProgramacionEvaluacion
{
    public int SeguimientoId { get; set; }

    public int GrupoId { get; set; }

    public int TipoEvaluacionId { get; set; }

    public int PeriodoId { get; set; }

    public decimal PorcentajeEvaluacion { get; set; }

    public string CriterioEvaluacion { get; set; } = null!;

    public string Instrumento { get; set; } = null!;

    public string Evidencia { get; set; } = null!;

    public string? Observaciones { get; set; }

    public DateTime FechaEvaluacion { get; set; }

    public string? Usuario { get; set; }

    public DateTime? FechaCreacion { get; set; }

    public virtual Grupo Grupo { get; set; } = null!;

    public virtual ICollection<Nota> Nota { get; set; } = new List<Nota>();

    public virtual Periodo Periodo { get; set; } = null!;

    public virtual TipoEvaluacion TipoEvaluacion { get; set; } = null!;
}
