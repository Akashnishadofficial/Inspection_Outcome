using System;
using System.Collections.Generic;

namespace Inspection_Outcome.Models;

public partial class TblRndcmplPer
{
    public int Id { get; set; }

    public string SrNo { get; set; } = null!;

    public int ComplPer { get; set; }

    public string Entryby { get; set; } = null!;

    public DateTime EntryDt { get; set; }
}
