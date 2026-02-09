using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

public partial class NivelesEducacion
{
    public int NivelEducacionId { get; set; }

    public string CodigoIes { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public int? Valor { get; set; }

    public string? Distincion { get; set; }

    public virtual ICollection<Familiare> Familiares { get; set; } = new List<Familiare>();

    public virtual ICollection<InformacionAcademica> InformacionAcademicas { get; set; } = new List<InformacionAcademica>();

    public virtual ICollection<Persona> Personas { get; set; } = new List<Persona>();
}
