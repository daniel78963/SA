using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

public partial class MediosDifusionCrm
{
    public int MedioDifusionId { get; set; }

    public string Descripcion { get; set; } = null!;

    public string? Codigo { get; set; }
}
