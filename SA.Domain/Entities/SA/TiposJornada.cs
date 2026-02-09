using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

public partial class TiposJornada
{
    public int JornadaId { get; set; }

    public string CodigoIes { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public virtual ICollection<CambiosProgramasJornada> CambiosProgramasJornadaJornadaActuals { get; set; } = new List<CambiosProgramasJornada>();

    public virtual ICollection<CambiosProgramasJornada> CambiosProgramasJornadaJornadaCambios { get; set; } = new List<CambiosProgramasJornada>();

    public virtual ICollection<Grupo> Grupos { get; set; } = new List<Grupo>();

    public virtual ICollection<Inscripcione> Inscripciones { get; set; } = new List<Inscripcione>();

    public virtual ICollection<Matricula> Matriculas { get; set; } = new List<Matricula>();

    public virtual ICollection<ProgramasxTiposJornada> ProgramasxTiposJornada { get; set; } = new List<ProgramasxTiposJornada>();
}
