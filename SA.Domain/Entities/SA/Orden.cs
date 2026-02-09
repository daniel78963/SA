using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

public partial class Orden
{
    public int OrdenId { get; set; }

    public string CodigoIes { get; set; } = null!;

    public int OrigenId { get; set; }

    public string Descripcion { get; set; } = null!;

    public virtual ICollection<Ie> Ies { get; set; } = new List<Ie>();

    public virtual ICollection<InstitucionesAcademica> InstitucionesAcademicas { get; set; } = new List<InstitucionesAcademica>();

    public virtual Origen Origen { get; set; } = null!;
}
