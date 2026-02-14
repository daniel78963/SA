using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

public partial class PersonasOtrosDato
{
    public int PersonaOtrosDatosId { get; set; }

    public int PersonaId { get; set; }

    public bool? EncuestaVirtualizacion { get; set; }

    public DateTime? EncuestaVirtualizacionFecha { get; set; }

    public virtual Persona Persona { get; set; } = null!;
}
