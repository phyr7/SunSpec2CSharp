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
  [SunSpecModel(id: 802, length: 62)]
  public struct Battery
  {
    /// [Ah]
    /// Nameplate Charge Capacity - Nameplate charge capacity in amp-hours.
    /// Nameplate charge capacity in amp-hours.
    [SunSpecProperty(offset: 0, length: 1)]
    public UInt16 AHRtg { get; set; }
    /// [Wh]
    /// Nameplate Energy Capacity - Nameplate energy capacity in DC watt-hours.
    /// Nameplate energy capacity in DC watt-hours.
    [SunSpecProperty(offset: 1, length: 1)]
    public UInt16 WHRtg { get; set; }
    /// [W]
    /// Nameplate Max Charge Rate - Maximum rate of energy transfer into the storage device in DC watts.
    /// Maximum rate of energy transfer into the storage device in DC watts.
    [SunSpecProperty(offset: 2, length: 1)]
    public UInt16 WChaRteMax { get; set; }
    /// [W]
    /// Nameplate Max Discharge Rate - Maximum rate of energy transfer out of the storage device in DC watts.
    /// Maximum rate of energy transfer out of the storage device in DC watts.
    [SunSpecProperty(offset: 3, length: 1)]
    public UInt16 WDisChaRteMax { get; set; }
    /// [%WHRtg]
    /// Self Discharge Rate - Self discharge rate.  Percentage of capacity (WHRtg) discharged per day.
    /// Self discharge rate.  Percentage of capacity (WHRtg) discharged per day.
    [SunSpecProperty(offset: 4, length: 1)]
    public UInt16? DisChaRte { get; set; }
    /// [%WHRtg]
    /// Nameplate Max SoC - Manufacturer maximum state of charge, expressed as a percentage.
    /// Manufacturer maximum state of charge, expressed as a percentage.
    [SunSpecProperty(offset: 5, length: 1)]
    public UInt16? SoCMax { get; set; }
    /// [%WHRtg]
    /// Nameplate Min SoC - Manufacturer minimum state of charge, expressed as a percentage.
    /// Manufacturer minimum state of charge, expressed as a percentage.
    [SunSpecProperty(offset: 6, length: 1)]
    public UInt16? SoCMin { get; set; }
    /// [%WHRtg]
    /// Max Reserve Percent - Setpoint for maximum reserve for storage as a percentage of the nominal maximum storage.
    /// Setpoint for maximum reserve for storage as a percentage of the nominal maximum storage.
    [SunSpecProperty(offset: 7, length: 1)]
    public UInt16? SocRsvMax { get; set; }
    /// [%WHRtg]
    /// Min Reserve Percent - Setpoint for maximum reserve for storage as a percentage of the nominal maximum storage.
    /// Setpoint for maximum reserve for storage as a percentage of the nominal maximum storage.
    [SunSpecProperty(offset: 8, length: 1)]
    public UInt16? SoCRsvMin { get; set; }
    /// [%WHRtg]
    /// State of Charge - State of charge, expressed as a percentage.
    /// State of charge, expressed as a percentage.
    /// NOTES: Measurement.
    [SunSpecProperty(offset: 9, length: 1)]
    public UInt16 SoC { get; set; }
    /// [%]
    /// Depth of Discharge - Depth of discharge, expressed as a percentage.
    /// Depth of discharge, expressed as a percentage.
    /// NOTES: Measurement.
    [SunSpecProperty(offset: 10, length: 1)]
    public UInt16? DoD { get; set; }
    /// [%]
    /// State of Health - Percentage of battery life remaining.
    /// Percentage of battery life remaining.
    [SunSpecProperty(offset: 11, length: 1)]
    public UInt16? SoH { get; set; }
    /// Cycle Count - Number of cycles executed in the battery.
    /// Number of cycles executed in the battery.
    [SunSpecProperty(offset: 12, length: 1)]
    public UInt32? NCyc { get; set; }
    public enum E_ChaSt : UInt16
    {
      OFF = 1,
      EMPTY = 2,
      DISCHARGING = 3,
      CHARGING = 4,
      FULL = 5,
      HOLDING = 6,
      TESTING = 7,
    }
    /// Charge Status - Charge status of storage device. Enumeration.
    /// Charge status of storage device. Enumeration.
    [SunSpecProperty(offset: 14, length: 1)]
    public E_ChaSt? ChaSt { get; set; }
    public enum E_LocRemCtl : UInt16
    {
      REMOTE = 0,
      LOCAL = 1,
    }
    /// Control Mode - Battery control mode. Enumeration.
    /// Battery control mode. Enumeration.
    /// NOTES: Maps to DRCC.LocRemCtl in IEC 61850.
    [SunSpecProperty(offset: 15, length: 1)]
    public E_LocRemCtl LocRemCtl { get; set; }
    /// Battery Heartbeat - Value is incremented every second with periodic resets to zero.
    /// Value is incremented every second with periodic resets to zero.
    [SunSpecProperty(offset: 16, length: 1)]
    public UInt16? Hb { get; set; }
    /// Controller Heartbeat - Value is incremented every second with periodic resets to zero.
    /// Value is incremented every second with periodic resets to zero.
    [SunSpecProperty(offset: 17, length: 1)]
    public UInt16? CtrlHb { get; set; }
    /// Alarm Reset - Used to reset any latched alarms.  1 = Reset.
    /// Used to reset any latched alarms.  1 = Reset.
    /// NOTES: Battery should reset to 0 when reset is complete.
    [SunSpecProperty(offset: 18, length: 1)]
    public UInt16 AlmRst { get; set; }
    public enum E_Typ : UInt16
    {
      NOT_APPLICABLE_UNKNOWN = 0,
      LEAD_ACID = 1,
      NICKEL_METAL_HYDRATE = 2,
      NICKEL_CADMIUM = 3,
      LITHIUM_ION = 4,
      CARBON_ZINC = 5,
      ZINC_CHLORIDE = 6,
      ALKALINE = 7,
      RECHARGEABLE_ALKALINE = 8,
      SODIUM_SULFUR = 9,
      FLOW = 10,
      OTHER = 99,
    }
    /// Battery Type - Type of battery. Enumeration.
    /// Type of battery. Enumeration.
    /// NOTES: Maps to DBAT.BatTyp in 61850.
    [SunSpecProperty(offset: 19, length: 1)]
    public E_Typ Typ { get; set; }
    public enum E_State : UInt16
    {
      DISCONNECTED = 1,
      INITIALIZING = 2,
      CONNECTED = 3,
      STANDBY = 4,
      SOC_PROTECTION = 5,
      SUSPENDING = 6,
      FAULT = 99,
    }
    /// State of the Battery Bank - State of the battery bank.  Enumeration.
    /// State of the battery bank.  Enumeration.
    /// NOTES: Must be reconciled with State in IEC 61850.
    [SunSpecProperty(offset: 20, length: 1)]
    public E_State State { get; set; }
    public enum E_StateVnd : UInt16
    {
    }
    /// Vendor Battery Bank State - Vendor specific battery bank state.  Enumeration.
    /// Vendor specific battery bank state.  Enumeration.
    [SunSpecProperty(offset: 21, length: 1)]
    public E_StateVnd? StateVnd { get; set; }
    /// Warranty Date - Date the device warranty expires.
    /// Date the device warranty expires.
    /// NOTES: Number of days since 1/1/2000.
    [SunSpecProperty(offset: 22, length: 1)]
    public UInt32? WarrDt { get; set; }
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
      CURRENT_IMBALANCE_WARNING = 24,
      OTHER_ALARM = 25,
      OTHER_WARNING = 26,
      RESERVED_1 = 27,
      CONFIGURATION_ALARM = 28,
      CONFIGURATION_WARNING = 29,
    }
    /// Battery Event 1 Bitfield - Alarms and warnings.  Bit flags.
    /// Alarms and warnings.  Bit flags.
    [SunSpecProperty(offset: 24, length: 1)]
    public E_Evt1 Evt1 { get; set; }
    [Flags]
    public enum E_Evt2 : UInt32
    {
    }
    /// Battery Event 2 Bitfield - Alarms and warnings.  Bit flags.
    /// Alarms and warnings.  Bit flags.
    /// NOTES: Reserved for future use.
    [SunSpecProperty(offset: 26, length: 1)]
    public E_Evt2 Evt2 { get; set; }
    [Flags]
    public enum E_EvtVnd1 : UInt32
    {
    }
    /// Vendor Event Bitfield 1 - Vendor defined events.
    /// Vendor defined events.
    [SunSpecProperty(offset: 28, length: 1)]
    public E_EvtVnd1 EvtVnd1 { get; set; }
    [Flags]
    public enum E_EvtVnd2 : UInt32
    {
    }
    /// Vendor Event Bitfield 2 - Vendor defined events.
    /// Vendor defined events.
    [SunSpecProperty(offset: 30, length: 1)]
    public E_EvtVnd2 EvtVnd2 { get; set; }
    /// [V]
    /// External Battery Voltage - DC Bus Voltage.
    /// DC Bus Voltage.
    /// NOTES: Maps to ZBAT.V in IEC 61850.
    [SunSpecProperty(offset: 32, length: 1)]
    public UInt16 V { get; set; }
    /// [V]
    /// Max Battery Voltage - Instantaneous maximum battery voltage.
    /// Instantaneous maximum battery voltage.
    /// NOTES: If not implemented, must implement AChaMax and ADisChaMax.
    [SunSpecProperty(offset: 33, length: 1)]
    public UInt16? VMax { get; set; }
    /// [V]
    /// Min Battery Voltage - Instantaneous minimum battery voltage.
    /// Instantaneous minimum battery voltage.
    /// NOTES: If not implemented, must implement AChaMax and ADisChaMax.
    [SunSpecProperty(offset: 34, length: 1)]
    public UInt16? VMin { get; set; }
    /// [V]
    /// Max Cell Voltage - Maximum voltage for all cells in the bank.
    /// Maximum voltage for all cells in the bank.
    /// NOTES: Measurement.
    [SunSpecProperty(offset: 35, length: 1)]
    public UInt16? CellVMax { get; set; }
    /// Max Cell Voltage String - String containing the cell with maximum voltage.
    /// String containing the cell with maximum voltage.
    [SunSpecProperty(offset: 36, length: 1)]
    public UInt16? CellVMaxStr { get; set; }
    /// Max Cell Voltage Module - Module containing the cell with maximum voltage.
    /// Module containing the cell with maximum voltage.
    [SunSpecProperty(offset: 37, length: 1)]
    public UInt16? CellVMaxMod { get; set; }
    /// [V]
    /// Min Cell Voltage - Minimum voltage for all cells in the bank.
    /// Minimum voltage for all cells in the bank.
    /// NOTES: Measurement.
    [SunSpecProperty(offset: 38, length: 1)]
    public UInt16? CellVMin { get; set; }
    /// Min Cell Voltage String - String containing the cell with minimum voltage.
    /// String containing the cell with minimum voltage.
    [SunSpecProperty(offset: 39, length: 1)]
    public UInt16? CellVMinStr { get; set; }
    /// Min Cell Voltage Module - Module containing the cell with minimum voltage.
    /// Module containing the cell with minimum voltage.
    [SunSpecProperty(offset: 40, length: 1)]
    public UInt16? CellVMinMod { get; set; }
    /// [V]
    /// Average Cell Voltage - Average cell voltage for all cells in the bank.
    /// Average cell voltage for all cells in the bank.
    /// NOTES: Calculation based on measurements.
    [SunSpecProperty(offset: 41, length: 1)]
    public UInt16? CellVAvg { get; set; }
    /// [A]
    /// Total DC Current - Total DC current flowing to/from the battery bank.
    /// Total DC current flowing to/from the battery bank.
    /// NOTES: Measurement.
    [SunSpecProperty(offset: 42, length: 1)]
    public Int16 A { get; set; }
    /// [A]
    /// Max Charge Current - Instantaneous maximum DC charge current.
    /// Instantaneous maximum DC charge current.
    /// NOTES: Calculation which is always unsigned (i.e. magnitude only). If not implemented, must implement VMax and VMin.
    [SunSpecProperty(offset: 43, length: 1)]
    public UInt16? AChaMax { get; set; }
    /// [A]
    /// Max Discharge Current - Instantaneous maximum DC discharge current.
    /// Instantaneous maximum DC discharge current.
    /// NOTES: Calculation which is always unsigned (i.e. magnitude only). If not implemented, must implement VMax and VMin.
    [SunSpecProperty(offset: 44, length: 1)]
    public UInt16? ADisChaMax { get; set; }
    /// [W]
    /// Total Power - Total power flowing to/from the battery bank.
    /// Total power flowing to/from the battery bank.
    /// NOTES: Measurement.
    [SunSpecProperty(offset: 45, length: 1)]
    public Int16 W { get; set; }
    public enum E_ReqInvState : UInt16
    {
      NO_REQUEST = 0,
      START = 1,
      STOP = 2,
    }
    /// Inverter State Request - Request from battery to start or stop the inverter.  Enumeration.
    /// Request from battery to start or stop the inverter.  Enumeration.
    /// NOTES: Used in special states such as manual battery charging.
    [SunSpecProperty(offset: 46, length: 1)]
    public E_ReqInvState? ReqInvState { get; set; }
    /// [W]
    /// Battery Power Request - AC Power requested by battery.
    /// AC Power requested by battery.
    /// NOTES: Used in special states such as string balancing.
    [SunSpecProperty(offset: 47, length: 1)]
    public Int16? ReqW { get; set; }
    public enum E_SetOp : UInt16
    {
      CONNECT = 1,
      DISCONNECT = 2,
    }
    /// Set Operation - Instruct the battery bank to perform an operation such as connecting.  Enumeration.
    /// Instruct the battery bank to perform an operation such as connecting.  Enumeration.
    [SunSpecProperty(offset: 48, length: 1)]
    public E_SetOp SetOp { get; set; }
    public enum E_SetInvState : UInt16
    {
      INVERTER_STOPPED = 1,
      INVERTER_STANDBY = 2,
      INVERTER_STARTED = 3,
    }
    /// Set Inverter State - Set the current state of the inverter.
    /// Set the current state of the inverter.
    /// NOTES: Information needed by battery for some operations.
    [SunSpecProperty(offset: 49, length: 1)]
    public E_SetInvState SetInvState { get; set; }
    /// Scale factor for charge capacity.
    [SunSpecProperty(offset: 50, length: 1)]
    public Int16 AHRtg_SF { get; set; }
    /// Scale factor for energy capacity.
    [SunSpecProperty(offset: 51, length: 1)]
    public Int16 WHRtg_SF { get; set; }
    /// Scale factor for maximum charge and discharge rate.
    [SunSpecProperty(offset: 52, length: 1)]
    public Int16 WChaDisChaMax_SF { get; set; }
    /// Scale factor for self discharge rate.
    [SunSpecProperty(offset: 53, length: 1)]
    public Int16? DisChaRte_SF { get; set; }
    /// Scale factor for state of charge values.
    [SunSpecProperty(offset: 54, length: 1)]
    public Int16 SoC_SF { get; set; }
    /// Scale factor for depth of discharge.
    [SunSpecProperty(offset: 55, length: 1)]
    public Int16? DoD_SF { get; set; }
    /// Scale factor for state of health.
    [SunSpecProperty(offset: 56, length: 1)]
    public Int16? SoH_SF { get; set; }
    /// Scale factor for DC bus voltage.
    [SunSpecProperty(offset: 57, length: 1)]
    public Int16 V_SF { get; set; }
    /// Scale factor for cell voltage.
    [SunSpecProperty(offset: 58, length: 1)]
    public Int16 CellV_SF { get; set; }
    /// Scale factor for DC current.
    [SunSpecProperty(offset: 59, length: 1)]
    public Int16 A_SF { get; set; }
    /// Scale factor for instantaneous DC charge/discharge current.
    [SunSpecProperty(offset: 60, length: 1)]
    public Int16 AMax_SF { get; set; }
    /// Scale factor for AC power request.
    [SunSpecProperty(offset: 61, length: 1)]
    public Int16? W_SF { get; set; }
  }
}
