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
  /// Include to support an IPv6 protocol stack on this interface
  [SunSpecModel(id: 13, length: 174)]
  public struct IPv6Protocol
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
    /// IPv6 Config - Enumerated value.  Configuration method used.
    /// Enumerated value.  Configuration method used.
    [SunSpecProperty(offset: 7, length: 1)]
    public E_Cfg Cfg { get; set; }
    public enum E_Ctl : UInt16
    {
      ENABLE_DNS = 0,
      ENABLE_NTP = 1,
    }
    /// Control - Bitmask value.  Configure use of services
    /// Bitmask value.  Configure use of services
    [SunSpecProperty(offset: 8, length: 1)]
    public E_Ctl Ctl { get; set; }
    /// IP - IPv6 numeric address as a dotted string xxxx.xxxx.xxxx.xxxx
    /// IPv6 numeric address as a dotted string xxxx.xxxx.xxxx.xxxx
    [SunSpecProperty(offset: 9, length: 20)]
    public String Addr { get; set; }
    /// CIDR - Classless Inter-Domain Routing Number
    /// Classless Inter-Domain Routing Number
    [SunSpecProperty(offset: 29, length: 20)]
    public String? CIDR { get; set; }
    /// Gateway - IPv6 numeric address as a dotted string xxxx.xxxx.xxxx.xxxx
    /// IPv6 numeric address as a dotted string xxxx.xxxx.xxxx.xxxx
    [SunSpecProperty(offset: 49, length: 20)]
    public String? Gw { get; set; }
    /// DNS1 - IPv6 numeric DNS address as a dotted string xxxx.xxxx.xxxx.xxxx
    /// IPv6 numeric DNS address as a dotted string xxxx.xxxx.xxxx.xxxx
    [SunSpecProperty(offset: 69, length: 20)]
    public String? DNS1 { get; set; }
    /// DNS2 - IPv6 numeric DNS address as a dotted string xxxx.xxxx.xxxx.xxxx
    /// IPv6 numeric DNS address as a dotted string xxxx.xxxx.xxxx.xxxx
    [SunSpecProperty(offset: 89, length: 20)]
    public String? DNS2 { get; set; }
    /// NTP1 - IPv6 numeric NTP address as a name or dotted string xxxx.xxxx.xxxx.xxxx
    /// IPv6 numeric NTP address as a name or dotted string xxxx.xxxx.xxxx.xxxx
    [SunSpecProperty(offset: 109, length: 20)]
    public String? NTP1 { get; set; }
    /// NTP2 - IPv6 numeric NTP address as a name or dotted string xxxx.xxxx.xxxx.xxxx
    /// IPv6 numeric NTP address as a name or dotted string xxxx.xxxx.xxxx.xxxx
    [SunSpecProperty(offset: 129, length: 20)]
    public String? NTP2 { get; set; }
    /// Domain - Domain name (24 chars max)
    /// Domain name (24 chars max)
    [SunSpecProperty(offset: 149, length: 12)]
    public String? DomNam { get; set; }
    /// Host Name - Host name (24 chars max)
    /// Host name (24 chars max)
    [SunSpecProperty(offset: 161, length: 12)]
    public String? HostNam { get; set; }
    [SunSpecProperty(offset: 173, length: 1)]
    public UInt16? Pad { get; set; }
  }
}
