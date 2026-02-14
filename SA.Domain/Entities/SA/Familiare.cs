using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

public partial class Familiare
{
    public int FamiliarId { get; set; }

    public int PersonaId { get; set; }

    public string PrimerNombre { get; set; } = null!;

    public string? SegundoNombre { get; set; }

    public string PrimerApellido { get; set; } = null!;

    public string? SegundoApellido { get; set; }

    public int? ParentescoId { get; set; }

    public int? NivelEducacionId { get; set; }

    public string? Direccion { get; set; }

    public string? MunicipioId { get; set; }

    public int? Telefono { get; set; }

    public string Ocupacion { get; set; } = null!;

    public string? PaisId { get; set; }

    public string? DepartamentoId { get; set; }

    public virtual NivelesEducacion? NivelEducacion { get; set; }

    public virtual TiposParentesco? Parentesco { get; set; }

    public virtual Persona Persona { get; set; } = null!;
}
