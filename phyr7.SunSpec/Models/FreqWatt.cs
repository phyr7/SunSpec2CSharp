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
  /// Curve-Based Frequency-Watt 
  /// NOTES: Ref 3: 8.9.1.2, 8.9.4.2
  [SunSpecModel(id: 134, length: 68)]
  public struct FreqWatt
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
    /// ModEna - Is curve-based Frequency-Watt control active.
    /// Is curve-based Frequency-Watt control active.
    [SunSpecProperty(offset: 1, length: 1)]
    public E_ModEna ModEna { get; set; }
    /// [Secs]
    /// WinTms - Time window for freq-watt change.
    /// Time window for freq-watt change.
    [SunSpecProperty(offset: 2, length: 1)]
    public UInt16? WinTms { get; set; }
    /// [Secs]
    /// RvrtTms - Timeout period for freq-watt curve selection.
    /// Timeout period for freq-watt curve selection.
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
    /// NPt - Number of curve points supported (maximum of 10).
    /// Number of curve points supported (maximum of 10).
    [SunSpecProperty(offset: 6, length: 1)]
    public UInt16 NPt { get; private set; }
    /// [SF]
    /// Hz_SF - Scale factor for frequency.
    /// Scale factor for frequency.
    [SunSpecProperty(offset: 7, length: 1)]
    public Int16 Hz_SF { get; private set; }
    /// [SF]
    /// W_SF - Scale factor for percent WRef.
    /// Scale factor for percent WRef.
    [SunSpecProperty(offset: 8, length: 1)]
    public Int16 W_SF { get; private set; }
    /// [SF]
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
      /// [Hz]
      /// Hz1 - Point 1 Hertz.
      /// Point 1 Hertz.
      [SunSpecProperty(offset: 1, length: 1)]
      public UInt16 Hz1 { get; set; }
      /// [% WRef]
      /// W1 - Point 1 Watts.
      /// Point 1 Watts.
      [SunSpecProperty(offset: 2, length: 1)]
      public Int16 W1 { get; set; }
      /// [Hz]
      /// Hz2 - Point 2 Hertz.
      /// Point 2 Hertz.
      [SunSpecProperty(offset: 3, length: 1)]
      public UInt16? Hz2 { get; set; }
      /// [% WRef]
      /// W2 - Point 2 Watts.
      /// Point 2 Watts.
      [SunSpecProperty(offset: 4, length: 1)]
      public Int16? W2 { get; set; }
      /// [Hz]
      /// Hz3 - Point 3 Hertz.
      /// Point 3 Hertz.
      [SunSpecProperty(offset: 5, length: 1)]
      public UInt16? Hz3 { get; set; }
      /// [% WRef]
      /// W3 - Point 3 Watts.
      /// Point 3 Watts.
      [SunSpecProperty(offset: 6, length: 1)]
      public Int16? W3 { get; set; }
      /// [Hz]
      /// Hz4 - Point 4 Hertz.
      /// Point 4 Hertz.
      [SunSpecProperty(offset: 7, length: 1)]
      public UInt16? Hz4 { get; set; }
      /// [% WRef]
      /// W4 - Point 4 Watts.
      /// Point 4 Watts.
      [SunSpecProperty(offset: 8, length: 1)]
      public Int16? W4 { get; set; }
      /// [Hz]
      /// Hz5 - Point 5 Hertz.
      /// Point 5 Hertz.
      [SunSpecProperty(offset: 9, length: 1)]
      public UInt16? Hz5 { get; set; }
      /// [% WRef]
      /// W5 - Point 5 Watts.
      /// Point 5 Watts.
      [SunSpecProperty(offset: 10, length: 1)]
      public Int16? W5 { get; set; }
      /// [Hz]
      /// Hz6 - Point 6 Hertz.
      /// Point 6 Hertz.
      [SunSpecProperty(offset: 11, length: 1)]
      public UInt16? Hz6 { get; set; }
      /// [% WRef]
      /// W6 - Point 6 Watts.
      /// Point 6 Watts.
      [SunSpecProperty(offset: 12, length: 1)]
      public Int16? W6 { get; set; }
      /// [Hz]
      /// Hz7 - Point 7 Hertz.
      /// Point 7 Hertz.
      [SunSpecProperty(offset: 13, length: 1)]
      public UInt16? Hz7 { get; set; }
      /// [% WRef]
      /// W7 - Point 7 Watts.
      /// Point 7 Watts.
      [SunSpecProperty(offset: 14, length: 1)]
      public Int16? W7 { get; set; }
      /// [Hz]
      /// Hz8 - Point 8 Hertz.
      /// Point 8 Hertz.
      [SunSpecProperty(offset: 15, length: 1)]
      public UInt16? Hz8 { get; set; }
      /// [% WRef]
      /// W8 - Point 8 Watts.
      /// Point 8 Watts.
      [SunSpecProperty(offset: 16, length: 1)]
      public Int16? W8 { get; set; }
      /// [Hz]
      /// Hz9 - Point 9 Hertz.
      /// Point 9 Hertz.
      [SunSpecProperty(offset: 17, length: 1)]
      public UInt16? Hz9 { get; set; }
      /// [% WRef]
      /// W9 - Point 9 Watts.
      /// Point 9 Watts.
      [SunSpecProperty(offset: 18, length: 1)]
      public Int16? W9 { get; set; }
      /// [Hz]
      /// Hz10 - Point 10 Hertz.
      /// Point 10 Hertz.
      [SunSpecProperty(offset: 19, length: 1)]
      public UInt16? Hz10 { get; set; }
      /// [% WRef]
      /// W10 - Point 10 Watts.
      /// Point 10 Watts.
      [SunSpecProperty(offset: 20, length: 1)]
      public Int16? W10 { get; set; }
      /// [Hz]
      /// Hz11 - Point 11 Hertz.
      /// Point 11 Hertz.
      [SunSpecProperty(offset: 21, length: 1)]
      public UInt16? Hz11 { get; set; }
      /// [% WRef]
      /// W11 - Point 11 Watts.
      /// Point 11 Watts.
      [SunSpecProperty(offset: 22, length: 1)]
      public Int16? W11 { get; set; }
      /// [Hz]
      /// Hz12 - Point 12 Hertz.
      /// Point 12 Hertz.
      [SunSpecProperty(offset: 23, length: 1)]
      public UInt16? Hz12 { get; set; }
      /// [% WRef]
      /// W12 - Point 12 Watts.
      /// Point 12 Watts.
      [SunSpecProperty(offset: 24, length: 1)]
      public Int16? W12 { get; set; }
      /// [Hz]
      /// Hz13 - Point 13 Hertz.
      /// Point 13 Hertz.
      [SunSpecProperty(offset: 25, length: 1)]
      public UInt16? Hz13 { get; set; }
      /// [% WRef]
      /// W13 - Point 13 Watts.
      /// Point 13 Watts.
      [SunSpecProperty(offset: 26, length: 1)]
      public Int16? W13 { get; set; }
      /// [Hz]
      /// Hz14 - Point 14 Hertz.
      /// Point 14 Hertz.
      [SunSpecProperty(offset: 27, length: 1)]
      public UInt16? Hz14 { get; set; }
      /// [% WRef]
      /// W14 - Point 14 Watts.
      /// Point 14 Watts.
      [SunSpecProperty(offset: 28, length: 1)]
      public Int16? W14 { get; set; }
      /// [Hz]
      /// Hz15 - Point 15 Hertz.
      /// Point 15 Hertz.
      [SunSpecProperty(offset: 29, length: 1)]
      public UInt16? Hz15 { get; set; }
      /// [% WRef]
      /// W15 - Point 15 Watts.
      /// Point 15 Watts.
      [SunSpecProperty(offset: 30, length: 1)]
      public Int16? W15 { get; set; }
      /// [Hz]
      /// Hz16 - Point 16 Hertz.
      /// Point 16 Hertz.
      [SunSpecProperty(offset: 31, length: 1)]
      public UInt16? Hz16 { get; set; }
      /// [% WRef]
      /// W16 - Point 16 Watts.
      /// Point 16 Watts.
      [SunSpecProperty(offset: 32, length: 1)]
      public Int16? W16 { get; set; }
      /// [Hz]
      /// Hz17 - Point 17 Hertz.
      /// Point 17 Hertz.
      [SunSpecProperty(offset: 33, length: 1)]
      public UInt16? Hz17 { get; set; }
      /// [% WRef]
      /// W17 - Point 17 Watts.
      /// Point 17 Watts.
      [SunSpecProperty(offset: 34, length: 1)]
      public Int16? W17 { get; set; }
      /// [Hz]
      /// Hz18 - Point 18 Hertz.
      /// Point 18 Hertz.
      [SunSpecProperty(offset: 35, length: 1)]
      public UInt16? Hz18 { get; set; }
      /// [% WRef]
      /// W18 - Point 18 Watts.
      /// Point 18 Watts.
      [SunSpecProperty(offset: 36, length: 1)]
      public Int16? W18 { get; set; }
      /// [Hz]
      /// Hz19 - Point 19 Hertz.
      /// Point 19 Hertz.
      [SunSpecProperty(offset: 37, length: 1)]
      public UInt16? Hz19 { get; set; }
      /// [% WRef]
      /// W19 - Point 19 Watts.
      /// Point 19 Watts.
      [SunSpecProperty(offset: 38, length: 1)]
      public Int16? W19 { get; set; }
      /// [Hz]
      /// Hz20 - Point 20 Hertz.
      /// Point 20 Hertz.
      [SunSpecProperty(offset: 39, length: 1)]
      public UInt16? Hz20 { get; set; }
      /// [% WRef]
      /// W20 - Point 20 Watts.
      /// Point 20 Watts.
      [SunSpecProperty(offset: 40, length: 1)]
      public Int16? W20 { get; set; }
      /// CrvNam - Optional description for curve. (Max 16 chars)
      /// Optional description for curve. (Max 16 chars)
      [SunSpecProperty(offset: 41, length: 8)]
      public String? CrvNam { get; set; }
      /// [Secs]
      /// RmpPT1Tms - The time of the PT1 in seconds (time to accomplish a change of 95%).
      /// The time of the PT1 in seconds (time to accomplish a change of 95%).
      [SunSpecProperty(offset: 49, length: 1)]
      public UInt16? RmpPT1Tms { get; set; }
      /// [% WMax/min]
      /// RmpDecTmm - The maximum rate at which the power value may be reduced in response to changes in the frequency value.
      /// The maximum rate at which the power value may be reduced in response to changes in the frequency value.
      [SunSpecProperty(offset: 50, length: 1)]
      public UInt16? RmpDecTmm { get; set; }
      /// [% WMax/min]
      /// RmpIncTmm - The maximum rate at which the power value may be increased in response to changes in the frequency value.
      /// The maximum rate at which the power value may be increased in response to changes in the frequency value.
      [SunSpecProperty(offset: 51, length: 1)]
      public UInt16? RmpIncTmm { get; set; }
      /// [% WMax/min]
      /// RmpRsUp - The maximum rate at which the power may be increased after releasing the frozen value of snap shot function. 
      /// The maximum rate at which the power may be increased after releasing the frozen value of snap shot function. 
      [SunSpecProperty(offset: 52, length: 1)]
      public UInt16? RmpRsUp { get; set; }
      [Flags]
      public enum E_SnptW : UInt16
      {
      }
      /// SnptW - 1=enable snapshot/capture mode
      /// 1=enable snapshot/capture mode
      [SunSpecProperty(offset: 53, length: 1)]
      public E_SnptW SnptW { get; set; }
      /// [W]
      /// WRef - Reference active power (default = WMax).
      /// Reference active power (default = WMax).
      [SunSpecProperty(offset: 54, length: 1)]
      public UInt16? WRef { get; set; }
      /// [Hz]
      /// WRefStrHz - Frequency deviation from nominal frequency at the time of the snapshot to start constraining power output.
      /// Frequency deviation from nominal frequency at the time of the snapshot to start constraining power output.
      [SunSpecProperty(offset: 55, length: 1)]
      public UInt16? WRefStrHz { get; set; }
      /// [Hz]
      /// WRefStopHz - Frequency deviation from nominal frequency at which to release the power output.
      /// Frequency deviation from nominal frequency at which to release the power output.
      [SunSpecProperty(offset: 56, length: 1)]
      public UInt16? WRefStopHz { get; set; }
      public enum E_ReadOnly : UInt16
      {
        READWRITE = 0,
        READONLY = 1,
      }
      /// ReadOnly - Enumerated value indicates if curve is read-only or can be modified.
      /// Enumerated value indicates if curve is read-only or can be modified.
      [SunSpecProperty(offset: 57, length: 1)]
      public E_ReadOnly ReadOnly { get; private set; }
    };
    public S_Curve[] Curve;
  }
}
