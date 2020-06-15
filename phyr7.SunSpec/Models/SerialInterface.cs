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
  /// Include this model for serial interface configuration support
  [SunSpecModel(id: 17, length: 12)]
  public struct SerialInterface
  {
    /// Name - Interface name (8 chars)
    /// Interface name (8 chars)
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
    public enum E_Typ : UInt16
    {
      UNKNOWN = 0,
      RS232 = 1,
      RS485 = 2,
    }
    /// Interface Type - Enumerated value.  Interface type
    /// Enumerated value.  Interface type
    [SunSpecProperty(offset: 10, length: 1)]
    public E_Typ? Typ { get; set; }
    public enum E_Pcol : UInt16
    {
      UNKNOWN = 0,
      MODBUS = 1,
      VENDOR = 2,
    }
    /// Protocol - Enumerated value. Serial protocol selection
    /// Enumerated value. Serial protocol selection
    [SunSpecProperty(offset: 11, length: 1)]
    public E_Pcol? Pcol { get; set; }
  }
}
