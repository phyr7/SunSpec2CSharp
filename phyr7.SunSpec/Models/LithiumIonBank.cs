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
  [SunSpecModel(id: 803, length: 58)]
  public struct LithiumIonBank
  {
    /// String Count - Number of strings in the bank.
    /// Number of strings in the bank.
    [SunSpecProperty(offset: 0, length: 1)]
    public UInt16 NStr { get; set; }
    /// Connected String Count - Number of strings with contactor closed.
    /// Number of strings with contactor closed.
    [SunSpecProperty(offset: 1, length: 1)]
    public UInt16 NStrCon { get; set; }
    /// Max Module Temperature - Maximum temperature for all modules in the bank.
    /// Maximum temperature for all modules in the bank.
    /// NOTES: Measurement.
    [SunSpecProperty(offset: 2, length: 1)]
    public Int16 ModTmpMax { get; set; }
    /// Max Module Temperature String - String containing the module with maximum temperature.
    /// String containing the module with maximum temperature.
    [SunSpecProperty(offset: 3, length: 1)]
    public UInt16? ModTmpMaxStr { get; set; }
    /// Max Module Temperature Module - Module with maximum temperature.
    /// Module with maximum temperature.
    [SunSpecProperty(offset: 4, length: 1)]
    public UInt16? ModTmpMaxMod { get; set; }
    /// [C]
    /// Min Module Temperature - Minimum temperature for all modules in the bank.
    /// Minimum temperature for all modules in the bank.
    /// NOTES: Measurement.
    [SunSpecProperty(offset: 5, length: 1)]
    public Int16 ModTmpMin { get; set; }
    /// Min Module Temperature String - String containing the module with minimum temperature.
    /// String containing the module with minimum temperature.
    [SunSpecProperty(offset: 6, length: 1)]
    public UInt16? ModTmpMinStr { get; set; }
    /// Min Module Temperature Module - Module with minimum temperature.
    /// Module with minimum temperature.
    [SunSpecProperty(offset: 7, length: 1)]
    public UInt16? ModTmpMinMod { get; set; }
    /// Average Module Temperature - Average temperature for all modules in the bank.
    /// Average temperature for all modules in the bank.
    /// NOTES: Calculation based on measurements.
    [SunSpecProperty(offset: 8, length: 1)]
    public UInt16? ModTmpAvg { get; set; }
    /// [V]
    /// Max String Voltage - Maximum string voltage for all strings in the bank.
    /// Maximum string voltage for all strings in the bank.
    /// NOTES: Measurement.
    [SunSpecProperty(offset: 9, length: 1)]
    public UInt16? StrVMax { get; set; }
    /// Max String Voltage String - String with maximum voltage.
    /// String with maximum voltage.
    [SunSpecProperty(offset: 10, length: 1)]
    public UInt16? StrVMaxStr { get; set; }
    /// [V]
    /// Min String Voltage - Minimum string voltage for all strings in the bank.
    /// Minimum string voltage for all strings in the bank.
    /// NOTES: Measurement.
    [SunSpecProperty(offset: 11, length: 1)]
    public UInt16? StrVMin { get; set; }
    /// Min String Voltage String - String with minimum voltage.
    /// String with minimum voltage.
    [SunSpecProperty(offset: 12, length: 1)]
    public UInt16? StrVMinStr { get; set; }
    /// [V]
    /// Average String Voltage - Average string voltage for all strings in the bank.
    /// Average string voltage for all strings in the bank.
    /// NOTES: Calculation based on measurements.
    [SunSpecProperty(offset: 13, length: 1)]
    public UInt16? StrVAvg { get; set; }
    /// [A]
    /// Max String Current - Maximum current of any string in the bank.
    /// Maximum current of any string in the bank.
    /// NOTES: Measurement.
    [SunSpecProperty(offset: 14, length: 1)]
    public Int16? StrAMax { get; set; }
    /// Max String Current String - String with the maximum current.
    /// String with the maximum current.
    [SunSpecProperty(offset: 15, length: 1)]
    public UInt16? StrAMaxStr { get; set; }
    /// [A]
    /// Min String Current - Minimum current of any string in the bank.
    /// Minimum current of any string in the bank.
    /// NOTES: Measurement.
    [SunSpecProperty(offset: 16, length: 1)]
    public Int16? StrAMin { get; set; }
    /// Min String Current String - String with the minimum current.
    /// String with the minimum current.
    [SunSpecProperty(offset: 17, length: 1)]
    public UInt16? StrAMinStr { get; set; }
    /// [A]
    /// Average String Current - Average string current for all strings in the bank.
    /// Average string current for all strings in the bank.
    /// NOTES: Calculation based on measurements.
    [SunSpecProperty(offset: 18, length: 1)]
    public Int16? StrAAvg { get; set; }
    /// Battery Cell Balancing Count - Total number of cells that are currently being balanced.
    /// Total number of cells that are currently being balanced.
    [SunSpecProperty(offset: 19, length: 1)]
    public UInt16? NCellBal { get; set; }
    /// Scale factor for cell voltage.
    [SunSpecProperty(offset: 20, length: 1)]
    public Int16 CellV_SF { get; set; }
    /// Scale factor for module temperatures.
    [SunSpecProperty(offset: 21, length: 1)]
    public Int16 ModTmp_SF { get; set; }
    /// Scale factor for string currents.
    [SunSpecProperty(offset: 22, length: 1)]
    public Int16 A_SF { get; set; }
    /// Scale factor for string state of health.
    [SunSpecProperty(offset: 23, length: 1)]
    public Int16? SoH_SF { get; set; }
    /// Scale factor for string state of charge.
    [SunSpecProperty(offset: 24, length: 1)]
    public Int16 SoC_SF { get; set; }
    /// Scale factor for string voltage.
    [SunSpecProperty(offset: 25, length: 1)]
    public Int16? V_SF { get; set; }
    public struct S_String
    {
      /// Module Count - Count of modules in the string.
      /// Count of modules in the string.
      [SunSpecProperty(offset: 0, length: 1)]
      public UInt16 StrNMod { get; set; }
      [Flags]
      public enum E_StrSt : UInt32
      {
        STRING_ENABLED = 0,
        CONTACTOR_STATUS = 1,
      }
      /// String Status - Current status of the string.
      /// Current status of the string.
      [SunSpecProperty(offset: 1, length: 1)]
      public E_StrSt StrSt { get; set; }
      public enum E_StrConFail : UInt16
      {
        NO_FAILURE = 0,
        BUTTON_PUSHED = 1,
        STR_GROUND_FAULT = 2,
        OUTSIDE_VOLTAGE_RANGE = 3,
        STRING_NOT_ENABLED = 4,
        FUSE_OPEN = 5,
        CONTACTOR_FAILURE = 6,
        PRECHARGE_FAILURE = 7,
        STRING_FAULT = 8,
      }
      /// Connection Failure Reason - 
      [SunSpecProperty(offset: 3, length: 1)]
      public E_StrConFail? StrConFail { get; set; }
      /// [%]
      /// String State of Charge - Battery string state of charge, expressed as a percentage.
      /// Battery string state of charge, expressed as a percentage.
      /// NOTES: Measurement.
      [SunSpecProperty(offset: 4, length: 1)]
      public UInt16 StrSoC { get; set; }
      /// [%]
      /// String State of Health - Battery string state of health, expressed as a percentage.
      /// Battery string state of health, expressed as a percentage.
      /// NOTES: Measurement.
      [SunSpecProperty(offset: 5, length: 1)]
      public UInt16? StrSoH { get; set; }
      /// [A]
      /// String Current - String current measurement.
      /// String current measurement.
      /// NOTES: Measurement.
      [SunSpecProperty(offset: 6, length: 1)]
      public Int16 StrA { get; set; }
      /// [V]
      /// Max Cell Voltage - Maximum voltage for all cells in the string.
      /// Maximum voltage for all cells in the string.
      /// NOTES: Measurement.
      [SunSpecProperty(offset: 7, length: 1)]
      public UInt16 StrCellVMax { get; set; }
      /// Max Cell Voltage Module - Module containing the maximum cell voltage.
      /// Module containing the maximum cell voltage.
      [SunSpecProperty(offset: 8, length: 1)]
      public UInt16? StrCellVMaxMod { get; set; }
      /// [V]
      /// Min Cell Voltage - Minimum voltage for all cells in the string.
      /// Minimum voltage for all cells in the string.
      /// NOTES: Measurement.
      [SunSpecProperty(offset: 9, length: 1)]
      public UInt16 StrCellVMin { get; set; }
      /// Min Cell Voltage Module - Module containing the minimum cell voltage.
      /// Module containing the minimum cell voltage.
      [SunSpecProperty(offset: 10, length: 1)]
      public UInt16? StrCellVMinMod { get; set; }
      /// [V]
      /// Average Cell Voltage - Average voltage for all cells in the string.
      /// Average voltage for all cells in the string.
      /// NOTES: Calculation based on measurements.
      [SunSpecProperty(offset: 11, length: 1)]
      public UInt16 StrCellVAvg { get; set; }
      /// [C]
      /// Max Module Temperature - Maximum temperature for all modules in the bank.
      /// Maximum temperature for all modules in the bank.
      /// NOTES: Measurement.
      [SunSpecProperty(offset: 12, length: 1)]
      public Int16 StrModTmpMax { get; set; }
      /// Max Module Temperature Module - Module with the maximum temperature.
      /// Module with the maximum temperature.
      [SunSpecProperty(offset: 13, length: 1)]
      public UInt16? StrModTmpMaxMod { get; set; }
      /// [C]
      /// Min Module Temperature - Minimum temperature for all modules in the bank.
      /// Minimum temperature for all modules in the bank.
      /// NOTES: Measurement.
      [SunSpecProperty(offset: 14, length: 1)]
      public Int16 StrModTmpMin { get; set; }
      /// Min Module Temperature Module - Module with the minimum temperature.
      /// Module with the minimum temperature.
      [SunSpecProperty(offset: 15, length: 1)]
      public UInt16? StrModTmpMinMod { get; set; }
      /// [C]
      /// Average Module Temperature - Average temperature for all modules in the bank.
      /// Average temperature for all modules in the bank.
      /// NOTES: Calculation based on measurements.
      [SunSpecProperty(offset: 16, length: 1)]
      public Int16 StrModTmpAvg { get; set; }
      public enum E_StrDisRsn : UInt16
      {
        NONE = 0,
        FAULT = 1,
        MAINTENANCE = 2,
        EXTERNAL = 3,
        OTHER = 4,
      }
      /// Disabled Reason - Reason why the string is currently disabled.
      /// Reason why the string is currently disabled.
      [SunSpecProperty(offset: 17, length: 1)]
      public E_StrDisRsn? StrDisRsn { get; set; }
      [Flags]
      public enum E_StrConSt : UInt32
      {
        CONTACTOR_0 = 0,
        CONTACTOR_1 = 1,
        CONTACTOR_2 = 2,
        CONTACTOR_3 = 3,
        CONTACTOR_4 = 4,
        CONTACTOR_5 = 5,
        CONTACTOR_6 = 6,
        CONTACTOR_7 = 7,
        CONTACTOR_8 = 8,
        CONTACTOR_9 = 9,
        CONTACTOR_10 = 10,
        CONTACTOR_11 = 11,
        CONTACTOR_12 = 12,
        CONTACTOR_13 = 13,
        CONTACTOR_14 = 14,
        CONTACTOR_15 = 15,
        CONTACTOR_16 = 16,
        CONTACTOR_17 = 17,
        CONTACTOR_18 = 18,
        CONTACTOR_19 = 19,
        CONTACTOR_20 = 20,
        CONTACTOR_21 = 21,
        CONTACTOR_22 = 22,
        CONTACTOR_23 = 23,
        CONTACTOR_24 = 24,
        CONTACTOR_25 = 25,
        CONTACTOR_26 = 26,
        CONTACTOR_27 = 27,
        CONTACTOR_28 = 28,
        CONTACTOR_29 = 29,
        CONTACTOR_30 = 30,
      }
      /// Contactor Status - Status of the contactor(s) for the string.
      /// Status of the contactor(s) for the string.
      [SunSpecProperty(offset: 18, length: 1)]
      public E_StrConSt? StrConSt { get; set; }
      [Flags]
      public enum E_StrEvt1 : UInt32
      {
        COMMUNICATION_ERROR = 0,
        OVER_TEMP_ALARM = 1,
        OVER_TEMP_WARNING = 2,
        UNDER_TEMP_ALARM = 3,
        UNDER_TEMP_WARNING = 4,
        OVER_CHARGE_CURRENT_ALARM = 5,
        OVER_CHARGE_CURRENT_WARNING = 6,
        OVER_DISCHARGE_CURRENT_ALARM = 7,
        OVER_DISCHARGE_CURRENT_WARNING = 8,
        OVER_VOLT_ALARM = 9,
        OVER_VOLT_WARNING = 10,
        UNDER_VOLT_ALARM = 11,
        UNDER_VOLT_WARNING = 12,
        UNDER_SOC_MIN_ALARM = 13,
        UNDER_SOC_MIN_WARNING = 14,
        OVER_SOC_MAX_ALARM = 15,
        OVER_SOC_MAX_WARNING = 16,
        VOLTAGE_IMBALANCE_WARNING = 17,
        TEMPERATURE_IMBALANCE_ALARM = 18,
        TEMPERATURE_IMBALANCE_WARNING = 19,
        CONTACTOR_ERROR = 20,
        FAN_ERROR = 21,
        GROUND_FAULT = 22,
        OPEN_DOOR_ERROR = 23,
        RESERVED_1 = 24,
        OTHER_ALARM = 25,
        OTHER_WARNING = 26,
        RESERVED_2 = 27,
        CONFIGURATION_ALARM = 28,
        CONFIGURATION_WARNING = 29,
      }
      /// String Event 1 - Alarms, warnings and status values.  Bit flags.
      /// Alarms, warnings and status values.  Bit flags.
      [SunSpecProperty(offset: 20, length: 1)]
      public E_StrEvt1 StrEvt1 { get; set; }
      [Flags]
      public enum E_StrEvt2 : UInt32
      {
      }
      /// String Event 2 - Alarms, warnings and status values.  Bit flags.
      /// Alarms, warnings and status values.  Bit flags.
      /// NOTES: Reserved for future use.
      [SunSpecProperty(offset: 22, length: 1)]
      public E_StrEvt2? StrEvt2 { get; set; }
      [Flags]
      public enum E_StrEvtVnd1 : UInt32
      {
      }
      /// Vendor String Event Bitfield 1 - Vendor defined events.
      /// Vendor defined events.
      [SunSpecProperty(offset: 24, length: 1)]
      public E_StrEvtVnd1? StrEvtVnd1 { get; set; }
      [Flags]
      public enum E_StrEvtVnd2 : UInt32
      {
      }
      /// Vendor String Event Bitfield 2 - Vendor defined events.
      /// Vendor defined events.
      [SunSpecProperty(offset: 26, length: 1)]
      public E_StrEvtVnd2? StrEvtVnd2 { get; set; }
      public enum E_StrSetEna : UInt16
      {
        ENABLE_STRING = 1,
        DISABLE_STRING = 2,
      }
      /// Enable/Disable String - Enables and disables the string.
      /// Enables and disables the string.
      /// NOTES: Should reset to 0 upon completion.
      [SunSpecProperty(offset: 28, length: 1)]
      public E_StrSetEna? StrSetEna { get; set; }
      public enum E_StrSetCon : UInt16
      {
        CONNECT_STRING = 1,
        DISCONNECT_STRING = 2,
      }
      /// Connect/Disconnect String - Connects and disconnects the string.
      /// Connects and disconnects the string.
      /// NOTES: Should reset to 0 upon completion.
      [SunSpecProperty(offset: 29, length: 1)]
      public E_StrSetCon? StrSetCon { get; set; }
      /// Pad - Pad register.
      /// Pad register.
      [SunSpecProperty(offset: 30, length: 1)]
      public UInt16 Pad1 { get; set; }
      /// Pad - Pad register.
      /// Pad register.
      [SunSpecProperty(offset: 31, length: 1)]
      public UInt16 Pad2 { get; set; }
    };
    public S_String[] String;
  }
}
