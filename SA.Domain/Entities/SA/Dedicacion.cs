using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

public partial class Dedicacion
{
    public int DedicacionId { get; set; }

    public string CodigoIes { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public virtual ICollection<Docente> Docentes { get; set; } = new List<Docente>();
}
