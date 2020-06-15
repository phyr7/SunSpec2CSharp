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
  /// Include to support a standard reference point
  [SunSpecModel(id: 306, length: 4)]
  public struct RefPoint
  {
    /// [W/m2]
    /// GHI - Global Horizontal Irradiance
    /// Global Horizontal Irradiance
    [SunSpecProperty(offset: 0, length: 1)]
    public UInt16? GHI { get; set; }
    /// [W/m2]
    /// Amps - Current measurement at reference point
    /// Current measurement at reference point
    [SunSpecProperty(offset: 1, length: 1)]
    public UInt16? A { get; set; }
    /// [W/m2]
    /// Voltage - Voltage  measurement at reference point
    /// Voltage  measurement at reference point
    [SunSpecProperty(offset: 2, length: 1)]
    public UInt16? V { get; set; }
    /// [W/m2]
    /// Temperature - Temperature measurement at reference point
    /// Temperature measurement at reference point
    [SunSpecProperty(offset: 3, length: 1)]
    public UInt16? Tmp { get; set; }
  }
}
