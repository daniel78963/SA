using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

public partial class Duracion
{
    public int DuracionId { get; set; }

    public string CodigoIes { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public virtual ICollection<InformacionLaboral> InformacionLaborals { get; set; } = new List<InformacionLaboral>();
}
