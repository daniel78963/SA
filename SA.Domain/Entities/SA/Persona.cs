using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

public partial class Persona
{
    public int PersonaId { get; set; }

    public string Identificacion { get; set; } = null!;

    public string Usuario { get; set; } = null!;

    public byte[]? Foto { get; set; }

    public int? CargoId { get; set; }

    public DateTime FechaIngreso { get; set; }

    public int? NivelEducacionId { get; set; }

    public bool CambiarContrasena { get; set; }

    public string? TipoIdentificacionCodigo { get; set; }

    public string? PrimerNombre { get; set; }

    public string? SegundoNombre { get; set; }

    public string? PrimerApellido { get; set; }

    public string? SegundoApellido { get; set; }

    public string? CorreoElectronico { get; set; }

    public DateTime? FechaNacimiento { get; set; }

    public string? PaisExpedicionCodigo { get; set; }

    public string? DepartamentoExpedicionCodigo { get; set; }

    public string? MunicipioExpedicionCodigo { get; set; }

    public string? PaisNacimientoCodigo { get; set; }

    public string? DepartamentoNacimientoCodigo { get; set; }

    public string? MunicipioNacimientoCodigo { get; set; }

    public string? PaisBarrioCodigo { get; set; }

    public string? DepartamentoBarrioCodigo { get; set; }

    public string? MunicipioBarrioCodigo { get; set; }

    public string? BarrioCodigo { get; set; }

    public string? Genero { get; set; }

    /// <summary>
    /// &apos;C&apos; &apos;CASADO(A)&apos; 
    /// &apos;V&apos; &apos;VIUDO(A)&apos;
    /// &apos;E&apos; &apos;SEPARADO(A)&apos;
    /// &apos;D&apos; &apos;DIVORCIADO(A)&apos;
    /// &apos;U&apos; &apos;UNION LIBRE&apos;
    /// &apos;I&apos; &apos;INDETERMINADO&apos;
    /// &apos;R&apos; &apos;RELIGIOSO(A)&apos; 
    /// &apos;M&apos; &apos;MADRE SOLTERA&apos;
    /// </summary>
    public string? EstadoCivil { get; set; }

    public string? NumeroHijos { get; set; }

    public string? EpsCodigo { get; set; }

    public string? Rh { get; set; }

    public string? Telefono { get; set; }

    public string? Telefono2 { get; set; }

    public string? Celular { get; set; }

    public string? Direccion { get; set; }

    public string? Estrato { get; set; }

    public string? NombreCompleto { get; set; }

    public string? Observaciones { get; set; }

    public string? ApellidosNombresCompleto { get; set; }

    public bool? CambiarDatosPersonales { get; set; }

    public int? EntidadId { get; set; }

    public bool? Inactivo { get; set; }

    public string? Ocupacion { get; set; }

    public string? CorreoInstitucional { get; set; }

    public string? TipoIdentificacionCodigoAnterior { get; set; }

    public string? IdentificacionAnterior { get; set; }

    public bool? IdentificacionAnteriorNoTomarSnies { get; set; }

    public DateOnly? FechaExpedicionDocumento { get; set; }

    public DateOnly? FechaExpedicionDocumentoAnterior { get; set; }

    public bool? TratamientoDatos { get; set; }

    public DateTime? TratamientoDatosFecha { get; set; }

    public virtual ICollection<ActasGrado> ActasGradoDecanos { get; set; } = new List<ActasGrado>();

    public virtual ICollection<ActasGrado> ActasGradoRectors { get; set; } = new List<ActasGrado>();

    public virtual ICollection<ActasGrado> ActasGradoSecretariaGenerals { get; set; } = new List<ActasGrado>();

    public virtual ICollection<AreasNucleosxPersona> AreasNucleosxPersonas { get; set; } = new List<AreasNucleosxPersona>();

    public virtual ICollection<Deuda> Deuda { get; set; } = new List<Deuda>();

    public virtual ICollection<Docente> Docentes { get; set; } = new List<Docente>();

    public virtual Entidade? Entidad { get; set; }

    public virtual ICollection<Familiare> Familiares { get; set; } = new List<Familiare>();

    public virtual ICollection<Graduando> Graduandos { get; set; } = new List<Graduando>();

    public virtual ICollection<InformacionAcademica> InformacionAcademicas { get; set; } = new List<InformacionAcademica>();

    public virtual ICollection<InformacionAdicional> InformacionAdicionals { get; set; } = new List<InformacionAdicional>();

    public virtual ICollection<InformacionLaboral> InformacionLaborals { get; set; } = new List<InformacionLaboral>();

    public virtual ICollection<Inscripcione> Inscripciones { get; set; } = new List<Inscripcione>();

    public virtual NivelesEducacion? NivelEducacion { get; set; }

    public virtual ICollection<OcupacionxDocente> OcupacionxDocentes { get; set; } = new List<OcupacionxDocente>();

    public virtual ICollection<OcupacionxRecursoFisico> OcupacionxRecursoFisicos { get; set; } = new List<OcupacionxRecursoFisico>();

    public virtual ICollection<PersonasOtrosDato> PersonasOtrosDatos { get; set; } = new List<PersonasOtrosDato>();

    public virtual ICollection<PersonasxTiposPersona> PersonasxTiposPersonas { get; set; } = new List<PersonasxTiposPersona>();

    public virtual ICollection<ResponsablexEntrevistum> ResponsablexEntrevista { get; set; } = new List<ResponsablexEntrevistum>();

    public virtual ICollection<Suficiencia> Suficiencia { get; set; } = new List<Suficiencia>();

    public virtual ICollection<UnidadOrganizacional> UnidadOrganizacionals { get; set; } = new List<UnidadOrganizacional>();
}
