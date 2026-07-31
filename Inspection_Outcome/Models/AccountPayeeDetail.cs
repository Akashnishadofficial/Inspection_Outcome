using System;
using System.Collections.Generic;

namespace Inspection_Outcome.Models;

public partial class AccountPayeeDetail
{
    public int Id { get; set; }

    public string? PayeeCode { get; set; }

    public string PayeeName { get; set; } = null!;

    public string? BankName { get; set; }

    public string? BranchName { get; set; }

    public string? Ifsccode { get; set; }

    public string? AccountNumber { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public string? AccountCategory { get; set; }

    public string? Centre { get; set; }
}
