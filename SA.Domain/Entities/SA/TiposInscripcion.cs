using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

public partial class TiposInscripcion
{
    public int TipoInscripcionId { get; set; }

    public string CodigoIes { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public bool? Activo { get; set; }

    public virtual ICollection<Inscripcione> Inscripciones { get; set; } = new List<Inscripcione>();
}
