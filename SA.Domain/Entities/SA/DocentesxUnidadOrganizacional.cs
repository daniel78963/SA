using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

public partial class DocentesxUnidadOrganizacional
{
    public int DocenteUnidadOrganizacionalId { get; set; }

    public int DocenteId { get; set; }

    public int UnidadOrganizacionalId { get; set; }

    public DateTime? FechaIngresoUo { get; set; }

    public virtual Docente Docente { get; set; } = null!;

    public virtual UnidadOrganizacional UnidadOrganizacional { get; set; } = null!;
}
