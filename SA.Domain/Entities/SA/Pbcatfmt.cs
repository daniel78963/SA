using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

public partial class Pbcatfmt
{
    public string PbfName { get; set; } = null!;

    public string? PbfFrmt { get; set; }

    public short? PbfType { get; set; }

    public int? PbfCntr { get; set; }
}
