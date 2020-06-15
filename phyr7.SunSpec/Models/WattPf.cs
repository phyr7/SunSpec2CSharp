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
  /// Watt-Power Factor 
  /// NOTES: Ref 3: 8.11.1.2
  [SunSpecModel(id: 131, length: 64)]
  public struct WattPf
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
    /// ModEna - Is watt-PF mode active.
    /// Is watt-PF mode active.
    [SunSpecProperty(offset: 1, length: 1)]
    public E_ModEna ModEna { get; set; }
    /// [Secs]
    /// WinTms - Time window for watt-PF change.
    /// Time window for watt-PF change.
    [SunSpecProperty(offset: 2, length: 1)]
    public UInt16? WinTms { get; set; }
    /// [Secs]
    /// RvrtTms - Timeout period for watt-PF curve selection.
    /// Timeout period for watt-PF curve selection.
    [SunSpecProperty(offset: 3, length: 1)]
    public UInt16? RvrtTms { get; set; }
    /// [Secs]
    /// RmpTms - Ramp time for moving from current mode to new mode.
    /// Ramp time for moving from current mode to new mode.
    [SunSpecProperty(offset: 4, length: 1)]
    public UInt16? RmpTms { get; set; }
    /// NCrv - Number of curves supported (recommend 4).
    /// Number of curves supported (recommend 4).
    [SunSpecProperty(offset: 5, length: 1)]
    public UInt16 NCrv { get; private set; }
    /// NPt - Max number of points in array.
    /// Max number of points in array.
    [SunSpecProperty(offset: 6, length: 1)]
    public UInt16 NPt { get; private set; }
    /// W_SF - Scale factor for percent WMax.
    /// Scale factor for percent WMax.
    [SunSpecProperty(offset: 7, length: 1)]
    public Int16 W_SF { get; private set; }
    /// PF_SF - Scale factor for PF.
    /// Scale factor for PF.
    [SunSpecProperty(offset: 8, length: 1)]
    public Int16 PF_SF { get; private set; }
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
      /// [% WMax]
      /// W1 - Point 1 Watts.
      /// Point 1 Watts.
      [SunSpecProperty(offset: 1, length: 1)]
      public Int16 W1 { get; set; }
      /// [cos()]
      /// PF1 - Point 1 PF in EEI notation.
      /// Point 1 PF in EEI notation.
      [SunSpecProperty(offset: 2, length: 1)]
      public Int16 PF1 { get; set; }
      /// [% WMax]
      /// W2 - Point 2 Watts.
      /// Point 2 Watts.
      [SunSpecProperty(offset: 3, length: 1)]
      public Int16? W2 { get; set; }
      /// [cos()]
      /// PF2 - Point 2 PF in EEI notation.
      /// Point 2 PF in EEI notation.
      [SunSpecProperty(offset: 4, length: 1)]
      public Int16? PF2 { get; set; }
      /// [% WMax]
      /// W3 - Point 3 Watts.
      /// Point 3 Watts.
      [SunSpecProperty(offset: 5, length: 1)]
      public Int16? W3 { get; set; }
      /// [cos()]
      /// PF3 - Point 3 PF in EEI notation.
      /// Point 3 PF in EEI notation.
      [SunSpecProperty(offset: 6, length: 1)]
      public Int16? PF3 { get; set; }
      /// [% WMax]
      /// W4 - Point 4 Watts.
      /// Point 4 Watts.
      [SunSpecProperty(offset: 7, length: 1)]
      public Int16? W4 { get; set; }
      /// [cos()]
      /// PF4 - Point 4 PF in EEI notation.
      /// Point 4 PF in EEI notation.
      [SunSpecProperty(offset: 8, length: 1)]
      public Int16? PF4 { get; set; }
      /// [% WMax]
      /// W5 - Point 5 Watts.
      /// Point 5 Watts.
      [SunSpecProperty(offset: 9, length: 1)]
      public Int16? W5 { get; set; }
      /// [cos()]
      /// PF5 - Point 5 PF in EEI notation.
      /// Point 5 PF in EEI notation.
      [SunSpecProperty(offset: 10, length: 1)]
      public Int16? PF5 { get; set; }
      /// [% WMax]
      /// W6 - Point 6 Watts.
      /// Point 6 Watts.
      [SunSpecProperty(offset: 11, length: 1)]
      public Int16? W6 { get; set; }
      /// [cos()]
      /// PF6 - Point 6 PF in EEI notation.
      /// Point 6 PF in EEI notation.
      [SunSpecProperty(offset: 12, length: 1)]
      public Int16? PF6 { get; set; }
      /// [% WMax]
      /// W7 - Point 7 Watts.
      /// Point 7 Watts.
      [SunSpecProperty(offset: 13, length: 1)]
      public Int16? W7 { get; set; }
      /// [cos()]
      /// PF7 - Point 7 PF in EEI notation.
      /// Point 7 PF in EEI notation.
      [SunSpecProperty(offset: 14, length: 1)]
      public Int16? PF7 { get; set; }
      /// [% WMax]
      /// W8 - Point 8 Watts.
      /// Point 8 Watts.
      [SunSpecProperty(offset: 15, length: 1)]
      public Int16? W8 { get; set; }
      /// [cos()]
      /// PF8 - Point 8 PF in EEI notation.
      /// Point 8 PF in EEI notation.
      [SunSpecProperty(offset: 16, length: 1)]
      public Int16? PF8 { get; set; }
      /// [% WMax]
      /// W9 - Point 9 Watts.
      /// Point 9 Watts.
      [SunSpecProperty(offset: 17, length: 1)]
      public Int16? W9 { get; set; }
      /// [cos()]
      /// PF9 - Point 9 PF in EEI notation.
      /// Point 9 PF in EEI notation.
      [SunSpecProperty(offset: 18, length: 1)]
      public Int16? PF9 { get; set; }
      /// [% WMax]
      /// W10 - Point 10 Watts.
      /// Point 10 Watts.
      [SunSpecProperty(offset: 19, length: 1)]
      public Int16? W10 { get; set; }
      /// [cos()]
      /// PF10 - Point 10 PF in EEI notation.
      /// Point 10 PF in EEI notation.
      [SunSpecProperty(offset: 20, length: 1)]
      public Int16? PF10 { get; set; }
      /// [% WMax]
      /// W11 - Point 11 Watts.
      /// Point 11 Watts.
      [SunSpecProperty(offset: 21, length: 1)]
      public Int16? W11 { get; set; }
      /// [cos()]
      /// PF11 - Point 11 PF in EEI notation.
      /// Point 11 PF in EEI notation.
      [SunSpecProperty(offset: 22, length: 1)]
      public Int16? PF11 { get; set; }
      /// [% WMax]
      /// W12 - Point 12 Watts.
      /// Point 12 Watts.
      [SunSpecProperty(offset: 23, length: 1)]
      public Int16? W12 { get; set; }
      /// [cos()]
      /// PF12 - Point 12 PF in EEI notation.
      /// Point 12 PF in EEI notation.
      [SunSpecProperty(offset: 24, length: 1)]
      public Int16? PF12 { get; set; }
      /// [% WMax]
      /// W13 - Point 13 Watts.
      /// Point 13 Watts.
      [SunSpecProperty(offset: 25, length: 1)]
      public Int16? W13 { get; set; }
      /// [cos()]
      /// PF13 - Point 13 PF in EEI notation.
      /// Point 13 PF in EEI notation.
      [SunSpecProperty(offset: 26, length: 1)]
      public Int16? PF13 { get; set; }
      /// [% WMax]
      /// W14 - Point 14 Watts.
      /// Point 14 Watts.
      [SunSpecProperty(offset: 27, length: 1)]
      public Int16? W14 { get; set; }
      /// [cos()]
      /// PF14 - Point 14 PF in EEI notation.
      /// Point 14 PF in EEI notation.
      [SunSpecProperty(offset: 28, length: 1)]
      public Int16? PF14 { get; set; }
      /// [% WMax]
      /// W15 - Point 15 Watts.
      /// Point 15 Watts.
      [SunSpecProperty(offset: 29, length: 1)]
      public Int16? W15 { get; set; }
      /// [cos()]
      /// PF15 - Point 15 PF in EEI notation.
      /// Point 15 PF in EEI notation.
      [SunSpecProperty(offset: 30, length: 1)]
      public Int16? PF15 { get; set; }
      /// [% WMax]
      /// W16 - Point 16 Watts.
      /// Point 16 Watts.
      [SunSpecProperty(offset: 31, length: 1)]
      public Int16? W16 { get; set; }
      /// [cos()]
      /// PF16 - Point 16 PF in EEI notation.
      /// Point 16 PF in EEI notation.
      [SunSpecProperty(offset: 32, length: 1)]
      public Int16? PF16 { get; set; }
      /// [% WMax]
      /// W17 - Point 17 Watts.
      /// Point 17 Watts.
      [SunSpecProperty(offset: 33, length: 1)]
      public Int16? W17 { get; set; }
      /// [cos()]
      /// PF17 - Point 17 PF in EEI notation.
      /// Point 17 PF in EEI notation.
      [SunSpecProperty(offset: 34, length: 1)]
      public Int16? PF17 { get; set; }
      /// [% WMax]
      /// W18 - Point 18 Watts.
      /// Point 18 Watts.
      [SunSpecProperty(offset: 35, length: 1)]
      public Int16? W18 { get; set; }
      /// [cos()]
      /// PF18 - Point 18 PF in EEI notation.
      /// Point 18 PF in EEI notation.
      [SunSpecProperty(offset: 36, length: 1)]
      public Int16? PF18 { get; set; }
      /// [% WMax]
      /// W19 - Point 19 Watts.
      /// Point 19 Watts.
      [SunSpecProperty(offset: 37, length: 1)]
      public Int16? W19 { get; set; }
      /// [cos()]
      /// PF19 - Point 19 PF in EEI notation.
      /// Point 19 PF in EEI notation.
      [SunSpecProperty(offset: 38, length: 1)]
      public Int16? PF19 { get; set; }
      /// [% WMax]
      /// W20 - Point 20 Watts.
      /// Point 20 Watts.
      [SunSpecProperty(offset: 39, length: 1)]
      public Int16? W20 { get; set; }
      /// [cos()]
      /// PF20 - Point 20 PF in EEI notation.
      /// Point 20 PF in EEI notation.
      [SunSpecProperty(offset: 40, length: 1)]
      public Int16? PF20 { get; set; }
      /// CrvNam - Optional description for curve.
      /// Optional description for curve.
      [SunSpecProperty(offset: 41, length: 8)]
      public String? CrvNam { get; set; }
      /// [Secs]
      /// RmpPT1Tms - The time of the PT1 in seconds (time to accomplish a change of 95%).
      /// The time of the PT1 in seconds (time to accomplish a change of 95%).
      [SunSpecProperty(offset: 49, length: 1)]
      public UInt16? RmpPT1Tms { get; set; }
      /// [% PF/min]
      /// RmpDecTmm - The maximum rate at which the power factor may be reduced in response to changes in the power value.
      /// The maximum rate at which the power factor may be reduced in response to changes in the power value.
      [SunSpecProperty(offset: 50, length: 1)]
      public UInt16? RmpDecTmm { get; set; }
      /// [% PF/min]
      /// RmpIncTmm - The maximum rate at which the power factor may be increased in response to changes in the power value.
      /// The maximum rate at which the power factor may be increased in response to changes in the power value.
      [SunSpecProperty(offset: 51, length: 1)]
      public UInt16? RmpIncTmm { get; set; }
      public enum E_ReadOnly : UInt16
      {
        READWRITE = 0,
        READONLY = 1,
      }
      /// ReadOnly - Enumerated value indicates if curve is read-only or can be modified.
      /// Enumerated value indicates if curve is read-only or can be modified.
      [SunSpecProperty(offset: 52, length: 1)]
      public E_ReadOnly ReadOnly { get; private set; }
      [SunSpecProperty(offset: 53, length: 1)]
      public UInt16? Pad { get; private set; }
    };
    public S_Curve[] Curve;
  }
}
