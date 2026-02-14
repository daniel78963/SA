using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

public partial class Docente
{
    public int DocenteId { get; set; }

    public int PersonaId { get; set; }

    public int TipoDocenteId { get; set; }

    public int? NivelMaximoEducacionId { get; set; }

    public virtual ICollection<AsignaturasxProgramasxDocente> AsignaturasxProgramasxDocentes { get; set; } = new List<AsignaturasxProgramasxDocente>();

    public virtual ICollection<DisponibilidadDocente> DisponibilidadDocentes { get; set; } = new List<DisponibilidadDocente>();

    public virtual ICollection<DocentesxAsignatura> DocentesxAsignaturas { get; set; } = new List<DocentesxAsignatura>();

    public virtual ICollection<DocentesxUnidadOrganizacional> DocentesxUnidadOrganizacionals { get; set; } = new List<DocentesxUnidadOrganizacional>();

    public virtual Persona Persona { get; set; } = null!;

    public virtual Dedicacion TipoDocente { get; set; } = null!;
}
