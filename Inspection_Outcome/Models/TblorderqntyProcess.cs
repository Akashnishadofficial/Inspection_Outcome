using System;
using System.Collections.Generic;

namespace Inspection_Outcome.Models;

public partial class TblorderqntyProcess
{
    public int Id { get; set; }

    public DateOnly? Cdate { get; set; }

    public string? Sname { get; set; }

    public int? OpnQnty { get; set; }

    public int? RcptQnty { get; set; }

    public int? ProcessQnty { get; set; }

    public int? ClosedQnty { get; set; }
}
