using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

public partial class Actividade
{
    public int ActvidadId { get; set; }

    public string Descripcion { get; set; } = null!;

    public bool EstadoActividad { get; set; }

    public virtual ICollection<ActividadesCalendario> ActividadesCalendarios { get; set; } = new List<ActividadesCalendario>();
}
