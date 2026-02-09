using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

public partial class TipoOcupacionDocente
{
    public int TipoOcupacionDocenteId { get; set; }

    public string Descripcion { get; set; } = null!;

    public virtual ICollection<OcupacionxDocente> OcupacionxDocentes { get; set; } = new List<OcupacionxDocente>();
}
