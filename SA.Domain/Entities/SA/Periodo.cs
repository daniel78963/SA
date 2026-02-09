using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

public partial class Periodo
{
    public int PeriodoId { get; set; }

    public string AnoCohorte { get; set; } = null!;

    public string SemestreCohorte { get; set; } = null!;

    public DateOnly FechaInicio { get; set; }

    public DateOnly FechaFin { get; set; }

    public string Campo { get; set; } = null!;

    public int? Orden { get; set; }

    public bool? Mostrar { get; set; }

    public virtual ICollection<AdicionesxGruposxAsignatura> AdicionesxGruposxAsignaturas { get; set; } = new List<AdicionesxGruposxAsignatura>();

    public virtual ICollection<Admitido> Admitidos { get; set; } = new List<Admitido>();

    public virtual ICollection<AutoevaluacionToolValue> AutoevaluacionToolValues { get; set; } = new List<AutoevaluacionToolValue>();

    public virtual ICollection<Calendario> Calendarios { get; set; } = new List<Calendario>();

    public virtual ICollection<CalificacionToolValue> CalificacionToolValues { get; set; } = new List<CalificacionToolValue>();

    public virtual ICollection<CambiosProgramasJornada> CambiosProgramasJornada { get; set; } = new List<CambiosProgramasJornada>();

    public virtual ICollection<Deuda> Deuda { get; set; } = new List<Deuda>();

    public virtual ICollection<DocentesxAsignatura> DocentesxAsignaturas { get; set; } = new List<DocentesxAsignatura>();

    public virtual ICollection<Entrevista> Entrevista { get; set; } = new List<Entrevista>();

    public virtual ICollection<Grupo> Grupos { get; set; } = new List<Grupo>();

    public virtual ICollection<HistorialInasistencium> HistorialInasistencia { get; set; } = new List<HistorialInasistencium>();

    public virtual ICollection<HistoricoNota> HistoricoNota { get; set; } = new List<HistoricoNota>();

    public virtual ICollection<Homologacione> Homologaciones { get; set; } = new List<Homologacione>();

    public virtual ICollection<HomologacionesDetalle> HomologacionesDetalles { get; set; } = new List<HomologacionesDetalle>();

    public virtual ICollection<HorariosxDisponibilidadDocente> HorariosxDisponibilidadDocentes { get; set; } = new List<HorariosxDisponibilidadDocente>();

    public virtual ICollection<Inscripcione> Inscripciones { get; set; } = new List<Inscripcione>();

    public virtual ICollection<InscripcionesResumenAcademico> InscripcionesResumenAcademicoPeriodoIdPrimeraMatriculaNavigations { get; set; } = new List<InscripcionesResumenAcademico>();

    public virtual ICollection<InscripcionesResumenAcademico> InscripcionesResumenAcademicoPeriodoIdUltimaMatriculaNavigations { get; set; } = new List<InscripcionesResumenAcademico>();

    public virtual ICollection<Liquidacione> Liquidaciones { get; set; } = new List<Liquidacione>();

    public virtual ICollection<Matricula> Matriculas { get; set; } = new List<Matricula>();

    public virtual ICollection<MatriculasAcceso> MatriculasAccesos { get; set; } = new List<MatriculasAcceso>();

    public virtual ICollection<Multimedium> Multimedia { get; set; } = new List<Multimedium>();

    public virtual ICollection<MultimediaMatriculaContrato> MultimediaMatriculaContratos { get; set; } = new List<MultimediaMatriculaContrato>();

    public virtual ICollection<Nota> Nota { get; set; } = new List<Nota>();

    public virtual ICollection<NovedadesNota> NovedadesNota { get; set; } = new List<NovedadesNota>();

    public virtual ICollection<OcupacionxDocente> OcupacionxDocentes { get; set; } = new List<OcupacionxDocente>();

    public virtual ICollection<PersonasxRequisitosxProceso> PersonasxRequisitosxProcesos { get; set; } = new List<PersonasxRequisitosxProceso>();

    public virtual ICollection<ProgramacionEvaluacion> ProgramacionEvaluacions { get; set; } = new List<ProgramacionEvaluacion>();

    public virtual ICollection<Recaudo> Recaudos { get; set; } = new List<Recaudo>();

    public virtual ICollection<SolicitudesCancelacion> SolicitudesCancelacions { get; set; } = new List<SolicitudesCancelacion>();

    public virtual ICollection<Suficiencia> Suficiencia { get; set; } = new List<Suficiencia>();

    public virtual ICollection<TipoEvaluacion> TipoEvaluacions { get; set; } = new List<TipoEvaluacion>();
}
