using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

public partial class Periodicidade
{
    public int PeriodicidadId { get; set; }

    public string CodigoIes { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public virtual ICollection<Programa> Programas { get; set; } = new List<Programa>();
}
