using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

public partial class LineasProfundizacion
{
    public int LineaId { get; set; }

    public int AsignaturaPlanEstudioId { get; set; }

    public string NombreLinea { get; set; } = null!;

    public virtual AsignaturasxPlanesEstudio AsignaturaPlanEstudio { get; set; } = null!;
}
