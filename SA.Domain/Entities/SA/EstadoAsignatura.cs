using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

public partial class EstadoAsignatura
{
    public int EstadoAsignaturaId { get; set; }

    public string Descripcion { get; set; } = null!;

    public virtual ICollection<AsignaturasxPrograma> AsignaturasxProgramas { get; set; } = new List<AsignaturasxPrograma>();

    public virtual ICollection<HistoricoNota> HistoricoNota { get; set; } = new List<HistoricoNota>();

    public virtual ICollection<HomologacionesDetalle> HomologacionesDetalles { get; set; } = new List<HomologacionesDetalle>();
}
