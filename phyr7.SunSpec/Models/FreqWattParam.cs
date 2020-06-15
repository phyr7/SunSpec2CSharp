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
  /// Parameterized Frequency-Watt 
  /// NOTES: Ref 3: 8.9.1.2, 8.9.4.2
  [SunSpecModel(id: 127, length: 10)]
  public struct FreqWattParam
  {
    /// [% PM/Hz]
    /// WGra - The slope of the reduction in the maximum allowed watts output as a function of frequency.
    /// The slope of the reduction in the maximum allowed watts output as a function of frequency.
    [SunSpecProperty(offset: 0, length: 1)]
    public UInt16 WGra { get; set; }
    /// [Hz]
    /// HzStr - The frequency deviation from nominal frequency (ECPNomHz) at which a snapshot of the instantaneous power output is taken to act as the CAPPED power level (PM) and above which reduction in power output occurs.
    /// The frequency deviation from nominal frequency (ECPNomHz) at which a snapshot of the instantaneous power output is taken to act as the CAPPED power level (PM) and above which reduction in power output occurs.
    [SunSpecProperty(offset: 1, length: 1)]
    public Int16 HzStr { get; set; }
    /// [Hz]
    /// HzStop - The frequency deviation from nominal frequency (ECPNomHz) at which curtailed power output may return to normal and the cap on the power level value is removed.
    /// The frequency deviation from nominal frequency (ECPNomHz) at which curtailed power output may return to normal and the cap on the power level value is removed.
    [SunSpecProperty(offset: 2, length: 1)]
    public Int16 HzStop { get; set; }
    [Flags]
    public enum E_HysEna : UInt16
    {
      ENABLED = 0,
    }
    /// HysEna - Enable hysteresis
    /// Enable hysteresis
    [SunSpecProperty(offset: 3, length: 1)]
    public E_HysEna HysEna { get; set; }
    [Flags]
    public enum E_ModEna : UInt16
    {
      ENABLED = 0,
    }
    /// ModEna - Is Parameterized Frequency-Watt control active.
    /// Is Parameterized Frequency-Watt control active.
    [SunSpecProperty(offset: 4, length: 1)]
    public E_ModEna ModEna { get; set; }
    /// [% WMax/min]
    /// HzStopWGra - The maximum time-based rate of change at which power output returns to normal after having been capped by an over frequency event.
    /// The maximum time-based rate of change at which power output returns to normal after having been capped by an over frequency event.
    [SunSpecProperty(offset: 5, length: 1)]
    public UInt16? HzStopWGra { get; set; }
    /// WGra_SF - Scale factor for output gradient.
    /// Scale factor for output gradient.
    [SunSpecProperty(offset: 6, length: 1)]
    public Int16? WGra_SF { get; private set; }
    /// HzStrStop_SF - Scale factor for frequency deviations.
    /// Scale factor for frequency deviations.
    [SunSpecProperty(offset: 7, length: 1)]
    public Int16? HzStrStop_SF { get; private set; }
    /// RmpIncDec_SF - Scale factor for increment and decrement ramps.
    /// Scale factor for increment and decrement ramps.
    [SunSpecProperty(offset: 8, length: 1)]
    public Int16? RmpIncDec_SF { get; private set; }
    [SunSpecProperty(offset: 9, length: 1)]
    public UInt16? Pad { get; private set; }
  }
}
