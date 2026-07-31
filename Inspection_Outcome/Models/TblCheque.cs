using System;
using System.Collections.Generic;

namespace Inspection_Outcome.Models;

public partial class TblCheque
{
    public int ChequeId { get; set; }

    public int? DocNo { get; set; }

    public string? BankName { get; set; }

    public string ChequeNo { get; set; } = null!;

    public string PayeeName { get; set; } = null!;

    public decimal Amount { get; set; }

    public DateOnly ChequeDate { get; set; }

    public string? Status { get; set; }

    public string? ChequeType { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedAt { get; set; }

    public string? GroupName { get; set; }

    public string? PayeeCode { get; set; }

    public string? AccountNo { get; set; }
}
