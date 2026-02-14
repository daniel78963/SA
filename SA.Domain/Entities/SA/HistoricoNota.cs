using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

public partial class HistoricoNota
{
    public int HistoricoNotaId { get; set; }

    public int InscripcionId { get; set; }

    public int PlanEstudioAsignaturaId { get; set; }

    public decimal Nota { get; set; }

    public int EstadoAsignaturaId { get; set; }

    public int PeriodoId { get; set; }

    public int? GrupoId { get; set; }

    public bool? Relacional { get; set; }

    public int? AsignaturaRelacionalId { get; set; }

    public int? PlanEstudioAsignaturaLineaHijaId { get; set; }

    public int? MatriculaId { get; set; }

    public decimal? NotaAnversa { get; set; }

    public int? PlanEstudioAsignaturaLineaPadreId { get; set; }

    public string? Usuario { get; set; }

    public DateTime? FechaModificacion { get; set; }

    public string? UsuarioCierreSemestre { get; set; }

    public DateTime? FechaCierreSemestre { get; set; }

    public virtual AsignaturasRelacionale? AsignaturaRelacional { get; set; }

    public virtual EstadoAsignatura EstadoAsignatura { get; set; } = null!;

    public virtual ICollection<HomologacionesDetalle> HomologacionesDetalles { get; set; } = new List<HomologacionesDetalle>();

    public virtual Inscripcione Inscripcion { get; set; } = null!;

    public virtual Matricula? Matricula { get; set; }

    public virtual Periodo Periodo { get; set; } = null!;

    public virtual AsignaturasxPlanesEstudio PlanEstudioAsignatura { get; set; } = null!;

    public virtual ICollection<Suficiencia> Suficiencia { get; set; } = new List<Suficiencia>();
}
