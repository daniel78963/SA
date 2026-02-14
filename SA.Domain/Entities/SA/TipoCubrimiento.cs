using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

public partial class TipoCubrimiento
{
    public int TipoCubrimientoId { get; set; }

    public string CodigoIes { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public virtual ICollection<CubrimientoxPrograma> CubrimientoxProgramas { get; set; } = new List<CubrimientoxPrograma>();
}
