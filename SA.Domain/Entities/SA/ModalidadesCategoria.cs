using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

public partial class ModalidadesCategoria
{
    public int ModalidadCategoriaId { get; set; }

    public string? NombreModalidad { get; set; }

    public virtual ICollection<Grupo> Grupos { get; set; } = new List<Grupo>();

    public virtual ICollection<Matricula> Matriculas { get; set; } = new List<Matricula>();
}
