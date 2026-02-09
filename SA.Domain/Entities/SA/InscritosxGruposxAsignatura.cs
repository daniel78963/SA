using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

public partial class InscritosxGruposxAsignatura
{
    public int InscritosGrupoId { get; set; }

    public int GrupoId { get; set; }

    public int InscripcionId { get; set; }

    public bool? SolicitudNotas { get; set; }

    public bool? AutorizacionNotas { get; set; }

    public int? MatriculaId { get; set; }

    public virtual Grupo Grupo { get; set; } = null!;

    public virtual ICollection<HistorialInasistencium> HistorialInasistencia { get; set; } = new List<HistorialInasistencium>();

    public virtual Inscripcione Inscripcion { get; set; } = null!;

    public virtual Matricula? Matricula { get; set; }

    public virtual ICollection<Nota> Nota { get; set; } = new List<Nota>();

    public virtual ICollection<NovedadesNotasDetalle> NovedadesNotasDetalles { get; set; } = new List<NovedadesNotasDetalle>();
}
