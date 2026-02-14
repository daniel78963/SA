using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

public partial class Criterio
{
    public int CriterioId { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Descripcion { get; set; }

    public decimal? Peso { get; set; }

    public int CalificacionToolId { get; set; }

    public int? Orden { get; set; }

    public virtual CalificacionTool CalificacionTool { get; set; } = null!;

    public virtual ICollection<CriteriosCalificacion> CriteriosCalificacions { get; set; } = new List<CriteriosCalificacion>();

    public virtual ICollection<Pregunta> Pregunta { get; set; } = new List<Pregunta>();
}
