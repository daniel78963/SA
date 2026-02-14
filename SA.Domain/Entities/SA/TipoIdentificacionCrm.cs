using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

public partial class TipoIdentificacionCrm
{
    public int TipoIdentificacionId { get; set; }

    public string Descripcion { get; set; } = null!;

    public string? Codigo { get; set; }

    public virtual ICollection<PersonasCrm> PersonasCrms { get; set; } = new List<PersonasCrm>();
}
