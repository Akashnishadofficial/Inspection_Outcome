using System;
using System.Collections.Generic;

namespace Inspection_Outcome.Models;

public partial class TblLead
{
    public int Leadid { get; set; }

    public string? LeadNo { get; set; }

    public string? LeadType { get; set; }

    public string? Solutation { get; set; }

    public string? Rating { get; set; }

    public string? Title { get; set; }

    public string? LeadStatus { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? LeadSource { get; set; }

    public string? LeadsourceOth { get; set; }

    public string? Brand { get; set; }

    public string? Referrer { get; set; }

    public string? Business { get; set; }

    public string? Email { get; set; }

    public string? HoldReason { get; set; }

    public string? LostReason { get; set; }

    public DateTime? FollowupDate { get; set; }

    public string? Company { get; set; }

    public string? Industries { get; set; }

    public string? Website { get; set; }

    public string? Streets { get; set; }

    public long? Zip { get; set; }

    public string? City { get; set; }

    public string? Country { get; set; }

    public string? State { get; set; }

    public string? Desicription { get; set; }

    public string? Contrycode { get; set; }

    public int? UserId { get; set; }

    public DateOnly? CreateDate { get; set; }

    public long? Phone { get; set; }

    public long? Mobil { get; set; }
}
