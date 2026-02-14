using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

public partial class Origen
{
    public int OrigenId { get; set; }

    public string CodigoIes { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public virtual ICollection<InformacionAcademica> InformacionAcademicas { get; set; } = new List<InformacionAcademica>();

    public virtual ICollection<InstitucionesAcademica> InstitucionesAcademicas { get; set; } = new List<InstitucionesAcademica>();

    public virtual ICollection<Orden> Ordens { get; set; } = new List<Orden>();
}
