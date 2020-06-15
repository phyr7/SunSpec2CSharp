using System;

{
  /// Include to support a few basic measurements
  [SunSpecModel(id: 308, length: 4)]
  public class MiniMet
  {
    /// [W/m2]
    /// GHI - Global Horizontal Irradiance
    /// Global Horizontal Irradiance
    [SunSpecProperty(offset: 0, length: 1)]
    public UInt16? GHI { get; set; }
    /// [C]
    /// Temp - Back of module temperature measurement
    /// Back of module temperature measurement
    [SunSpecProperty(offset: 1, length: 1)]
    public Int16? TmpBOM { get; set; }
    /// [C]
    /// Ambient Temperature - 
    [SunSpecProperty(offset: 2, length: 1)]
    public Int16? TmpAmb { get; set; }
    /// [m/s]
    /// Wind Speed - 
    [SunSpecProperty(offset: 3, length: 1)]
    public UInt16? WndSpd { get; set; }
  }
}
