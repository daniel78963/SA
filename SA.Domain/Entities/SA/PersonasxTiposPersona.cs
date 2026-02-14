using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

public partial class PersonasxTiposPersona
{
    public int PersonaTipoPersonaId { get; set; }

    public int PersonaId { get; set; }

    public int TiposPersonaId { get; set; }

    public virtual Persona Persona { get; set; } = null!;

    public virtual TiposPersona TiposPersona { get; set; } = null!;
}
