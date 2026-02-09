using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

public partial class MultimediaMatriculaContrato
{
    public int MultimediaContratoId { get; set; }

    public string? Nombre { get; set; }

    public string? Type { get; set; }

    public byte[]? Data { get; set; }

    public int? PeriodoId { get; set; }

    public virtual Periodo? Periodo { get; set; }
}
