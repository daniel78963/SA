using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

public partial class EventLog
{
    public long EventLogId { get; set; }

    public string Tipo { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public DateTime Fecha { get; set; }
}
