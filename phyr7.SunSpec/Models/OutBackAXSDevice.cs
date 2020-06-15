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
  [SunSpecModel(id: 64110, length: 282)]
  public struct OutBackAXSDevice
  {
    /// AXS Major Firmware Number - 
    [SunSpecProperty(offset: 0, length: 1)]
    public UInt16 MajorFWRev { get; set; }
    /// AXS Mid Firmware Number - 
    [SunSpecProperty(offset: 1, length: 1)]
    public UInt16 MidFWRev { get; set; }
    /// AXS Minor Firmware Number - 
    [SunSpecProperty(offset: 2, length: 1)]
    public UInt16 MinorFWRev { get; set; }
    /// Encryption Key - 
    [SunSpecProperty(offset: 3, length: 1)]
    public UInt16 EncrypKey { get; set; }
    /// MAC Address - 
    [SunSpecProperty(offset: 4, length: 7)]
    public String MAC_Address { get; set; }
    /// Write Password - 
    [SunSpecProperty(offset: 11, length: 8)]
    public String WritePassword { get; set; }
    public enum E_EnableDHCP : UInt16
    {
    }
    /// Enable DHCP - 
    [SunSpecProperty(offset: 19, length: 1)]
    public E_EnableDHCP EnableDHCP { get; set; }
    /// TCPIP Address - 
    [SunSpecProperty(offset: 20, length: 1)]
    public UInt32 TCPIP_address { get; set; }
    /// TCPIP Gateway - 
    [SunSpecProperty(offset: 22, length: 1)]
    public UInt32 Gateway_address { get; set; }
    /// TCPIP Netmask - 
    [SunSpecProperty(offset: 24, length: 1)]
    public UInt32 TCPIP_Netmask { get; set; }
    /// TCPIP DNS1 - 
    [SunSpecProperty(offset: 26, length: 1)]
    public UInt32 DNS1_address { get; set; }
    /// TCPIP DNS2 - 
    [SunSpecProperty(offset: 28, length: 1)]
    public UInt32 DNS2_address { get; set; }
    /// ModBus Port - 
    [SunSpecProperty(offset: 30, length: 1)]
    public UInt16 Modbus_port { get; set; }
    /// SMTP Server Name - 
    [SunSpecProperty(offset: 31, length: 20)]
    public String SMTP_server_nm { get; set; }
    /// SMTP Account Name - 
    [SunSpecProperty(offset: 51, length: 16)]
    public String SMTP_account_nm { get; set; }
    public enum E_SMTP_enable_SSL : UInt16
    {
      ASX_DISABLED = 0,
      ASX_ENABLED = 1,
    }
    /// Enable SMTP SSL - 
    [SunSpecProperty(offset: 67, length: 1)]
    public E_SMTP_enable_SSL SMTP_enable_SSL { get; set; }
    /// SMTP Password - 
    [SunSpecProperty(offset: 68, length: 8)]
    public String SMTP_password { get; set; }
    /// SMTP User Name - 
    [SunSpecProperty(offset: 76, length: 20)]
    public String SMTP_user_nm { get; set; }
    /// Status Email Interval - 
    [SunSpecProperty(offset: 96, length: 1)]
    public UInt16 Stat_email_int { get; set; }
    /// Status Email Start Hour - 
    [SunSpecProperty(offset: 97, length: 1)]
    public UInt16 Stat_start_HR { get; set; }
    /// Status Email Subject - 
    [SunSpecProperty(offset: 98, length: 25)]
    public String Stat_email_sub { get; set; }
    /// Status Email to Address 1 - 
    [SunSpecProperty(offset: 123, length: 20)]
    public String Stat_email_addr1 { get; set; }
    /// Status Email to Address 2 - 
    [SunSpecProperty(offset: 143, length: 20)]
    public String Stat_email_addr2 { get; set; }
    public enum E_Alarm_email_en : UInt16
    {
      ASX_DISABLED = 0,
      ASX_ENABLED = 1,
    }
    /// Enable Alarm Email - 
    [SunSpecProperty(offset: 163, length: 1)]
    public E_Alarm_email_en Alarm_email_en { get; set; }
    /// Alarm Email Subject - 
    [SunSpecProperty(offset: 164, length: 25)]
    public String Alarm_email_sub { get; set; }
    /// Alarm Email to Address 1 - 
    [SunSpecProperty(offset: 189, length: 20)]
    public String Alarm_email_addr1 { get; set; }
    /// Alarm Email to Address 2 - 
    [SunSpecProperty(offset: 209, length: 20)]
    public String Alarm_email_addr2 { get; set; }
    /// FTP Password - 
    [SunSpecProperty(offset: 229, length: 8)]
    public String FTP_password { get; set; }
    /// Telnet Password - 
    [SunSpecProperty(offset: 237, length: 8)]
    public String TELNET_password { get; set; }
    /// [Tms]
    /// SD-Card Datalog Write Interval - 
    [SunSpecProperty(offset: 245, length: 1)]
    public UInt16 Log_write_int { get; set; }
    /// [Tmd]
    /// SD-Card Datalog Retain - 
    [SunSpecProperty(offset: 246, length: 1)]
    public UInt16 Log_retain { get; set; }
    public enum E_Log_mode : UInt16
    {
      LOG_DISABLED = 0,
      LOG_EXCEL = 1,
      LOG_COMPACT = 2,
    }
    /// SD-Card Datalog Mode - 
    [SunSpecProperty(offset: 247, length: 1)]
    public E_Log_mode Log_mode { get; set; }
    /// NTP Timer Server Name - 
    [SunSpecProperty(offset: 248, length: 20)]
    public String NTP_server_nm { get; set; }
    public enum E_NTP_enable : UInt16
    {
      ASX_DISABLED = 0,
      ASX_ENABLED = 1,
    }
    /// Enable Network Time - 
    [SunSpecProperty(offset: 268, length: 1)]
    public E_NTP_enable NTP_enable { get; set; }
    /// [Tmh]
    /// Time Zone - 
    [SunSpecProperty(offset: 269, length: 1)]
    public Int16 TimeZone { get; set; }
    /// Year - 
    [SunSpecProperty(offset: 270, length: 1)]
    public UInt16 Date_year { get; set; }
    /// Month - 
    [SunSpecProperty(offset: 271, length: 1)]
    public UInt16 Date_month { get; set; }
    /// Day - 
    [SunSpecProperty(offset: 272, length: 1)]
    public UInt16 Date_Day { get; set; }
    /// Hour - 
    [SunSpecProperty(offset: 273, length: 1)]
    public UInt16 Time_hour { get; set; }
    /// Minute - 
    [SunSpecProperty(offset: 274, length: 1)]
    public UInt16 Time_minute { get; set; }
    /// Second - 
    [SunSpecProperty(offset: 275, length: 1)]
    public UInt16 Time_second { get; set; }
    /// [C]
    /// Battery Temperature - 
    [SunSpecProperty(offset: 276, length: 1)]
    public Int16 Battery_temp { get; set; }
    /// [C]
    /// Ambient Temperature - 
    [SunSpecProperty(offset: 277, length: 1)]
    public Int16 Ambient_temp { get; set; }
    [SunSpecProperty(offset: 278, length: 1)]
    public Int16 Temp_SF { get; set; }
    [Flags]
    public enum E_AXS_Error : UInt16
    {
    }
    /// AXS Error - 
    [SunSpecProperty(offset: 279, length: 1)]
    public E_AXS_Error AXS_Error { get; set; }
    [Flags]
    public enum E_AXS_Status : UInt16
    {
    }
    /// AXS Status - 
    [SunSpecProperty(offset: 280, length: 1)]
    public E_AXS_Status AXS_Status { get; set; }
    /// Spare - 
    [SunSpecProperty(offset: 281, length: 1)]
    public UInt16 AXS_Spare { get; set; }
  }
}
