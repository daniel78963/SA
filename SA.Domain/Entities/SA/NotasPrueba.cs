using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

public partial class NotasPrueba
{
    public int PersonaId { get; set; }

    public int SeguimientoId { get; set; }

    public decimal? Nota { get; set; }
}
