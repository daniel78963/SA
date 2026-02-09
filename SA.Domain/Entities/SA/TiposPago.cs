using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

public partial class TiposPago
{
    public int TipoPagoId { get; set; }

    public string Codigo { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public virtual ICollection<Matricula> Matriculas { get; set; } = new List<Matricula>();
}
