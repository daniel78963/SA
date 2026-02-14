using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

public partial class ViewJornadasByProgramaId
{
    public int ProgramaId { get; set; }

    public int JornadaId { get; set; }

    public string Descripcion { get; set; } = null!;
}
