using System;
using System.Collections.Generic;

namespace Inspection_Outcome.Models;

public partial class TblColor
{
    public int Id { get; set; }

    public string? Colour { get; set; }

    public string? Excolour { get; set; }

    public string? Username { get; set; }

    public string? Companycode { get; set; }

    public int? EntryBy { get; set; }

    public DateTime? EntryDt { get; set; }
}
