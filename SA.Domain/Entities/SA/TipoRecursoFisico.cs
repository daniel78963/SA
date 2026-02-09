using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

public partial class TipoRecursoFisico
{
    public int TipoRecursoFisicoId { get; set; }

    public string Descripcion { get; set; } = null!;

    public virtual ICollection<RecursosFisico> RecursosFisicos { get; set; } = new List<RecursosFisico>();
}
