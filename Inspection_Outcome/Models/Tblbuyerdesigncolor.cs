using System;
using System.Collections.Generic;

namespace Inspection_Outcome.Models;

public partial class Tblbuyerdesigncolor
{
    public int Id { get; set; }

    public string? Bno { get; set; }

    public string? Buyercode { get; set; }

    public string? Designno { get; set; }

    public string? Quality { get; set; }

    public string? Collection { get; set; }

    public string? Colour { get; set; }

    public string? Pdesign { get; set; }

    public string? EntryBy { get; set; }

    public DateTime? EntryDate { get; set; }

    public bool Latex { get; set; }

    public bool Berai { get; set; }

    public bool Streching { get; set; }

    public bool PattiMori { get; set; }

    public bool Clipping { get; set; }

    public bool Washing { get; set; }

    public bool Iiibacking { get; set; }

    public bool Embossing { get; set; }

    public bool Binding { get; set; }

    public bool Newar { get; set; }
}
