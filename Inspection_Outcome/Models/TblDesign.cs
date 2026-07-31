using System;
using System.Collections.Generic;

namespace Inspection_Outcome.Models;

public partial class TblDesign
{
    public int DesignId { get; set; }

    public string? DesignNo { get; set; }

    public string? Design { get; set; }

    public string? Quality { get; set; }

    public string? Colour { get; set; }

    public string? Collection { get; set; }

    public string? Reference { get; set; }

    public float? Loss { get; set; }

    public string? Path { get; set; }

    public string? Latex { get; set; }

    public string? Woolquality { get; set; }

    public string? Woolquality1 { get; set; }

    public string? Woolquality2 { get; set; }

    public string? Woolquality3 { get; set; }

    public string? Othermaterial { get; set; }

    public string? Dyeing { get; set; }

    public string? Ply { get; set; }

    public string? Plytwist { get; set; }

    public string? Heightprod { get; set; }

    public string? Heightfinish { get; set; }

    public string? Washing { get; set; }

    public string? Jalli { get; set; }

    public string? Bindingyn { get; set; }

    public string? Fringes { get; set; }

    public string? Iiird { get; set; }

    public string? Newar { get; set; }

    public string? Finish { get; set; }

    public string? Areawall { get; set; }

    public string? Hsn { get; set; }

    public string? Composition { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? Modifydate { get; set; }

    public int? Userid { get; set; }
}
