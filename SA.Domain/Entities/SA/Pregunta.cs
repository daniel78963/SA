using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

public partial class Pregunta
{
    public int PreguntaId { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Descripcion { get; set; }

    public decimal Peso { get; set; }

    public int CriterioId { get; set; }

    public string TipoPregunta { get; set; } = null!;

    public int? Orden { get; set; }

    public int? OrdenReal { get; set; }

    public virtual ICollection<AutoevaluacionToolValuesDetail> AutoevaluacionToolValuesDetails { get; set; } = new List<AutoevaluacionToolValuesDetail>();

    public virtual ICollection<CalificacionToolValuesDetail> CalificacionToolValuesDetails { get; set; } = new List<CalificacionToolValuesDetail>();

    public virtual Criterio Criterio { get; set; } = null!;

    public virtual ICollection<EscalasResultado> EscalasResultados { get; set; } = new List<EscalasResultado>();
}
