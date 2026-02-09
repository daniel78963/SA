using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

public partial class Nbc
{
    public int Nbcid { get; set; }

    public string CodigoIes { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public int? AreaConocimientoId { get; set; }

    public virtual AreasNbc? AreaConocimiento { get; set; }

    public virtual ICollection<Programa> Programas { get; set; } = new List<Programa>();
}
