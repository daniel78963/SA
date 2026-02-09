using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

public partial class AreasConocimientoXprograma
{
    public int AreaConocimientXporgramaId { get; set; }

    public int ProgramaId { get; set; }

    public int AreaConocimientoId { get; set; }

    public bool Principal { get; set; }

    public virtual AreasNbc AreaConocimiento { get; set; } = null!;

    public virtual Programa Programa { get; set; } = null!;
}
