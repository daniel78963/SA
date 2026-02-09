using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

public partial class Parametro
{
    public int ParametroId { get; set; }

    public string Descripcion { get; set; } = null!;

    public string ValorParametro { get; set; } = null!;

    public byte[]? Data { get; set; }

    public string? Observaciones { get; set; }

    public int? EntidadEducacionId { get; set; }

    public string? TipoParametro { get; set; }

    public virtual Ie? EntidadEducacion { get; set; }
}
