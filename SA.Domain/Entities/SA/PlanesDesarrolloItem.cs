using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

public partial class PlanesDesarrolloItem
{
    public int PlanDesarrolloItemId { get; set; }

    public int PlanDesarrolloId { get; set; }

    public string Numero { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public int? PlanDesarrolloJerarquiaId { get; set; }

    public int? PlanDesarrolloItemPadreId { get; set; }

    public string? MetaAno1 { get; set; }

    public string? MetaAno2 { get; set; }

    public string? MetaAno3 { get; set; }

    public string? MetaAno4 { get; set; }

    public string? MetaAno5 { get; set; }

    public double? PresupuestoProyectado { get; set; }

    public double? AsignacionAno1 { get; set; }

    public double? AsignacionAno2 { get; set; }

    public double? AsignacionAno3 { get; set; }

    public double? AsignacionAno4 { get; set; }

    public double? AsignacionAno5 { get; set; }

    public virtual PlanesDesarrollo PlanDesarrollo { get; set; } = null!;

    public virtual PlanesDesarrolloJerarquia? PlanDesarrolloJerarquia { get; set; }

    public virtual ICollection<PlanesAccion> PlanesAccions { get; set; } = new List<PlanesAccion>();
}
