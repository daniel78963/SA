using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

public partial class AsignaturasRelacionale
{
    public int AsignaturaRelacionalId { get; set; }

    public int PlanEstudioAsignaturaBaseId { get; set; }

    public int PlanEstudioAsignaturaRelacionalId { get; set; }

    public DateTime? FechaCreacion { get; set; }

    public DateTime? FechaUltimaModificacion { get; set; }

    public virtual ICollection<AdicionesxGruposxAsignatura> AdicionesxGruposxAsignaturas { get; set; } = new List<AdicionesxGruposxAsignatura>();

    public virtual ICollection<HistoricoNota> HistoricoNota { get; set; } = new List<HistoricoNota>();

    public virtual AsignaturasxPlanesEstudio PlanEstudioAsignaturaBase { get; set; } = null!;

    public virtual AsignaturasxPlanesEstudio PlanEstudioAsignaturaRelacional { get; set; } = null!;
}
