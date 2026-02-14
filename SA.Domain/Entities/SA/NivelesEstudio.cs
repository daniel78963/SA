using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

public partial class NivelesEstudio
{
    public int NivelEstudioId { get; set; }

    public string CodigoIes { get; set; } = null!;

    public string Descripcion { get; set; } = null!;
}
