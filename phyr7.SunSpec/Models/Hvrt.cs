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
  /// HVRT Must Disconnect
  /// NOTES: Ref 4: 11
  [SunSpecModel(id: 130, length: 60)]
  public struct Hvrt
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
    /// ModEna - HVRT control mode. Enable active curve.  Bitfield value.
    /// HVRT control mode. Enable active curve.  Bitfield value.
    [SunSpecProperty(offset: 1, length: 1)]
    public E_ModEna ModEna { get; set; }
    /// [Secs]
    /// WinTms - Time window for HVRT change.
    /// Time window for HVRT change.
    /// NOTES: Setting is ignored for HVRT controls.
    [SunSpecProperty(offset: 2, length: 1)]
    public UInt16? WinTms { get; set; }
    /// [Secs]
    /// RvrtTms - Timeout period for HVRT curve selection.
    /// Timeout period for HVRT curve selection.
    /// NOTES: Setting is ignored for HVRT controls.
    [SunSpecProperty(offset: 3, length: 1)]
    public UInt16? RvrtTms { get; set; }
    /// [Secs]
    /// RmpTms - Ramp time for moving from current mode to new mode.
    /// Ramp time for moving from current mode to new mode.
    /// NOTES: Setting is ignored for HVRT controls.
    [SunSpecProperty(offset: 4, length: 1)]
    public UInt16? RmpTms { get; set; }
    /// NCrv - Number of curves supported (recommend 4).
    /// Number of curves supported (recommend 4).
    [SunSpecProperty(offset: 5, length: 1)]
    public UInt16 NCrv { get; private set; }
    /// NPt - Number of curve points supported (maximum of 20).
    /// Number of curve points supported (maximum of 20).
    [SunSpecProperty(offset: 6, length: 1)]
    public UInt16 NPt { get; private set; }
    /// Tms_SF - Scale factor for duration.
    /// Scale factor for duration.
    [SunSpecProperty(offset: 7, length: 1)]
    public Int16 Tms_SF { get; private set; }
    /// V_SF - Scale factor for percent VRef.
    /// Scale factor for percent VRef.
    [SunSpecProperty(offset: 8, length: 1)]
    public Int16 V_SF { get; private set; }
    [SunSpecProperty(offset: 9, length: 1)]
    public UInt16? Pad { get; private set; }
    public struct S_Curve
    {
      /// ActPt - Number of active points in array.
      /// Number of active points in array.
      [SunSpecProperty(offset: 0, length: 1)]
      public UInt16 ActPt { get; set; }
      /// [Secs]
      /// Tms1 - Point 1 must disconnect duration.
      /// Point 1 must disconnect duration.
      [SunSpecProperty(offset: 1, length: 1)]
      public UInt16 Tms1 { get; set; }
      /// [% VRef]
      /// V1 - Point 1 must disconnect voltage.
      /// Point 1 must disconnect voltage.
      [SunSpecProperty(offset: 2, length: 1)]
      public UInt16 V1 { get; set; }
      /// [Secs]
      /// Tms2 - Point 2 must disconnect duration.
      /// Point 2 must disconnect duration.
      [SunSpecProperty(offset: 3, length: 1)]
      public UInt16? Tms2 { get; set; }
      /// [% VRef]
      /// V2 - Point 2 must disconnect voltage.
      /// Point 2 must disconnect voltage.
      [SunSpecProperty(offset: 4, length: 1)]
      public UInt16? V2 { get; set; }
      /// [Secs]
      /// Tms3 - Point 3 must disconnect duration.
      /// Point 3 must disconnect duration.
      [SunSpecProperty(offset: 5, length: 1)]
      public UInt16? Tms3 { get; set; }
      /// [% VRef]
      /// V3 - Point 3 must disconnect voltage.
      /// Point 3 must disconnect voltage.
      [SunSpecProperty(offset: 6, length: 1)]
      public UInt16? V3 { get; set; }
      /// [Secs]
      /// Tms4 - Point 4 must disconnect duration.
      /// Point 4 must disconnect duration.
      [SunSpecProperty(offset: 7, length: 1)]
      public UInt16? Tms4 { get; set; }
      /// [% VRef]
      /// V4 - Point 4 must disconnect voltage.
      /// Point 4 must disconnect voltage.
      [SunSpecProperty(offset: 8, length: 1)]
      public UInt16? V4 { get; set; }
      /// [Secs]
      /// Tms5 - Point 5 must disconnect duration.
      /// Point 5 must disconnect duration.
      [SunSpecProperty(offset: 9, length: 1)]
      public UInt16? Tms5 { get; set; }
      /// [% VRef]
      /// V5 - Point 5 must disconnect voltage.
      /// Point 5 must disconnect voltage.
      [SunSpecProperty(offset: 10, length: 1)]
      public UInt16? V5 { get; set; }
      /// [Secs]
      /// Tms6 - Point 6 must disconnect duration.
      /// Point 6 must disconnect duration.
      [SunSpecProperty(offset: 11, length: 1)]
      public UInt16? Tms6 { get; set; }
      /// [% VRef]
      /// V6 - Point 6 must disconnect voltage.
      /// Point 6 must disconnect voltage.
      [SunSpecProperty(offset: 12, length: 1)]
      public UInt16? V6 { get; set; }
      /// [Secs]
      /// Tms7 - Point 7 must disconnect duration.
      /// Point 7 must disconnect duration.
      [SunSpecProperty(offset: 13, length: 1)]
      public UInt16? Tms7 { get; set; }
      /// [% VRef]
      /// V7 - Point 7 must disconnect voltage.
      /// Point 7 must disconnect voltage.
      [SunSpecProperty(offset: 14, length: 1)]
      public UInt16? V7 { get; set; }
      /// [Secs]
      /// Tms8 - Point 8 must disconnect duration.
      /// Point 8 must disconnect duration.
      [SunSpecProperty(offset: 15, length: 1)]
      public UInt16? Tms8 { get; set; }
      /// [% VRef]
      /// V8 - Point 8 must disconnect voltage.
      /// Point 8 must disconnect voltage.
      [SunSpecProperty(offset: 16, length: 1)]
      public UInt16? V8 { get; set; }
      /// [Secs]
      /// Tms9 - Point 9 must disconnect duration.
      /// Point 9 must disconnect duration.
      [SunSpecProperty(offset: 17, length: 1)]
      public UInt16? Tms9 { get; set; }
      /// [% VRef]
      /// V9 - Point 9 must disconnect voltage.
      /// Point 9 must disconnect voltage.
      [SunSpecProperty(offset: 18, length: 1)]
      public UInt16? V9 { get; set; }
      /// [Secs]
      /// Tms10 - Point 10 must disconnect duration.
      /// Point 10 must disconnect duration.
      [SunSpecProperty(offset: 19, length: 1)]
      public UInt16? Tms10 { get; set; }
      /// [% VRef]
      /// V10 - Point 10 must disconnect voltage.
      /// Point 10 must disconnect voltage.
      [SunSpecProperty(offset: 20, length: 1)]
      public UInt16? V10 { get; set; }
      /// [Secs]
      /// Tms11 - Point 11 must disconnect duration.
      /// Point 11 must disconnect duration.
      [SunSpecProperty(offset: 21, length: 1)]
      public UInt16? Tms11 { get; set; }
      /// [% VRef]
      /// V11 - Point 11 must disconnect voltage.
      /// Point 11 must disconnect voltage.
      [SunSpecProperty(offset: 22, length: 1)]
      public UInt16? V11 { get; set; }
      /// [Secs]
      /// Tms12 - Point 12 must disconnect duration.
      /// Point 12 must disconnect duration.
      [SunSpecProperty(offset: 23, length: 1)]
      public UInt16? Tms12 { get; set; }
      /// [% VRef]
      /// V12 - Point 12 must disconnect voltage.
      /// Point 12 must disconnect voltage.
      [SunSpecProperty(offset: 24, length: 1)]
      public UInt16? V12 { get; set; }
      /// [Secs]
      /// Tms13 - Point 13 must disconnect duration.
      /// Point 13 must disconnect duration.
      [SunSpecProperty(offset: 25, length: 1)]
      public UInt16? Tms13 { get; set; }
      /// [% VRef]
      /// V13 - Point 13 must disconnect voltage.
      /// Point 13 must disconnect voltage.
      [SunSpecProperty(offset: 26, length: 1)]
      public UInt16? V13 { get; set; }
      /// [Secs]
      /// Tms14 - Point 14 must disconnect duration.
      /// Point 14 must disconnect duration.
      [SunSpecProperty(offset: 27, length: 1)]
      public UInt16? Tms14 { get; set; }
      /// [% VRef]
      /// V14 - Point 14 must disconnect voltage.
      /// Point 14 must disconnect voltage.
      [SunSpecProperty(offset: 28, length: 1)]
      public UInt16? V14 { get; set; }
      /// [Secs]
      /// Tms15 - Point 15 must disconnect duration.
      /// Point 15 must disconnect duration.
      [SunSpecProperty(offset: 29, length: 1)]
      public UInt16? Tms15 { get; set; }
      /// [% VRef]
      /// V15 - Point 15 must disconnect voltage.
      /// Point 15 must disconnect voltage.
      [SunSpecProperty(offset: 30, length: 1)]
      public UInt16? V15 { get; set; }
      /// [Secs]
      /// Tms16 - Point 16 must disconnect duration.
      /// Point 16 must disconnect duration.
      [SunSpecProperty(offset: 31, length: 1)]
      public UInt16? Tms16 { get; set; }
      /// [% VRef]
      /// V16 - Point 16 must disconnect voltage.
      /// Point 16 must disconnect voltage.
      [SunSpecProperty(offset: 32, length: 1)]
      public UInt16? V16 { get; set; }
      /// [Secs]
      /// Tms17 - Point 17 must disconnect duration.
      /// Point 17 must disconnect duration.
      [SunSpecProperty(offset: 33, length: 1)]
      public UInt16? Tms17 { get; set; }
      /// [% VRef]
      /// V17 - Point 17 must disconnect voltage.
      /// Point 17 must disconnect voltage.
      [SunSpecProperty(offset: 34, length: 1)]
      public UInt16? V17 { get; set; }
      /// [Secs]
      /// Tms18 - Point 18 must disconnect duration.
      /// Point 18 must disconnect duration.
      [SunSpecProperty(offset: 35, length: 1)]
      public UInt16? Tms18 { get; set; }
      /// [% VRef]
      /// V18 - Point 18 must disconnect voltage.
      /// Point 18 must disconnect voltage.
      [SunSpecProperty(offset: 36, length: 1)]
      public UInt16? V18 { get; set; }
      /// [Secs]
      /// Tms19 - Point 19 must disconnect duration.
      /// Point 19 must disconnect duration.
      [SunSpecProperty(offset: 37, length: 1)]
      public UInt16? Tms19 { get; set; }
      /// [% VRef]
      /// V19 - Point 19 must disconnect voltage.
      /// Point 19 must disconnect voltage.
      [SunSpecProperty(offset: 38, length: 1)]
      public UInt16? V19 { get; set; }
      /// [Secs]
      /// Tms20 - Point 20 must disconnect duration.
      /// Point 20 must disconnect duration.
      [SunSpecProperty(offset: 39, length: 1)]
      public UInt16? Tms20 { get; set; }
      /// [% VRef]
      /// V20 - Point 20 must disconnect voltage.
      /// Point 20 must disconnect voltage.
      [SunSpecProperty(offset: 40, length: 1)]
      public UInt16? V20 { get; set; }
      /// CrvNam - Optional description for curve.
      /// Optional description for curve.
      [SunSpecProperty(offset: 41, length: 8)]
      public String? CrvNam { get; set; }
      public enum E_ReadOnly : UInt16
      {
        READWRITE = 0,
        READONLY = 1,
      }
      /// ReadOnly - Enumerated value indicates if curve is read-only or can be modified.
      /// Enumerated value indicates if curve is read-only or can be modified.
      [SunSpecProperty(offset: 49, length: 1)]
      public E_ReadOnly ReadOnly { get; private set; }
    };
    public S_Curve[] Curve;
  }
}
