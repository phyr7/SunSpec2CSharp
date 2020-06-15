using System;

// ReSharper disable InconsistentNaming
// ReSharper disable IdentifierTypo
// ReSharper disable CommentTypo
// ReSharper disable UnusedType.Global
// ReSharper disable UnusedMember.Global
// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable UnusedAutoPropertyAccessor.Local
// ReSharper disable ArgumentsStyleLiteral
// ReSharper disable BuiltInTypeReferenceStyle
namespace phyr7.SunSpec.Models
{
  /// Base Meteorological Model
  /// NOTES: This model supersedes model 301
  [SunSpecModel(id: 307, length: 11)]
  public struct BaseMet
  {
    /// [C]
    /// Ambient Temperature - 
    [SunSpecProperty(offset: 0, length: 1)]
    public Int16? TmpAmb { get; set; }
    /// [Pct]
    /// Relative Humidity - 
    [SunSpecProperty(offset: 1, length: 1)]
    public Int16? RH { get; set; }
    /// [HPa]
    /// Barometric Pressure - 
    [SunSpecProperty(offset: 2, length: 1)]
    public Int16? Pres { get; set; }
    /// [mps]
    /// Wind Speed - 
    [SunSpecProperty(offset: 3, length: 1)]
    public Int16? WndSpd { get; set; }
    /// [deg]
    /// Wind Direction - 
    [SunSpecProperty(offset: 4, length: 1)]
    public Int16? WndDir { get; set; }
    /// [mm]
    /// Rainfall - 
    [SunSpecProperty(offset: 5, length: 1)]
    public Int16? Rain { get; set; }
    /// [mm]
    /// Snow Depth - 
    [SunSpecProperty(offset: 6, length: 1)]
    public Int16? Snw { get; set; }
    /// Precipitation Type -  Precipitation Type (WMO 4680 SYNOP code reference)
    ///  Precipitation Type (WMO 4680 SYNOP code reference)
    [SunSpecProperty(offset: 7, length: 1)]
    public Int16? PPT { get; set; }
    /// [Vm]
    /// Electric Field - 
    [SunSpecProperty(offset: 8, length: 1)]
    public Int16? ElecFld { get; set; }
    /// [kO]
    /// Surface Wetness - 
    [SunSpecProperty(offset: 9, length: 1)]
    public Int16? SurWet { get; set; }
    /// [Pct]
    /// Soil Wetness - 
    [SunSpecProperty(offset: 10, length: 1)]
    public Int16? SoilWet { get; set; }
  }
}
