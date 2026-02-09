using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

public partial class AutoevaluacionToolValuexPrograma
{
    public int AutoevaluacionToolValueProgramaId { get; set; }

    public int? AutoevaluacionToolValueId { get; set; }

    public int? ProgramaId { get; set; }

    public virtual AutoevaluacionToolValue? AutoevaluacionToolValue { get; set; }

    public virtual Programa? Programa { get; set; }
}
