using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

public partial class PlanesDesarrollo
{
    public int PlanDesarrolloId { get; set; }

    public int EntidadEducacionId { get; set; }

    public int AnoInicial { get; set; }

    public int AnoFinal { get; set; }

    public string Titulo { get; set; } = null!;

    public string? Descripcion { get; set; }

    public virtual Ie EntidadEducacion { get; set; } = null!;

    public virtual ICollection<PlanesAccion> PlanesAccions { get; set; } = new List<PlanesAccion>();

    public virtual ICollection<PlanesDesarrolloItem> PlanesDesarrolloItems { get; set; } = new List<PlanesDesarrolloItem>();
}
