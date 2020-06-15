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
  [SunSpecModel(id: 64001, length: 71)]
  public struct VerisStatusAndConfiguration
  {
    public enum E_Cmd : UInt16
    {
    }
    /// Command Code - 
    [SunSpecProperty(offset: 0, length: 1)]
    public E_Cmd? Cmd { get; set; }
    /// Hardware Revision - 
    [SunSpecProperty(offset: 1, length: 1)]
    public UInt16? HWRev { get; set; }
    /// RS FW Revision - 
    [SunSpecProperty(offset: 2, length: 1)]
    public UInt16? RSFWRev { get; set; }
    /// OS FW Revision - 
    [SunSpecProperty(offset: 3, length: 1)]
    public UInt16? OSFWRev { get; set; }
    /// Product Revision - 
    [SunSpecProperty(offset: 4, length: 2)]
    public String? ProdRev { get; set; }
    /// Boot Count - 
    [SunSpecProperty(offset: 6, length: 1)]
    public UInt16? Boots { get; set; }
    [Flags]
    public enum E_Switch : UInt16
    {
    }
    /// DIP Switches - 
    [SunSpecProperty(offset: 7, length: 1)]
    public E_Switch? Switch { get; set; }
    /// Num Detected Sensors - 
    [SunSpecProperty(offset: 8, length: 1)]
    public UInt16? Sensors { get; set; }
    /// Num Communicating Sensors - 
    [SunSpecProperty(offset: 9, length: 1)]
    public UInt16? Talking { get; set; }
    [Flags]
    public enum E_Status : UInt16
    {
    }
    /// System Status - 
    [SunSpecProperty(offset: 10, length: 1)]
    public E_Status? Status { get; set; }
    [Flags]
    public enum E_Config : UInt16
    {
    }
    /// System Configuration - 
    [SunSpecProperty(offset: 11, length: 1)]
    public E_Config? Config { get; set; }
    /// [Pct]
    /// LED Blink Threshold - 
    [SunSpecProperty(offset: 12, length: 1)]
    public UInt16? LEDblink { get; set; }
    /// [Pct]
    /// LED On Threshold - 
    [SunSpecProperty(offset: 13, length: 1)]
    public UInt16? LEDon { get; set; }
    [SunSpecProperty(offset: 14, length: 1)]
    public UInt16? Reserved { get; set; }
    /// Location String - 
    [SunSpecProperty(offset: 15, length: 16)]
    public String? Loc { get; set; }
    public enum E_S1ID : UInt16
    {
    }
    /// Sensor 1 Unit ID - 
    [SunSpecProperty(offset: 31, length: 1)]
    public E_S1ID? S1ID { get; set; }
    /// Sensor 1 Address - 
    [SunSpecProperty(offset: 32, length: 1)]
    public UInt16? S1Addr { get; set; }
    /// Sensor 1 OS Version - 
    [SunSpecProperty(offset: 33, length: 1)]
    public UInt16? S1OSVer { get; set; }
    /// Sensor 1 Product Version - 
    [SunSpecProperty(offset: 34, length: 2)]
    public String? S1Ver { get; set; }
    /// Sensor 1 Serial Num - 
    [SunSpecProperty(offset: 36, length: 5)]
    public String? S1Serial { get; set; }
    public enum E_S2ID : UInt16
    {
    }
    /// Sensor 2 Unit ID - 
    [SunSpecProperty(offset: 41, length: 1)]
    public E_S2ID? S2ID { get; set; }
    /// Sensor 2 Address - 
    [SunSpecProperty(offset: 42, length: 1)]
    public UInt16? S2Addr { get; set; }
    /// Sensor 2 OS Version - 
    [SunSpecProperty(offset: 43, length: 1)]
    public UInt16? S2OSVer { get; set; }
    /// Sensor 2 Product Version - 
    [SunSpecProperty(offset: 44, length: 2)]
    public String? S2Ver { get; set; }
    /// Sensor 2 Serial Num - 
    [SunSpecProperty(offset: 46, length: 5)]
    public String? S2Serial { get; set; }
    public enum E_S3ID : UInt16
    {
    }
    /// Sensor 3 Unit ID - 
    [SunSpecProperty(offset: 51, length: 1)]
    public E_S3ID? S3ID { get; set; }
    /// Sensor 3 Address - 
    [SunSpecProperty(offset: 52, length: 1)]
    public UInt16? S3Addr { get; set; }
    /// Sensor 3 OS Version - 
    [SunSpecProperty(offset: 53, length: 1)]
    public UInt16? S3OSVer { get; set; }
    /// Sensor 3 Product Version - 
    [SunSpecProperty(offset: 54, length: 2)]
    public String? S3Ver { get; set; }
    /// Sensor 3 Serial Num - 
    [SunSpecProperty(offset: 56, length: 5)]
    public String? S3Serial { get; set; }
    public enum E_S4ID : UInt16
    {
    }
    /// Sensor 4 Unit ID - 
    [SunSpecProperty(offset: 61, length: 1)]
    public E_S4ID? S4ID { get; set; }
    /// Sensor 4 Address - 
    [SunSpecProperty(offset: 62, length: 1)]
    public UInt16? S4Addr { get; set; }
    /// Sensor 4 OS Version - 
    [SunSpecProperty(offset: 63, length: 1)]
    public UInt16? S4OSVer { get; set; }
    /// Sensor 4 Product Version - 
    [SunSpecProperty(offset: 64, length: 2)]
    public String? S4Ver { get; set; }
    /// Sensor 4 Serial Num - 
    [SunSpecProperty(offset: 66, length: 5)]
    public String? S4Serial { get; set; }
  }
}
