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
  /// Inverter Controls Extended Measurements and Status 
  /// NOTES: Ref 3: 8.14.3.2, Ref 4: 17
  [SunSpecModel(id: 122, length: 44)]
  public struct Status
  {
    [Flags]
    public enum E_PVConn : UInt16
    {
      CONNECTED = 0,
      AVAILABLE = 1,
      OPERATING = 2,
      TEST = 3,
    }
    /// PVConn - PV inverter present/available status. Enumerated value.
    /// PV inverter present/available status. Enumerated value.
    [SunSpecProperty(offset: 0, length: 1)]
    public E_PVConn PVConn { get; private set; }
    [Flags]
    public enum E_StorConn : UInt16
    {
      CONNECTED = 0,
      AVAILABLE = 1,
      OPERATING = 2,
      TEST = 3,
    }
    /// StorConn - Storage inverter present/available status. Enumerated value.
    /// Storage inverter present/available status. Enumerated value.
    [SunSpecProperty(offset: 1, length: 1)]
    public E_StorConn StorConn { get; private set; }
    [Flags]
    public enum E_ECPConn : UInt16
    {
      CONNECTED = 0,
    }
    /// ECPConn - ECP connection status: disconnected=0  connected=1.
    /// ECP connection status: disconnected=0  connected=1.
    [SunSpecProperty(offset: 2, length: 1)]
    public E_ECPConn ECPConn { get; private set; }
    /// [Wh]
    /// ActWh - AC lifetime active (real) energy output.
    /// AC lifetime active (real) energy output.
    [SunSpecProperty(offset: 3, length: 4)]
    public UInt64? ActWh { get; private set; }
    /// [VAh]
    /// ActVAh - AC lifetime apparent energy output.
    /// AC lifetime apparent energy output.
    [SunSpecProperty(offset: 7, length: 4)]
    public UInt64? ActVAh { get; private set; }
    /// [varh]
    /// ActVArhQ1 - AC lifetime reactive energy output in quadrant 1.
    /// AC lifetime reactive energy output in quadrant 1.
    [SunSpecProperty(offset: 11, length: 4)]
    public UInt64? ActVArhQ1 { get; private set; }
    /// [varh]
    /// ActVArhQ2 - AC lifetime reactive energy output in quadrant 2.
    /// AC lifetime reactive energy output in quadrant 2.
    [SunSpecProperty(offset: 15, length: 4)]
    public UInt64? ActVArhQ2 { get; private set; }
    /// [varh]
    /// ActVArhQ3 - AC lifetime negative energy output  in quadrant 3.
    /// AC lifetime negative energy output  in quadrant 3.
    [SunSpecProperty(offset: 19, length: 4)]
    public UInt64? ActVArhQ3 { get; private set; }
    /// [varh]
    /// ActVArhQ4 - AC lifetime reactive energy output  in quadrant 4.
    /// AC lifetime reactive energy output  in quadrant 4.
    [SunSpecProperty(offset: 23, length: 4)]
    public UInt64? ActVArhQ4 { get; private set; }
    /// [var]
    /// VArAval - Amount of VARs available without impacting watts output.
    /// Amount of VARs available without impacting watts output.
    [SunSpecProperty(offset: 27, length: 1)]
    public Int16? VArAval { get; private set; }
    /// VArAval_SF - Scale factor for available VARs.
    /// Scale factor for available VARs.
    [SunSpecProperty(offset: 28, length: 1)]
    public Int16? VArAval_SF { get; private set; }
    /// [var]
    /// WAval - Amount of Watts available.
    /// Amount of Watts available.
    [SunSpecProperty(offset: 29, length: 1)]
    public UInt16? WAval { get; private set; }
    /// WAval_SF - Scale factor for available Watts.
    /// Scale factor for available Watts.
    [SunSpecProperty(offset: 30, length: 1)]
    public Int16? WAval_SF { get; private set; }
    [Flags]
    public enum E_StSetLimMsk : UInt32
    {
      WMax = 0,
      VAMax = 1,
      VArAval = 2,
      VArMaxQ1 = 3,
      VArMaxQ2 = 4,
      VArMaxQ3 = 5,
      VArMaxQ4 = 6,
      PFMinQ1 = 7,
      PFMinQ2 = 8,
      PFMinQ3 = 9,
      PFMinQ4 = 10,
    }
    /// StSetLimMsk - Bit Mask indicating setpoint limit(s) reached.
    /// Bit Mask indicating setpoint limit(s) reached.
    /// NOTES: Bits shall be automatically cleared on read.
    [SunSpecProperty(offset: 31, length: 2)]
    public E_StSetLimMsk? StSetLimMsk { get; private set; }
    [Flags]
    public enum E_StActCtl : UInt32
    {
      FixedW = 0,
      FixedVAR = 1,
      FixedPF = 2,
      Volt_VAr = 3,
      Freq_Watt_Param = 4,
      Freq_Watt_Curve = 5,
      Dyn_Reactive_Current = 6,
      LVRT = 7,
      HVRT = 8,
      Watt_PF = 9,
      Volt_Watt = 10,
      Scheduled = 12,
      LFRT = 13,
      HFRT = 14,
    }
    /// StActCtl - Bit Mask indicating which inverter controls are currently active.
    /// Bit Mask indicating which inverter controls are currently active.
    [SunSpecProperty(offset: 33, length: 2)]
    public E_StActCtl? StActCtl { get; private set; }
    /// TmSrc - Source of time synchronization.
    /// Source of time synchronization.
    [SunSpecProperty(offset: 35, length: 4)]
    public String? TmSrc { get; private set; }
    /// [Secs]
    /// Tms - Seconds since 01-01-2000 00:00 UTC
    /// Seconds since 01-01-2000 00:00 UTC
    [SunSpecProperty(offset: 39, length: 2)]
    public UInt32? Tms { get; private set; }
    [Flags]
    public enum E_RtSt : UInt16
    {
      LVRT_ACTIVE = 0,
      HVRT_ACTIVE = 1,
      LFRT_ACTIVE = 2,
      HFRT_ACTIVE = 3,
    }
    /// RtSt - Bit Mask indicating active ride-through status.
    /// Bit Mask indicating active ride-through status.
    [SunSpecProperty(offset: 41, length: 1)]
    public E_RtSt? RtSt { get; private set; }
    /// [ohms]
    /// Ris - Isolation resistance.
    /// Isolation resistance.
    [SunSpecProperty(offset: 42, length: 1)]
    public UInt16? Ris { get; private set; }
    /// Ris_SF - Scale factor for isolation resistance.
    /// Scale factor for isolation resistance.
    [SunSpecProperty(offset: 43, length: 1)]
    public Int16? Ris_SF { get; private set; }
  }
}
