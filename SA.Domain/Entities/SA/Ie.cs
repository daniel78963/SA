using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

/// <summary>
/// Información de la Entidad de Educación Superior
/// </summary>
public partial class Ie
{
    public int EntidadEducacionId { get; set; }

    /// <summary>
    /// Identificación única de cada una de las Instituciones de Educación Superior, este código es asignado por el Ministerio de Educación Nacional
    /// </summary>
    public string CodigoIes { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    /// <summary>
    /// 01: Si es sede principal 02: s
    /// </summary>
    public bool Principal { get; set; }

    /// <summary>
    /// En el caso de que la IES no sea principal, debe ir el código de la IES padre
    /// </summary>
    public int? CodigoIesprincipal { get; set; }

    public string RazonSocial { get; set; } = null!;

    /// <summary>
    /// Es la identificación que otorga la administración tributaria como contribuyente
    /// </summary>
    public string Nit { get; set; } = null!;

    public string? Direccion { get; set; }

    public string? Telefono { get; set; }

    /// <summary>
    /// Indica el origen  de las instituciones de educación superior, según su fuente de creación.
    /// </summary>
    public int OrdenId { get; set; }

    /// <summary>
    /// Indica el carácter de las instituciones.
    /// </summary>
    public int CaracterAcademicoId { get; set; }

    /// <summary>
    /// Fecha en la cual nació jurídicamente la Institución de Educación Superior.
    /// </summary>
    public DateTime? FechaCreacion { get; set; }

    /// <summary>
    /// Dirección en Internet donde se pueda consultar el documento que define la Misión de la Institución. 
    /// </summary>
    public string? UrlPaginaIstitucional { get; set; }

    /// <summary>
    /// Normativa mediante la cual se le dió vida jurídica a la Institución de Educación Superior, en su calidad de tal.   
    /// </summary>
    public string NormaCreacion { get; set; } = null!;

    public int TipoNormaLegalId { get; set; }

    /// <summary>
    /// Número que identifica la norma anteriormente mencionada.
    /// </summary>
    public int Numero { get; set; }

    public DateTime FechaNorma { get; set; }

    public string AutoridadExpide { get; set; } = null!;

    public string UrlNorma { get; set; } = null!;

    public string EstatutoGeneral { get; set; } = null!;

    public string UrlEstatutoGeneral { get; set; } = null!;

    public string EstatutoDocente { get; set; } = null!;

    public string UrlEstatutoDocente { get; set; } = null!;

    public string ReglamentoEstudiantil { get; set; } = null!;

    public string UrlReglamentoEstudiantil { get; set; } = null!;

    public string ReglamentoAdministrativo { get; set; } = null!;

    public string UrlReglamentoAdministrativo { get; set; } = null!;

    public int TipoReglamentoId { get; set; }

    public string Reglamento { get; set; } = null!;

    public string UrlReglamento { get; set; } = null!;

    public int SemanasAnuales { get; set; }

    public int HorasSemanales { get; set; }

    public int TipoAcreditacionId { get; set; }

    public DateTime? FechaAcreditacion { get; set; }

    public int? Duracion { get; set; }

    public string? UrlAcreditacion { get; set; }

    public string? UrlDirectorioAutoridades { get; set; }

    public string? UrlRequisitosIngresoAdmision { get; set; }

    public string? UrlProcesoAutoEvaluacion { get; set; }

    public string? UrlProcesosEleccionConformacionOrganosGobierno { get; set; }

    public string? UrlActividadesCulturales { get; set; }

    public string? UrlActividadesDeportivas { get; set; }

    public string? UrlAreasSalud { get; set; }

    public string? UrlAreasSociales { get; set; }

    public string UrlProyeccionComunitaria { get; set; } = null!;

    public string? UrlFinanciacion { get; set; }

    public bool PartDemoEstudiantes { get; set; }

    public bool PartDemoProfesor { get; set; }

    public string? NombreClave { get; set; }

    public virtual ICollection<CalificacionToolValue> CalificacionToolValues { get; set; } = new List<CalificacionToolValue>();

    public virtual ICollection<CalificacionTool> CalificacionTools { get; set; } = new List<CalificacionTool>();

    public virtual ICollection<CalificacionToolsxEntidadEducacion> CalificacionToolsxEntidadEducacions { get; set; } = new List<CalificacionToolsxEntidadEducacion>();

    public virtual CaracterAcademico CaracterAcademico { get; set; } = null!;

    public virtual ICollection<CentrosCostosCrm> CentrosCostosCrms { get; set; } = new List<CentrosCostosCrm>();

    public virtual ICollection<Deuda> Deuda { get; set; } = new List<Deuda>();

    public virtual ICollection<Homologacione> HomologacioneIes { get; set; } = new List<Homologacione>();

    public virtual ICollection<Homologacione> HomologacioneIeshomologacions { get; set; } = new List<Homologacione>();

    public virtual Orden Orden { get; set; } = null!;

    public virtual ICollection<Parametro> Parametros { get; set; } = new List<Parametro>();

    public virtual ICollection<PlanesDesarrollo> PlanesDesarrollos { get; set; } = new List<PlanesDesarrollo>();

    public virtual ICollection<Recaudo> Recaudos { get; set; } = new List<Recaudo>();

    public virtual TipoAcreditacion TipoAcreditacion { get; set; } = null!;

    public virtual ICollection<TipoEvaluacion> TipoEvaluacions { get; set; } = new List<TipoEvaluacion>();

    public virtual TipoNormaLegal TipoNormaLegal { get; set; } = null!;

    public virtual TipoReglamentoOpcional TipoReglamento { get; set; } = null!;

    public virtual ICollection<UnidadOrganizacional> UnidadOrganizacionals { get; set; } = new List<UnidadOrganizacional>();
}
