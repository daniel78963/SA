using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

public partial class InformacionAcademica
{
    public int InformacionAcademicaId { get; set; }

    public int PersonaId { get; set; }

    public string Titulo { get; set; } = null!;

    public string NombreInstitucion { get; set; } = null!;

    public int TipoInstitucionId { get; set; }

    public string? MunicipioId { get; set; }

    public string? AnoGrado { get; set; }

    public string? AnoIcfes { get; set; }

    public string? Snp { get; set; }

    public int? NivelEducacionId { get; set; }

    public string? DepartamentoId { get; set; }

    public string? PaisId { get; set; }

    public DateTime? FechaIcfes { get; set; }

    public virtual NivelesEducacion? NivelEducacion { get; set; }

    public virtual Persona Persona { get; set; } = null!;

    public virtual Origen TipoInstitucion { get; set; } = null!;
}
