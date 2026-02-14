using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

public partial class HomologacionesDetalle
{
    public int HomologacionDetalleId { get; set; }

    public int? HomologacionId { get; set; }

    public string? Asignatura { get; set; }

    public decimal? Nota { get; set; }

    public int? Creditos { get; set; }

    public string? Periodo { get; set; }

    public int? HistoricoNotaId { get; set; }

    public int? PlanEstudioAsignaturaId { get; set; }

    public decimal? NotaHomologada { get; set; }

    public int? PeriodoId { get; set; }

    public int? EstadoAsignaturaId { get; set; }

    public bool? NoHomologada { get; set; }

    public int? HistoricoNotaHomologadaId { get; set; }

    public DateTime? FechaModificacion { get; set; }

    public string? Usuario { get; set; }

    public virtual EstadoAsignatura? EstadoAsignatura { get; set; }

    public virtual HistoricoNota? HistoricoNota { get; set; }

    public virtual Homologacione? Homologacion { get; set; }

    public virtual Periodo? PeriodoNavigation { get; set; }

    public virtual AsignaturasxPlanesEstudio? PlanEstudioAsignatura { get; set; }
}
