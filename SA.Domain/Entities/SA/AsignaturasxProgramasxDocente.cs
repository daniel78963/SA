using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

public partial class AsignaturasxProgramasxDocente
{
    public int AsignaturasxProgramasxDocentesId { get; set; }

    public int AsignaturasxProgramaId { get; set; }

    public int DocenteId { get; set; }

    public virtual AsignaturasxPrograma AsignaturasxPrograma { get; set; } = null!;

    public virtual Docente Docente { get; set; } = null!;
}
