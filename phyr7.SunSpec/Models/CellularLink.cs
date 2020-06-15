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
  /// Include this model to support a cellular interface link
  [SunSpecModel(id: 18, length: 22)]
  public struct CellularLink
  {
    /// Name - Interface name
    /// Interface name
    [SunSpecProperty(offset: 0, length: 4)]
    public String? Nam { get; set; }
    /// IMEI - International Mobile Equipment Identifier for the interface
    /// International Mobile Equipment Identifier for the interface
    [SunSpecProperty(offset: 4, length: 1)]
    public UInt32? IMEI { get; set; }
    /// APN - Access Point Name for the interface
    /// Access Point Name for the interface
    [SunSpecProperty(offset: 6, length: 4)]
    public String? APN { get; set; }
    /// Number - Phone number for the interface
    /// Phone number for the interface
    [SunSpecProperty(offset: 10, length: 6)]
    public String? Num { get; set; }
    /// PIN - Personal Identification Number for the interface
    /// Personal Identification Number for the interface
    [SunSpecProperty(offset: 16, length: 6)]
    public String? Pin { get; set; }
  }
}
