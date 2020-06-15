using System;

{
  /// Include to support variable number of  back of module temperature measurements
  [SunSpecModel(id: 303, length: 1)]
  public class BomTemp
  {
    public struct Temp
    {
      /// [C]
      /// Temp - Back of module temperature measurement
      /// Back of module temperature measurement
      [SunSpecProperty(offset: 0, length: 1)]
      public Int16 TmpBOM { get; set; }
    }[];
  }
}
