using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

public partial class TipoAsignatura
{
    public int TipoAsignaturaId { get; set; }

    public string CodigoIes { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public virtual ICollection<AsignaturasxPlanesEstudio> AsignaturasxPlanesEstudios { get; set; } = new List<AsignaturasxPlanesEstudio>();
}
