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
  [SunSpecModel(id: 64111, length: 23)]
  public struct ChargeController
  {
    /// Port Number - 
    [SunSpecProperty(offset: 0, length: 1)]
    public UInt16 Port { get; set; }
    [SunSpecProperty(offset: 1, length: 1)]
    public Int16 V_SF { get; set; }
    [SunSpecProperty(offset: 2, length: 1)]
    public Int16 A_SF { get; set; }
    [SunSpecProperty(offset: 3, length: 1)]
    public Int16 P_SF { get; set; }
    [SunSpecProperty(offset: 4, length: 1)]
    public Int16 AH_SF { get; set; }
    [SunSpecProperty(offset: 5, length: 1)]
    public Int16 KWH_SF { get; set; }
    /// [V]
    /// Battery Voltage - 
    [SunSpecProperty(offset: 6, length: 1)]
    public UInt16 BattV { get; set; }
    /// [V]
    /// Array Voltage - 
    [SunSpecProperty(offset: 7, length: 1)]
    public UInt16 ArrayV { get; set; }
    /// [A]
    /// Output Current - 
    [SunSpecProperty(offset: 8, length: 1)]
    public UInt16 OutputA { get; set; }
    /// [A]
    /// Array Current - 
    [SunSpecProperty(offset: 9, length: 1)]
    public UInt16 InputA { get; set; }
    public enum E_ChargerSt : UInt16
    {
      Off = 0,
      Float = 1,
      Bulk = 2,
      Absorb = 3,
      EQ = 4,
    }
    /// Operating State - 
    [SunSpecProperty(offset: 10, length: 1)]
    public E_ChargerSt ChargerSt { get; set; }
    /// [W]
    /// Output Wattage - 
    [SunSpecProperty(offset: 11, length: 1)]
    public UInt16 OutputW { get; set; }
    /// [V]
    /// Today's Minimum Battery Voltage - 
    [SunSpecProperty(offset: 12, length: 1)]
    public UInt16 TodayMinBatV { get; set; }
    /// [V]
    /// Today's Maximum Battery Voltage - 
    [SunSpecProperty(offset: 13, length: 1)]
    public UInt16 TodayMaxBatV { get; set; }
    /// [V]
    /// VOC - 
    [SunSpecProperty(offset: 14, length: 1)]
    public UInt16 VOCV { get; set; }
    /// [V]
    /// Today's Maximum VOC - 
    [SunSpecProperty(offset: 15, length: 1)]
    public UInt16 TodayMaxVOC { get; set; }
    /// [kWh]
    /// Today's kWh - 
    [SunSpecProperty(offset: 16, length: 1)]
    public UInt16 TodaykWhOutput { get; set; }
    /// [AH]
    /// Today's AH - 
    [SunSpecProperty(offset: 17, length: 1)]
    public UInt16 TodayAHOutput { get; set; }
    /// [kWh]
    /// Lifetime kWh - 
    [SunSpecProperty(offset: 18, length: 1)]
    public UInt16 LifeTimeKWHOut { get; set; }
    /// [kAH]
    /// Lifetime kAH - 
    [SunSpecProperty(offset: 19, length: 1)]
    public UInt16 LifeTimeAHOut { get; set; }
    /// [W]
    /// Lifetime Maximum Output Wattage - 
    [SunSpecProperty(offset: 20, length: 1)]
    public UInt16 LifeTimeMaxOut { get; set; }
    /// [V]
    /// Lifetime Maximum Battery Voltage - 
    [SunSpecProperty(offset: 21, length: 1)]
    public UInt16 LifeTimeMaxBatt { get; set; }
    /// [V]
    /// Lifetime Maximum VOC Voltage - 
    [SunSpecProperty(offset: 22, length: 1)]
    public UInt16 LifeTimeMaxVOC { get; set; }
  }
}
