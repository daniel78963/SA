using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

public partial class CalificacionTooValuexPrograma
{
    public int CalificacionTooValuesProgramaId { get; set; }

    public int? CalificacionTooValuesId { get; set; }

    public int? ProgramaId { get; set; }

    public virtual CalificacionToolValue? CalificacionTooValues { get; set; }

    public virtual Programa? Programa { get; set; }
}
