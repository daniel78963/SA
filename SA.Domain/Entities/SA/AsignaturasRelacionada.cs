using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

public partial class AsignaturasRelacionada
{
    public int AsignaturasRelacionadasId { get; set; }

    public int PlanEstudioAsignaturaId { get; set; }

    /// <summary>
    /// Prerequisito =1 , correquisito=2
    /// </summary>
    public int TiposRelacionId { get; set; }

    public int AsignaturaIdRelacion { get; set; }

    public virtual AsignaturasxPlanesEstudio AsignaturaIdRelacionNavigation { get; set; } = null!;

    public virtual AsignaturasxPlanesEstudio PlanEstudioAsignatura { get; set; } = null!;

    public virtual TiposRelacion TiposRelacion { get; set; } = null!;
}
