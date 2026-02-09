using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

public partial class DisponibilidadDocente
{
    public int DisponibilidadDocenteId { get; set; }

    public int DocenteId { get; set; }

    public int EstadoId { get; set; }

    public virtual Docente Docente { get; set; } = null!;

    public virtual Estado Estado { get; set; } = null!;

    public virtual ICollection<HorariosxDisponibilidadDocente> HorariosxDisponibilidadDocentes { get; set; } = new List<HorariosxDisponibilidadDocente>();
}
