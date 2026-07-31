using System;
using System.Collections.Generic;

namespace Inspection_Outcome.Models;

public partial class TblClientCodeMaster
{
    public int Id { get; set; }

    public string? ShortCode { get; set; }

    public string? Code { get; set; }

    public string? Location { get; set; }
}
