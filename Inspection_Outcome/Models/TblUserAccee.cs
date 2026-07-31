using System;
using System.Collections.Generic;

namespace Inspection_Outcome.Models;

public partial class TblUserAccee
{
    public int Id { get; set; }

    public int? UserId { get; set; }

    public int? AcccesId { get; set; }

    public string? AccessRightName { get; set; }
}
