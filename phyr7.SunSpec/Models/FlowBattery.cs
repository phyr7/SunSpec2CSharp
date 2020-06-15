using System;

{
  [SunSpecModel(id: 806, length: 2)]
  public class FlowBattery
  {
    /// Battery Points To Be Determined - 
    [SunSpecProperty(offset: 0, length: 1)]
    public UInt16 BatTBD { get; set; }
    public struct BatteryString
    {
      /// Battery String Points To Be Determined - 
      [SunSpecProperty(offset: 0, length: 1)]
      public UInt16 BatStTBD { get; set; }
    }[];
  }
}
