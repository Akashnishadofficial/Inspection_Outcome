using System;
using System.Collections.Generic;

namespace Inspection_Outcome.Models;

public partial class TblCurrency
{
    public int Id { get; set; }

    public string? Currency { get; set; }

    public double? Exchangerate { get; set; }
}
