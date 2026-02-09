using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

public partial class TiposPersona
{
    public int TiposPersonaId { get; set; }

    public string Descripcion { get; set; } = null!;

    public virtual ICollection<PersonasxTiposPersona> PersonasxTiposPersonas { get; set; } = new List<PersonasxTiposPersona>();
}
