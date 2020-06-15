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
  /// Include this model for a simple IPv4 network stack
  [SunSpecModel(id: 16, length: 52)]
  public struct SimpleIPNetwork
  {
    /// Name - Interface name.  (8 chars)
    /// Interface name.  (8 chars)
    [SunSpecProperty(offset: 0, length: 4)]
    public String? Nam { get; set; }
    public enum E_Cfg : UInt16
    {
      STATIC = 0,
      DHCP = 1,
    }
    /// Config - Enumerated value.  Force IPv4 configuration method
    /// Enumerated value.  Force IPv4 configuration method
    [SunSpecProperty(offset: 4, length: 1)]
    public E_Cfg Cfg { get; set; }
    public enum E_Ctl : UInt16
    {
      ENABLE_DNS = 0,
      ENABLE_NTP = 1,
    }
    /// Control - Bitmask value Configure use of services
    /// Bitmask value Configure use of services
    [SunSpecProperty(offset: 5, length: 1)]
    public E_Ctl Ctl { get; set; }
    /// Address - IP address
    /// IP address
    [SunSpecProperty(offset: 6, length: 8)]
    public String Addr { get; set; }
    /// Netmask - Netmask
    /// Netmask
    [SunSpecProperty(offset: 14, length: 8)]
    public String Msk { get; set; }
    /// Gateway - Gateway IP address
    /// Gateway IP address
    [SunSpecProperty(offset: 22, length: 8)]
    public String? Gw { get; set; }
    /// DNS1 - 32 bit IP address of DNS server
    /// 32 bit IP address of DNS server
    [SunSpecProperty(offset: 30, length: 8)]
    public String? DNS1 { get; set; }
    /// DNS2 - 32 bit IP address of DNS server
    /// 32 bit IP address of DNS server
    [SunSpecProperty(offset: 38, length: 8)]
    public String? DNS2 { get; set; }
    /// MAC - IEEE MAC address of this interface
    /// IEEE MAC address of this interface
    [SunSpecProperty(offset: 46, length: 1)]
    public UInt64? MAC { get; private set; }
    [Flags]
    public enum E_LnkCtl : UInt16
    {
      AUTONEGOTIATE = 0,
      FULL_DUPLEX = 1,
      FORCE_10MB = 2,
      FORCE_100MB = 3,
      FORCE_1GB = 4,
    }
    /// Link Control - Bitmask value.  Link control flags
    /// Bitmask value.  Link control flags
    [SunSpecProperty(offset: 50, length: 1)]
    public E_LnkCtl? LnkCtl { get; set; }
    [SunSpecProperty(offset: 51, length: 1)]
    public UInt16? Pad { get; set; }
  }
}
