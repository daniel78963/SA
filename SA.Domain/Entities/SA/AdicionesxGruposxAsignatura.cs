using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

public partial class AdicionesxGruposxAsignatura
{
    public int AdicionGrupoId { get; set; }

    public int GrupoId { get; set; }

    public int InscripcionId { get; set; }

    /// <summary>
    /// 1: Pendiente, 2: Aprobada, 3:Rechazada
    /// </summary>
    public int EstadoAdicionId { get; set; }

    public int PeriodoId { get; set; }

    public int PlanEstudioAsignaturaId { get; set; }

    public DateTime FechaGeneracion { get; set; }

    public DateTime? FechaAprobacion { get; set; }

    public bool? Relacional { get; set; }

    public int? AsignaturaRelacionalId { get; set; }

    public int? PlanEstudioAsignaturaLineaHijaId { get; set; }

    public virtual AsignaturasRelacionale? AsignaturaRelacional { get; set; }

    public virtual Grupo Grupo { get; set; } = null!;

    public virtual Inscripcione Inscripcion { get; set; } = null!;

    public virtual Periodo Periodo { get; set; } = null!;
}
