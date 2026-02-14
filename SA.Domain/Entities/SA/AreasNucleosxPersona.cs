using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

public partial class AreasNucleosxPersona
{
    public int AreaNucleoPersonaId { get; set; }

    public int? AreaNucleoId { get; set; }

    public int? PersonaId { get; set; }

    /// <summary>
    /// Coordinador
    /// 
    /// DocenteAdscrito
    /// </summary>
    public string? TipoRelacionAreaNucleo { get; set; }

    public virtual AreasNucleo? AreaNucleo { get; set; }

    public virtual Persona? Persona { get; set; }
}
