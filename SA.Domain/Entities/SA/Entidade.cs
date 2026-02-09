using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

public partial class Entidade
{
    public int EntidadId { get; set; }

    public string? NombreEntidad { get; set; }

    public string? Codigo { get; set; }

    public string? TipoEntidad { get; set; }

    public virtual ICollection<Persona> Personas { get; set; } = new List<Persona>();
}
