using System;
using System.Collections.Generic;

namespace Inspection_Outcome.Models;

public partial class TblcountPcsMst
{
    public int Id { get; set; }

    public string? SrNo { get; set; }

    public int? PieceNo { get; set; }

    public string? PieceSrNo { get; set; }
}
