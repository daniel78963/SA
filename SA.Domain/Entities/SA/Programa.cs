using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

public partial class Programa
{
    public int ProgramaId { get; set; }

    public int ProconsecutivoPrograma { get; set; }

    public string CodigoProgramaIes { get; set; } = null!;

    public string NombrePrograma { get; set; } = null!;

    public string? UrlInformacionPrograma { get; set; }

    public string? ActoAdministrativo { get; set; }

    public int UnidadOrganizacionalId { get; set; }

    public int AreaConocimientoId { get; set; }

    public int Nbcid { get; set; }

    /// <summary>
    /// 01-pregrado 02-posgrado
    /// </summary>
    public int? NivelPrograma { get; set; }

    public int? SubNivelPrograma { get; set; }

    public int ModalidadId { get; set; }

    /// <summary>
    /// 01-SI 02-NO
    /// </summary>
    public bool CicloPropedeutico { get; set; }

    public string? CodigoNivelSuperior { get; set; }

    public int PeriodicidadId { get; set; }

    public int? NumPeriodos { get; set; }

    /// <summary>
    /// 01-presencial 02-Distancia
    /// </summary>
    public string Metodologia { get; set; } = null!;

    public int? NumeroCreditos { get; set; }

    public int EstadoProgramaId { get; set; }

    public int? JustificacionId { get; set; }

    public int TipoAcreditacionId { get; set; }

    public DateTime? FechaAcreditacion { get; set; }

    public int? DuracionAnos { get; set; }

    public string? EntidadAcreditacionInternacional { get; set; }

    public DateTime? FechaAcreditacionInternacional { get; set; }

    public int? DuracionAcreditacionInternacional { get; set; }

    public string Titulo { get; set; } = null!;

    public string? UrlPerfilAspirante { get; set; }

    public string? UrlPerfilProfesionalPrograma { get; set; }

    public bool Revision { get; set; }

    public int? Orden { get; set; }

    public virtual AreasNbc AreaConocimiento { get; set; } = null!;

    public virtual ICollection<AreasConocimientoXprograma> AreasConocimientoXprogramas { get; set; } = new List<AreasConocimientoXprograma>();

    public virtual ICollection<AreasNucleo> AreasNucleos { get; set; } = new List<AreasNucleo>();

    public virtual ICollection<AreasNucleosxPrograma> AreasNucleosxProgramas { get; set; } = new List<AreasNucleosxPrograma>();

    public virtual ICollection<AsignaturasxPrograma> AsignaturasxProgramas { get; set; } = new List<AsignaturasxPrograma>();

    public virtual ICollection<AsignaturasxProgramaxSubgrupo> AsignaturasxProgramaxSubgrupos { get; set; } = new List<AsignaturasxProgramaxSubgrupo>();

    public virtual ICollection<AutoevaluacionToolValuexPrograma> AutoevaluacionToolValuexProgramas { get; set; } = new List<AutoevaluacionToolValuexPrograma>();

    public virtual ICollection<CalificacionTooValuexPrograma> CalificacionTooValuexProgramas { get; set; } = new List<CalificacionTooValuexPrograma>();

    public virtual ICollection<CambiosProgramasJornada> CambiosProgramasJornadaProgramaActuals { get; set; } = new List<CambiosProgramasJornada>();

    public virtual ICollection<CambiosProgramasJornada> CambiosProgramasJornadaProgramaCambios { get; set; } = new List<CambiosProgramasJornada>();

    public virtual ICollection<CentrosCostosCrm> CentrosCostosCrms { get; set; } = new List<CentrosCostosCrm>();

    public virtual ICollection<CubrimientoxPrograma> CubrimientoxProgramas { get; set; } = new List<CubrimientoxPrograma>();

    public virtual ICollection<Entrevista> Entrevista { get; set; } = new List<Entrevista>();

    public virtual EstadosPrograma EstadoPrograma { get; set; } = null!;

    public virtual ICollection<Homologacione> HomologacioneProgramaHomologacions { get; set; } = new List<Homologacione>();

    public virtual ICollection<Homologacione> HomologacioneProgramaNavigations { get; set; } = new List<Homologacione>();

    public virtual ICollection<Inscripcione> Inscripciones { get; set; } = new List<Inscripcione>();

    public virtual Justificacione? Justificacion { get; set; }

    public virtual Modalidade Modalidad { get; set; } = null!;

    public virtual Nbc Nbc { get; set; } = null!;

    public virtual ICollection<OcupacionxDocente> OcupacionxDocentes { get; set; } = new List<OcupacionxDocente>();

    public virtual Periodicidade Periodicidad { get; set; } = null!;

    public virtual ICollection<PlanesEstudio> PlanesEstudios { get; set; } = new List<PlanesEstudio>();

    public virtual ICollection<ProgramasxProgramasCrm> ProgramasxProgramasCrms { get; set; } = new List<ProgramasxProgramasCrm>();

    public virtual ICollection<ProgramasxTiposJornada> ProgramasxTiposJornada { get; set; } = new List<ProgramasxTiposJornada>();

    public virtual TipoAcreditacion TipoAcreditacion { get; set; } = null!;

    public virtual ICollection<TipoEvaluacion> TipoEvaluacions { get; set; } = new List<TipoEvaluacion>();

    public virtual UnidadOrganizacional UnidadOrganizacional { get; set; } = null!;
}
