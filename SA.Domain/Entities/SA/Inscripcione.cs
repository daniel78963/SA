using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

public partial class Inscripcione
{
    public int InscripcionId { get; set; }

    public DateTime FechaRegistro { get; set; }

    public int PersonaId { get; set; }

    public int? ModalidadId { get; set; }

    public int ProgramaId { get; set; }

    public int JornadaId { get; set; }

    public int PeriodoId { get; set; }

    public int CubrimientoId { get; set; }

    public string MedioDifusion { get; set; } = null!;

    public int? TipoInscripcionId { get; set; }

    public bool? Activa { get; set; }

    public int? ConsecutivoSemestral { get; set; }

    public int? AntiguedadId { get; set; }

    public string? NumeroFormulario { get; set; }

    public bool? Homologado { get; set; }

    public string? Observaciones { get; set; }

    public virtual ICollection<AdicionesxGruposxAsignatura> AdicionesxGruposxAsignaturas { get; set; } = new List<AdicionesxGruposxAsignatura>();

    public virtual ICollection<Admitido> Admitidos { get; set; } = new List<Admitido>();

    public virtual Antiguedade? Antiguedad { get; set; }

    public virtual ICollection<AsignaturasxPlanesEstudioExcepcionesxInscripcione> AsignaturasxPlanesEstudioExcepcionesxInscripciones { get; set; } = new List<AsignaturasxPlanesEstudioExcepcionesxInscripcione>();

    public virtual ICollection<CambiosProgramasJornada> CambiosProgramasJornada { get; set; } = new List<CambiosProgramasJornada>();

    public virtual ICollection<CertificadosExpedido> CertificadosExpedidos { get; set; } = new List<CertificadosExpedido>();

    public virtual CubrimientoxPrograma Cubrimiento { get; set; } = null!;

    public virtual ICollection<Deuda> Deuda { get; set; } = new List<Deuda>();

    public virtual ICollection<EntrevistasxInscripcion> EntrevistasxInscripcions { get; set; } = new List<EntrevistasxInscripcion>();

    public virtual ICollection<Graduando> Graduandos { get; set; } = new List<Graduando>();

    public virtual ICollection<HistorialEstadosInscripcione> HistorialEstadosInscripciones { get; set; } = new List<HistorialEstadosInscripcione>();

    public virtual ICollection<HistoricoNota> HistoricoNota { get; set; } = new List<HistoricoNota>();

    public virtual ICollection<Homologacione> Homologaciones { get; set; } = new List<Homologacione>();

    public virtual ICollection<InscripcionesResumenAcademico> InscripcionesResumenAcademicos { get; set; } = new List<InscripcionesResumenAcademico>();

    public virtual ICollection<InscripcionesxActasGrado> InscripcionesxActasGrados { get; set; } = new List<InscripcionesxActasGrado>();

    public virtual ICollection<InscripcionxProceso> InscripcionxProcesos { get; set; } = new List<InscripcionxProceso>();

    public virtual ICollection<InscritosxGruposxAsignatura> InscritosxGruposxAsignaturas { get; set; } = new List<InscritosxGruposxAsignatura>();

    public virtual TiposJornada Jornada { get; set; } = null!;

    public virtual ICollection<Liquidacione> Liquidaciones { get; set; } = new List<Liquidacione>();

    public virtual ICollection<Matricula> Matriculas { get; set; } = new List<Matricula>();

    public virtual ICollection<MatriculasAcceso> MatriculasAccesos { get; set; } = new List<MatriculasAcceso>();

    public virtual Modalidade? Modalidad { get; set; }

    public virtual Periodo Periodo { get; set; } = null!;

    public virtual Persona Persona { get; set; } = null!;

    public virtual ICollection<PersonasxRequisitosxProceso> PersonasxRequisitosxProcesos { get; set; } = new List<PersonasxRequisitosxProceso>();

    public virtual ICollection<PlanesEstudiosxInscripcion> PlanesEstudiosxInscripcions { get; set; } = new List<PlanesEstudiosxInscripcion>();

    public virtual Programa Programa { get; set; } = null!;

    public virtual ICollection<SolicitudesCancelacion> SolicitudesCancelacions { get; set; } = new List<SolicitudesCancelacion>();

    public virtual ICollection<Suficiencia> Suficiencia { get; set; } = new List<Suficiencia>();

    public virtual ICollection<SuficienciasxInscripcione> SuficienciasxInscripciones { get; set; } = new List<SuficienciasxInscripcione>();

    public virtual TiposInscripcion? TipoInscripcion { get; set; }
}
