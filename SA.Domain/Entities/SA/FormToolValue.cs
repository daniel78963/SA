using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

public partial class FormToolValue
{
    public int FormToolValuesId { get; set; }

    public int FormToolId { get; set; }

    public string Usuario { get; set; } = null!;

    public DateTime FechaCreacion { get; set; }

    public string UserCreated { get; set; } = null!;

    public virtual FormTool FormTool { get; set; } = null!;

    public virtual ICollection<FormToolValuesDetail> FormToolValuesDetails { get; set; } = new List<FormToolValuesDetail>();
}
