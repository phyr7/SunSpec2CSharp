using System;

{
  /// Low Frequency Ride-through
  /// NOTES: Ref 4: 11
  [SunSpecModel(id: 135, length: 60)]
  public class Lfrt
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
    /// ModEna - LHzRT control mode. Enable active curve.  Bitfield value.
    /// LHzRT control mode. Enable active curve.  Bitfield value.
    [SunSpecProperty(offset: 1, length: 1)]
    public E_ModEna ModEna { get; set; }
    /// [Secs]
    /// WinTms - Time window for LFRT change.
    /// Time window for LFRT change.
    /// NOTES: Setting is ignored for LFRT controls.
    [SunSpecProperty(offset: 2, length: 1)]
    public UInt16? WinTms { get; set; }
    /// [Secs]
    /// RvrtTms - Timeout period for LFRT curve selection.
    /// Timeout period for LFRT curve selection.
    /// NOTES: Setting is ignored for LFRT controls.
    [SunSpecProperty(offset: 3, length: 1)]
    public UInt16? RvrtTms { get; set; }
    /// [Secs]
    /// RmpTms - Ramp time for moving from current mode to new mode.
    /// Ramp time for moving from current mode to new mode.
    /// NOTES: Setting is ignored for LFRT controls.
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
    /// Hz_SF - Scale factor for frequency.
    /// Scale factor for frequency.
    [SunSpecProperty(offset: 8, length: 1)]
    public Int16 Hz_SF { get; private set; }
    [SunSpecProperty(offset: 9, length: 1)]
    public UInt16? Pad { get; private set; }
    public struct Curve
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
      /// [Hz]
      /// Hz1 - Point 1 must disconnect frequency.
      /// Point 1 must disconnect frequency.
      [SunSpecProperty(offset: 2, length: 1)]
      public UInt16 Hz1 { get; set; }
      /// [Secs]
      /// Tms2 - Point 2 must disconnect duration.
      /// Point 2 must disconnect duration.
      [SunSpecProperty(offset: 3, length: 1)]
      public UInt16? Tms2 { get; set; }
      /// [Hz]
      /// Hz2 - Point 2 must disconnect frequency.
      /// Point 2 must disconnect frequency.
      [SunSpecProperty(offset: 4, length: 1)]
      public UInt16? Hz2 { get; set; }
      /// [Secs]
      /// Tms3 - Point 3 must disconnect duration.
      /// Point 3 must disconnect duration.
      [SunSpecProperty(offset: 5, length: 1)]
      public UInt16? Tms3 { get; set; }
      /// [Hz]
      /// Hz3 - Point 3 must disconnect frequency.
      /// Point 3 must disconnect frequency.
      [SunSpecProperty(offset: 6, length: 1)]
      public UInt16? Hz3 { get; set; }
      /// [Secs]
      /// Tms4 - Point 4 must disconnect duration.
      /// Point 4 must disconnect duration.
      [SunSpecProperty(offset: 7, length: 1)]
      public UInt16? Tms4 { get; set; }
      /// [Hz]
      /// Hz4 - Point 4 must disconnect frequency.
      /// Point 4 must disconnect frequency.
      [SunSpecProperty(offset: 8, length: 1)]
      public UInt16? Hz4 { get; set; }
      /// [Secs]
      /// Tms5 - Point 5 must disconnect duration.
      /// Point 5 must disconnect duration.
      [SunSpecProperty(offset: 9, length: 1)]
      public UInt16? Tms5 { get; set; }
      /// [Hz]
      /// Hz5 - Point 5 must disconnect frequency.
      /// Point 5 must disconnect frequency.
      [SunSpecProperty(offset: 10, length: 1)]
      public UInt16? Hz5 { get; set; }
      /// [Secs]
      /// Tms6 - Point 6 must disconnect duration.
      /// Point 6 must disconnect duration.
      [SunSpecProperty(offset: 11, length: 1)]
      public UInt16? Tms6 { get; set; }
      /// [Hz]
      /// Hz6 - Point 6 must disconnect frequency.
      /// Point 6 must disconnect frequency.
      [SunSpecProperty(offset: 12, length: 1)]
      public UInt16? Hz6 { get; set; }
      /// [Secs]
      /// Tms7 - Point 7 must disconnect duration.
      /// Point 7 must disconnect duration.
      [SunSpecProperty(offset: 13, length: 1)]
      public UInt16? Tms7 { get; set; }
      /// [Hz]
      /// Hz7 - Point 7 must disconnect frequency.
      /// Point 7 must disconnect frequency.
      [SunSpecProperty(offset: 14, length: 1)]
      public UInt16? Hz7 { get; set; }
      /// [Secs]
      /// Tms8 - Point 8 must disconnect duration.
      /// Point 8 must disconnect duration.
      [SunSpecProperty(offset: 15, length: 1)]
      public UInt16? Tms8 { get; set; }
      /// [Hz]
      /// Hz8 - Point 8 must disconnect frequency.
      /// Point 8 must disconnect frequency.
      [SunSpecProperty(offset: 16, length: 1)]
      public UInt16? Hz8 { get; set; }
      /// [Secs]
      /// Tms9 - Point 9 must disconnect duration.
      /// Point 9 must disconnect duration.
      [SunSpecProperty(offset: 17, length: 1)]
      public UInt16? Tms9 { get; set; }
      /// [Hz]
      /// Hz9 - Point 9 must disconnect frequency.
      /// Point 9 must disconnect frequency.
      [SunSpecProperty(offset: 18, length: 1)]
      public UInt16? Hz9 { get; set; }
      /// [Secs]
      /// Tms10 - Point 10 must disconnect duration.
      /// Point 10 must disconnect duration.
      [SunSpecProperty(offset: 19, length: 1)]
      public UInt16? Tms10 { get; set; }
      /// [Hz]
      /// Hz10 - Point 10 must disconnect frequency.
      /// Point 10 must disconnect frequency.
      [SunSpecProperty(offset: 20, length: 1)]
      public UInt16? Hz10 { get; set; }
      /// [Secs]
      /// Tms11 - Point 11 must disconnect duration.
      /// Point 11 must disconnect duration.
      [SunSpecProperty(offset: 21, length: 1)]
      public UInt16? Tms11 { get; set; }
      /// [Hz]
      /// Hz11 - Point 11 must disconnect frequency.
      /// Point 11 must disconnect frequency.
      [SunSpecProperty(offset: 22, length: 1)]
      public UInt16? Hz11 { get; set; }
      /// [Secs]
      /// Tms12 - Point 12 must disconnect duration.
      /// Point 12 must disconnect duration.
      [SunSpecProperty(offset: 23, length: 1)]
      public UInt16? Tms12 { get; set; }
      /// [Hz]
      /// Hz12 - Point 12 must disconnect frequency.
      /// Point 12 must disconnect frequency.
      [SunSpecProperty(offset: 24, length: 1)]
      public UInt16? Hz12 { get; set; }
      /// [Secs]
      /// Tms13 - Point 13 must disconnect duration.
      /// Point 13 must disconnect duration.
      [SunSpecProperty(offset: 25, length: 1)]
      public UInt16? Tms13 { get; set; }
      /// [Hz]
      /// Hz13 - Point 13 must disconnect frequency.
      /// Point 13 must disconnect frequency.
      [SunSpecProperty(offset: 26, length: 1)]
      public UInt16? Hz13 { get; set; }
      /// [Secs]
      /// Tms14 - Point 14 must disconnect duration.
      /// Point 14 must disconnect duration.
      [SunSpecProperty(offset: 27, length: 1)]
      public UInt16? Tms14 { get; set; }
      /// [Hz]
      /// Hz14 - Point 14 must disconnect frequency.
      /// Point 14 must disconnect frequency.
      [SunSpecProperty(offset: 28, length: 1)]
      public UInt16? Hz14 { get; set; }
      /// [Secs]
      /// Tms15 - Point 15 must disconnect duration.
      /// Point 15 must disconnect duration.
      [SunSpecProperty(offset: 29, length: 1)]
      public UInt16? Tms15 { get; set; }
      /// [Hz]
      /// Hz15 - Point 15 must disconnect frequency.
      /// Point 15 must disconnect frequency.
      [SunSpecProperty(offset: 30, length: 1)]
      public UInt16? Hz15 { get; set; }
      /// [Secs]
      /// Tms16 - Point 16 must disconnect duration.
      /// Point 16 must disconnect duration.
      [SunSpecProperty(offset: 31, length: 1)]
      public UInt16? Tms16 { get; set; }
      /// [Hz]
      /// Hz16 - Point 16 must disconnect frequency.
      /// Point 16 must disconnect frequency.
      [SunSpecProperty(offset: 32, length: 1)]
      public UInt16? Hz16 { get; set; }
      /// [Secs]
      /// Tms17 - Point 17 must disconnect duration.
      /// Point 17 must disconnect duration.
      [SunSpecProperty(offset: 33, length: 1)]
      public UInt16? Tms17 { get; set; }
      /// [Hz]
      /// Hz17 - Point 17 must disconnect frequency.
      /// Point 17 must disconnect frequency.
      [SunSpecProperty(offset: 34, length: 1)]
      public UInt16? Hz17 { get; set; }
      /// [Secs]
      /// Tms18 - Point 18 must disconnect duration.
      /// Point 18 must disconnect duration.
      [SunSpecProperty(offset: 35, length: 1)]
      public UInt16? Tms18 { get; set; }
      /// [Hz]
      /// Hz18 - Point 18 must disconnect frequency.
      /// Point 18 must disconnect frequency.
      [SunSpecProperty(offset: 36, length: 1)]
      public UInt16? Hz18 { get; set; }
      /// [Secs]
      /// Tms19 - Point 19 must disconnect duration.
      /// Point 19 must disconnect duration.
      [SunSpecProperty(offset: 37, length: 1)]
      public UInt16? Tms19 { get; set; }
      /// [Hz]
      /// Hz19 - Point 19 must disconnect frequency.
      /// Point 19 must disconnect frequency.
      [SunSpecProperty(offset: 38, length: 1)]
      public UInt16? Hz19 { get; set; }
      /// [Secs]
      /// Tms20 - Point 20 must disconnect duration.
      /// Point 20 must disconnect duration.
      [SunSpecProperty(offset: 39, length: 1)]
      public UInt16? Tms20 { get; set; }
      /// [Hz]
      /// Hz20 - Point 20 must disconnect frequency.
      /// Point 20 must disconnect frequency.
      [SunSpecProperty(offset: 40, length: 1)]
      public UInt16? Hz20 { get; set; }
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
    }[];
  }
}
