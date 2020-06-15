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
  /// Include this model to configure a Point-to-Point Protocol link
  [SunSpecModel(id: 19, length: 30)]
  public struct PPPLink
  {
    /// Name - Interface name
    /// Interface name
    [SunSpecProperty(offset: 0, length: 4)]
    public String? Nam { get; set; }
    /// [bps]
    /// Rate - Interface baud rate in bits per second
    /// Interface baud rate in bits per second
    [SunSpecProperty(offset: 4, length: 1)]
    public UInt32 Rte { get; set; }
    /// Bits - Number of data bits per character
    /// Number of data bits per character
    [SunSpecProperty(offset: 6, length: 1)]
    public UInt16 Bits { get; set; }
    public enum E_Pty : UInt16
    {
      NONE = 0,
      ODD = 1,
      EVEN = 2,
    }
    /// Parity - Bitmask value.  Parity setting
    /// Bitmask value.  Parity setting
    [SunSpecProperty(offset: 7, length: 1)]
    public E_Pty Pty { get; set; }
    public enum E_Dup : UInt16
    {
      FULL = 0,
      HALF = 1,
    }
    /// Duplex - Enumerated value.  Duplex mode
    /// Enumerated value.  Duplex mode
    [SunSpecProperty(offset: 8, length: 1)]
    public E_Dup? Dup { get; set; }
    public enum E_Flw : UInt16
    {
      NONE = 0,
      HW = 1,
      XONXOFF = 2,
    }
    /// Flow Control - Flow Control Method
    /// Flow Control Method
    [SunSpecProperty(offset: 9, length: 1)]
    public E_Flw? Flw { get; set; }
    public enum E_Auth : UInt16
    {
      NONE = 0,
      PAP = 1,
      CHAP = 2,
    }
    /// Authentication - Enumerated value.  Authentication method
    /// Enumerated value.  Authentication method
    [SunSpecProperty(offset: 10, length: 1)]
    public E_Auth? Auth { get; set; }
    /// Username - Username for authentication
    /// Username for authentication
    [SunSpecProperty(offset: 11, length: 12)]
    public String? UsrNam { get; set; }
    /// Password - Password for authentication
    /// Password for authentication
    [SunSpecProperty(offset: 23, length: 6)]
    public String? Pw { get; set; }
    [SunSpecProperty(offset: 29, length: 1)]
    public UInt16? Pad { get; set; }
  }
}
