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
  /// Include to support various irradiance measurements
  [SunSpecModel(id: 302, length: 5)]
  public struct Irradiance
  {
    public struct S_Block1
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
    };
    public S_Block1[] Block1;
  }
}
