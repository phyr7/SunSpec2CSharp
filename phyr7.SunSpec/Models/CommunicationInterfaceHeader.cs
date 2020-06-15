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
  /// To be included first for a complete interface description
  [SunSpecModel(id: 10, length: 4)]
  public struct CommunicationInterfaceHeader
  {
    public enum E_St : UInt16
    {
      DOWN = 0,
      UP = 1,
      FAULT = 2,
    }
    /// Interface Status - Overall interface status
    /// Overall interface status
    [SunSpecProperty(offset: 0, length: 1)]
    public E_St St { get; set; }
    /// Interface Control - Overall interface control (TBD)
    /// Overall interface control (TBD)
    [SunSpecProperty(offset: 1, length: 1)]
    public UInt16? Ctl { get; set; }
    public enum E_Typ : UInt16
    {
      UNKNOWN = 0,
      INTERNAL = 1,
      TWISTED_PAIR = 2,
      FIBER = 3,
      WIRELESS = 4,
    }
    /// Physical Access Type - Enumerated value.  Type of physical media
    /// Enumerated value.  Type of physical media
    [SunSpecProperty(offset: 2, length: 1)]
    public E_Typ? Typ { get; set; }
    [SunSpecProperty(offset: 3, length: 1)]
    public UInt16? Pad { get; set; }
  }
}
