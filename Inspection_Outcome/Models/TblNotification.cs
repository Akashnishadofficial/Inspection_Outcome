using System;
using System.Collections.Generic;

namespace Inspection_Outcome.Models;

public partial class TblNotification
{
    public int Id { get; set; }

    public string? FromUser { get; set; }

    public string? ToUser { get; set; }

    public string? NotificationType { get; set; }

    public string? Message { get; set; }

    public DateTime? CreatedDate { get; set; }

    public bool? IsRead { get; set; }

    public bool? IsSend { get; set; }

    public DateTime? ReadDate { get; set; }

    public string? SrNo { get; set; }

    public bool? IsRead1 { get; set; }

    public bool? IsSend1 { get; set; }
}
