using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

/// <summary>
/// Almacena la información de los responsables de las entrevistas
/// </summary>
public partial class ResponsablexEntrevistum
{
    /// <summary>
    /// Consecutivo generado por el sistema
    /// </summary>
    public int ResponsableEntrevistaId { get; set; }

    public int EntrevistaId { get; set; }

    public int PersonaId { get; set; }

    public virtual Entrevista Entrevista { get; set; } = null!;

    public virtual Persona Persona { get; set; } = null!;
}
