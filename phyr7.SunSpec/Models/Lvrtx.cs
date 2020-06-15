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
  /// LVRT extended curve
  /// NOTES: Ref 4: 11
  [SunSpecModel(id: 139, length: 60)]
  public struct Lvrtx
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
    /// ModEna - LVRT control mode. Enable active curve.  Bitfield value.
    /// LVRT control mode. Enable active curve.  Bitfield value.
    [SunSpecProperty(offset: 1, length: 1)]
    public E_ModEna ModEna { get; set; }
    /// [Secs]
    /// WinTms - Time window for LVRT change.
    /// Time window for LVRT change.
    /// NOTES: Setting is ignored for LVRT controls.
    [SunSpecProperty(offset: 2, length: 1)]
    public UInt16? WinTms { get; set; }
    /// [Secs]
    /// RvrtTms - Timeout period for LVRT curve selection.
    /// Timeout period for LVRT curve selection.
    /// NOTES: Setting is ignored for LVRT controls.
    [SunSpecProperty(offset: 3, length: 1)]
    public UInt16? RvrtTms { get; set; }
    /// [Secs]
    /// RmpTms - Ramp time for moving from current mode to new mode.
    /// Ramp time for moving from current mode to new mode.
    /// NOTES: Setting is ignored for LVRT controls.
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
    public enum E_CrvType : UInt16
    {
      CEASE_TO_ENERGIZE = 1,
    }
    [SunSpecProperty(offset: 9, length: 1)]
    public E_CrvType CrvType { get; private set; }
    public struct S_Curve
    {
      /// ActPt - Number of active points in array.
      /// Number of active points in array.
      [SunSpecProperty(offset: 0, length: 1)]
      public UInt16 ActPt { get; set; }
      /// [Secs]
      /// Tms1 - Point 1 duration.
      /// Point 1 duration.
      [SunSpecProperty(offset: 1, length: 1)]
      public UInt16 Tms1 { get; set; }
      /// [% VRef]
      /// V1 - Point 1 voltage.
      /// Point 1 voltage.
      [SunSpecProperty(offset: 2, length: 1)]
      public UInt16 V1 { get; set; }
      /// [Secs]
      /// Tms2 - Point 2 duration.
      /// Point 2 duration.
      [SunSpecProperty(offset: 3, length: 1)]
      public UInt16? Tms2 { get; set; }
      /// [% VRef]
      /// V2 - Point 2 voltage.
      /// Point 2 voltage.
      [SunSpecProperty(offset: 4, length: 1)]
      public UInt16? V2 { get; set; }
      /// [Secs]
      /// Tms3 - Point 3 duration.
      /// Point 3 duration.
      [SunSpecProperty(offset: 5, length: 1)]
      public UInt16? Tms3 { get; set; }
      /// [% VRef]
      /// V3 - Point 3 voltage.
      /// Point 3 voltage.
      [SunSpecProperty(offset: 6, length: 1)]
      public UInt16? V3 { get; set; }
      /// [Secs]
      /// Tms4 - Point 4 duration.
      /// Point 4 duration.
      [SunSpecProperty(offset: 7, length: 1)]
      public UInt16? Tms4 { get; set; }
      /// [% VRef]
      /// V4 - Point 4 voltage.
      /// Point 4 voltage.
      [SunSpecProperty(offset: 8, length: 1)]
      public UInt16? V4 { get; set; }
      /// [Secs]
      /// Tms5 - Point 5 duration.
      /// Point 5 duration.
      [SunSpecProperty(offset: 9, length: 1)]
      public UInt16? Tms5 { get; set; }
      /// [% VRef]
      /// V5 - Point 5 voltage.
      /// Point 5 voltage.
      [SunSpecProperty(offset: 10, length: 1)]
      public UInt16? V5 { get; set; }
      /// [Secs]
      /// Tms6 - Point 6 duration.
      /// Point 6 duration.
      [SunSpecProperty(offset: 11, length: 1)]
      public UInt16? Tms6 { get; set; }
      /// [% VRef]
      /// V6 - Point 6 voltage.
      /// Point 6 voltage.
      [SunSpecProperty(offset: 12, length: 1)]
      public UInt16? V6 { get; set; }
      /// [Secs]
      /// Tms7 - Point 7 duration.
      /// Point 7 duration.
      [SunSpecProperty(offset: 13, length: 1)]
      public UInt16? Tms7 { get; set; }
      /// [% VRef]
      /// V7 - Point 7 voltage.
      /// Point 7 voltage.
      [SunSpecProperty(offset: 14, length: 1)]
      public UInt16? V7 { get; set; }
      /// [Secs]
      /// Tms8 - Point 8 duration.
      /// Point 8 duration.
      [SunSpecProperty(offset: 15, length: 1)]
      public UInt16? Tms8 { get; set; }
      /// [% VRef]
      /// V8 - Point 8 voltage.
      /// Point 8 voltage.
      [SunSpecProperty(offset: 16, length: 1)]
      public UInt16? V8 { get; set; }
      /// [Secs]
      /// Tms9 - Point 9 duration.
      /// Point 9 duration.
      [SunSpecProperty(offset: 17, length: 1)]
      public UInt16? Tms9 { get; set; }
      /// [% VRef]
      /// V9 - Point 9 voltage.
      /// Point 9 voltage.
      [SunSpecProperty(offset: 18, length: 1)]
      public UInt16? V9 { get; set; }
      /// [Secs]
      /// Tms10 - Point 10 duration.
      /// Point 10 duration.
      [SunSpecProperty(offset: 19, length: 1)]
      public UInt16? Tms10 { get; set; }
      /// [% VRef]
      /// V10 - Point 10 voltage.
      /// Point 10 voltage.
      [SunSpecProperty(offset: 20, length: 1)]
      public UInt16? V10 { get; set; }
      /// [Secs]
      /// Tms11 - Point 11 duration.
      /// Point 11 duration.
      [SunSpecProperty(offset: 21, length: 1)]
      public UInt16? Tms11 { get; set; }
      /// [% VRef]
      /// V11 - Point 11 voltage.
      /// Point 11 voltage.
      [SunSpecProperty(offset: 22, length: 1)]
      public UInt16? V11 { get; set; }
      /// [Secs]
      /// Tms12 - Point 12 duration.
      /// Point 12 duration.
      [SunSpecProperty(offset: 23, length: 1)]
      public UInt16? Tms12 { get; set; }
      /// [% VRef]
      /// V12 - Point 12 voltage.
      /// Point 12 voltage.
      [SunSpecProperty(offset: 24, length: 1)]
      public UInt16? V12 { get; set; }
      /// [Secs]
      /// Tms13 - Point 13 duration.
      /// Point 13 duration.
      [SunSpecProperty(offset: 25, length: 1)]
      public UInt16? Tms13 { get; set; }
      /// [% VRef]
      /// V13 - Point 13 voltage.
      /// Point 13 voltage.
      [SunSpecProperty(offset: 26, length: 1)]
      public UInt16? V13 { get; set; }
      /// [Secs]
      /// Tms14 - Point 14 duration.
      /// Point 14 duration.
      [SunSpecProperty(offset: 27, length: 1)]
      public UInt16? Tms14 { get; set; }
      /// [% VRef]
      /// V14 - Point 14 voltage.
      /// Point 14 voltage.
      [SunSpecProperty(offset: 28, length: 1)]
      public UInt16? V14 { get; set; }
      /// [Secs]
      /// Tms15 - Point 15 duration.
      /// Point 15 duration.
      [SunSpecProperty(offset: 29, length: 1)]
      public UInt16? Tms15 { get; set; }
      /// [% VRef]
      /// V15 - Point 15 voltage.
      /// Point 15 voltage.
      [SunSpecProperty(offset: 30, length: 1)]
      public UInt16? V15 { get; set; }
      /// [Secs]
      /// Tms16 - Point 16 duration.
      /// Point 16 duration.
      [SunSpecProperty(offset: 31, length: 1)]
      public UInt16? Tms16 { get; set; }
      /// [% VRef]
      /// V16 - Point 16 voltage.
      /// Point 16 voltage.
      [SunSpecProperty(offset: 32, length: 1)]
      public UInt16? V16 { get; set; }
      /// [Secs]
      /// Tms17 - Point 17 duration.
      /// Point 17 duration.
      [SunSpecProperty(offset: 33, length: 1)]
      public UInt16? Tms17 { get; set; }
      /// [% VRef]
      /// V17 - Point 17 voltage.
      /// Point 17 voltage.
      [SunSpecProperty(offset: 34, length: 1)]
      public UInt16? V17 { get; set; }
      /// [Secs]
      /// Tms18 - Point 18 duration.
      /// Point 18 duration.
      [SunSpecProperty(offset: 35, length: 1)]
      public UInt16? Tms18 { get; set; }
      /// [% VRef]
      /// V18 - Point 18 voltage.
      /// Point 18 voltage.
      [SunSpecProperty(offset: 36, length: 1)]
      public UInt16? V18 { get; set; }
      /// [Secs]
      /// Tms19 - Point 19 duration.
      /// Point 19 duration.
      [SunSpecProperty(offset: 37, length: 1)]
      public UInt16? Tms19 { get; set; }
      /// [% VRef]
      /// V19 - Point 19 voltage.
      /// Point 19 voltage.
      [SunSpecProperty(offset: 38, length: 1)]
      public UInt16? V19 { get; set; }
      /// [Secs]
      /// Tms20 - Point 20 duration.
      /// Point 20 duration.
      [SunSpecProperty(offset: 39, length: 1)]
      public UInt16? Tms20 { get; set; }
      /// [% VRef]
      /// V20 - Point 20 voltage.
      /// Point 20 voltage.
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
