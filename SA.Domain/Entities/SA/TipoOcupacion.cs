using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

public partial class TipoOcupacion
{
    public int TipoOcupacionId { get; set; }

    public string Descripcion { get; set; } = null!;

    public virtual ICollection<OcupacionxRecursoFisico> OcupacionxRecursoFisicos { get; set; } = new List<OcupacionxRecursoFisico>();
}
