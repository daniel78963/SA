using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

public partial class ViewPersona
{
    public int PersonaId { get; set; }

    public string Identificacion { get; set; } = null!;

    public int? CargoId { get; set; }

    public int PersonaTipoPersonaId { get; set; }

    public int TiposPersonaId { get; set; }

    public string Descripcion { get; set; } = null!;
}
