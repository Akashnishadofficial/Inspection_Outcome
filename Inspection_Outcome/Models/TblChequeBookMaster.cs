using System;
using System.Collections.Generic;

namespace Inspection_Outcome.Models;

public partial class TblChequeBookMaster
{
    public int ChequeBookId { get; set; }

    public string BankName { get; set; } = null!;

    public string AccountNo { get; set; } = null!;

    public string ChequeFromNo { get; set; } = null!;

    public string ChequeToNo { get; set; } = null!;

    public int TotalCheques { get; set; }

    public DateOnly IssueDate { get; set; }

    public string? Status { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }
}
