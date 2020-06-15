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
  [SunSpecModel(id: 809, length: 2)]
  public struct FlowBatteryStack
  {
    /// Stack Points To Be Determined - 
    [SunSpecProperty(offset: 0, length: 1)]
    public UInt16 StackTBD { get; set; }
    public struct S_Cell
    {
      /// Cell Points To Be Determined - 
      [SunSpecProperty(offset: 0, length: 1)]
      public UInt16 CellTBD { get; set; }
    };
    public S_Cell[] Cell;
  }
}
