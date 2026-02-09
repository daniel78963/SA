using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

public partial class AreasNbc
{
    public int AreaConocimientoId { get; set; }

    public string CodigoIes { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public int Nbcid { get; set; }

    public virtual ICollection<ActasGrado> ActasGrados { get; set; } = new List<ActasGrado>();

    public virtual ICollection<AreasConocimientoXprograma> AreasConocimientoXprogramas { get; set; } = new List<AreasConocimientoXprograma>();

    public virtual ICollection<AsignaturasxPrograma> AsignaturasxProgramas { get; set; } = new List<AsignaturasxPrograma>();

    public virtual ICollection<Nbc> Nbcs { get; set; } = new List<Nbc>();

    public virtual ICollection<Programa> Programas { get; set; } = new List<Programa>();
}
