using System;
using System.Collections.Generic;

namespace Inspection_Outcome.Models;

public partial class TblNotice
{
    public int Id { get; set; }

    public string? Notice { get; set; }

    public DateOnly? NoticeDate { get; set; }

    public bool? IsOpen { get; set; }

    public int? UserId { get; set; }
}
