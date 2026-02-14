using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

public partial class Requisito
{
    public int RequisitoId { get; set; }

    public string Descripcion { get; set; } = null!;

    public virtual ICollection<RequisitosxProceso> RequisitosxProcesos { get; set; } = new List<RequisitosxProceso>();
}
