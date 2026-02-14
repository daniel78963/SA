using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

public partial class AuditoriaObjetosGrp
{
    public int AuditoriaObjetoId { get; set; }

    public string? Proceso { get; set; }

    public string? Descripcion { get; set; }

    public string? Usuario { get; set; }

    public string? Evento { get; set; }

    public DateTime? Fecha { get; set; }
}
