using System;
using System.Collections.Generic;

namespace Inspection_Outcome.Models;

public partial class TblTicket
{
    public int Id { get; set; }

    public int? Userid { get; set; }

    public string? Fullname { get; set; }

    public string? Emailaddress { get; set; }

    public string? Mobileno { get; set; }

    public string? Domain { get; set; }

    public string? HelpTopic { get; set; }

    public string? Subject { get; set; }

    public string? Message { get; set; }

    public string? Remark { get; set; }

    public string? Priority { get; set; }

    public string? CaptchaText { get; set; }

    public string? EnterCaptcha { get; set; }

    public bool? Isdelete { get; set; }

    public string? Tooltip { get; set; }

    public string? Fallow { get; set; }

    public string? Status { get; set; }

    public string? Img { get; set; }

    public string? Uploadfile { get; set; }

    public DateTime Lastupdate { get; set; }

    public bool? Isactive { get; set; }

    public DateTime? CloseTicketDate { get; set; }

    public string? ClosedTicketByName { get; set; }

    public int? ClosedTicketById { get; set; }

    public DateTime? GenerateTicketBy { get; set; }

    public DateTime? Etd { get; set; }
}
