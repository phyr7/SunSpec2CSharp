using System;

{
  /// Include to support various irradiance measurements
  [SunSpecModel(id: 302, length: 5)]
  public class Irradiance
  {
    public struct 
    {
      /// [W/m2]
      /// GHI - Global Horizontal Irradiance
      /// Global Horizontal Irradiance
      [SunSpecProperty(offset: 0, length: 1)]
      public UInt16? GHI { get; set; }
      /// [W/m2]
      /// POAI - Plane-of-Array Irradiance
      /// Plane-of-Array Irradiance
      [SunSpecProperty(offset: 1, length: 1)]
      public UInt16? POAI { get; set; }
      /// [W/m2]
      /// DFI - Diffuse Irradiance
      /// Diffuse Irradiance
      [SunSpecProperty(offset: 2, length: 1)]
      public UInt16? DFI { get; set; }
      /// [W/m2]
      /// DNI - Direct Normal Irradiance
      /// Direct Normal Irradiance
      [SunSpecProperty(offset: 3, length: 1)]
      public UInt16? DNI { get; set; }
      /// [W/m2]
      /// OTI - Other Irradiance
      /// Other Irradiance
      [SunSpecProperty(offset: 4, length: 1)]
      public UInt16? OTI { get; set; }
    }[];
  }
}
