using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

public partial class UnidadOrganizacional
{
    public int UnidadOrganizacionalId { get; set; }

    public int? EntidadEducacionId { get; set; }

    public string CodigoUnidadOrgIes { get; set; } = null!;

    public int? CodigoPadre { get; set; }

    public string NombreUnidad { get; set; } = null!;

    public int TipoUnidadOrganizacionalId { get; set; }

    public string? PaisId { get; set; }

    public string? DepartamentoId { get; set; }

    public string? MunicipioId { get; set; }

    public string Direccion { get; set; } = null!;

    public string Telefono { get; set; } = null!;

    public string? Extension { get; set; }

    public int? IndicativoNalTel { get; set; }

    public int? IndicativoTelPais { get; set; }

    public string? Fax { get; set; }

    public int? IndicativoNalFax { get; set; }

    public int? IndicativoFaxPais { get; set; }

    public string? Email { get; set; }

    public DateOnly FechaCreacionUnidad { get; set; }

    public int? PersonaId { get; set; }

    public virtual ICollection<DocentesxUnidadOrganizacional> DocentesxUnidadOrganizacionals { get; set; } = new List<DocentesxUnidadOrganizacional>();

    public virtual Ie? EntidadEducacion { get; set; }

    public virtual Persona? Persona { get; set; }

    public virtual ICollection<PlanesAccion> PlanesAccions { get; set; } = new List<PlanesAccion>();

    public virtual ICollection<Programa> Programas { get; set; } = new List<Programa>();

    public virtual TipoUnidadOrganizacional TipoUnidadOrganizacional { get; set; } = null!;
}
