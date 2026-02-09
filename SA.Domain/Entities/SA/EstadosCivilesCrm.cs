using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

public partial class EstadosCivilesCrm
{
    public int EstadoCivilId { get; set; }

    public string Descripcion { get; set; } = null!;

    public virtual ICollection<PersonasCrm> PersonasCrms { get; set; } = new List<PersonasCrm>();
}
