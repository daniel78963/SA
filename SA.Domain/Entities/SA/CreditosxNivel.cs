using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

public partial class CreditosxNivel
{
    public int CreditosxNivelId { get; set; }

    public int PlanEstudioId { get; set; }

    public int Nivel { get; set; }

    public int CreditosxNivel1 { get; set; }

    public int SumaCreditos { get; set; }

    public virtual PlanesEstudio PlanEstudio { get; set; } = null!;
}
