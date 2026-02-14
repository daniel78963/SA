using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

public partial class NovedadesNotasDetalle
{
    public int NovedadNotaDetalleId { get; set; }

    public int NovedadNotaId { get; set; }

    public int? GrupoId { get; set; }

    public int? InscritosGrupoId { get; set; }

    public int? NotaId { get; set; }

    public int? TipoEvaluacionId { get; set; }

    public decimal? NotaNueva { get; set; }

    public virtual Grupo? Grupo { get; set; }

    public virtual InscritosxGruposxAsignatura? InscritosGrupo { get; set; }

    public virtual Nota? Nota { get; set; }

    public virtual NovedadesNota NovedadNota { get; set; } = null!;

    public virtual TipoEvaluacion? TipoEvaluacion { get; set; }
}
