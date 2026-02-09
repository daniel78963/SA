using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

public partial class CriteriosCalificacion
{
    public int CriterioCalificacionId { get; set; }

    public string Nombre { get; set; } = null!;

    public decimal ValorMaximo { get; set; }

    public int CalificacionToolId { get; set; }

    public string Tipo { get; set; } = null!;

    public int? CriterioId { get; set; }

    public virtual CalificacionTool CalificacionTool { get; set; } = null!;

    public virtual Criterio? Criterio { get; set; }
}
