using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

public partial class Grupo
{
    public int GrupoId { get; set; }

    public int AsignaturasxProgramaId { get; set; }

    public string DescripcionGrupo { get; set; } = null!;

    public string? Estado { get; set; }

    public int JornadaId { get; set; }

    public int? DocenteAsignaturaId { get; set; }

    public int Cupo { get; set; }

    public int PeriodoId { get; set; }

    public int? NumeroDias { get; set; }

    public string? Usuario { get; set; }

    public DateTime? FechaModificacion { get; set; }

    public string? UsuarioSolape { get; set; }

    public DateTime? FechaSolape { get; set; }

    public int? ModalidadCategoriaId { get; set; }

    public virtual ICollection<AdicionesxGruposxAsignatura> AdicionesxGruposxAsignaturas { get; set; } = new List<AdicionesxGruposxAsignatura>();

    public virtual AsignaturasxPrograma AsignaturasxPrograma { get; set; } = null!;

    public virtual ICollection<AutoevaluacionToolValue> AutoevaluacionToolValues { get; set; } = new List<AutoevaluacionToolValue>();

    public virtual ICollection<CalificacionToolValue> CalificacionToolValues { get; set; } = new List<CalificacionToolValue>();

    public virtual DocentesxAsignatura? DocenteAsignatura { get; set; }

    public virtual ICollection<GruposPlane> GruposPlanes { get; set; } = new List<GruposPlane>();

    public virtual ICollection<HerramientasxGrupo> HerramientasxGrupos { get; set; } = new List<HerramientasxGrupo>();

    public virtual ICollection<HorariosxGrupo> HorariosxGrupos { get; set; } = new List<HorariosxGrupo>();

    public virtual ICollection<InscritosxGruposxAsignatura> InscritosxGruposxAsignaturas { get; set; } = new List<InscritosxGruposxAsignatura>();

    public virtual TiposJornada Jornada { get; set; } = null!;

    public virtual ModalidadesCategoria? ModalidadCategoria { get; set; }

    public virtual ICollection<NovedadesNotasDetalle> NovedadesNotasDetalles { get; set; } = new List<NovedadesNotasDetalle>();

    public virtual Periodo Periodo { get; set; } = null!;

    public virtual ICollection<ProgramacionEvaluacion> ProgramacionEvaluacions { get; set; } = new List<ProgramacionEvaluacion>();
}
