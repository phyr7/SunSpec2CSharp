using System;

{
  [SunSpecModel(id: 160, length: 28)]
  public class Mppt
  {
    /// Current Scale Factor - 
    [SunSpecProperty(offset: 0, length: 1)]
    public Int16? DCA_SF { get; set; }
    /// Voltage Scale Factor - 
    [SunSpecProperty(offset: 1, length: 1)]
    public Int16? DCV_SF { get; set; }
    /// Power Scale Factor - 
    [SunSpecProperty(offset: 2, length: 1)]
    public Int16? DCW_SF { get; set; }
    /// Energy Scale Factor - 
    [SunSpecProperty(offset: 3, length: 1)]
    public Int16? DCWH_SF { get; set; }
    [Flags]
    public enum E_Evt : UInt32
    {
      GROUND_FAULT = 0,
      INPUT_OVER_VOLTAGE = 1,
      RESERVED_2 = 2,
      DC_DISCONNECT = 3,
      RESERVED_4 = 4,
      CABINET_OPEN = 5,
      MANUAL_SHUTDOWN = 6,
      OVER_TEMP = 7,
      RESERVED_8 = 8,
      RESERVED_9 = 9,
      RESERVED_10 = 10,
      RESERVED_11 = 11,
      BLOWN_FUSE = 12,
      UNDER_TEMP = 13,
      MEMORY_LOSS = 14,
      ARC_DETECTION = 15,
      RESERVED_16 = 16,
      RESERVED_17 = 17,
      RESERVED_18 = 18,
      RESERVED_19 = 19,
      TEST_FAILED = 20,
      INPUT_UNDER_VOLTAGE = 21,
      INPUT_OVER_CURRENT = 22,
    }
    /// Global Events - 
    [SunSpecProperty(offset: 4, length: 1)]
    public E_Evt? Evt { get; set; }
    /// Number of Modules - 
    [SunSpecProperty(offset: 6, length: 1)]
    public UInt16? N { get; set; }
    /// Timestamp Period - 
    [SunSpecProperty(offset: 7, length: 1)]
    public UInt16? TmsPer { get; set; }
    public struct Module
    {
      /// Input ID - 
      [SunSpecProperty(offset: 0, length: 1)]
      public UInt16? ID { get; set; }
      /// Input ID Sting - 
      [SunSpecProperty(offset: 1, length: 8)]
      public String? IDStr { get; set; }
      /// [A]
      /// DC Current - 
      [SunSpecProperty(offset: 9, length: 1)]
      public UInt16? DCA { get; set; }
      /// [V]
      /// DC Voltage - 
      [SunSpecProperty(offset: 10, length: 1)]
      public UInt16? DCV { get; set; }
      /// [W]
      /// DC Power - 
      [SunSpecProperty(offset: 11, length: 1)]
      public UInt16? DCW { get; set; }
      /// [Wh]
      /// Lifetime Energy - 
      [SunSpecProperty(offset: 12, length: 1)]
      public UInt32? DCWH { get; set; }
      /// [Secs]
      /// Timestamp - 
      [SunSpecProperty(offset: 14, length: 1)]
      public UInt32? Tms { get; set; }
      /// [C]
      /// Temperature - 
      [SunSpecProperty(offset: 16, length: 1)]
      public Int16? Tmp { get; set; }
      public enum E_DCSt : UInt16
      {
        OFF = 1,
        SLEEPING = 2,
        STARTING = 3,
        MPPT = 4,
        THROTTLED = 5,
        SHUTTING_DOWN = 6,
        FAULT = 7,
        STANDBY = 8,
        TEST = 9,
        RESERVED_10 = 10,
      }
      /// Operating State - 
      [SunSpecProperty(offset: 17, length: 1)]
      public E_DCSt? DCSt { get; set; }
      [Flags]
      public enum E_DCEvt : UInt32
      {
        GROUND_FAULT = 0,
        INPUT_OVER_VOLTAGE = 1,
        RESERVED_2 = 2,
        DC_DISCONNECT = 3,
        RESERVED_4 = 4,
        CABINET_OPEN = 5,
        MANUAL_SHUTDOWN = 6,
        OVER_TEMP = 7,
        RESERVED_8 = 8,
        RESERVED_9 = 9,
        RESERVED_10 = 10,
        RESERVED_11 = 11,
        BLOWN_FUSE = 12,
        UNDER_TEMP = 13,
        MEMORY_LOSS = 14,
        ARC_DETECTION = 15,
        RESERVED_16 = 16,
        RESERVED_17 = 17,
        RESERVED_18 = 18,
        RESERVED_19 = 19,
        TEST_FAILED = 20,
        INPUT_UNDER_VOLTAGE = 21,
        INPUT_OVER_CURRENT = 22,
      }
      /// Module Events - 
      [SunSpecProperty(offset: 18, length: 1)]
      public E_DCEvt? DCEvt { get; set; }
    }[];
  }
}
