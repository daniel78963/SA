using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

public partial class InscripcionesxActasGrado
{
    public int InscripcionxActaGradoId { get; set; }

    public int ActaGradoId { get; set; }

    public int InscripcionId { get; set; }

    public string? Folio { get; set; }

    public virtual ActasGrado ActaGrado { get; set; } = null!;

    public virtual Inscripcione Inscripcion { get; set; } = null!;
}
