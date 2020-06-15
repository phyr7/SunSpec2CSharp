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
  /// Include to support location measurements
  [SunSpecModel(id: 305, length: 36)]
  public struct Location
  {
    /// [hhmmss.sssZ]
    /// Tm - UTC 24 hour time stamp to millisecond hhmmss.sssZ format
    /// UTC 24 hour time stamp to millisecond hhmmss.sssZ format
    [SunSpecProperty(offset: 0, length: 6)]
    public String? Tm { get; set; }
    /// [YYYYMMDD]
    /// Date - UTC Date string YYYYMMDD format
    /// UTC Date string YYYYMMDD format
    [SunSpecProperty(offset: 6, length: 4)]
    public String? Date { get; set; }
    /// [text]
    /// Location - Location string (40 chars max)
    /// Location string (40 chars max)
    [SunSpecProperty(offset: 10, length: 20)]
    public String? Loc { get; set; }
    /// [Degrees]
    /// Lat - Latitude with seven degrees of precision
    /// Latitude with seven degrees of precision
    [SunSpecProperty(offset: 30, length: 1)]
    public Int32? Lat { get; set; }
    /// [Degrees]
    /// Long - Longitude with seven degrees of precision
    /// Longitude with seven degrees of precision
    [SunSpecProperty(offset: 32, length: 1)]
    public Int32? Long { get; set; }
    /// [meters]
    /// Altitude - Altitude measurement in meters
    /// Altitude measurement in meters
    [SunSpecProperty(offset: 34, length: 1)]
    public Int32? Alt { get; set; }
  }
}
