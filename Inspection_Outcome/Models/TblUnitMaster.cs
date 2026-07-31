using System;
using System.Collections.Generic;

namespace Inspection_Outcome.Models;

public partial class TblUnitMaster
{
    public int Id { get; set; }

    public string? Symbol { get; set; }

    public string? Fullname { get; set; }

    public short? Decimalplace { get; set; }

    public string? Username { get; set; }

    public DateTime? Datetime { get; set; }

    public string? Companycode { get; set; }
}
