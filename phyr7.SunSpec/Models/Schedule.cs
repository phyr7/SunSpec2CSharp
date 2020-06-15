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
  /// Basic Scheduling 
  /// NOTES: Ref 2: 2.2.8
  [SunSpecModel(id: 133, length: 66)]
  public struct Schedule
  {
    [Flags]
    public enum E_ActSchd : UInt32
    {
      SCHED1 = 0,
      SCHED2 = 1,
      SCHED3 = 2,
      SCHED4 = 3,
      SCHED5 = 4,
      SCHED6 = 5,
      SCHED7 = 6,
      SCHED8 = 7,
      SCHED9 = 8,
      SCHED10 = 9,
      SCHED12 = 10,
      SCHED13 = 11,
      SCHED14 = 12,
      SCHED15 = 13,
      SCHED16 = 14,
      SCHED17 = 15,
      SCHED18 = 16,
      SCHED19 = 17,
      SCHED20 = 18,
      SCHED21 = 19,
      SCHED22 = 21,
      SCHED23 = 22,
      SCHED24 = 23,
      SCHED25 = 24,
      SCHED26 = 25,
      SCHED27 = 26,
      SCHED28 = 27,
      SCHED29 = 28,
      SCHED30 = 29,
      SCHED31 = 30,
      SCHED32 = 31,
    }
    /// ActSchd - Bitfield of active schedules
    /// Bitfield of active schedules
    [SunSpecProperty(offset: 0, length: 2)]
    public E_ActSchd ActSchd { get; set; }
    [Flags]
    public enum E_ModEna : UInt16
    {
      ENABLED = 0,
    }
    /// ModEna - Is basic scheduling active.
    /// Is basic scheduling active.
    [SunSpecProperty(offset: 2, length: 1)]
    public E_ModEna ModEna { get; set; }
    /// NSchd - Number of schedules supported (recommend min. 4, max 32)
    /// Number of schedules supported (recommend min. 4, max 32)
    [SunSpecProperty(offset: 3, length: 1)]
    public UInt16 NSchd { get; private set; }
    /// NPts - Number of schedule entries supported (maximum of 10).
    /// Number of schedule entries supported (maximum of 10).
    [SunSpecProperty(offset: 4, length: 1)]
    public UInt16 NPts { get; private set; }
    /// Pad - Pad register.
    /// Pad register.
    [SunSpecProperty(offset: 5, length: 1)]
    public UInt16? Pad { get; private set; }
    public struct S_Block2
    {
      /// ActPts - Number of active entries in schedule.
      /// Number of active entries in schedule.
      [SunSpecProperty(offset: 0, length: 1)]
      public UInt16 ActPts { get; set; }
      /// [Secs]
      /// StrTms - Schedule start in seconds since 2000 JAN 01 00:00:00 UTC.
      /// Schedule start in seconds since 2000 JAN 01 00:00:00 UTC.
      [SunSpecProperty(offset: 1, length: 2)]
      public UInt32 StrTms { get; set; }
      /// RepPer - The repetition count for time-based schedules (0=repeat forever)
      /// The repetition count for time-based schedules (0=repeat forever)
      [SunSpecProperty(offset: 3, length: 1)]
      public UInt16 RepPer { get; set; }
      public enum E_IntvTyp : UInt16
      {
        ONETIME = 0,
        DAILY = 1,
        WEEKLY = 2,
        MONTHLY = 3,
        WEEKDAY = 4,
        HOLIDAY = 5,
        WEEKEND = 6,
        YEARLY = 7,
      }
      /// SchdTyp - The repetition frequency for time-based schedules: no repeat=0
      /// The repetition frequency for time-based schedules: no repeat=0
      [SunSpecProperty(offset: 4, length: 1)]
      public E_IntvTyp IntvTyp { get; set; }
      public enum E_XTyp : UInt16
      {
        UNSET = 0,
        TIME = 1,
        TEMP = 2,
        PRICE = 3,
        OTHER = 99,
      }
      /// XTyp - The meaning of the X-values in the array. 
      /// The meaning of the X-values in the array. 
      [SunSpecProperty(offset: 5, length: 1)]
      public E_XTyp XTyp { get; set; }
      /// X_SF - Scale factor for schedule range values.
      /// Scale factor for schedule range values.
      [SunSpecProperty(offset: 6, length: 1)]
      public Int16 X_SF { get; set; }
      public enum E_YTyp : UInt16
      {
        UNSET = 0,
        WMax = 1,
        RSRVD2 = 2,
        PF = 3,
        RSRVD4 = 4,
        WATT_PRICE = 5,
        VAR_PRICE = 6,
        RSRVD7 = 7,
        VOLT_VAR_ARRAY = 8,
        WChaGra = 9,
        WDisChaGra = 10,
        VArAval = 11,
        Schedule = 12,
        OTHER = 99,
      }
      /// YTyp - The meaning of the Y-values in the array.
      /// The meaning of the Y-values in the array.
      [SunSpecProperty(offset: 7, length: 1)]
      public E_YTyp YTyp { get; set; }
      /// Y_SF - Scale factor for schedule target values.
      /// Scale factor for schedule target values.
      [SunSpecProperty(offset: 8, length: 1)]
      public Int16 Y_SF { get; set; }
      /// X1 - Entry 1 range.
      /// Entry 1 range.
      [SunSpecProperty(offset: 9, length: 2)]
      public Int32 X1 { get; set; }
      /// Y1 - Entry 1 target.
      /// Entry 1 target.
      [SunSpecProperty(offset: 11, length: 2)]
      public Int32 Y1 { get; set; }
      /// X2 - Entry 2 range.
      /// Entry 2 range.
      [SunSpecProperty(offset: 13, length: 2)]
      public Int32? X2 { get; set; }
      /// Y2 - Entry 2 target.
      /// Entry 2 target.
      [SunSpecProperty(offset: 15, length: 2)]
      public Int32? Y2 { get; set; }
      /// X3 - Entry 3 range.
      /// Entry 3 range.
      [SunSpecProperty(offset: 17, length: 2)]
      public Int32? X3 { get; set; }
      /// Y3 - Entry 3 target.
      /// Entry 3 target.
      [SunSpecProperty(offset: 19, length: 2)]
      public Int32? Y3 { get; set; }
      /// X4 - Entry 4 range.
      /// Entry 4 range.
      [SunSpecProperty(offset: 21, length: 2)]
      public Int32? X4 { get; set; }
      /// Y4 - Entry 4 target.
      /// Entry 4 target.
      [SunSpecProperty(offset: 23, length: 2)]
      public Int32? Y4 { get; set; }
      /// X5 - Entry 15range.
      /// Entry 15range.
      [SunSpecProperty(offset: 25, length: 2)]
      public Int32? X5 { get; set; }
      /// Y5 - Entry 5 target.
      /// Entry 5 target.
      [SunSpecProperty(offset: 27, length: 2)]
      public Int32? Y5 { get; set; }
      /// X6 - Entry 6 range.
      /// Entry 6 range.
      [SunSpecProperty(offset: 29, length: 2)]
      public Int32? X6 { get; set; }
      /// Y6 - Entry 6 target.
      /// Entry 6 target.
      [SunSpecProperty(offset: 31, length: 2)]
      public Int32? Y6 { get; set; }
      /// X7 - Entry 7 range.
      /// Entry 7 range.
      [SunSpecProperty(offset: 33, length: 2)]
      public Int32? X7 { get; set; }
      /// Y7 - Entry 7 target.
      /// Entry 7 target.
      [SunSpecProperty(offset: 35, length: 2)]
      public Int32? Y7 { get; set; }
      /// X8 - Entry 8 range.
      /// Entry 8 range.
      [SunSpecProperty(offset: 37, length: 2)]
      public Int32? X8 { get; set; }
      /// Y8 - Entry 8 target.
      /// Entry 8 target.
      [SunSpecProperty(offset: 39, length: 2)]
      public Int32? Y8 { get; set; }
      /// X9 - Entry 9 range.
      /// Entry 9 range.
      [SunSpecProperty(offset: 41, length: 2)]
      public Int32? X9 { get; set; }
      /// Y9 - Entry 9 target.
      /// Entry 9 target.
      [SunSpecProperty(offset: 43, length: 2)]
      public Int32? Y9 { get; set; }
      /// X10 - Entry 10 range.
      /// Entry 10 range.
      [SunSpecProperty(offset: 45, length: 2)]
      public Int32? X10 { get; set; }
      /// Y10 - Entry 10 target.
      /// Entry 10 target.
      [SunSpecProperty(offset: 47, length: 2)]
      public Int32? Y10 { get; set; }
      /// Nam - Optional description for schedule.
      /// Optional description for schedule.
      [SunSpecProperty(offset: 49, length: 8)]
      public String? Nam { get; set; }
      /// [Secs]
      /// WinTms - Time window for schedule entry change.
      /// Time window for schedule entry change.
      [SunSpecProperty(offset: 57, length: 1)]
      public UInt16? WinTms { get; set; }
      /// [Secs]
      /// RmpTms - Ramp time for moving from current target to new target.
      /// Ramp time for moving from current target to new target.
      [SunSpecProperty(offset: 58, length: 1)]
      public UInt16? RmpTms { get; set; }
      /// ActIndx - Index of active entry in the active schedule.
      /// Index of active entry in the active schedule.
      [SunSpecProperty(offset: 59, length: 1)]
      public UInt16 ActIndx { get; private set; }
    };
    public S_Block2[] Block2;
  }
}
