using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

public partial class ViewProgramaByPersonaInscritum
{
    public int ProgramaId { get; set; }

    public string NombrePrograma { get; set; } = null!;

    public string Identificacion { get; set; } = null!;

    public string AnoCohorte { get; set; } = null!;

    public string SemestreCohorte { get; set; } = null!;
}
