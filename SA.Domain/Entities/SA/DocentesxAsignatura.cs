using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

public partial class DocentesxAsignatura
{
    public int DocentesAsignaturaId { get; set; }

    public int DocenteId { get; set; }

    public int AsignaturaId { get; set; }

    public int PeriodoId { get; set; }

    public virtual AsignaturasxPrograma Asignatura { get; set; } = null!;

    public virtual Docente Docente { get; set; } = null!;

    public virtual ICollection<Grupo> Grupos { get; set; } = new List<Grupo>();

    public virtual Periodo Periodo { get; set; } = null!;
}
