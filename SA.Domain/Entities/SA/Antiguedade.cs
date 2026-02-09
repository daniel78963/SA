using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

public partial class Antiguedade
{
    public int AntiguedadId { get; set; }

    public string Nombre { get; set; } = null!;

    public string? CodigoAntiguedad { get; set; }

    public virtual ICollection<Inscripcione> Inscripciones { get; set; } = new List<Inscripcione>();

    public virtual ICollection<Matricula> Matriculas { get; set; } = new List<Matricula>();
}
