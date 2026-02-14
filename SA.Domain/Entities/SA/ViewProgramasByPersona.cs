using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

public partial class ViewProgramasByPersona
{
    public string Identificacion { get; set; } = null!;

    public string NombrePrograma { get; set; } = null!;

    public int ProgramaId { get; set; }

    public string Descripcion { get; set; } = null!;
}
