using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

public partial class FormToolDetailsOption
{
    public int FormToolDetailsOptionsId { get; set; }

    public int FormTollDetailsId { get; set; }

    public string Value { get; set; } = null!;

    public virtual FormToolDetail FormTollDetails { get; set; } = null!;
}
