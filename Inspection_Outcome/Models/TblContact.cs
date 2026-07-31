using System;
using System.Collections.Generic;

namespace Inspection_Outcome.Models;

public partial class TblContact
{
    public int Id { get; set; }

    public string? ClientName { get; set; }

    public string? Salutation { get; set; }

    public string? FirstName { get; set; }

    public string? MiddleName { get; set; }

    public string? LastName { get; set; }

    public string? Suffix { get; set; }

    public string? Title { get; set; }

    public string? ContactType { get; set; }

    public string? ContactTypeOth { get; set; }

    public string? Email { get; set; }

    public int? Mobile { get; set; }

    public int? Phone { get; set; }

    public string? MailingStreets { get; set; }

    public string? MailingCity { get; set; }

    public string? MailingState { get; set; }

    public int? Mailingzip { get; set; }

    public string? MailingCountry { get; set; }

    public string? EntryBy { get; set; }

    public DateTime? EntrdyDt { get; set; }

    public string? UpdateBy { get; set; }

    public DateTime? Updatedt { get; set; }

    public int? Userid { get; set; }
}
