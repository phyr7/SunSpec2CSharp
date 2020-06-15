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
  /// Immediate Inverter Controls 
  /// NOTES: Ref 3: 8.7.1.2, 8.7.2.2, 8.7.3.2
  [SunSpecModel(id: 123, length: 24)]
  public struct Controls
  {
    /// [Secs]
    /// Conn_WinTms - Time window for connect/disconnect.
    /// Time window for connect/disconnect.
    [SunSpecProperty(offset: 0, length: 1)]
    public UInt16? Conn_WinTms { get; set; }
    /// [Secs]
    /// Conn_RvrtTms - Timeout period for connect/disconnect.
    /// Timeout period for connect/disconnect.
    [SunSpecProperty(offset: 1, length: 1)]
    public UInt16? Conn_RvrtTms { get; set; }
    public enum E_Conn : UInt16
    {
      DISCONNECT = 0,
      CONNECT = 1,
    }
    /// Conn - Enumerated valued.  Connection control.
    /// Enumerated valued.  Connection control.
    [SunSpecProperty(offset: 2, length: 1)]
    public E_Conn Conn { get; set; }
    /// [% WMax]
    /// WMaxLimPct - Set power output to specified level.
    /// Set power output to specified level.
    [SunSpecProperty(offset: 3, length: 1)]
    public UInt16 WMaxLimPct { get; set; }
    /// [Secs]
    /// WMaxLimPct_WinTms - Time window for power limit change.
    /// Time window for power limit change.
    [SunSpecProperty(offset: 4, length: 1)]
    public UInt16? WMaxLimPct_WinTms { get; set; }
    /// [Secs]
    /// WMaxLimPct_RvrtTms - Timeout period for power limit.
    /// Timeout period for power limit.
    [SunSpecProperty(offset: 5, length: 1)]
    public UInt16? WMaxLimPct_RvrtTms { get; set; }
    /// [Secs]
    /// WMaxLimPct_RmpTms - Ramp time for moving from current setpoint to new setpoint.
    /// Ramp time for moving from current setpoint to new setpoint.
    [SunSpecProperty(offset: 6, length: 1)]
    public UInt16? WMaxLimPct_RmpTms { get; set; }
    public enum E_WMaxLim_Ena : UInt16
    {
      DISABLED = 0,
      ENABLED = 1,
    }
    /// WMaxLim_Ena - Enumerated valued.  Throttle enable/disable control.
    /// Enumerated valued.  Throttle enable/disable control.
    [SunSpecProperty(offset: 7, length: 1)]
    public E_WMaxLim_Ena WMaxLim_Ena { get; set; }
    /// [cos()]
    /// OutPFSet - Set power factor to specific value - cosine of angle.
    /// Set power factor to specific value - cosine of angle.
    [SunSpecProperty(offset: 8, length: 1)]
    public Int16 OutPFSet { get; set; }
    /// [Secs]
    /// OutPFSet_WinTms - Time window for power factor change.
    /// Time window for power factor change.
    [SunSpecProperty(offset: 9, length: 1)]
    public UInt16? OutPFSet_WinTms { get; set; }
    /// [Secs]
    /// OutPFSet_RvrtTms - Timeout period for power factor.
    /// Timeout period for power factor.
    [SunSpecProperty(offset: 10, length: 1)]
    public UInt16? OutPFSet_RvrtTms { get; set; }
    /// [Secs]
    /// OutPFSet_RmpTms - Ramp time for moving from current setpoint to new setpoint.
    /// Ramp time for moving from current setpoint to new setpoint.
    [SunSpecProperty(offset: 11, length: 1)]
    public UInt16? OutPFSet_RmpTms { get; set; }
    public enum E_OutPFSet_Ena : UInt16
    {
      DISABLED = 0,
      ENABLED = 1,
    }
    /// OutPFSet_Ena - Enumerated valued.  Fixed power factor enable/disable control.
    /// Enumerated valued.  Fixed power factor enable/disable control.
    [SunSpecProperty(offset: 12, length: 1)]
    public E_OutPFSet_Ena OutPFSet_Ena { get; set; }
    /// [% WMax]
    /// VArWMaxPct - Reactive power in percent of WMax.
    /// Reactive power in percent of WMax.
    [SunSpecProperty(offset: 13, length: 1)]
    public Int16? VArWMaxPct { get; set; }
    /// [% VArMax]
    /// VArMaxPct - Reactive power in percent of VArMax.
    /// Reactive power in percent of VArMax.
    [SunSpecProperty(offset: 14, length: 1)]
    public Int16? VArMaxPct { get; set; }
    /// [% VArAval]
    /// VArAvalPct - Reactive power in percent of VArAval.
    /// Reactive power in percent of VArAval.
    [SunSpecProperty(offset: 15, length: 1)]
    public Int16? VArAvalPct { get; set; }
    /// [Secs]
    /// VArPct_WinTms - Time window for VAR limit change.
    /// Time window for VAR limit change.
    [SunSpecProperty(offset: 16, length: 1)]
    public UInt16? VArPct_WinTms { get; set; }
    /// [Secs]
    /// VArPct_RvrtTms - Timeout period for VAR limit.
    /// Timeout period for VAR limit.
    [SunSpecProperty(offset: 17, length: 1)]
    public UInt16? VArPct_RvrtTms { get; set; }
    /// [Secs]
    /// VArPct_RmpTms - Ramp time for moving from current setpoint to new setpoint.
    /// Ramp time for moving from current setpoint to new setpoint.
    [SunSpecProperty(offset: 18, length: 1)]
    public UInt16? VArPct_RmpTms { get; set; }
    public enum E_VArPct_Mod : UInt16
    {
      NONE = 0,
      WMax = 1,
      VArMax = 2,
      VArAval = 3,
    }
    /// VArPct_Mod - Enumerated value. VAR percent limit mode.
    /// Enumerated value. VAR percent limit mode.
    [SunSpecProperty(offset: 19, length: 1)]
    public E_VArPct_Mod? VArPct_Mod { get; set; }
    public enum E_VArPct_Ena : UInt16
    {
      DISABLED = 0,
      ENABLED = 1,
    }
    /// VArPct_Ena - Enumerated valued.  Percent limit VAr enable/disable control.
    /// Enumerated valued.  Percent limit VAr enable/disable control.
    [SunSpecProperty(offset: 20, length: 1)]
    public E_VArPct_Ena VArPct_Ena { get; set; }
    /// WMaxLimPct_SF - Scale factor for power output percent.
    /// Scale factor for power output percent.
    [SunSpecProperty(offset: 21, length: 1)]
    public Int16 WMaxLimPct_SF { get; private set; }
    /// OutPFSet_SF - Scale factor for power factor.
    /// Scale factor for power factor.
    [SunSpecProperty(offset: 22, length: 1)]
    public Int16 OutPFSet_SF { get; private set; }
    /// VArPct_SF - Scale factor for reactive power percent.
    /// Scale factor for reactive power percent.
    [SunSpecProperty(offset: 23, length: 1)]
    public Int16? VArPct_SF { get; private set; }
  }
}
