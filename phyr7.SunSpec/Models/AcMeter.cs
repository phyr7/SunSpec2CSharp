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
  /// Include this model for secure metering
  [SunSpecModel(id: 220, length: 43)]
  public struct AcMeter
  {
    /// [A]
    /// Amps - Total AC Current
    /// Total AC Current
    [SunSpecProperty(offset: 0, length: 1)]
    public Int16 A { get; set; }
    /// Current scale factor
    [SunSpecProperty(offset: 1, length: 1)]
    public Int16 A_SF { get; set; }
    /// [V]
    /// Voltage - Average phase or line voltage
    /// Average phase or line voltage
    [SunSpecProperty(offset: 2, length: 1)]
    public Int16? PhV { get; set; }
    /// Voltage scale factor
    [SunSpecProperty(offset: 3, length: 1)]
    public Int16 V_SF { get; set; }
    /// [Hz]
    /// Hz - Frequency
    /// Frequency
    [SunSpecProperty(offset: 4, length: 1)]
    public Int16 Hz { get; set; }
    /// Frequency scale factor
    [SunSpecProperty(offset: 5, length: 1)]
    public Int16? Hz_SF { get; set; }
    /// [W]
    /// Watts - Total Real Power
    /// Total Real Power
    [SunSpecProperty(offset: 6, length: 1)]
    public Int16 W { get; set; }
    /// Real Power scale factor
    [SunSpecProperty(offset: 7, length: 1)]
    public Int16 W_SF { get; set; }
    /// [VA]
    /// VA - AC Apparent Power
    /// AC Apparent Power
    [SunSpecProperty(offset: 8, length: 1)]
    public Int16? VA { get; set; }
    /// Apparent Power scale factor
    [SunSpecProperty(offset: 9, length: 1)]
    public Int16? VA_SF { get; set; }
    /// [var]
    /// VAR - Reactive Power
    /// Reactive Power
    [SunSpecProperty(offset: 10, length: 1)]
    public Int16? VAR { get; set; }
    /// Reactive Power scale factor
    [SunSpecProperty(offset: 11, length: 1)]
    public Int16? VAR_SF { get; set; }
    /// [Pct]
    /// PF - Power Factor
    /// Power Factor
    [SunSpecProperty(offset: 12, length: 1)]
    public Int16? PF { get; set; }
    /// Power Factor scale factor
    [SunSpecProperty(offset: 13, length: 1)]
    public Int16? PF_SF { get; set; }
    /// [Wh]
    /// Total Watt-hours Exported - Total Real Energy Exported
    /// Total Real Energy Exported
    [SunSpecProperty(offset: 14, length: 1)]
    public UInt32 TotWhExp { get; set; }
    /// [Wh]
    /// Total Watt-hours Imported - Total Real Energy Imported
    /// Total Real Energy Imported
    [SunSpecProperty(offset: 16, length: 1)]
    public UInt32 TotWhImp { get; set; }
    /// Real Energy scale factor
    [SunSpecProperty(offset: 18, length: 1)]
    public Int16 TotWh_SF { get; set; }
    /// [VAh]
    /// Total VA-hours Exported - Total Apparent Energy Exported
    /// Total Apparent Energy Exported
    [SunSpecProperty(offset: 19, length: 1)]
    public UInt32? TotVAhExp { get; set; }
    /// [VAh]
    /// Total VA-hours Imported - Total Apparent Energy Imported
    /// Total Apparent Energy Imported
    [SunSpecProperty(offset: 21, length: 1)]
    public UInt32? TotVAhImp { get; set; }
    /// Apparent Energy scale factor
    [SunSpecProperty(offset: 23, length: 1)]
    public Int16? TotVAh_SF { get; set; }
    /// [varh]
    /// Total VAR-hours Imported Q1 - Total Reactive Energy Imported Quadrant 1
    /// Total Reactive Energy Imported Quadrant 1
    [SunSpecProperty(offset: 24, length: 1)]
    public UInt32? TotVArhImpQ1 { get; set; }
    /// [varh]
    /// Total VAr-hours Imported Q2 - Total Reactive Power Imported Quadrant 2
    /// Total Reactive Power Imported Quadrant 2
    [SunSpecProperty(offset: 26, length: 1)]
    public UInt32? TotVArhImpQ2 { get; set; }
    /// [varh]
    /// Total VAr-hours Exported Q3 - Total Reactive Power Exported Quadrant 3
    /// Total Reactive Power Exported Quadrant 3
    [SunSpecProperty(offset: 28, length: 1)]
    public UInt32? TotVArhExpQ3 { get; set; }
    /// [varh]
    /// Total VAr-hours Exported Q4 - Total Reactive Power Exported Quadrant 4
    /// Total Reactive Power Exported Quadrant 4
    [SunSpecProperty(offset: 30, length: 1)]
    public UInt32? TotVArhExpQ4 { get; set; }
    /// Reactive Energy scale factor
    [SunSpecProperty(offset: 32, length: 1)]
    public Int16? TotVArh_SF { get; set; }
    [Flags]
    public enum E_Evt : UInt32
    {
      Power_Failure = 2,
      Under_Voltage = 3,
      Low_PF = 4,
      Over_Current = 5,
      Over_Voltage = 6,
      Missing_Sensor = 7,
      OEM01 = 16,
      OEM02 = 17,
      OEM03 = 18,
      OEM04 = 19,
      OEM05 = 20,
      OEM06 = 21,
      OEM07 = 22,
      OEM08 = 23,
      OEM09 = 24,
      OEM10 = 25,
      OEM11 = 26,
      OEM12 = 27,
      OEM13 = 28,
      OEM14 = 29,
      OEM15 = 30,
    }
    /// Events - Meter Event Flags
    /// Meter Event Flags
    [SunSpecProperty(offset: 33, length: 1)]
    public E_Evt Evt { get; set; }
    [SunSpecProperty(offset: 35, length: 1)]
    public UInt16 Rsrvd { get; private set; }
    /// Timestamp - Timestamp value is the number of seconds since January 1, 2000
    /// Timestamp value is the number of seconds since January 1, 2000
    [SunSpecProperty(offset: 36, length: 1)]
    public UInt32 Ts { get; private set; }
    /// Milliseconds - Millisecond counter 0-999
    /// Millisecond counter 0-999
    [SunSpecProperty(offset: 38, length: 1)]
    public UInt16 Ms { get; private set; }
    /// Sequence - Sequence number of request
    /// Sequence number of request
    /// NOTES: Shall be advanced for each request
    [SunSpecProperty(offset: 39, length: 1)]
    public UInt16 Seq { get; private set; }
    public enum E_Alg : UInt16
    {
      NONE = 0,
      AES_GMAC_64 = 1,
      ECC_256 = 2,
    }
    /// Algorithm - Algorithm used to compute the digital signature
    /// Algorithm used to compute the digital signature
    /// NOTES: For future proof
    [SunSpecProperty(offset: 40, length: 1)]
    public E_Alg Alg { get; private set; }
    /// N - Number of registers comprising the digital signature.
    /// Number of registers comprising the digital signature.
    /// NOTES: The value of N must be at least 4 (64 bits)
    [SunSpecProperty(offset: 41, length: 1)]
    public UInt16 N { get; private set; }
    public struct S_Block2
    {
      [SunSpecProperty(offset: 0, length: 1)]
      public UInt16 DS { get; private set; }
    };
    public S_Block2[] Block2;
  }
}
