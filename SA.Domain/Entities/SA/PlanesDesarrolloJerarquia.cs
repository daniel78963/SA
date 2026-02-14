using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

public partial class PlanesDesarrolloJerarquia
{
    public int PlanDesarrolloJerarquiaId { get; set; }

    public string Jerarquia { get; set; } = null!;

    public byte? Nivel { get; set; }

    public virtual ICollection<PlanesDesarrolloItem> PlanesDesarrolloItems { get; set; } = new List<PlanesDesarrolloItem>();
}
