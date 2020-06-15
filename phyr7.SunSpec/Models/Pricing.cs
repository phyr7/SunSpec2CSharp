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
  /// Pricing Signal  
  /// NOTES: Ref 3: 8.7.5.1; Ref 4: 6
  [SunSpecModel(id: 125, length: 8)]
  public struct Pricing
  {
    [Flags]
    public enum E_ModEna : UInt16
    {
      ENABLE = 0,
    }
    /// ModEna - Is price-based charge/discharge mode active?
    /// Is price-based charge/discharge mode active?
    [SunSpecProperty(offset: 0, length: 1)]
    public E_ModEna ModEna { get; set; }
    public enum E_SigType : UInt16
    {
      UNKNOWN = 0,
      ABSOLUTE = 1,
      RELATIVE = 2,
      MULTIPLIER = 3,
      LEVEL = 4,
    }
    /// SigType - Meaning of the pricing signal. When a Price schedule is used, type must match the schedule range variable description.
    /// Meaning of the pricing signal. When a Price schedule is used, type must match the schedule range variable description.
    [SunSpecProperty(offset: 1, length: 1)]
    public E_SigType? SigType { get; set; }
    /// Sig - Utility/ESP specific pricing signal. Content depends on pricing signal type. When H/M/L type is specified. Low=0; Med=1; High=2.
    /// Utility/ESP specific pricing signal. Content depends on pricing signal type. When H/M/L type is specified. Low=0; Med=1; High=2.
    [SunSpecProperty(offset: 2, length: 1)]
    public Int16 Sig { get; set; }
    /// [Secs]
    /// WinTms - Time window for charge/discharge pricing change.
    /// Time window for charge/discharge pricing change.
    [SunSpecProperty(offset: 3, length: 1)]
    public UInt16? WinTms { get; set; }
    /// [Secs]
    /// RvtTms - Timeout period for charge/discharge pricing change.
    /// Timeout period for charge/discharge pricing change.
    [SunSpecProperty(offset: 4, length: 1)]
    public UInt16? RvtTms { get; set; }
    /// [Secs]
    /// RmpTms - Ramp time for moving from current charge or discharge level to new level.
    /// Ramp time for moving from current charge or discharge level to new level.
    [SunSpecProperty(offset: 5, length: 1)]
    public UInt16? RmpTms { get; set; }
    /// Sig_SF - Pricing signal scale factor.
    /// Pricing signal scale factor.
    [SunSpecProperty(offset: 6, length: 1)]
    public Int16 Sig_SF { get; private set; }
    [SunSpecProperty(offset: 7, length: 1)]
    public UInt16? Pad { get; private set; }
  }
}
