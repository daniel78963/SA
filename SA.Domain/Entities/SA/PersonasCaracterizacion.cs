using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

public partial class PersonasCaracterizacion
{
    public int PersonaCaracterizacionId { get; set; }

    public string Identificacion { get; set; } = null!;

    public string? Usuario { get; set; }

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

    public string? SemestreActual { get; set; }

    public string? NumeroPersonasAcargo { get; set; }

    public string? Programa { get; set; }

    public string? Jornada { get; set; }

    public int? EntidadEducacionId { get; set; }

    public string? Version { get; set; }

    public bool? UsoInformacion { get; set; }

    public string? PaisBarrioPrevioCodigo { get; set; }

    public string? DepartamentoBarrioPrevioCodigo { get; set; }

    public string? MunicipioBarrioPrevioCodigo { get; set; }

    public DateTime? FechaPresentacion { get; set; }

    public virtual ICollection<PersonasCaracterizacionAdicional> PersonasCaracterizacionAdicionals { get; set; } = new List<PersonasCaracterizacionAdicional>();
}
