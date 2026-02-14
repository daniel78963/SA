using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

public partial class AreasNucleo
{
    public int AreaNucleoId { get; set; }

    public string? NombreAreaNucleo { get; set; }

    public int? ProgramaId { get; set; }

    public virtual ICollection<AreasNucleosxPersona> AreasNucleosxPersonas { get; set; } = new List<AreasNucleosxPersona>();

    public virtual ICollection<AreasNucleosxPrograma> AreasNucleosxProgramas { get; set; } = new List<AreasNucleosxPrograma>();

    public virtual ICollection<CalificacionToolValue> CalificacionToolValues { get; set; } = new List<CalificacionToolValue>();

    public virtual Programa? Programa { get; set; }
}
