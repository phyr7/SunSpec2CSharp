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
  /// An advanced string combiner including voltage and energy measurements
  /// NOTES: This model supersedes model 402
  [SunSpecModel(id: 404, length: 39)]
  public struct StringCombiner
  {
    /// Current scale factor
    [SunSpecProperty(offset: 0, length: 1)]
    public Int16 DCA_SF { get; set; }
    /// Amp-hour scale factor
    [SunSpecProperty(offset: 1, length: 1)]
    public Int16? DCAhr_SF { get; set; }
    /// Voltage scale factor
    [SunSpecProperty(offset: 2, length: 1)]
    public Int16? DCV_SF { get; set; }
    /// Power scale factor
    [SunSpecProperty(offset: 3, length: 1)]
    public Int16? DCW_SF { get; set; }
    /// Energy scale factor
    [SunSpecProperty(offset: 4, length: 1)]
    public Int16? DCWh_SF { get; set; }
    /// [A]
    /// Rating - Maximum DC Current Rating
    /// Maximum DC Current Rating
    [SunSpecProperty(offset: 5, length: 1)]
    public UInt16 DCAMax { get; set; }
    /// N - Number of Inputs
    /// Number of Inputs
    [SunSpecProperty(offset: 6, length: 1)]
    public UInt16 N { get; set; }
    [Flags]
    public enum E_Evt : UInt32
    {
      LOW_VOLTAGE = 0,
      LOW_POWER = 1,
      LOW_EFFICIENCY = 2,
      CURRENT = 3,
      VOLTAGE = 4,
      POWER = 5,
      PR = 6,
      DISCONNECTED = 7,
      FUSE_FAULT = 8,
      COMBINER_FUSE_FAULT = 9,
      COMBINER_CABINET_OPEN = 10,
      TEMP = 11,
      GROUNDFAULT = 12,
      REVERSED_POLARITY = 13,
      INCOMPATIBLE = 14,
      COMM_ERROR = 15,
      INTERNAL_ERROR = 16,
      THEFT = 17,
      ARC_DETECTED = 18,
    }
    /// Event - Bitmask value.  Events
    /// Bitmask value.  Events
    [SunSpecProperty(offset: 7, length: 1)]
    public E_Evt Evt { get; set; }
    [Flags]
    public enum E_EvtVnd : UInt32
    {
    }
    /// Vendor Event - Bitmask value.  Vendor defined events
    /// Bitmask value.  Vendor defined events
    [SunSpecProperty(offset: 9, length: 1)]
    public E_EvtVnd? EvtVnd { get; set; }
    /// [A]
    /// Amps - Total measured current
    /// Total measured current
    [SunSpecProperty(offset: 11, length: 1)]
    public Int16 DCA { get; set; }
    /// [Ah]
    /// Amp-hours - Total metered Amp-hours
    /// Total metered Amp-hours
    [SunSpecProperty(offset: 12, length: 1)]
    public UInt32? DCAhr { get; set; }
    /// [V]
    /// Voltage - Output Voltage
    /// Output Voltage
    [SunSpecProperty(offset: 14, length: 1)]
    public Int16? DCV { get; set; }
    /// [C]
    /// Temp - Internal operating temperature
    /// Internal operating temperature
    [SunSpecProperty(offset: 15, length: 1)]
    public Int16? Tmp { get; set; }
    /// [W]
    /// Watts - Output power
    /// Output power
    [SunSpecProperty(offset: 16, length: 1)]
    public Int16? DCW { get; set; }
    /// [Pct]
    /// PR - DC Performance ratio value
    /// DC Performance ratio value
    [SunSpecProperty(offset: 17, length: 1)]
    public Int16? DCPR { get; set; }
    /// [Wh]
    /// Watt-hours - Output energy
    /// Output energy
    [SunSpecProperty(offset: 18, length: 1)]
    public UInt32? DCWh { get; set; }
    /// Current scale factor for inputs
    [SunSpecProperty(offset: 20, length: 1)]
    public Int16? InDCA_SF { get; set; }
    /// Amp-hour scale factor for inputs
    [SunSpecProperty(offset: 21, length: 1)]
    public Int16? InDCAhr_SF { get; set; }
    /// Voltage scale factor for inputs
    [SunSpecProperty(offset: 22, length: 1)]
    public Int16? InDCV_SF { get; set; }
    /// Power scale factor for inputs
    [SunSpecProperty(offset: 23, length: 1)]
    public Int16? InDCW_SF { get; set; }
    /// Energy scale factor for inputs
    [SunSpecProperty(offset: 24, length: 1)]
    public Int16? InDCWh_SF { get; set; }
    public struct S_String
    {
      /// ID - Uniquely identifies this input set
      /// Uniquely identifies this input set
      [SunSpecProperty(offset: 0, length: 1)]
      public UInt16 InID { get; set; }
      [Flags]
      public enum E_InEvt : UInt32
      {
        LOW_VOLTAGE = 0,
        LOW_POWER = 1,
        LOW_EFFICIENCY = 2,
        CURRENT = 3,
        VOLTAGE = 4,
        POWER = 5,
        PR = 6,
        DISCONNECTED = 7,
        FUSE_FAULT = 8,
        COMBINER_FUSE_FAULT = 9,
        COMBINER_CABINET_OPEN = 10,
        TEMP = 11,
        GROUNDFAULT = 12,
        REVERSED_POLARITY = 13,
        INCOMPATIBLE = 14,
        COMM_ERROR = 15,
        INTERNAL_ERROR = 16,
        THEFT = 17,
        ARC_DETECTED = 18,
      }
      /// Input Event - String Input Event Flags
      /// String Input Event Flags
      [SunSpecProperty(offset: 1, length: 1)]
      public E_InEvt InEvt { get; set; }
      [Flags]
      public enum E_InEvtVnd : UInt32
      {
      }
      /// Input Event Vendor - String Input Vendor Event Flags
      /// String Input Vendor Event Flags
      [SunSpecProperty(offset: 3, length: 1)]
      public E_InEvtVnd? InEvtVnd { get; set; }
      /// [A]
      /// Amps - String Input Current
      /// String Input Current
      [SunSpecProperty(offset: 5, length: 1)]
      public Int16 InDCA { get; set; }
      /// [Ah]
      /// Amp-hours - String Input Amp-Hours
      /// String Input Amp-Hours
      [SunSpecProperty(offset: 6, length: 1)]
      public UInt32? InDCAhr { get; set; }
      /// [V]
      /// Voltage - String Input Voltage
      /// String Input Voltage
      [SunSpecProperty(offset: 8, length: 1)]
      public Int16? InDCV { get; set; }
      /// [W]
      /// Watts - String Input Power
      /// String Input Power
      [SunSpecProperty(offset: 9, length: 1)]
      public Int16? InDCW { get; set; }
      /// [Wh]
      /// Watt-hours - String Input Energy
      /// String Input Energy
      [SunSpecProperty(offset: 10, length: 1)]
      public UInt32? InDCWh { get; set; }
      /// [Pct]
      /// PR - String Performance Ratio
      /// String Performance Ratio
      [SunSpecProperty(offset: 12, length: 1)]
      public UInt16? InDCPR { get; set; }
      /// N - Number of modules in this input string
      /// Number of modules in this input string
      /// NOTES: Configured value
      [SunSpecProperty(offset: 13, length: 1)]
      public UInt16? InN { get; set; }
    };
    public S_String[] String;
  }
}
