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
  /// Volt-Watt 
  /// NOTES: Ref 3: 8.12.1.2
  [SunSpecModel(id: 132, length: 64)]
  public struct VoltWatt
  {
    /// ActCrv - Index of active curve. 0=no active curve.
    /// Index of active curve. 0=no active curve.
    [SunSpecProperty(offset: 0, length: 1)]
    public UInt16 ActCrv { get; set; }
    [Flags]
    public enum E_ModEna : UInt16
    {
      ENABLED = 0,
    }
    /// ModEna - Is Volt-Watt control active.
    /// Is Volt-Watt control active.
    [SunSpecProperty(offset: 1, length: 1)]
    public E_ModEna ModEna { get; set; }
    /// [Secs]
    /// WinTms - Time window for volt-watt change.
    /// Time window for volt-watt change.
    [SunSpecProperty(offset: 2, length: 1)]
    public UInt16? WinTms { get; set; }
    /// [Secs]
    /// RvrtTms - Timeout period for volt-watt curve selection.
    /// Timeout period for volt-watt curve selection.
    [SunSpecProperty(offset: 3, length: 1)]
    public UInt16? RvrtTms { get; set; }
    /// [Secs]
    /// RmpTms - Ramp time for moving from current mode to new mode.
    /// Ramp time for moving from current mode to new mode.
    [SunSpecProperty(offset: 4, length: 1)]
    public UInt16? RmpTms { get; set; }
    /// NCrv - Number of curves supported (recommend min. 4).
    /// Number of curves supported (recommend min. 4).
    [SunSpecProperty(offset: 5, length: 1)]
    public UInt16 NCrv { get; private set; }
    /// NPt - Number of points in array (maximum 20).
    /// Number of points in array (maximum 20).
    [SunSpecProperty(offset: 6, length: 1)]
    public UInt16 NPt { get; private set; }
    /// V_SF - Scale factor for percent VRef.
    /// Scale factor for percent VRef.
    [SunSpecProperty(offset: 7, length: 1)]
    public Int16 V_SF { get; private set; }
    /// DeptRef_SF - Scale factor for % DeptRef.
    /// Scale factor for % DeptRef.
    [SunSpecProperty(offset: 8, length: 1)]
    public Int16 DeptRef_SF { get; private set; }
    /// RmpIncDec_SF - Scale factor for increment and decrement ramps.
    /// Scale factor for increment and decrement ramps.
    [SunSpecProperty(offset: 9, length: 1)]
    public Int16? RmpIncDec_SF { get; private set; }
    public struct S_Curve
    {
      /// ActPt - Number of active points in array.
      /// Number of active points in array.
      [SunSpecProperty(offset: 0, length: 1)]
      public UInt16 ActPt { get; set; }
      public enum E_DeptRef : UInt16
      {
        PercentWMax = 1,
        PercentWAval = 2,
      }
      /// DeptRef - Defines the meaning of the Watts DeptRef.  1=% WMax 2=% WAvail
      /// Defines the meaning of the Watts DeptRef.  1=% WMax 2=% WAvail
      [SunSpecProperty(offset: 1, length: 1)]
      public E_DeptRef DeptRef { get; set; }
      /// [% VRef]
      /// V1 - Point 1 Volts.
      /// Point 1 Volts.
      [SunSpecProperty(offset: 2, length: 1)]
      public UInt16 V1 { get; set; }
      /// [% VRef]
      /// W1 - Point 1 Watts.
      /// Point 1 Watts.
      [SunSpecProperty(offset: 3, length: 1)]
      public Int16 W1 { get; set; }
      /// [% VRef]
      /// V2 - Point 2 Volts.
      /// Point 2 Volts.
      [SunSpecProperty(offset: 4, length: 1)]
      public UInt16? V2 { get; set; }
      /// [% VRef]
      /// W2 - Point 2 Watts.
      /// Point 2 Watts.
      [SunSpecProperty(offset: 5, length: 1)]
      public Int16? W2 { get; set; }
      /// [% VRef]
      /// V3 - Point 3 Volts.
      /// Point 3 Volts.
      [SunSpecProperty(offset: 6, length: 1)]
      public UInt16? V3 { get; set; }
      /// [% VRef]
      /// W3 - Point 3 Watts.
      /// Point 3 Watts.
      [SunSpecProperty(offset: 7, length: 1)]
      public Int16? W3 { get; set; }
      /// [% VRef]
      /// V4 - Point 4 Volts.
      /// Point 4 Volts.
      [SunSpecProperty(offset: 8, length: 1)]
      public UInt16? V4 { get; set; }
      /// [% VRef]
      /// W4 - Point 4 Watts.
      /// Point 4 Watts.
      [SunSpecProperty(offset: 9, length: 1)]
      public Int16? W4 { get; set; }
      /// [% VRef]
      /// V5 - Point 5 Volts.
      /// Point 5 Volts.
      [SunSpecProperty(offset: 10, length: 1)]
      public UInt16? V5 { get; set; }
      /// [% VRef]
      /// W5 - Point 5 Watts.
      /// Point 5 Watts.
      [SunSpecProperty(offset: 11, length: 1)]
      public Int16? W5 { get; set; }
      /// [% VRef]
      /// V6 - Point 6 Volts.
      /// Point 6 Volts.
      [SunSpecProperty(offset: 12, length: 1)]
      public UInt16? V6 { get; set; }
      /// [% VRef]
      /// W6 - Point 6 Watts.
      /// Point 6 Watts.
      [SunSpecProperty(offset: 13, length: 1)]
      public Int16? W6 { get; set; }
      /// [% VRef]
      /// V7 - Point 7 Volts.
      /// Point 7 Volts.
      [SunSpecProperty(offset: 14, length: 1)]
      public UInt16? V7 { get; set; }
      /// [% VRef]
      /// W7 - Point 7 Watts.
      /// Point 7 Watts.
      [SunSpecProperty(offset: 15, length: 1)]
      public Int16? W7 { get; set; }
      /// [% VRef]
      /// V8 - Point 8 Volts.
      /// Point 8 Volts.
      [SunSpecProperty(offset: 16, length: 1)]
      public UInt16? V8 { get; set; }
      /// [% VRef]
      /// W8 - Point 8 Watts.
      /// Point 8 Watts.
      [SunSpecProperty(offset: 17, length: 1)]
      public Int16? W8 { get; set; }
      /// [% VRef]
      /// V9 - Point 9 Volts.
      /// Point 9 Volts.
      [SunSpecProperty(offset: 18, length: 1)]
      public UInt16? V9 { get; set; }
      /// [% VRef]
      /// W9 - Point 9 Watts.
      /// Point 9 Watts.
      [SunSpecProperty(offset: 19, length: 1)]
      public Int16? W9 { get; set; }
      /// [% VRef]
      /// V10 - Point 10 Volts.
      /// Point 10 Volts.
      [SunSpecProperty(offset: 20, length: 1)]
      public UInt16? V10 { get; set; }
      /// [% VRef]
      /// W10 - Point 10 Watts.
      /// Point 10 Watts.
      [SunSpecProperty(offset: 21, length: 1)]
      public Int16? W10 { get; set; }
      /// [% VRef]
      /// V11 - Point 11 Volts.
      /// Point 11 Volts.
      [SunSpecProperty(offset: 22, length: 1)]
      public UInt16? V11 { get; set; }
      /// [% VRef]
      /// W11 - Point 11 Watts.
      /// Point 11 Watts.
      [SunSpecProperty(offset: 23, length: 1)]
      public Int16? W11 { get; set; }
      /// [% VRef]
      /// V12 - Point 12 Volts.
      /// Point 12 Volts.
      [SunSpecProperty(offset: 24, length: 1)]
      public UInt16? V12 { get; set; }
      /// [% VRef]
      /// W12 - Point 12 Watts.
      /// Point 12 Watts.
      [SunSpecProperty(offset: 25, length: 1)]
      public Int16? W12 { get; set; }
      /// [% VRef]
      /// V13 - Point 13 Volts.
      /// Point 13 Volts.
      [SunSpecProperty(offset: 26, length: 1)]
      public UInt16? V13 { get; set; }
      /// [% VRef]
      /// W13 - Point 13 Watts.
      /// Point 13 Watts.
      [SunSpecProperty(offset: 27, length: 1)]
      public Int16? W13 { get; set; }
      /// [% VRef]
      /// V14 - Point 14 Volts.
      /// Point 14 Volts.
      [SunSpecProperty(offset: 28, length: 1)]
      public UInt16? V14 { get; set; }
      /// [% VRef]
      /// W14 - Point 14 Watts.
      /// Point 14 Watts.
      [SunSpecProperty(offset: 29, length: 1)]
      public Int16? W14 { get; set; }
      /// [% VRef]
      /// V15 - Point 15 Volts.
      /// Point 15 Volts.
      [SunSpecProperty(offset: 30, length: 1)]
      public UInt16? V15 { get; set; }
      /// [% VRef]
      /// W15 - Point 15 Watts.
      /// Point 15 Watts.
      [SunSpecProperty(offset: 31, length: 1)]
      public Int16? W15 { get; set; }
      /// [% VRef]
      /// V16 - Point 16 Volts.
      /// Point 16 Volts.
      [SunSpecProperty(offset: 32, length: 1)]
      public UInt16? V16 { get; set; }
      /// [% VRef]
      /// W16 - Point 16 Watts.
      /// Point 16 Watts.
      [SunSpecProperty(offset: 33, length: 1)]
      public Int16? W16 { get; set; }
      /// [% VRef]
      /// V17 - Point 17 Volts.
      /// Point 17 Volts.
      [SunSpecProperty(offset: 34, length: 1)]
      public UInt16? V17 { get; set; }
      /// [% VRef]
      /// W17 - Point 17 Watts.
      /// Point 17 Watts.
      [SunSpecProperty(offset: 35, length: 1)]
      public Int16? W17 { get; set; }
      /// [% VRef]
      /// V18 - Point 18 Volts.
      /// Point 18 Volts.
      [SunSpecProperty(offset: 36, length: 1)]
      public UInt16? V18 { get; set; }
      /// [% VRef]
      /// W18 - Point 18 Watts.
      /// Point 18 Watts.
      [SunSpecProperty(offset: 37, length: 1)]
      public Int16? W18 { get; set; }
      /// [% VRef]
      /// V19 - Point 19 Volts.
      /// Point 19 Volts.
      [SunSpecProperty(offset: 38, length: 1)]
      public UInt16? V19 { get; set; }
      /// [% VRef]
      /// W19 - Point 19 Watts.
      /// Point 19 Watts.
      [SunSpecProperty(offset: 39, length: 1)]
      public Int16? W19 { get; set; }
      /// [% VRef]
      /// V20 - Point 20 Volts.
      /// Point 20 Volts.
      [SunSpecProperty(offset: 40, length: 1)]
      public UInt16? V20 { get; set; }
      /// [% VRef]
      /// W20 - Point 20 Watts.
      /// Point 20 Watts.
      [SunSpecProperty(offset: 41, length: 1)]
      public Int16? W20 { get; set; }
      /// CrvNam - Optional description for curve.
      /// Optional description for curve.
      [SunSpecProperty(offset: 42, length: 8)]
      public String? CrvNam { get; set; }
      /// [Secs]
      /// RmpPt1Tms - The time of the PT1 in seconds (time to accomplish a change of 95%).
      /// The time of the PT1 in seconds (time to accomplish a change of 95%).
      [SunSpecProperty(offset: 50, length: 1)]
      public UInt16? RmpPt1Tms { get; set; }
      /// [% WMax/min]
      /// RmpDecTmm - The maximum rate at which the watt value may be reduced in response to changes in the voltage value.
      /// The maximum rate at which the watt value may be reduced in response to changes in the voltage value.
      [SunSpecProperty(offset: 51, length: 1)]
      public UInt16? RmpDecTmm { get; set; }
      /// [% WMax/min]
      /// RmpIncTmm - The maximum rate at which the watt value may be increased in response to changes in the voltage value.
      /// The maximum rate at which the watt value may be increased in response to changes in the voltage value.
      [SunSpecProperty(offset: 52, length: 1)]
      public UInt16? RmpIncTmm { get; set; }
      public enum E_ReadOnly : UInt16
      {
        READWRITE = 0,
        READONLY = 1,
      }
      /// ReadOnly - Enumerated value indicates if curve is read-only or can be modified.
      /// Enumerated value indicates if curve is read-only or can be modified.
      [SunSpecProperty(offset: 53, length: 1)]
      public E_ReadOnly ReadOnly { get; private set; }
    };
    public S_Curve[] Curve;
  }
}
