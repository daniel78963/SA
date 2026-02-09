using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

public partial class PlanesAccion
{
    public int PlanAccionId { get; set; }

    public int PlanDesarrolloId { get; set; }

    public int UnidadOrganizacionalId { get; set; }

    public int PlanDesarrolloItemId { get; set; }

    public int Ano { get; set; }

    public bool? Enero { get; set; }

    public bool? Febrero { get; set; }

    public bool? Marzo { get; set; }

    public bool? Abril { get; set; }

    public bool? Mayo { get; set; }

    public bool? Junio { get; set; }

    public bool? Julio { get; set; }

    public bool? Agosto { get; set; }

    public bool? Septiembre { get; set; }

    public bool? Octubre { get; set; }

    public bool? Noviembre { get; set; }

    public bool? Diciembre { get; set; }

    public string? Actividad { get; set; }

    public double? Ponderacion { get; set; }

    public double? Presupuesto { get; set; }

    public virtual PlanesDesarrollo PlanDesarrollo { get; set; } = null!;

    public virtual PlanesDesarrolloItem PlanDesarrolloItem { get; set; } = null!;

    public virtual UnidadOrganizacional UnidadOrganizacional { get; set; } = null!;
}
