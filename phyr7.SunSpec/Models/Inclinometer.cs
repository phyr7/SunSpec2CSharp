namespace SunSpec
{
  /// Include to support orientation measurements
  [SunSpecModel(id: 304, length: 6)]
  public class Inclinometer
  {
    public struct Incl
    {
      /// [Degrees]
      /// X - X-Axis inclination
      /// X-Axis inclination
      [SunSpecProperty(offset: 0, length: 1)]
      public Int32 Inclx { get; set; }
      /// [Degrees]
      /// Y - Y-Axis inclination
      /// Y-Axis inclination
      [SunSpecProperty(offset: 2, length: 1)]
      public Int32? Incly { get; set; }
      /// [Degrees]
      /// Z - Z-Axis inclination
      /// Z-Axis inclination
      [SunSpecProperty(offset: 4, length: 1)]
      public Int32? Inclz { get; set; }
    }[];
  }
}
