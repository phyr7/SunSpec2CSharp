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
  /// Include to support orientation measurements
  [SunSpecModel(id: 304, length: 6)]
  public struct Inclinometer
  {
    public struct S_Incl
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
    };
    public S_Incl[] Incl;
  }
}
