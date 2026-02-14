using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

public partial class ViewEstudiantesProgramacionEvaluacion
{
    public int? SeguimientoId { get; set; }

    public string? NombreTipoEvaluacion { get; set; }

    public decimal? PorcentajeEvaluacion { get; set; }

    public string? Instrumento { get; set; }

    public string? CriterioEvaluacion { get; set; }

    public string? Evidencia { get; set; }

    public string? Observaciones { get; set; }

    public DateTime? FechaEvaluacion { get; set; }

    public int DocenteId { get; set; }

    public int PersonaId { get; set; }

    public int DocentesAsignaturaId { get; set; }

    public int AsignaturasxProgramaId { get; set; }

    public int GrupoId { get; set; }

    public string DescripcionGrupo { get; set; } = null!;

    public string NombreAsignaturaGrupo { get; set; } = null!;

    public int PeriodoId { get; set; }

    public string? NombrePeriodo { get; set; }

    public int ProgramaId { get; set; }

    public string NombrePrograma { get; set; } = null!;

    public decimal? Nota { get; set; }

    public int? InscritosGrupoId { get; set; }

    public int InscripcionId { get; set; }

    public int EstudianteId { get; set; }
}
