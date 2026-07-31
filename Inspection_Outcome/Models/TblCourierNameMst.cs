using System;
using System.Collections.Generic;

namespace Inspection_Outcome.Models;

public partial class TblCourierNameMst
{
    public int Id { get; set; }

    public string? CourierName { get; set; }

    public string? Website { get; set; }

    public bool? Active { get; set; }

    public string? EntryBy { get; set; }

    public DateTime? EntryDate { get; set; }

    public string? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }
}
