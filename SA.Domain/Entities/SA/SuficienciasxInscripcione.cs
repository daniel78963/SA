using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

public partial class SuficienciasxInscripcione
{
    public int SuficienciaInscripcionId { get; set; }

    public int? SuficienciaId { get; set; }

    public int? InscripcionId { get; set; }

    public int? PlanEstudioAsignaturaId { get; set; }

    public decimal? Nota { get; set; }

    public bool? NoAsentada { get; set; }

    public int? HistoricoNotaId { get; set; }

    public virtual Inscripcione? Inscripcion { get; set; }

    public virtual AsignaturasxPlanesEstudio? PlanEstudioAsignatura { get; set; }

    public virtual Suficiencia? Suficiencia { get; set; }
}
