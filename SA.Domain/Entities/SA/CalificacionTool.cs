using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

public partial class CalificacionTool
{
    public int CalificacionToolId { get; set; }

    public string? Titulo { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Descripcion { get; set; }

    public string? EscalaExplicacion { get; set; }

    public string Estado { get; set; } = null!;

    public int? Version { get; set; }

    public int? EntidadEducacionId { get; set; }

    public int? TipoCalificacionToolId { get; set; }

    public bool? EscalasResultadosUnificadas { get; set; }

    public virtual ICollection<AutoevaluacionToolValue> AutoevaluacionToolValues { get; set; } = new List<AutoevaluacionToolValue>();

    public virtual ICollection<CalificacionToolValue> CalificacionToolValues { get; set; } = new List<CalificacionToolValue>();

    public virtual ICollection<CalificacionToolsxEntidadEducacion> CalificacionToolsxEntidadEducacions { get; set; } = new List<CalificacionToolsxEntidadEducacion>();

    public virtual ICollection<Criterio> Criterios { get; set; } = new List<Criterio>();

    public virtual ICollection<CriteriosCalificacion> CriteriosCalificacions { get; set; } = new List<CriteriosCalificacion>();

    public virtual Ie? EntidadEducacion { get; set; }

    public virtual ICollection<EscalasResultado> EscalasResultados { get; set; } = new List<EscalasResultado>();

    public virtual ICollection<Fase> Fases { get; set; } = new List<Fase>();

    public virtual ICollection<HerramientasxGrupo> HerramientasxGrupos { get; set; } = new List<HerramientasxGrupo>();

    public virtual TiposCalificacionTool? TipoCalificacionTool { get; set; }
}
