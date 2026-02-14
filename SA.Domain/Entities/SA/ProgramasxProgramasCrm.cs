using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

public partial class ProgramasxProgramasCrm
{
    public int ProgramaCrmprogramaId { get; set; }

    public int? ProgramaId { get; set; }

    public string? ProgramaCrm { get; set; }

    public int? ModalidadId { get; set; }

    public virtual Programa? Programa { get; set; }
}
