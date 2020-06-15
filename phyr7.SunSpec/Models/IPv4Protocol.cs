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
  /// Include to support an IPv4 protocol stack on this interface
  [SunSpecModel(id: 12, length: 98)]
  public struct IPv4Protocol
  {
    /// Name - Interface name
    /// Interface name
    [SunSpecProperty(offset: 0, length: 4)]
    public String? Nam { get; set; }
    public enum E_CfgSt : UInt16
    {
      NOT_CONFIGURED = 0,
      VALID_SETTING = 1,
      VALID_HW = 2,
    }
    /// Config Status - Enumerated value.  Configuration status
    /// Enumerated value.  Configuration status
    [SunSpecProperty(offset: 4, length: 1)]
    public E_CfgSt CfgSt { get; set; }
    [Flags]
    public enum E_ChgSt : UInt16
    {
      PENDING = 0,
    }
    /// Change Status - Bitmask value.  A configuration change is pending
    /// Bitmask value.  A configuration change is pending
    [SunSpecProperty(offset: 5, length: 1)]
    public E_ChgSt ChgSt { get; set; }
    [Flags]
    public enum E_Cap : UInt16
    {
      DHCP = 0,
      BOOTP = 1,
      ZEROCONF = 2,
      DNS = 3,
      CFG_SETTABLE = 4,
      HW_CONFIG = 5,
      NTP_CLIENT = 6,
      RESET_REQUIRED = 7,
    }
    /// Config Capability - Bitmask value. Identify capable sources of configuration
    /// Bitmask value. Identify capable sources of configuration
    [SunSpecProperty(offset: 6, length: 1)]
    public E_Cap Cap { get; set; }
    public enum E_Cfg : UInt16
    {
      STATIC = 0,
      DHCP = 1,
      BOOTP = 2,
      ZEROCONF = 3,
    }
    /// IPv4 Config - Enumerated value.  Configuration method used.
    /// Enumerated value.  Configuration method used.
    [SunSpecProperty(offset: 7, length: 1)]
    public E_Cfg Cfg { get; set; }
    public enum E_Ctl : UInt16
    {
      ENABLE_DNS = 0,
      ENABLE_NTP = 1,
    }
    /// Control - Configure use of services
    /// Configure use of services
    [SunSpecProperty(offset: 8, length: 1)]
    public E_Ctl Ctl { get; set; }
    /// IP - IPv4 numeric address as a dotted string xxx.xxx.xxx.xxx
    /// IPv4 numeric address as a dotted string xxx.xxx.xxx.xxx
    [SunSpecProperty(offset: 9, length: 8)]
    public String Addr { get; set; }
    /// Netmask - IPv4 numeric netmask as a dotted string xxx.xxx.xxx.xxx
    /// IPv4 numeric netmask as a dotted string xxx.xxx.xxx.xxx
    [SunSpecProperty(offset: 17, length: 8)]
    public String Msk { get; set; }
    /// Gateway - IPv4 numeric gateway address as a dotted string xxx.xxx.xxx.xxx
    /// IPv4 numeric gateway address as a dotted string xxx.xxx.xxx.xxx
    [SunSpecProperty(offset: 25, length: 8)]
    public String? Gw { get; set; }
    /// DNS1 - IPv4 numeric DNS address as a dotted string xxx.xxx.xxx.xxx
    /// IPv4 numeric DNS address as a dotted string xxx.xxx.xxx.xxx
    [SunSpecProperty(offset: 33, length: 8)]
    public String? DNS1 { get; set; }
    /// DNS2 - IPv4 numeric DNS address as a dotted string xxx.xxx.xxx.xxx
    /// IPv4 numeric DNS address as a dotted string xxx.xxx.xxx.xxx
    [SunSpecProperty(offset: 41, length: 8)]
    public String? DNS2 { get; set; }
    /// NTP1 - IPv4 numeric NTP address as a dotted string xxx.xxx.xxx.xxx
    /// IPv4 numeric NTP address as a dotted string xxx.xxx.xxx.xxx
    [SunSpecProperty(offset: 49, length: 12)]
    public String? NTP1 { get; set; }
    /// NTP2 - IPv4 numeric NTP address as a dotted string xxx.xxx.xxx.xxx
    /// IPv4 numeric NTP address as a dotted string xxx.xxx.xxx.xxx
    [SunSpecProperty(offset: 61, length: 12)]
    public String? NTP2 { get; set; }
    /// Domain - Domain name (24 chars max)
    /// Domain name (24 chars max)
    [SunSpecProperty(offset: 73, length: 12)]
    public String? DomNam { get; set; }
    /// Host Name - Host name (24 chars max)
    /// Host name (24 chars max)
    [SunSpecProperty(offset: 85, length: 12)]
    public String? HostNam { get; set; }
    [SunSpecProperty(offset: 97, length: 1)]
    public UInt16? Pad { get; set; }
  }
}
