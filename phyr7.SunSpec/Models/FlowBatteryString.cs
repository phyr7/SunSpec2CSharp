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
  [SunSpecModel(id: 807, length: 58)]
  public struct FlowBatteryString
  {
    /// String Index - Index of the string within the bank.
    /// Index of the string within the bank.
    /// NOTES: Indices are one-based.
    [SunSpecProperty(offset: 0, length: 1)]
    public UInt16 Idx { get; set; }
    /// Module Count - Number of modules in this string.
    /// Number of modules in this string.
    [SunSpecProperty(offset: 1, length: 1)]
    public UInt16 NMod { get; set; }
    /// Connected Module Count - Number of electrically connected modules in this string.
    /// Number of electrically connected modules in this string.
    [SunSpecProperty(offset: 2, length: 1)]
    public UInt16 NModCon { get; set; }
    /// [V]
    /// Max Module Voltage - Maximum voltage for all modules in the string.
    /// Maximum voltage for all modules in the string.
    /// NOTES: Measurement.
    [SunSpecProperty(offset: 3, length: 1)]
    public UInt16 ModVMax { get; set; }
    /// Max Module Voltage Module - Module with the maximum voltage.
    /// Module with the maximum voltage.
    [SunSpecProperty(offset: 4, length: 1)]
    public UInt16? ModVMaxMod { get; set; }
    /// [V]
    /// Min Module Voltage - Minimum voltage for all modules in the string.
    /// Minimum voltage for all modules in the string.
    /// NOTES: Measurement.
    [SunSpecProperty(offset: 5, length: 1)]
    public UInt16 ModVMin { get; set; }
    /// Min Module Voltage Module - Module with the minimum voltage.
    /// Module with the minimum voltage.
    [SunSpecProperty(offset: 6, length: 1)]
    public UInt16? ModVMinMod { get; set; }
    /// [V]
    /// Average Module Voltage - Average voltage for all modules in the string.
    /// Average voltage for all modules in the string.
    /// NOTES: Calculation based on measurements.
    [SunSpecProperty(offset: 7, length: 1)]
    public UInt16 ModVAvg { get; set; }
    /// [V]
    /// Max Cell Voltage - Maximum voltage for all cells in the string.
    /// Maximum voltage for all cells in the string.
    /// NOTES: Measurement.
    [SunSpecProperty(offset: 8, length: 1)]
    public UInt16? CellVMax { get; set; }
    /// Max Cell Voltage Module - Module containing the cell with the maximum voltage.
    /// Module containing the cell with the maximum voltage.
    [SunSpecProperty(offset: 9, length: 1)]
    public UInt16? CellVMaxMod { get; set; }
    /// Max Cell Voltage Stack - Stack containing the cell with the maximum voltage.
    /// Stack containing the cell with the maximum voltage.
    [SunSpecProperty(offset: 10, length: 1)]
    public UInt16? CellVMaxStk { get; set; }
    /// [V]
    /// Min Cell Voltage - Minimum voltage for all cells in the string.
    /// Minimum voltage for all cells in the string.
    /// NOTES: Measurement.
    [SunSpecProperty(offset: 11, length: 1)]
    public UInt16? CellVMin { get; set; }
    /// Min Cell Voltage Module - Module containing the cell with the minimum voltage.
    /// Module containing the cell with the minimum voltage.
    [SunSpecProperty(offset: 12, length: 1)]
    public UInt16? CellVMinMod { get; set; }
    /// Min Cell Voltage Stack - Stack containing the cell with the minimum voltage.
    /// Stack containing the cell with the minimum voltage.
    [SunSpecProperty(offset: 13, length: 1)]
    public UInt16? CellVMinStk { get; set; }
    /// [V]
    /// Average Cell Voltage - Average voltage for all cells in the string.
    /// Average voltage for all cells in the string.
    /// NOTES: Calculation based on measurements.
    [SunSpecProperty(offset: 14, length: 1)]
    public UInt16? CellVAvg { get; set; }
    /// [C]
    /// Max Temperature - Maximum electrolyte temperature for all modules in the string.
    /// Maximum electrolyte temperature for all modules in the string.
    /// NOTES: Measurement.
    [SunSpecProperty(offset: 15, length: 1)]
    public Int16 TmpMax { get; set; }
    /// Max Temperature Module - Module with the maximum temperature.
    /// Module with the maximum temperature.
    [SunSpecProperty(offset: 16, length: 1)]
    public UInt16? TmpMaxMod { get; set; }
    /// [C]
    /// Min Temperature - Minimum electrolyte temperature for all modules in the string.
    /// Minimum electrolyte temperature for all modules in the string.
    /// NOTES: Measurement.
    [SunSpecProperty(offset: 17, length: 1)]
    public Int16 TmpMin { get; set; }
    /// Min Temperature Module - Module with the minimum temperature.
    /// Module with the minimum temperature.
    [SunSpecProperty(offset: 18, length: 1)]
    public UInt16? TmpMinMod { get; set; }
    /// [C]
    /// Average Temperature - Average electrolyte temperature for all modules in the string.
    /// Average electrolyte temperature for all modules in the string.
    /// NOTES: Calculation based on measurements.
    [SunSpecProperty(offset: 19, length: 1)]
    public Int16 TmpAvg { get; set; }
    [Flags]
    public enum E_Evt1 : UInt32
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
      RESERVED_1 = 18,
      RESERVED_2 = 19,
      CONTACTOR_ERROR = 20,
      FAN_ERROR = 21,
      GROUND_FAULT = 22,
      OPEN_DOOR_ERROR = 23,
      RESERVED_3 = 24,
      OTHER_ALARM = 25,
      OTHER_WARNING = 26,
      FIRE_ALARM = 27,
      CONFIGURATION_ALARM = 28,
      CONFIGURATION_WARNING = 29,
    }
    /// String Event 1 - Alarms, warnings and status values.  Bit flags.
    /// Alarms, warnings and status values.  Bit flags.
    [SunSpecProperty(offset: 20, length: 1)]
    public E_Evt1 Evt1 { get; set; }
    [Flags]
    public enum E_Evt2 : UInt32
    {
      LEAK_ALARM = 0,
      PUMP_ALARM = 1,
      HIGH_PRESSURE_ALARM = 2,
      HIGH_PRESSURE_WARNING = 3,
      LOW_FLOW_ALARM = 4,
      LOW_FLOW_WARNING = 5,
    }
    /// String Event 2 - Alarms, warnings and status values.  Bit flags.
    /// Alarms, warnings and status values.  Bit flags.
    [SunSpecProperty(offset: 22, length: 1)]
    public E_Evt2 Evt2 { get; set; }
    [Flags]
    public enum E_EvtVnd1 : UInt32
    {
    }
    /// Vendor Event Bitfield 1 - Vendor defined events.
    /// Vendor defined events.
    [SunSpecProperty(offset: 24, length: 1)]
    public E_EvtVnd1 EvtVnd1 { get; set; }
    [Flags]
    public enum E_EvtVnd2 : UInt32
    {
    }
    /// Vendor Event Bitfield 2 - Vendor defined events.
    /// Vendor defined events.
    [SunSpecProperty(offset: 26, length: 1)]
    public E_EvtVnd2 EvtVnd2 { get; set; }
    [SunSpecProperty(offset: 28, length: 1)]
    public Int16 ModV_SF { get; set; }
    /// Scale factor for voltage.
    [SunSpecProperty(offset: 29, length: 1)]
    public Int16 CellV_SF { get; set; }
    /// Scale factor for temperature.
    [SunSpecProperty(offset: 30, length: 1)]
    public Int16 Tmp_SF { get; set; }
    /// Scale factor for state of charge.
    [SunSpecProperty(offset: 31, length: 1)]
    public Int16 SoC_SF { get; set; }
    /// Scale factor for open circuit voltage.
    [SunSpecProperty(offset: 32, length: 1)]
    public Int16 OCV_SF { get; set; }
    /// Pad - Pad register.
    /// Pad register.
    [SunSpecProperty(offset: 33, length: 1)]
    public UInt16 Pad1 { get; set; }
    public struct S_Module
    {
      /// Module Index - Index of the module within the string.
      /// Index of the module within the string.
      /// NOTES: Indices are one-based.
      [SunSpecProperty(offset: 0, length: 1)]
      public UInt16 ModIdx { get; set; }
      /// Stack Count - Number of stacks in this module.
      /// Number of stacks in this module.
      [SunSpecProperty(offset: 1, length: 1)]
      public UInt16 ModNStk { get; set; }
      [Flags]
      public enum E_ModSt : UInt32
      {
        MODULE_ENABLED = 0,
        CONTACTOR_STATUS = 1,
      }
      /// Module Status - Current status of the module.
      /// Current status of the module.
      [SunSpecProperty(offset: 2, length: 1)]
      public E_ModSt ModSt { get; set; }
      /// [%]
      /// Module State of Charge - State of charge for this module.
      /// State of charge for this module.
      [SunSpecProperty(offset: 4, length: 1)]
      public UInt16 ModSoC { get; set; }
      /// [V]
      /// Open Circuit Voltage - Open circuit voltage for this module.
      /// Open circuit voltage for this module.
      [SunSpecProperty(offset: 5, length: 1)]
      public UInt16 ModOCV { get; set; }
      /// [V]
      /// External Voltage - External voltage fo this module.
      /// External voltage fo this module.
      [SunSpecProperty(offset: 6, length: 1)]
      public UInt16 ModV { get; set; }
      /// [V]
      /// Maximum Cell Voltage - Maximum voltage for all cells in this module.
      /// Maximum voltage for all cells in this module.
      /// NOTES: Measurement.
      [SunSpecProperty(offset: 7, length: 1)]
      public UInt16? ModCellVMax { get; set; }
      /// Max Cell Voltage Cell - Cell with the maximum cell voltage.
      /// Cell with the maximum cell voltage.
      [SunSpecProperty(offset: 8, length: 1)]
      public UInt16? ModCellVMaxCell { get; set; }
      /// [V]
      /// Minimum Cell Voltage - Minimum voltage for all cells in this module.
      /// Minimum voltage for all cells in this module.
      /// NOTES: Measurement.
      [SunSpecProperty(offset: 9, length: 1)]
      public UInt16? ModCellVMin { get; set; }
      /// Min Cell Voltage Cell - Cell with the minimum cell voltage.
      /// Cell with the minimum cell voltage.
      [SunSpecProperty(offset: 10, length: 1)]
      public UInt16? ModCellVMinCell { get; set; }
      /// [V]
      /// Average Cell Voltage - Average voltage for all cells in this module.
      /// Average voltage for all cells in this module.
      /// NOTES: Calculation based on measurements.
      [SunSpecProperty(offset: 11, length: 1)]
      public UInt16? ModCellVAvg { get; set; }
      /// [C]
      /// Anolyte Temperature - 
      [SunSpecProperty(offset: 12, length: 1)]
      public UInt16? ModAnoTmp { get; set; }
      /// [C]
      /// Catholyte Temperature - 
      [SunSpecProperty(offset: 13, length: 1)]
      public UInt16? ModCatTmp { get; set; }
      [Flags]
      public enum E_ModConSt : UInt32
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
      /// Contactor Status - 
      [SunSpecProperty(offset: 14, length: 1)]
      public E_ModConSt? ModConSt { get; set; }
      [Flags]
      public enum E_ModEvt1 : UInt32
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
        RESERVED_1 = 18,
        RESERVED_2 = 19,
        CONTACTOR_ERROR = 20,
        FAN_ERROR = 21,
        GROUND_FAULT = 22,
        OPEN_DOOR_ERROR = 23,
        RESERVED_3 = 24,
        RESERVED_4 = 25,
        RESERVED_5 = 26,
        FIRE_ALARM = 27,
        MODULE_CONFIGURATION_ALARM = 28,
        MODULE_CONFIGURATION_WARNING = 29,
      }
      /// Module Event 1 - Alarms, warnings and status values.  Bit flags.
      /// Alarms, warnings and status values.  Bit flags.
      [SunSpecProperty(offset: 16, length: 1)]
      public E_ModEvt1 ModEvt1 { get; set; }
      [Flags]
      public enum E_ModEvt2 : UInt32
      {
        LEAK_ALARM = 0,
        PUMP_ALARM = 1,
        HIGH_PRESSURE_ALARM = 2,
        HIGH_PRESSURE_WARNING = 3,
        LOW_FLOW_ALARM = 4,
        LOW_FLOW_WARNING = 5,
      }
      /// Module Event 2 - Alarms, warnings and status values.  Bit flags.
      /// Alarms, warnings and status values.  Bit flags.
      [SunSpecProperty(offset: 18, length: 1)]
      public E_ModEvt2 ModEvt2 { get; set; }
      public enum E_ModConFail : UInt16
      {
        NO_FAILURE = 0,
        BUTTON_PUSHED = 1,
        MODULE_GROUND_FAULT = 2,
        OUTSIDE_VOLTAGE_RANGE = 3,
        MODULE_NOT_ENABLED = 4,
        FUSE_OPEN = 5,
        CONTACTOR_FAILURE = 6,
        PRECHARGE_FAILURE = 7,
        MODULE_FAULT = 8,
      }
      /// Connection Failure Reason - 
      [SunSpecProperty(offset: 20, length: 1)]
      public E_ModConFail? ModConFail { get; set; }
      public enum E_ModSetEna : UInt16
      {
        ENABLE_MODULE = 1,
        DISABLE_MODULE = 2,
      }
      /// Enable/Disable Module - Enables and disables the module.
      /// Enables and disables the module.
      /// NOTES: Should reset to 0 upon completion.
      [SunSpecProperty(offset: 21, length: 1)]
      public E_ModSetEna? ModSetEna { get; set; }
      public enum E_ModSetCon : UInt16
      {
        CONNECT_MODULE = 1,
        DISCONNECT_MODULE = 2,
      }
      /// Connect/Disconnect Module  - Connects and disconnects the module.
      /// Connects and disconnects the module.
      /// NOTES: Should reset to 0 upon completion.
      [SunSpecProperty(offset: 22, length: 1)]
      public E_ModSetCon? ModSetCon { get; set; }
      public enum E_ModDisRsn : UInt16
      {
        NONE = 0,
        FAULT = 1,
        MAINTENANCE = 2,
        EXTERNAL = 3,
        OTHER = 4,
      }
      /// Disabled Reason - Reason why the module is currently disabled.
      /// Reason why the module is currently disabled.
      [SunSpecProperty(offset: 23, length: 1)]
      public E_ModDisRsn? ModDisRsn { get; set; }
    };
    public S_Module[] Module;
  }
}
