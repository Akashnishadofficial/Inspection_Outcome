using System;
using System.Collections.Generic;

namespace Inspection_Outcome.Models;

public partial class TblLoomMst
{
    public int Loomid { get; set; }

    public string? LoomName { get; set; }

    public int? Width { get; set; }

    public int? Length { get; set; }

    public DateTime? CreateDat { get; set; }

    public DateTime? ModifyDate { get; set; }

    public int? Userid { get; set; }
}
