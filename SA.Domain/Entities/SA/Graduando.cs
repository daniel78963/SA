using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

public partial class Graduando
{
    public int GraduandoId { get; set; }

    public int ActaGradoId { get; set; }

    public int InscripcionId { get; set; }

    public string? Folio { get; set; }

    public string? Acta { get; set; }

    public int? DecanoId { get; set; }

    public virtual ActasGrado ActaGrado { get; set; } = null!;

    public virtual Persona? Decano { get; set; }

    public virtual Inscripcione Inscripcion { get; set; } = null!;
}
