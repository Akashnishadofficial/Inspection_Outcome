using System;
using System.Collections.Generic;

namespace Inspection_Outcome.Models;

public partial class TblEmailQueue
{
    public int Id { get; set; }

    public string? FromUser { get; set; }

    public string RecipientEmail { get; set; } = null!;

    public string? Ccemails { get; set; }

    public string? Bccemails { get; set; }

    public string Subject { get; set; } = null!;

    public string Body { get; set; } = null!;

    public string? Attachments { get; set; }

    public bool? IsSent { get; set; }

    public string? ErrorMessage { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? SentAt { get; set; }
}
