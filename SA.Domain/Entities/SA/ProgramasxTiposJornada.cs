using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

public partial class ProgramasxTiposJornada
{
    public int ProgramaJornadaId { get; set; }

    public int JornadaId { get; set; }

    public int ProgramaId { get; set; }

    public virtual TiposJornada Jornada { get; set; } = null!;

    public virtual Programa Programa { get; set; } = null!;
}
