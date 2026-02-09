using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

public partial class TiposGruposPlane
{
    public int TipoGrupoPlanId { get; set; }

    public string NombreTipoGrupoPlan { get; set; } = null!;

    public bool Evaluativo { get; set; }

    public virtual ICollection<GruposPlane> GruposPlanes { get; set; } = new List<GruposPlane>();
}
