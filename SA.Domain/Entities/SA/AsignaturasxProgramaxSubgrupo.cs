using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

public partial class AsignaturasxProgramaxSubgrupo
{
    public int AsignaturasxProgramaSubgrupoId { get; set; }

    public int? ProgramaId { get; set; }

    public string? NombreAsignaturasxProgramaSubgrupo { get; set; }

    public virtual ICollection<AsignaturasxPrograma> AsignaturasxProgramas { get; set; } = new List<AsignaturasxPrograma>();

    public virtual Programa? Programa { get; set; }
}
