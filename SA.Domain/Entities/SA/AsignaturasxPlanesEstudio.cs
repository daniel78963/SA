using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

public partial class AsignaturasxPlanesEstudio
{
    public int PlanEstudioAsignaturaId { get; set; }

    public int PlanEstudioId { get; set; }

    public int AsignaturasxProgramaId { get; set; }

    public int NumeroCreditos { get; set; }

    public int HorasIndependiente { get; set; }

    public int HorasActividadPresencial { get; set; }

    public string Estado { get; set; } = null!;

    public int Nivel { get; set; }

    public int TipoAsignaturaId { get; set; }

    public DateTime FechaIngreso { get; set; }

    public bool? LineaProfundizacion { get; set; }

    public int? PlanEstudioAsignaturaPadreId { get; set; }

    public int? LineaProfundizacionId { get; set; }

    public bool? EstadoEspecialDesercion { get; set; }

    public string? Usuario { get; set; }

    public int? MinimoCreditosPrerequisito { get; set; }

    public virtual ICollection<AsignaturasRelacionada> AsignaturasRelacionadaAsignaturaIdRelacionNavigations { get; set; } = new List<AsignaturasRelacionada>();

    public virtual ICollection<AsignaturasRelacionada> AsignaturasRelacionadaPlanEstudioAsignaturas { get; set; } = new List<AsignaturasRelacionada>();

    public virtual ICollection<AsignaturasRelacionale> AsignaturasRelacionalePlanEstudioAsignaturaBases { get; set; } = new List<AsignaturasRelacionale>();

    public virtual ICollection<AsignaturasRelacionale> AsignaturasRelacionalePlanEstudioAsignaturaRelacionals { get; set; } = new List<AsignaturasRelacionale>();

    public virtual ICollection<AsignaturasxPlanesEstudioExcepcionesxInscripcione> AsignaturasxPlanesEstudioExcepcionesxInscripciones { get; set; } = new List<AsignaturasxPlanesEstudioExcepcionesxInscripcione>();

    public virtual AsignaturasxPrograma AsignaturasxPrograma { get; set; } = null!;

    public virtual ICollection<HistoricoNota> HistoricoNota { get; set; } = new List<HistoricoNota>();

    public virtual ICollection<HomologacionesDetalle> HomologacionesDetalles { get; set; } = new List<HomologacionesDetalle>();

    public virtual ICollection<LineasProfundizacion> LineasProfundizacions { get; set; } = new List<LineasProfundizacion>();

    public virtual PlanesEstudio PlanEstudio { get; set; } = null!;

    public virtual ICollection<Suficiencia> Suficiencia { get; set; } = new List<Suficiencia>();

    public virtual ICollection<SuficienciasxInscripcione> SuficienciasxInscripciones { get; set; } = new List<SuficienciasxInscripcione>();

    public virtual TipoAsignatura TipoAsignatura { get; set; } = null!;
}
