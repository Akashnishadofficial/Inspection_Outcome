using System;
using System.Collections.Generic;

namespace Inspection_Outcome.Models;

public partial class WinderShiftMaster
{
    public int Id { get; set; }

    public string? ShiftName { get; set; }

    public string? ShiftFromTime { get; set; }

    public string? ShifToTime { get; set; }

    public decimal? ShiftHrs { get; set; }
}
