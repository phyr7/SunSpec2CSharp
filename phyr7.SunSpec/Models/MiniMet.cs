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
  /// Include to support a few basic measurements
  [SunSpecModel(id: 308, length: 4)]
  public struct MiniMet
  {
    /// [W/m2]
    /// GHI - Global Horizontal Irradiance
    /// Global Horizontal Irradiance
    [SunSpecProperty(offset: 0, length: 1)]
    public UInt16? GHI { get; set; }
    /// [C]
    /// Temp - Back of module temperature measurement
    /// Back of module temperature measurement
    [SunSpecProperty(offset: 1, length: 1)]
    public Int16? TmpBOM { get; set; }
    /// [C]
    /// Ambient Temperature - 
    [SunSpecProperty(offset: 2, length: 1)]
    public Int16? TmpAmb { get; set; }
    /// [m/s]
    /// Wind Speed - 
    [SunSpecProperty(offset: 3, length: 1)]
    public UInt16? WndSpd { get; set; }
  }
}
