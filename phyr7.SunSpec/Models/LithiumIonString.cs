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
  [SunSpecModel(id: 804, length: 62)]
  public struct LithiumIonString
  {
    /// String Index - Index of the string within the bank.
    /// Index of the string within the bank.
    /// NOTES: Indices are one-based.
    [SunSpecProperty(offset: 0, length: 1)]
    public UInt16 Idx { get; set; }
    /// Module Count - Count of modules in the string.
    /// Count of modules in the string.
    [SunSpecProperty(offset: 1, length: 1)]
    public UInt16 NMod { get; set; }
    [Flags]
    public enum E_St : UInt32
    {
      STRING_ENABLED = 0,
      CONTACTOR_STATUS = 1,
    }
    /// String Status - Current status of the string.
    /// Current status of the string.
    [SunSpecProperty(offset: 2, length: 1)]
    public E_St St { get; set; }
    public enum E_ConFail : UInt16
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
    [SunSpecProperty(offset: 4, length: 1)]
    public E_ConFail? ConFail { get; set; }
    /// String Cell Balancing Count - Number of cells currently being balanced in the string.
    /// Number of cells currently being balanced in the string.
    [SunSpecProperty(offset: 5, length: 1)]
    public UInt16? NCellBal { get; set; }
    /// [%]
    /// String State of Charge - Battery string state of charge, expressed as a percentage.
    /// Battery string state of charge, expressed as a percentage.
    /// NOTES: Measurement.
    [SunSpecProperty(offset: 6, length: 1)]
    public UInt16 SoC { get; set; }
    /// [%]
    /// String Depth of Discharge - Depth of discharge for the string, expressed as a percentage.
    /// Depth of discharge for the string, expressed as a percentage.
    /// NOTES: Measurement.
    [SunSpecProperty(offset: 7, length: 1)]
    public UInt16? DoD { get; set; }
    /// String Cycle Count - Number of discharge cycles executed upon the string.
    /// Number of discharge cycles executed upon the string.
    [SunSpecProperty(offset: 8, length: 1)]
    public UInt32? NCyc { get; set; }
    /// [%]
    /// String State of Health - Battery string state of health, expressed as a percentage.
    /// Battery string state of health, expressed as a percentage.
    /// NOTES: Measurement.
    [SunSpecProperty(offset: 10, length: 1)]
    public UInt16? SoH { get; set; }
    /// [A]
    /// String Current - String current measurement.
    /// String current measurement.
    /// NOTES: Measurement.
    [SunSpecProperty(offset: 11, length: 1)]
    public Int16 A { get; set; }
    /// [V]
    /// String Voltage - String voltage measurement.
    /// String voltage measurement.
    /// NOTES: Measurement.
    [SunSpecProperty(offset: 12, length: 1)]
    public UInt16? V { get; set; }
    /// [V]
    /// Max Cell Voltage - Maximum voltage for all cells in the string.
    /// Maximum voltage for all cells in the string.
    /// NOTES: Measurement.
    [SunSpecProperty(offset: 13, length: 1)]
    public UInt16 CellVMax { get; set; }
    /// Max Cell Voltage Module - Module containing the cell with maximum cell voltage.
    /// Module containing the cell with maximum cell voltage.
    [SunSpecProperty(offset: 14, length: 1)]
    public UInt16? CellVMaxMod { get; set; }
    /// [V]
    /// Min Cell Voltage - Minimum voltage for all cells in the string.
    /// Minimum voltage for all cells in the string.
    /// NOTES: Measurement.
    [SunSpecProperty(offset: 15, length: 1)]
    public UInt16 CellVMin { get; set; }
    /// Min Cell Voltage Module - Module containing the cell with minimum cell voltage.
    /// Module containing the cell with minimum cell voltage.
    [SunSpecProperty(offset: 16, length: 1)]
    public UInt16? CellVMinMod { get; set; }
    /// [V]
    /// Average Cell Voltage - Average voltage for all cells in the string.
    /// Average voltage for all cells in the string.
    /// NOTES: Calculation based on measurements.
    [SunSpecProperty(offset: 17, length: 1)]
    public UInt16 CellVAvg { get; set; }
    /// [C]
    /// Max Module Temperature - Maximum temperature for all modules in the string.
    /// Maximum temperature for all modules in the string.
    /// NOTES: Measurement.
    [SunSpecProperty(offset: 18, length: 1)]
    public Int16 ModTmpMax { get; set; }
    /// Max Module Temperature Module - Module with the maximum temperature.
    /// Module with the maximum temperature.
    [SunSpecProperty(offset: 19, length: 1)]
    public UInt16 ModTmpMaxMod { get; set; }
    /// [C]
    /// Min Module Temperature - Minimum temperature for all modules in the string.
    /// Minimum temperature for all modules in the string.
    /// NOTES: Measurement.
    [SunSpecProperty(offset: 20, length: 1)]
    public Int16 ModTmpMin { get; set; }
    /// Min Module Temperature Module - Module with the minimum temperature.
    /// Module with the minimum temperature.
    [SunSpecProperty(offset: 21, length: 1)]
    public UInt16 ModTmpMinMod { get; set; }
    /// [C]
    /// Average Module Temperature - Average temperature for all modules in the string.
    /// Average temperature for all modules in the string.
    /// NOTES: Calculation based on measurements.
    [SunSpecProperty(offset: 22, length: 1)]
    public Int16 ModTmpAvg { get; set; }
    /// Pad - Pad register.
    /// Pad register.
    [SunSpecProperty(offset: 23, length: 1)]
    public UInt16 Pad1 { get; set; }
    [Flags]
    public enum E_ConSt : UInt32
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
    [SunSpecProperty(offset: 24, length: 1)]
    public E_ConSt? ConSt { get; set; }
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
    [SunSpecProperty(offset: 26, length: 1)]
    public E_Evt1 Evt1 { get; set; }
    [Flags]
    public enum E_Evt2 : UInt32
    {
    }
    /// String Event 2 - Alarms, warnings and status values.  Bit flags.
    /// Alarms, warnings and status values.  Bit flags.
    /// NOTES: Reserved for future use.
    [SunSpecProperty(offset: 28, length: 1)]
    public E_Evt2? Evt2 { get; set; }
    [Flags]
    public enum E_EvtVnd1 : UInt32
    {
    }
    /// Vendor Event Bitfield 1 - Vendor defined events.
    /// Vendor defined events.
    [SunSpecProperty(offset: 30, length: 1)]
    public E_EvtVnd1? EvtVnd1 { get; set; }
    [Flags]
    public enum E_EvtVnd2 : UInt32
    {
    }
    /// Vendor Event Bitfield 2 - Vendor defined events.
    /// Vendor defined events.
    [SunSpecProperty(offset: 32, length: 1)]
    public E_EvtVnd2? EvtVnd2 { get; set; }
    public enum E_SetEna : UInt16
    {
    }
    /// Enable/Disable String - Enables and disables the string.  Should reset to 0 upon completion.
    /// Enables and disables the string.  Should reset to 0 upon completion.
    [SunSpecProperty(offset: 34, length: 1)]
    public E_SetEna? SetEna { get; set; }
    public enum E_SetCon : UInt16
    {
      CONNECT_STRING = 1,
      DISCONNECT_STRING = 2,
    }
    /// Connect/Disconnect String - Connects and disconnects the string.
    /// Connects and disconnects the string.
    /// NOTES: Should reset to 0 upon completion.
    [SunSpecProperty(offset: 35, length: 1)]
    public E_SetCon? SetCon { get; set; }
    /// Scale factor for string state of charge.
    [SunSpecProperty(offset: 36, length: 1)]
    public Int16 SoC_SF { get; set; }
    /// Scale factor for string state of health.
    [SunSpecProperty(offset: 37, length: 1)]
    public Int16? SoH_SF { get; set; }
    /// Scale factor for string depth of discharge.
    [SunSpecProperty(offset: 38, length: 1)]
    public Int16? DoD_SF { get; set; }
    /// Scale factor for string current.
    [SunSpecProperty(offset: 39, length: 1)]
    public Int16 A_SF { get; set; }
    /// Scale factor for string voltage.
    [SunSpecProperty(offset: 40, length: 1)]
    public Int16? V_SF { get; set; }
    /// Scale factor for cell voltage.
    [SunSpecProperty(offset: 41, length: 1)]
    public Int16 CellV_SF { get; set; }
    /// Scale factor for module temperature.
    [SunSpecProperty(offset: 42, length: 1)]
    public Int16 ModTmp_SF { get; set; }
    /// Pad - Pad register.
    /// Pad register.
    [SunSpecProperty(offset: 43, length: 1)]
    public UInt16 Pad2 { get; set; }
    /// Pad - Pad register.
    /// Pad register.
    [SunSpecProperty(offset: 44, length: 1)]
    public UInt16 Pad3 { get; set; }
    /// Pad - Pad register.
    /// Pad register.
    [SunSpecProperty(offset: 45, length: 1)]
    public UInt16 Pad4 { get; set; }
    public struct S_LithiumIonStringModule
    {
      /// Module Cell Count - Count of all cells in the module.
      /// Count of all cells in the module.
      [SunSpecProperty(offset: 0, length: 1)]
      public UInt16 ModNCell { get; set; }
      /// [%]
      /// Module SoC - Module state of charge, expressed as a percentage.
      /// Module state of charge, expressed as a percentage.
      [SunSpecProperty(offset: 1, length: 1)]
      public UInt16? ModSoC { get; set; }
      /// [%]
      /// Module SoH - Module state of health, expressed as a percentage.
      /// Module state of health, expressed as a percentage.
      [SunSpecProperty(offset: 2, length: 1)]
      public UInt16? ModSoH { get; set; }
      /// [V]
      /// Max Cell Voltage - Maximum voltage for all cells in the module.
      /// Maximum voltage for all cells in the module.
      /// NOTES: Measurement.
      [SunSpecProperty(offset: 3, length: 1)]
      public UInt16 ModCellVMax { get; set; }
      /// Max Cell Voltage Cell - Cell with maximum voltage.
      /// Cell with maximum voltage.
      [SunSpecProperty(offset: 4, length: 1)]
      public UInt16? ModCellVMaxCell { get; set; }
      /// [V]
      /// Min Cell Voltage - Minimum voltage for all cells in the module.
      /// Minimum voltage for all cells in the module.
      /// NOTES: Measurement.
      [SunSpecProperty(offset: 5, length: 1)]
      public UInt16 ModCellVMin { get; set; }
      /// [V]
      /// Min Cell Voltage Cell - Cell with minimum voltage.
      /// Cell with minimum voltage.
      [SunSpecProperty(offset: 6, length: 1)]
      public UInt16? ModCellVMinCell { get; set; }
      /// [V]
      /// Average Cell Voltage - Average voltage for all cells in the module.
      /// Average voltage for all cells in the module.
      /// NOTES: Calculation based on measurements.
      [SunSpecProperty(offset: 7, length: 1)]
      public UInt16 ModCellVAvg { get; set; }
      /// [C]
      /// Max Cell Temperature - Maximum temperature for all cells in the module.
      /// Maximum temperature for all cells in the module.
      /// NOTES: Measurement.
      [SunSpecProperty(offset: 8, length: 1)]
      public Int16 ModCellTmpMax { get; set; }
      /// Max Cell Temperature Cell - Cell with maximum temperature.
      /// Cell with maximum temperature.
      [SunSpecProperty(offset: 9, length: 1)]
      public UInt16? ModCellTmpMaxCell { get; set; }
      /// [C]
      /// Min Cell Temperature - Minimum temperature for all cells in the module.
      /// Minimum temperature for all cells in the module.
      /// NOTES: Measurement.
      [SunSpecProperty(offset: 10, length: 1)]
      public Int16 ModCellTmpMin { get; set; }
      /// Min Cell Temperature Cell - Cell with minimum temperature.
      /// Cell with minimum temperature.
      [SunSpecProperty(offset: 11, length: 1)]
      public UInt16? ModCellTmpMinCell { get; set; }
      /// [C]
      /// Average Cell Temperature - Average temperature for all cells in the module.
      /// Average temperature for all cells in the module.
      /// NOTES: Calculation based on measurements.
      [SunSpecProperty(offset: 12, length: 1)]
      public Int16 ModCellTmpAvg { get; set; }
      /// Pad - Pad register.
      /// Pad register.
      [SunSpecProperty(offset: 13, length: 1)]
      public UInt16 Pad5 { get; set; }
      /// Pad - Pad register.
      /// Pad register.
      [SunSpecProperty(offset: 14, length: 1)]
      public UInt16 Pad6 { get; set; }
      /// Pad - Pad register.
      /// Pad register.
      [SunSpecProperty(offset: 15, length: 1)]
      public UInt16 Pad7 { get; set; }
    };
    public S_LithiumIonStringModule[] LithiumIonStringModule;
  }
}
