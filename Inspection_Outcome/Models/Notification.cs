using System;
using System.Collections.Generic;

namespace Inspection_Outcome.Models;

public partial class Notification
{
    public int Id { get; set; }

    public string Message { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public bool? IsNotified { get; set; }
}
