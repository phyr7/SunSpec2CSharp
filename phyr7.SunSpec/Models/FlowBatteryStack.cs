using System;

{
  [SunSpecModel(id: 809, length: 2)]
  public class FlowBatteryStack
  {
    /// Stack Points To Be Determined - 
    [SunSpecProperty(offset: 0, length: 1)]
    public UInt16 StackTBD { get; set; }
    public struct Cell
    {
      /// Cell Points To Be Determined - 
      [SunSpecProperty(offset: 0, length: 1)]
      public UInt16 CellTBD { get; set; }
    }[];
  }
}
