using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

public partial class GruposPlanesxArchivo
{
    public int GrupoPlanArchivoId { get; set; }

    public int GrupoPlanId { get; set; }

    public string? TipoArchivo { get; set; }

    public string? NombreArchivo { get; set; }

    public string? Ruta { get; set; }

    public virtual GruposPlane GrupoPlan { get; set; } = null!;
}
