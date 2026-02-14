using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

public partial class HerramientasxGrupo
{
    public int HerramientaGrupoId { get; set; }

    public int GrupoId { get; set; }

    public int CalificacionToolId { get; set; }

    public virtual CalificacionTool CalificacionTool { get; set; } = null!;

    public virtual Grupo Grupo { get; set; } = null!;
}
