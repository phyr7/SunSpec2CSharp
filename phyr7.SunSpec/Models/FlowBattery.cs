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
  [SunSpecModel(id: 806, length: 2)]
  public struct FlowBattery
  {
    /// Battery Points To Be Determined - 
    [SunSpecProperty(offset: 0, length: 1)]
    public UInt16 BatTBD { get; set; }
    public struct S_BatteryString
    {
      /// Battery String Points To Be Determined - 
      [SunSpecProperty(offset: 0, length: 1)]
      public UInt16 BatStTBD { get; set; }
    };
    public S_BatteryString[] BatteryString;
  }
}
