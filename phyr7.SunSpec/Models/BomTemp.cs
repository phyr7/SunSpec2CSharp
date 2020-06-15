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
  /// Include to support variable number of  back of module temperature measurements
  [SunSpecModel(id: 303, length: 1)]
  public struct BomTemp
  {
    public struct S_Temp
    {
      /// [C]
      /// Temp - Back of module temperature measurement
      /// Back of module temperature measurement
      [SunSpecProperty(offset: 0, length: 1)]
      public Int16 TmpBOM { get; set; }
    };
    public S_Temp[] Temp;
  }
}
