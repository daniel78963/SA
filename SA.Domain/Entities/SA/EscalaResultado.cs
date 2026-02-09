using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

/// <summary>
/// Almacena las escalas asociadas a cada pregunta
/// </summary>
public partial class EscalaResultado
{
    public int EscalaId { get; set; }

    public string Abreviatura { get; set; } = null!;

    public string? Descripcion { get; set; }

    public int Equivalencia { get; set; }

    public virtual ICollection<PreguntasxEvaluacion> PreguntasxEvaluacions { get; set; } = new List<PreguntasxEvaluacion>();
}
