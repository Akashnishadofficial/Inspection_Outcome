using System;
using System.Collections.Generic;

namespace Inspection_Outcome.Models;

public partial class TblAreaMst
{
    public int Id { get; set; }

    public int? Sno { get; set; }

    public string? ProjectName { get; set; }

    public string? AreaCode { get; set; }

    public string? AreaName { get; set; }

    public string? AreaNameIfOth { get; set; }

    public decimal? Area { get; set; }

    public DateTime? Deliverydt { get; set; }

    public string? ProductName { get; set; }

    public string? Material { get; set; }

    public string? Color { get; set; }

    public string? MaterialIfOth { get; set; }

    public string? Quality { get; set; }

    public string? Texture { get; set; }

    public string? InstallationType { get; set; }

    public string? Construction { get; set; }

    public string? OtherDetails { get; set; }

    public string? Unit { get; set; }

    public string? SubUnit { get; set; }

    public int? WidthUnit { get; set; }

    public int? WidthSubUnit { get; set; }

    public int? LengthUnit { get; set; }

    public int? LengthSubUnit { get; set; }

    public decimal? Width { get; set; }

    public decimal? Length { get; set; }

    public decimal? CustomAreaUnit { get; set; }

    public decimal? RatePerSqFeet { get; set; }

    public decimal? RatePerSqMeter { get; set; }

    public int? NoofPieces { get; set; }

    public decimal? Discount { get; set; }

    public decimal? DiscountPerArea { get; set; }

    public decimal? DiscountedAmount { get; set; }

    public string? ProductImage { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? ModifyDate { get; set; }

    public int? UserId { get; set; }
}
