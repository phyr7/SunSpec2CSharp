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
  /// Include this model for three phase inverter monitoring using float values
  [SunSpecModel(id: 113, length: 60)]
  public struct Inverter
  {
    /// [A]
    /// Amps - AC Current
    /// AC Current
    /// NOTES: Sum of active phases
    [SunSpecProperty(offset: 0, length: 1)]
    public Single A { get; set; }
    /// [A]
    /// Amps PhaseA - Phase A Current
    /// Phase A Current
    /// NOTES: Connected Phase
    [SunSpecProperty(offset: 2, length: 1)]
    public Single AphA { get; set; }
    /// [A]
    /// Amps PhaseB - Phase B Current
    /// Phase B Current
    /// NOTES: Connected Phase
    [SunSpecProperty(offset: 4, length: 1)]
    public Single AphB { get; set; }
    /// [A]
    /// Amps PhaseC - Phase C Current
    /// Phase C Current
    /// NOTES: Connected Phase
    [SunSpecProperty(offset: 6, length: 1)]
    public Single AphC { get; set; }
    /// [V]
    /// Phase Voltage AB - Phase Voltage AB
    /// Phase Voltage AB
    [SunSpecProperty(offset: 8, length: 1)]
    public Single? PPVphAB { get; set; }
    /// [V]
    /// Phase Voltage BC - Phase Voltage BC
    /// Phase Voltage BC
    [SunSpecProperty(offset: 10, length: 1)]
    public Single? PPVphBC { get; set; }
    /// [V]
    /// Phase Voltage CA - Phase Voltage CA
    /// Phase Voltage CA
    [SunSpecProperty(offset: 12, length: 1)]
    public Single? PPVphCA { get; set; }
    /// [V]
    /// Phase Voltage AN - Phase Voltage AN
    /// Phase Voltage AN
    [SunSpecProperty(offset: 14, length: 1)]
    public Single PhVphA { get; set; }
    /// [V]
    /// Phase Voltage BN - Phase Voltage BN
    /// Phase Voltage BN
    [SunSpecProperty(offset: 16, length: 1)]
    public Single PhVphB { get; set; }
    /// [V]
    /// Phase Voltage CN - Phase Voltage CN
    /// Phase Voltage CN
    [SunSpecProperty(offset: 18, length: 1)]
    public Single PhVphC { get; set; }
    /// [W]
    /// Watts - AC Power
    /// AC Power
    [SunSpecProperty(offset: 20, length: 1)]
    public Single W { get; set; }
    /// [Hz]
    /// Hz - Line Frequency
    /// Line Frequency
    [SunSpecProperty(offset: 22, length: 1)]
    public Single Hz { get; set; }
    /// [VA]
    /// VA - AC Apparent Power
    /// AC Apparent Power
    [SunSpecProperty(offset: 24, length: 1)]
    public Single? VA { get; set; }
    /// [var]
    /// VAr - AC Reactive Power
    /// AC Reactive Power
    [SunSpecProperty(offset: 26, length: 1)]
    public Single? VAr { get; set; }
    /// [Pct]
    /// PF - AC Power Factor
    /// AC Power Factor
    [SunSpecProperty(offset: 28, length: 1)]
    public Single? PF { get; set; }
    /// [Wh]
    /// WattHours - AC Energy
    /// AC Energy
    [SunSpecProperty(offset: 30, length: 1)]
    public Single WH { get; set; }
    /// [A]
    /// DC Amps - DC Current
    /// DC Current
    [SunSpecProperty(offset: 32, length: 1)]
    public Single? DCA { get; set; }
    /// [V]
    /// DC Voltage - DC Voltage
    /// DC Voltage
    [SunSpecProperty(offset: 34, length: 1)]
    public Single? DCV { get; set; }
    /// [W]
    /// DC Watts - DC Power
    /// DC Power
    [SunSpecProperty(offset: 36, length: 1)]
    public Single? DCW { get; set; }
    /// [C]
    /// Cabinet Temperature - Cabinet Temperature
    /// Cabinet Temperature
    [SunSpecProperty(offset: 38, length: 1)]
    public Single TmpCab { get; set; }
    /// [C]
    /// Heat Sink Temperature - Heat Sink Temperature
    /// Heat Sink Temperature
    [SunSpecProperty(offset: 40, length: 1)]
    public Single? TmpSnk { get; set; }
    /// [C]
    /// Transformer Temperature - Transformer Temperature
    /// Transformer Temperature
    [SunSpecProperty(offset: 42, length: 1)]
    public Single? TmpTrns { get; set; }
    /// [C]
    /// Other Temperature - Other Temperature
    /// Other Temperature
    [SunSpecProperty(offset: 44, length: 1)]
    public Single? TmpOt { get; set; }
    public enum E_St : UInt16
    {
      OFF = 1,
      SLEEPING = 2,
      STARTING = 3,
      MPPT = 4,
      THROTTLED = 5,
      SHUTTING_DOWN = 6,
      FAULT = 7,
      STANDBY = 8,
    }
    /// Operating State - Enumerated value.  Operating state
    /// Enumerated value.  Operating state
    [SunSpecProperty(offset: 46, length: 1)]
    public E_St St { get; set; }
    public enum E_StVnd : UInt16
    {
    }
    /// Vendor Operating State - Vendor specific operating state code
    /// Vendor specific operating state code
    [SunSpecProperty(offset: 47, length: 1)]
    public E_StVnd? StVnd { get; set; }
    [Flags]
    public enum E_Evt1 : UInt32
    {
      GROUND_FAULT = 0,
      DC_OVER_VOLT = 1,
      AC_DISCONNECT = 2,
      DC_DISCONNECT = 3,
      GRID_DISCONNECT = 4,
      CABINET_OPEN = 5,
      MANUAL_SHUTDOWN = 6,
      OVER_TEMP = 7,
      OVER_FREQUENCY = 8,
      UNDER_FREQUENCY = 9,
      AC_OVER_VOLT = 10,
      AC_UNDER_VOLT = 11,
      BLOWN_STRING_FUSE = 12,
      UNDER_TEMP = 13,
      MEMORY_LOSS = 14,
      HW_TEST_FAILURE = 15,
    }
    /// Event1 - Bitmask value. Event fields
    /// Bitmask value. Event fields
    [SunSpecProperty(offset: 48, length: 1)]
    public E_Evt1 Evt1 { get; set; }
    [Flags]
    public enum E_Evt2 : UInt32
    {
    }
    /// Event Bitfield 2 - Reserved for future use
    /// Reserved for future use
    [SunSpecProperty(offset: 50, length: 1)]
    public E_Evt2 Evt2 { get; set; }
    [Flags]
    public enum E_EvtVnd1 : UInt32
    {
    }
    /// Vendor Event Bitfield 1 - Vendor defined events
    /// Vendor defined events
    [SunSpecProperty(offset: 52, length: 1)]
    public E_EvtVnd1? EvtVnd1 { get; set; }
    [Flags]
    public enum E_EvtVnd2 : UInt32
    {
    }
    /// Vendor Event Bitfield 2 - Vendor defined events
    /// Vendor defined events
    [SunSpecProperty(offset: 54, length: 1)]
    public E_EvtVnd2? EvtVnd2 { get; set; }
    [Flags]
    public enum E_EvtVnd3 : UInt32
    {
    }
    /// Vendor Event Bitfield 3 - Vendor defined events
    /// Vendor defined events
    [SunSpecProperty(offset: 56, length: 1)]
    public E_EvtVnd3? EvtVnd3 { get; set; }
    [Flags]
    public enum E_EvtVnd4 : UInt32
    {
    }
    /// Vendor Event Bitfield 4 - Vendor defined events
    /// Vendor defined events
    [SunSpecProperty(offset: 58, length: 1)]
    public E_EvtVnd4? EvtVnd4 { get; set; }
  }
}
