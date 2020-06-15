using System;

{
  /// Include to support a wired ethernet port
  [SunSpecModel(id: 11, length: 13)]
  public class EthernetLinkLayer
  {
    /// [Mbps]
    /// Ethernet Link Speed - Interface speed in Mb/s
    /// Interface speed in Mb/s
    [SunSpecProperty(offset: 0, length: 1)]
    public UInt16 Spd { get; set; }
    [Flags]
    public enum E_CfgSt : UInt16
    {
      LINK = 0,
      FULL_DUPLEX = 1,
      AUTO_NEG1 = 2,
      AUTO_NEG2 = 3,
      AUTO_NEG3 = 4,
      RESET_REQUIRED = 5,
      HW_FAULT = 6,
    }
    /// Interface Status Flags - Bitmask values Interface flags.
    /// Bitmask values Interface flags.
    [SunSpecProperty(offset: 1, length: 1)]
    public E_CfgSt CfgSt { get; set; }
    public enum E_St : UInt16
    {
      UNKNOWN = 0,
      ENABLED = 1,
      DISABLED = 2,
      TESTING = 3,
    }
    /// Link State - Enumerated value. State information for this interface
    /// Enumerated value. State information for this interface
    [SunSpecProperty(offset: 2, length: 1)]
    public E_St St { get; set; }
    /// MAC - IEEE MAC address of this interface
    /// IEEE MAC address of this interface
    [SunSpecProperty(offset: 3, length: 1)]
    public UInt64? MAC { get; set; }
    /// Name - Interface name (8 chars)
    /// Interface name (8 chars)
    [SunSpecProperty(offset: 7, length: 4)]
    public String? Nam { get; set; }
    [Flags]
    public enum E_Ctl : UInt16
    {
      AUTO = 0,
      FULL_DUPLEX = 1,
    }
    /// Control - Control flags
    /// Control flags
    [SunSpecProperty(offset: 11, length: 1)]
    public E_Ctl? Ctl { get; set; }
    /// [Mbps]
    /// Forced Speed - Forced interface speed in Mb/s when AUTO is disabled
    /// Forced interface speed in Mb/s when AUTO is disabled
    [SunSpecProperty(offset: 12, length: 1)]
    public UInt16? FrcSpd { get; set; }
  }
}
