using System;
using System.Collections.Generic;

namespace Inspection_Outcome.Models;

public partial class TblMmenu
{
    public int Mmnuid { get; set; }

    public string Mmnuname { get; set; } = null!;

    public int Msequence { get; set; }

    public int UserId { get; set; }

    public string Icon { get; set; } = null!;
}
