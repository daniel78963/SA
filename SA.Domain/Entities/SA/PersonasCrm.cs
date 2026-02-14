using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

public partial class PersonasCrm
{
    public int PersonaId { get; set; }

    public string? Identificacion { get; set; }

    public int? TipoIdentificacionId { get; set; }

    public int? LugarExpedición { get; set; }

    public string? PrimerNombre { get; set; }

    public string? SegundoNombre { get; set; }

    public string? PrimerApellido { get; set; }

    public string? SegundoApellido { get; set; }

    public int? GeneroId { get; set; }

    public int? EstadoCivilId { get; set; }

    public string? Rh { get; set; }

    public DateTime? FechaNacimiento { get; set; }

    public int? LugarNacimientoId { get; set; }

    public string? Telefono { get; set; }

    public string? Telefono2 { get; set; }

    public string? CorreoElectronico { get; set; }

    public string? TipoPersona { get; set; }

    public int? Estrato { get; set; }

    public string? Eps { get; set; }

    public string? Direccion { get; set; }

    public string? Barrio { get; set; }

    public int? NumeroHijos { get; set; }

    public int? LugarResidenciaId { get; set; }

    public string? TelefonoCelular { get; set; }

    public string? NombreCompleto { get; set; }

    public virtual EstadosCivilesCrm? EstadoCivil { get; set; }

    public virtual GenerosCrm? Genero { get; set; }

    public virtual MunicipiosCrm? LugarNacimiento { get; set; }

    public virtual TipoIdentificacionCrm? TipoIdentificacion { get; set; }
}
