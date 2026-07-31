using System;
using System.Collections.Generic;

namespace Inspection_Outcome.Models;

public partial class TblRemitterMaster
{
    public int Id { get; set; }

    public string? Branch { get; set; }

    public string? AccountName { get; set; }

    public string? AccountNumber { get; set; }

    public string? AccountType { get; set; }

    public string? RemitterName { get; set; }

    public string? Createdby { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? Group { get; set; }
}
