using System;
using System.Collections.Generic;

namespace Inspection_Outcome.Models;

public partial class TblSubQuality
{
    public int Id { get; set; }

    public string? Quality { get; set; }

    public string? SubQuality { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? Username { get; set; }
}
