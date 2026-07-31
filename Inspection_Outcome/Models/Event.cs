using System;
using System.Collections.Generic;

namespace Inspection_Outcome.Models;

public partial class Event
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public DateTime StartTime { get; set; }

    public DateTime? EndTime { get; set; }

    public bool IsAllDay { get; set; }

    public string? Description { get; set; }
}
