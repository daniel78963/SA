using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

public partial class Estado
{
    public int EstadoId { get; set; }

    public int TipoEstadoId { get; set; }

    public string CodigoIes { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public virtual ICollection<CambiosProgramasJornada> CambiosProgramasJornada { get; set; } = new List<CambiosProgramasJornada>();

    public virtual ICollection<Deuda> Deuda { get; set; } = new List<Deuda>();

    public virtual ICollection<DisponibilidadDocente> DisponibilidadDocentes { get; set; } = new List<DisponibilidadDocente>();

    public virtual ICollection<Liquidacione> Liquidaciones { get; set; } = new List<Liquidacione>();

    public virtual ICollection<Matricula> Matriculas { get; set; } = new List<Matricula>();

    public virtual ICollection<NovedadesNota> NovedadesNota { get; set; } = new List<NovedadesNota>();

    public virtual ICollection<PersonasxRequisitosxProceso> PersonasxRequisitosxProcesos { get; set; } = new List<PersonasxRequisitosxProceso>();

    public virtual ICollection<SolicitudesCancelacion> SolicitudesCancelacions { get; set; } = new List<SolicitudesCancelacion>();

    public virtual TiposEstado TipoEstado { get; set; } = null!;
}
