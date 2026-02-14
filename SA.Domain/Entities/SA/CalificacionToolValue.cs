using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

public partial class CalificacionToolValue
{
    public int CalificacionToolValuesId { get; set; }

    public int? CalificacionToolId { get; set; }

    public string Usuario { get; set; } = null!;

    public DateTime FechaCreacion { get; set; }

    public string? Observaciones { get; set; }

    public string UserCreated { get; set; } = null!;

    public int? GrupoId { get; set; }

    public int? PeriodoId { get; set; }

    public int? Nivel { get; set; }

    public int? EntidadEducacionId { get; set; }

    public int? AreaNucleoId { get; set; }

    public virtual AreasNucleo? AreaNucleo { get; set; }

    public virtual ICollection<CalificacionTooValuexPrograma> CalificacionTooValuexProgramas { get; set; } = new List<CalificacionTooValuexPrograma>();

    public virtual CalificacionTool? CalificacionTool { get; set; }

    public virtual ICollection<CalificacionToolValuesDetail> CalificacionToolValuesDetails { get; set; } = new List<CalificacionToolValuesDetail>();

    public virtual ICollection<CalificacionToolValuesxEgresado> CalificacionToolValuesxEgresados { get; set; } = new List<CalificacionToolValuesxEgresado>();

    public virtual Ie? EntidadEducacion { get; set; }

    public virtual Grupo? Grupo { get; set; }

    public virtual Periodo? Periodo { get; set; }
}
