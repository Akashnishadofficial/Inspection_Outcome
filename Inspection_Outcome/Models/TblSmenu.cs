using System;
using System.Collections.Generic;

namespace Inspection_Outcome.Models;

public partial class TblSmenu
{
    public int Smnuid { get; set; }

    public string Smnuname { get; set; } = null!;

    public int Mmnuid { get; set; }

    public string Controller { get; set; } = null!;

    public string Action { get; set; } = null!;

    public string? Iconfile { get; set; }

    public int Msequence { get; set; }

    public bool Addmode { get; set; }

    public bool Edimode { get; set; }

    public bool Delmode { get; set; }

    public bool Viewmode { get; set; }
}
