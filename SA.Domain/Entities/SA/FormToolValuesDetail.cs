using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

public partial class FormToolValuesDetail
{
    public int FormToolValuesDetailsId { get; set; }

    public int FormToolValuesId { get; set; }

    public int FormTololDetailId { get; set; }

    public string Valor { get; set; } = null!;

    public virtual FormToolDetail FormTololDetail { get; set; } = null!;

    public virtual FormToolValue FormToolValues { get; set; } = null!;
}
