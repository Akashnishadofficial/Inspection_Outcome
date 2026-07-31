using System;
using System.Collections.Generic;

namespace Inspection_Outcome.Models;

public partial class TblMiscellaneou
{
    public int Id { get; set; }

    public int? Sno { get; set; }

    public string? Name { get; set; }

    public string? Detail { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? ModifyDate { get; set; }

    public int? Userid { get; set; }
}
