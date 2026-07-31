using System;
using System.Collections.Generic;

namespace Inspection_Outcome.Models;

public partial class TblLoginDetail
{
    public int Id { get; set; }

    public string? LastLoginip { get; set; }

    public DateTime? LastLogindate { get; set; }

    public DateTime? LogOutTime { get; set; }

    public string? UserId { get; set; }

    public bool? IsActive { get; set; }
}
