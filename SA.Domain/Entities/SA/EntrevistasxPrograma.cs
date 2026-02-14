using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

public partial class EntrevistasxPrograma
{
    public int EntrevistaProgramaId { get; set; }

    public int ProgramaId { get; set; }

    public int EntrevistaId { get; set; }

    public virtual Entrevista Entrevista { get; set; } = null!;

    public virtual Programa Programa { get; set; } = null!;
}
