using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

public partial class Configuracion
{
    public int ConfiguracionId { get; set; }

    public int? InscripcionCoordinador { get; set; }

    public int? InscripcionDocente { get; set; }

    public int? InscripcionConsultor { get; set; }
}
