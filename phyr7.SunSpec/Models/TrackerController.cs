using System;

{
  /// Monitors and controls multiple trackers
  /// NOTES: Trackers may include GPS model 305 for location information
  [SunSpecModel(id: 601, length: 48)]
  public class TrackerController
  {
    /// Controller - Descriptive name for this control unit
    /// Descriptive name for this control unit
    [SunSpecProperty(offset: 0, length: 8)]
    public String? Nam { get; set; }
    public enum E_Typ : UInt16
    {
      Unknown = 0,
      Fixed = 1,
      Horizontal = 2,
      Tilted = 3,
      Azimuth = 4,
      Dual = 5,
      Other = 99,
    }
    /// Type - Type of tracker
    /// Type of tracker
    [SunSpecProperty(offset: 8, length: 1)]
    public E_Typ Typ { get; set; }
    /// [YYYYMMDD]
    /// Date - Local date in YYYYMMDD format
    /// Local date in YYYYMMDD format
    [SunSpecProperty(offset: 9, length: 5)]
    public String? DtLoc { get; set; }
    /// [hhmmss]
    /// Time - 24 hour local time stamp to second
    /// 24 hour local time stamp to second
    [SunSpecProperty(offset: 14, length: 3)]
    public String? TmLoc { get; set; }
    /// Day - Number of the day in the year (1-366)
    /// Number of the day in the year (1-366)
    [SunSpecProperty(offset: 17, length: 1)]
    public UInt16? Day { get; set; }
    /// [Degrees]
    /// Manual Elevation - Global manual override target position of elevation in degrees from horizontal.  Unimplemented for single axis azimuth tracker type
    /// Global manual override target position of elevation in degrees from horizontal.  Unimplemented for single axis azimuth tracker type
    [SunSpecProperty(offset: 18, length: 1)]
    public Int32? GlblElCtl { get; set; }
    /// [Degrees]
    /// Manual Azimuth - Global manual override target position of azimuth in degrees from true north towards east.  Unimplemented for single axis azimuth tracker type
    /// Global manual override target position of azimuth in degrees from true north towards east.  Unimplemented for single axis azimuth tracker type
    [SunSpecProperty(offset: 20, length: 1)]
    public Int32? GlblAzCtl { get; set; }
    public enum E_GlblCtl : UInt16
    {
      Automatic = 0,
      Manual = 1,
      Calibrate = 2,
    }
    /// Global Mode - Global Control register operates on all trackers. Normal operation is automatic.  Operator can override the position by setting the ElCtl, AzCtl and enabling Manual operation. Entering calibration mode will revert to automatic operation after calibration is complete.
    /// Global Control register operates on all trackers. Normal operation is automatic.  Operator can override the position by setting the ElCtl, AzCtl and enabling Manual operation. Entering calibration mode will revert to automatic operation after calibration is complete.
    /// NOTES: The global controls all trackers
    [SunSpecProperty(offset: 22, length: 1)]
    public E_GlblCtl? GlblCtl { get; set; }
    [Flags]
    public enum E_GlblAlm : UInt16
    {
      SetPoint = 0,
      ObsEl = 1,
      ObsAz = 2,
    }
    /// Global Alarm - Global tracker alarm conditions
    /// Global tracker alarm conditions
    /// NOTES: Combined tracker alarm conditions.  See individual trackers for alarms
    [SunSpecProperty(offset: 23, length: 1)]
    public E_GlblAlm? GlblAlm { get; set; }
    /// SF - Scale Factor for targets and position measurements in degrees
    /// Scale Factor for targets and position measurements in degrees
    [SunSpecProperty(offset: 24, length: 1)]
    public Int16 Dgr_SF { get; set; }
    /// Trackers - Number of trackers being controlled.  Size of repeating block.
    /// Number of trackers being controlled.  Size of repeating block.
    [SunSpecProperty(offset: 25, length: 1)]
    public UInt16 N { get; set; }
    public struct Tracker
    {
      /// Tracker - Descriptive name for this tracker unit
      /// Descriptive name for this tracker unit
      [SunSpecProperty(offset: 0, length: 8)]
      public String? Id { get; set; }
      /// [Degrees]
      /// Target Elevation - Auto target elevation in degrees from horizontal.  Unimplemented for single axis azimuth tracker type
      /// Auto target elevation in degrees from horizontal.  Unimplemented for single axis azimuth tracker type
      /// NOTES: Conformant implementations shall implement El or Az
      [SunSpecProperty(offset: 8, length: 1)]
      public Int32? ElTrgt { get; set; }
      /// [Degrees]
      /// Target Azimuth - Auto target azimuth  in degrees from true north towards east.  Unimplemented for single axis horizontal tracker type
      /// Auto target azimuth  in degrees from true north towards east.  Unimplemented for single axis horizontal tracker type
      /// NOTES: Conformant implementations shall implement El or Az
      [SunSpecProperty(offset: 10, length: 1)]
      public Int32? AzTrgt { get; set; }
      /// [Degrees]
      /// Elevation - Actual elevation position  in degrees from horizontal.  Unimplemented for single axis azimuth tracker type
      /// Actual elevation position  in degrees from horizontal.  Unimplemented for single axis azimuth tracker type
      /// NOTES: Conformant implementations shall implement El or Az
      [SunSpecProperty(offset: 12, length: 1)]
      public Int32? ElPos { get; set; }
      /// [Degrees]
      /// Azimuth - Actual azimuth position  in degrees from true north towards east.  Unimplemented for single axis horizontal tracker type
      /// Actual azimuth position  in degrees from true north towards east.  Unimplemented for single axis horizontal tracker type
      /// NOTES: Conformant implementations shall implement El or Az
      [SunSpecProperty(offset: 14, length: 1)]
      public Int32? AzPos { get; set; }
      /// [Degrees]
      /// Manual Elevation - Manual override target position of elevation in degrees from horizontal.  Unimplemented for single axis azimuth tracker type
      /// Manual override target position of elevation in degrees from horizontal.  Unimplemented for single axis azimuth tracker type
      [SunSpecProperty(offset: 16, length: 1)]
      public Int32? ElCtl { get; set; }
      /// [Degrees]
      /// Manual Azimuth - Manual override target position of azimuth in degrees from true north towards east.  Unimplemented for single axis azimuth tracker type
      /// Manual override target position of azimuth in degrees from true north towards east.  Unimplemented for single axis azimuth tracker type
      [SunSpecProperty(offset: 18, length: 1)]
      public Int32? AzCtl { get; set; }
      public enum E_Ctl : UInt16
      {
        Automatic = 0,
        Manual = 1,
        Calibrate = 2,
      }
      /// Mode - Control register. Normal operation is automatic.  Operator can override the position by setting the ElCtl, AzCtl and enabling Manual operation. Entering calibration mode will revert to automatic operation after calibration is complete.
      /// Control register. Normal operation is automatic.  Operator can override the position by setting the ElCtl, AzCtl and enabling Manual operation. Entering calibration mode will revert to automatic operation after calibration is complete.
      [SunSpecProperty(offset: 20, length: 1)]
      public E_Ctl? Ctl { get; set; }
      [Flags]
      public enum E_Alm : UInt16
      {
        SetPoint = 0,
        ObsEl = 1,
        ObsAz = 2,
      }
      /// Alarm - Tracker alarm conditions
      /// Tracker alarm conditions
      [SunSpecProperty(offset: 21, length: 1)]
      public E_Alm? Alm { get; set; }
    }[];
  }
}
