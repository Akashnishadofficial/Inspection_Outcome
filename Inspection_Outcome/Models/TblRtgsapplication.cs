using System;
using System.Collections.Generic;

namespace Inspection_Outcome.Models;

public partial class TblRtgsapplication
{
    public int Id { get; set; }

    public DateTime? Date { get; set; }

    public string? RemitterName { get; set; }

    public string? BeneficiaryName { get; set; }

    public string? BeneficiaryAccount { get; set; }

    public decimal? Amount { get; set; }

    public decimal? BankCharges { get; set; }

    public string? Createdby { get; set; }

    public DateTime? CreatedDate { get; set; }
}
