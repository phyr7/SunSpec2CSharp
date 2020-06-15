using System;

{
  /// A solar module model supporting DC-DC converter
  /// NOTES: Integer
  [SunSpecModel(id: 502, length: 28)]
  public class SolarModule
  {
    /// Current scale factor
    [SunSpecProperty(offset: 0, length: 1)]
    public Int16? A_SF { get; set; }
    /// Voltage scale factor
    [SunSpecProperty(offset: 1, length: 1)]
    public Int16? V_SF { get; set; }
    /// Power scale factor
    [SunSpecProperty(offset: 2, length: 1)]
    public Int16? W_SF { get; set; }
    /// Energy scale factor
    [SunSpecProperty(offset: 3, length: 1)]
    public Int16? Wh_SF { get; set; }
    public enum E_Stat : UInt16
    {
      OFF = 1,
      SLEEPING = 2,
      STARTING = 3,
      MPPT = 4,
      THROTTLED = 5,
      SHUTTING_DOWN = 6,
      FAULT = 7,
      STANDBY = 8,
      TEST = 9,
      OTHER = 10,
    }
    /// Status - Enumerated value.  Module Status Code
    /// Enumerated value.  Module Status Code
    [SunSpecProperty(offset: 4, length: 1)]
    public E_Stat Stat { get; set; }
    public enum E_StatVend : UInt16
    {
    }
    /// Vendor Status - Module Vendor Status Code
    /// Module Vendor Status Code
    [SunSpecProperty(offset: 5, length: 1)]
    public E_StatVend? StatVend { get; set; }
    [Flags]
    public enum E_Evt : UInt32
    {
      GROUND_FAULT = 0,
      INPUT_OVER_VOLTAGE = 1,
      RESERVED_2 = 2,
      DC_DISCONNECT = 3,
      RESERVED_4 = 4,
      RESERVED_5 = 5,
      MANUAL_SHUTDOWN = 6,
      OVER_TEMPERATURE = 7,
      RESERVED_8 = 8,
      RESERVED_9 = 9,
      RESERVED_10 = 10,
      RESERVED_11 = 11,
      BLOWN_FUSE = 12,
      UNDER_TEMPERATURE = 13,
      MEMORY_LOSS = 14,
      ARC_DETECTION = 15,
      THEFT_DETECTION = 16,
      OUTPUT_OVER_CURRENT = 17,
      OUTPUT_OVER_VOLTAGE = 18,
      OUTPUT_UNDER_VOLTAGE = 19,
      TEST_FAILED = 20,
    }
    /// Events - Bitmask value.  Module Event Flags
    /// Bitmask value.  Module Event Flags
    [SunSpecProperty(offset: 6, length: 1)]
    public E_Evt Evt { get; set; }
    [Flags]
    public enum E_EvtVend : UInt32
    {
    }
    /// Vendor Module Event Flags - Vendor specific flags
    /// Vendor specific flags
    [SunSpecProperty(offset: 8, length: 1)]
    public E_EvtVend? EvtVend { get; set; }
    public enum E_Ctl : UInt16
    {
    }
    /// Control - Module Control
    /// Module Control
    [SunSpecProperty(offset: 10, length: 1)]
    public E_Ctl? Ctl { get; set; }
    public enum E_CtlVend : UInt32
    {
    }
    /// Vendor Control - Vendor Module Control
    /// Vendor Module Control
    [SunSpecProperty(offset: 11, length: 1)]
    public E_CtlVend? CtlVend { get; set; }
    /// Control Value - Module Control Value
    /// Module Control Value
    [SunSpecProperty(offset: 13, length: 1)]
    public Int32? CtlVal { get; set; }
    /// [Secs]
    /// Timestamp - Time in seconds since 2000 epoch
    /// Time in seconds since 2000 epoch
    [SunSpecProperty(offset: 15, length: 1)]
    public UInt32? Tms { get; set; }
    /// [A]
    /// Output Current - Output Current
    /// Output Current
    [SunSpecProperty(offset: 17, length: 1)]
    public Int16? OutA { get; set; }
    /// [V]
    /// Output Voltage - Output Voltage
    /// Output Voltage
    [SunSpecProperty(offset: 18, length: 1)]
    public Int16? OutV { get; set; }
    /// [Wh]
    /// Output Energy - Output Energy
    /// Output Energy
    [SunSpecProperty(offset: 19, length: 1)]
    public UInt32? OutWh { get; set; }
    /// [W]
    /// Output Power - Output Power
    /// Output Power
    [SunSpecProperty(offset: 21, length: 1)]
    public Int16? OutPw { get; set; }
    /// [C]
    /// Temp - Module Temperature
    /// Module Temperature
    [SunSpecProperty(offset: 22, length: 1)]
    public Int16? Tmp { get; set; }
    /// [A]
    /// Input Current - Input Current
    /// Input Current
    [SunSpecProperty(offset: 23, length: 1)]
    public Int16? InA { get; set; }
    /// [V]
    /// Input Voltage - Input Voltage
    /// Input Voltage
    [SunSpecProperty(offset: 24, length: 1)]
    public Int16? InV { get; set; }
    /// [Wh]
    /// Input Energy - Input Energy
    /// Input Energy
    [SunSpecProperty(offset: 25, length: 1)]
    public UInt32? InWh { get; set; }
    /// [W]
    /// Input Power - Input Power
    /// Input Power
    [SunSpecProperty(offset: 27, length: 1)]
    public Int16? InW { get; set; }
  }
}
