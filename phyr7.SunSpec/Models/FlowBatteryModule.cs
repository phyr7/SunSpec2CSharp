using System;

{
  [SunSpecModel(id: 808, length: 2)]
  public class FlowBatteryModule
  {
    /// Module Points To Be Determined - 
    [SunSpecProperty(offset: 0, length: 1)]
    public UInt16 ModuleTBD { get; set; }
    public struct Stack
    {
      /// Stack Points To Be Determined - 
      [SunSpecProperty(offset: 0, length: 1)]
      public UInt16 StackTBD { get; set; }
    }[];
  }
}
