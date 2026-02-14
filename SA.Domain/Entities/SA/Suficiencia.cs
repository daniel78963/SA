using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

public partial class Suficiencia
{
    public int SuficienciaId { get; set; }

    public int? RecursoFisicoId { get; set; }

    public int? EstadoId { get; set; }

    public DateTime? FechaInicio { get; set; }

    public DateTime? FechaFin { get; set; }

    public int? PeriodoId { get; set; }

    public int? OcupacionRecursoFisicoId { get; set; }

    public int? PersonaId { get; set; }

    public int? InscripcionId { get; set; }

    public int? PlanEstudioAsignaturaId { get; set; }

    public decimal? Nota { get; set; }

    public bool? NoAsentada { get; set; }

    public int? HistoricoNotaId { get; set; }

    public DateTime? FechaAsentamiento { get; set; }

    public int? PlanEstudioId { get; set; }

    public virtual HistoricoNota? HistoricoNota { get; set; }

    public virtual Inscripcione? Inscripcion { get; set; }

    public virtual OcupacionxRecursoFisico? OcupacionRecursoFisico { get; set; }

    public virtual Periodo? Periodo { get; set; }

    public virtual Persona? Persona { get; set; }

    public virtual PlanesEstudio? PlanEstudio { get; set; }

    public virtual AsignaturasxPlanesEstudio? PlanEstudioAsignatura { get; set; }

    public virtual RecursosFisico? RecursoFisico { get; set; }

    public virtual ICollection<SuficienciasxInscripcione> SuficienciasxInscripciones { get; set; } = new List<SuficienciasxInscripcione>();
}
