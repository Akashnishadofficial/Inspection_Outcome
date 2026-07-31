using System;
using System.Collections.Generic;

namespace Inspection_Outcome.Models;

public partial class TblShareGroup
{
    public int Id { get; set; }

    public string? SharePerson { get; set; }

    public string? ShareGroupName { get; set; }
}
