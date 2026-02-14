using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

public partial class AreasNucleosxPrograma
{
    public int AreaNucleoxProgramaId { get; set; }

    public int AreaNucleoId { get; set; }

    public int ProgramaId { get; set; }

    public virtual AreasNucleo AreaNucleo { get; set; } = null!;

    public virtual Programa Programa { get; set; } = null!;
}
