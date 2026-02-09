using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

public partial class GenerosCrm
{
    public int GeneroId { get; set; }

    public string Descripcion { get; set; } = null!;

    public virtual ICollection<PersonasCrm> PersonasCrms { get; set; } = new List<PersonasCrm>();
}
