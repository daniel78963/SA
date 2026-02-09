using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

public partial class FormTool
{
    public int FormToolId { get; set; }

    public string Nombre { get; set; } = null!;

    public virtual ICollection<FormToolDetail> FormToolDetailFormTools { get; set; } = new List<FormToolDetail>();

    public virtual ICollection<FormToolDetail> FormToolDetailListaFormTools { get; set; } = new List<FormToolDetail>();

    public virtual ICollection<FormToolValue> FormToolValues { get; set; } = new List<FormToolValue>();
}
