using System;
using System.Collections.Generic;

namespace Inspection_Outcome.Models;

public partial class TblUserDetail
{
    public int Id { get; set; }

    public int UserId { get; set; }

    public string UserName { get; set; } = null!;

    public string UserEmail { get; set; } = null!;

    public string UserPassword { get; set; } = null!;
}
