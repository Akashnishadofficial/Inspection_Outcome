using System;
using System.Collections.Generic;

namespace Inspection_Outcome.Models;

public partial class TblPermmenu
{
    public int Pmid { get; set; }

    public int Userid { get; set; }

    public int Mmnuid { get; set; }

    public int Smnuid { get; set; }

    public string Permission { get; set; } = null!;

    public bool Addperm { get; set; }

    public bool Ediperm { get; set; }

    public bool Delperm { get; set; }

    public bool Viewperm { get; set; }
}
