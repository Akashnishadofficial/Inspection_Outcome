using System;
using System.Collections.Generic;

namespace Inspection_Outcome.Models;

public partial class TblMaterialLabel
{
    public int Id { get; set; }

    public string? MaterialType { get; set; }

    public string? ToLabel { get; set; }
}
