using System;
using System.Collections.Generic;

namespace Inspection_Outcome.Models;

public partial class TblMachinSpeedRateMst
{
    public int Id { get; set; }

    public string? Quality { get; set; }

    public string? MachinNo { get; set; }

    public decimal? MachinSpeed { get; set; }

    public decimal? RatePerHr { get; set; }

    public DateTime? EntryDate { get; set; }

    public string? EnterBy { get; set; }

    public DateTime? UpdateDate { get; set; }

    public string? UpdateBy { get; set; }
}
