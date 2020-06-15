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
  /// Include this block to allow for a proxy server
  [SunSpecModel(id: 14, length: 52)]
  public struct ProxyServer
  {
    /// name - Interface name (8 chars)
    /// Interface name (8 chars)
    [SunSpecProperty(offset: 0, length: 4)]
    public String? Nam { get; set; }
    [Flags]
    public enum E_Cap : UInt16
    {
      NO_PROXY = 0,
      IPV4_PROXY = 1,
      IPV6_PROXY = 2,
    }
    /// Capabilities - Bitmask value.  Proxy configuration capabilities
    /// Bitmask value.  Proxy configuration capabilities
    [SunSpecProperty(offset: 4, length: 1)]
    public E_Cap Cap { get; set; }
    public enum E_Cfg : UInt16
    {
    }
    /// Config - Enumerated value.  Set proxy address type
    /// Enumerated value.  Set proxy address type
    [SunSpecProperty(offset: 5, length: 1)]
    public E_Cfg Cfg { get; set; }
    [Flags]
    public enum E_Typ : UInt16
    {
    }
    /// Type - Enumerate value.  Proxy server type
    /// Enumerate value.  Proxy server type
    [SunSpecProperty(offset: 6, length: 1)]
    public E_Typ Typ { get; set; }
    /// Address - IPv4 or IPv6 proxy hostname or dotted address (40 chars)
    /// IPv4 or IPv6 proxy hostname or dotted address (40 chars)
    [SunSpecProperty(offset: 7, length: 20)]
    public String Addr { get; set; }
    /// Port - Proxy port number
    /// Proxy port number
    [SunSpecProperty(offset: 27, length: 1)]
    public UInt16 Port { get; set; }
    /// Username - Proxy user name
    /// Proxy user name
    [SunSpecProperty(offset: 28, length: 12)]
    public String? User { get; set; }
    /// Password - Proxy password
    /// Proxy password
    [SunSpecProperty(offset: 40, length: 12)]
    public String? Pw { get; set; }
  }
}
