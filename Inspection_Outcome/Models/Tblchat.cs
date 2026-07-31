using System;
using System.Collections.Generic;

namespace Inspection_Outcome.Models;

public partial class Tblchat
{
    public int Id { get; set; }

    public int? TicketNo { get; set; }

    public string? SenderChat { get; set; }

    public string? ReceiverChat { get; set; }

    public TimeOnly? ChatTime { get; set; }

    public DateTime? ChatDate { get; set; }

    public string? SenderName { get; set; }

    public int? SenderUserId { get; set; }

    public string? ReceiverName { get; set; }

    public int? ReceiverUserId { get; set; }

    public string? SattachDoc { get; set; }

    public string? RattachDoc { get; set; }
}
