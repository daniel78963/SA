using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

public partial class RequisitosxProceso
{
    public int RequisitosxProcesoId { get; set; }

    public int ProcesoId { get; set; }

    public int RequisitoId { get; set; }

    public virtual ICollection<PersonasxRequisitosxProceso> PersonasxRequisitosxProcesos { get; set; } = new List<PersonasxRequisitosxProceso>();

    public virtual Proceso Proceso { get; set; } = null!;

    public virtual Requisito Requisito { get; set; } = null!;
}
