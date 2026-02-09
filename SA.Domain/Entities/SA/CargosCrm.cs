using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

public partial class CargosCrm
{
    public int CargoId { get; set; }

    public string CargoIes { get; set; } = null!;

    public string Descripcion { get; set; } = null!;
}
