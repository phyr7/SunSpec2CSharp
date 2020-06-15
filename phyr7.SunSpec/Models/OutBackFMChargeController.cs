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
  [SunSpecModel(id: 64112, length: 64)]
  public struct OutBackFMChargeController
  {
    /// Port Number - 
    [SunSpecProperty(offset: 0, length: 1)]
    public UInt16 Port { get; set; }
    [SunSpecProperty(offset: 1, length: 1)]
    public Int16 V_SF { get; set; }
    [SunSpecProperty(offset: 2, length: 1)]
    public Int16 C_SF { get; set; }
    [SunSpecProperty(offset: 3, length: 1)]
    public Int16 H_SF { get; set; }
    [SunSpecProperty(offset: 4, length: 1)]
    public Int16 P_SF { get; set; }
    [SunSpecProperty(offset: 5, length: 1)]
    public Int16 AH_SF { get; set; }
    [SunSpecProperty(offset: 6, length: 1)]
    public Int16 KWH_SF { get; set; }
    [Flags]
    public enum E_CC_Config_fault : UInt16
    {
    }
    /// Faults - 
    [SunSpecProperty(offset: 7, length: 1)]
    public E_CC_Config_fault CC_Config_fault { get; set; }
    /// [V]
    /// Absorb - 
    [SunSpecProperty(offset: 8, length: 1)]
    public UInt16 CC_Config_absorb_V { get; set; }
    /// [Tmh]
    /// Absorb Time - 
    [SunSpecProperty(offset: 9, length: 1)]
    public UInt16 CC_Config_absorb_Hr { get; set; }
    /// [A]
    /// Absorb End - 
    [SunSpecProperty(offset: 10, length: 1)]
    public UInt16 CC_Config_absorb_End_A { get; set; }
    /// [V]
    /// Rebulk - 
    [SunSpecProperty(offset: 11, length: 1)]
    public UInt16 CC_Config_rebulk_V { get; set; }
    /// [V]
    /// Float - 
    [SunSpecProperty(offset: 12, length: 1)]
    public UInt16 CC_Config_float_V { get; set; }
    /// [A]
    /// Maximum Charge - 
    [SunSpecProperty(offset: 13, length: 1)]
    public UInt16 CC_Config_max_Chg_A { get; set; }
    /// [V]
    /// Equalize - 
    [SunSpecProperty(offset: 14, length: 1)]
    public UInt16 CC_Config_equalize_V { get; set; }
    /// [Tmh]
    /// Equalize Time - 
    [SunSpecProperty(offset: 15, length: 1)]
    public UInt16 CC_Config_equalize_Hr { get; set; }
    /// [Tmd]
    /// Auto Equalize Interval - 
    [SunSpecProperty(offset: 16, length: 1)]
    public UInt16 CC_Config_auto_equalize { get; set; }
    public enum E_CC_Config_MPPT_mode : UInt16
    {
      Auto = 0,
      U_Pick = 1,
      Wind = 2,
    }
    /// MPPT mode - 
    [SunSpecProperty(offset: 17, length: 1)]
    public E_CC_Config_MPPT_mode CC_Config_MPPT_mode { get; set; }
    public enum E_CC_Config_sweep_width : UInt16
    {
      Half = 0,
      Full = 1,
    }
    /// Sweep Width - 
    [SunSpecProperty(offset: 18, length: 1)]
    public E_CC_Config_sweep_width CC_Config_sweep_width { get; set; }
    public enum E_CC_Config_sweep_max : UInt16
    {
      Eighty_Percent = 0,
      Eighty_Five_Percent = 1,
      Ninty_Percent = 2,
      Ninty_Nine_Percent = 3,
    }
    /// Sweep Maximum - 
    [SunSpecProperty(offset: 19, length: 1)]
    public E_CC_Config_sweep_max CC_Config_sweep_max { get; set; }
    /// [Pct]
    /// U-Pick PWM Duty Cycle - 
    [SunSpecProperty(offset: 20, length: 1)]
    public UInt16 CC_Config_U_Pick_Duty_cyc { get; set; }
    public enum E_CC_Config_grid_tie : UInt16
    {
      Disabled = 0,
      Enabled = 1,
    }
    /// Grid Tie Mode - 
    [SunSpecProperty(offset: 21, length: 1)]
    public E_CC_Config_grid_tie CC_Config_grid_tie { get; set; }
    public enum E_CC_Config_temp_comp : UInt16
    {
      Wide = 0,
      Limited = 1,
    }
    /// Temp Comp Mode - 
    [SunSpecProperty(offset: 22, length: 1)]
    public E_CC_Config_temp_comp CC_Config_temp_comp { get; set; }
    /// [V]
    /// Temp Comp Lower Limit - 
    [SunSpecProperty(offset: 23, length: 1)]
    public UInt16 CC_Config_temp_comp_llimt { get; set; }
    /// [V]
    /// Temp Comp Upper Limit - 
    [SunSpecProperty(offset: 24, length: 1)]
    public UInt16 CC_Config_temp_comp_hlimt { get; set; }
    public enum E_CC_Config_auto_restart : UInt16
    {
      Off = 0,
      Every_90_Minutes = 1,
      Every_90_Minutes_if_Absorb_or_Float = 2,
    }
    /// Auto Restart Mode - 
    [SunSpecProperty(offset: 25, length: 1)]
    public E_CC_Config_auto_restart CC_Config_auto_restart { get; set; }
    /// [V]
    /// Wakeup VOC Change - 
    [SunSpecProperty(offset: 26, length: 1)]
    public UInt16 CC_Config_wakeup_VOC { get; set; }
    /// [A]
    /// Snooze Mode - 
    [SunSpecProperty(offset: 27, length: 1)]
    public UInt16 CC_Config_snooze_mode_A { get; set; }
    /// [Tms]
    /// Wakeup Interval - 
    [SunSpecProperty(offset: 28, length: 1)]
    public UInt16 CC_Config_wakeup_interval { get; set; }
    public enum E_CC_Config_AUX_mode : UInt16
    {
      Float = 0,
      Diversion_Relay = 1,
      Diversion_Solid_St = 2,
      Low_Batt_Disconnect = 3,
      Remote = 4,
      Vent_Fan = 5,
      PV_Trigger = 6,
      Error_Output = 7,
      Night_Light = 8,
    }
    /// AUX Output Mode - 
    [SunSpecProperty(offset: 29, length: 1)]
    public E_CC_Config_AUX_mode CC_Config_AUX_mode { get; set; }
    public enum E_CC_Config_AUX_control : UInt16
    {
      Off = 0,
      Auto = 1,
      On = 2,
    }
    /// AUX Output Control - 
    [SunSpecProperty(offset: 30, length: 1)]
    public E_CC_Config_AUX_control CC_Config_AUX_control { get; set; }
    public enum E_CC_Config_AUX_state : UInt16
    {
      Disabled = 0,
      Enabled = 1,
    }
    /// AUX Output State - 
    [SunSpecProperty(offset: 31, length: 1)]
    public E_CC_Config_AUX_state CC_Config_AUX_state { get; set; }
    public enum E_CC_Config_AUX_polarity : UInt16
    {
      Low = 0,
      High = 1,
    }
    /// AUX Output Polarity - 
    [SunSpecProperty(offset: 32, length: 1)]
    public E_CC_Config_AUX_polarity CC_Config_AUX_polarity { get; set; }
    /// [V]
    /// AUX Low Battery Disconnect - 
    [SunSpecProperty(offset: 33, length: 1)]
    public UInt16 CC_Config_AUX_L_Batt_disc { get; set; }
    /// [V]
    /// AUX Low Battery Reconnect - 
    [SunSpecProperty(offset: 34, length: 1)]
    public UInt16 CC_Config_AUX_L_Batt_rcon { get; set; }
    /// [Tms]
    /// AUX Low Battery Disconnect Delay - 
    [SunSpecProperty(offset: 35, length: 1)]
    public UInt16 CC_Config_AUX_L_Batt_dly { get; set; }
    /// [V]
    /// AUX Vent Fan - 
    [SunSpecProperty(offset: 36, length: 1)]
    public UInt16 CC_Config_AUX_Vent_fan_V { get; set; }
    /// [V]
    /// AUX PV Trigger - 
    [SunSpecProperty(offset: 37, length: 1)]
    public UInt16 CC_Config_AUX_PV_triggerV { get; set; }
    /// [Tms]
    /// AUX PV Trigger Hold Time - 
    [SunSpecProperty(offset: 38, length: 1)]
    public UInt16 CC_Config_AUX_PV_trg_h_tm { get; set; }
    /// [V]
    /// AUX Night Light Threshold - 
    [SunSpecProperty(offset: 39, length: 1)]
    public UInt16 CC_Config_AUX_Nlite_ThrsV { get; set; }
    /// [Tmh]
    /// AUX Night Light On Time - 
    [SunSpecProperty(offset: 40, length: 1)]
    public UInt16 CC_Config_AUX_Nlite_On_tm { get; set; }
    /// [Tms]
    /// AUX Night Light On Hysteresis - 
    [SunSpecProperty(offset: 41, length: 1)]
    public UInt16 CC_Config_AUX_Nlite_On_hist { get; set; }
    /// [Tms]
    /// AUX Night Light Off Hysteresis - 
    [SunSpecProperty(offset: 42, length: 1)]
    public UInt16 CC_Config_AUX_Nlite_Off_hist { get; set; }
    /// [V]
    /// AUX Error Output Low Battery - 
    [SunSpecProperty(offset: 43, length: 1)]
    public UInt16 CC_Config_AUX_Error_batt_V { get; set; }
    /// [Tms]
    /// AUX Divert Hold Time - 
    [SunSpecProperty(offset: 44, length: 1)]
    public UInt16 CC_Config_AUX_Divert_h_time { get; set; }
    /// [Tms]
    /// AUX Divert Delay Time - 
    [SunSpecProperty(offset: 45, length: 1)]
    public UInt16 CC_Config_AUX_Divert_dly_time { get; set; }
    /// [V]
    /// AUX Divert Relative - 
    [SunSpecProperty(offset: 46, length: 1)]
    public UInt16 CC_Config_AUX_Divert_Rel_V { get; set; }
    /// [V]
    /// AUX Divert Hysteresis - 
    [SunSpecProperty(offset: 47, length: 1)]
    public UInt16 CC_Config_AUX_Divert_Hyst_V { get; set; }
    /// FM CC Major Firmware Number - 
    [SunSpecProperty(offset: 48, length: 1)]
    public UInt16 CC_Config_MajorFWRev { get; set; }
    /// FM CC Mid Firmware Number - 
    [SunSpecProperty(offset: 49, length: 1)]
    public UInt16 CC_Config_MidFWRev { get; set; }
    /// FM CC Minor Firmware Number - 
    [SunSpecProperty(offset: 50, length: 1)]
    public UInt16 CC_Config_MinorFWRev { get; set; }
    /// [Tmd]
    /// Set Data Log Day Offset - 
    [SunSpecProperty(offset: 51, length: 1)]
    public UInt16 CC_Config_DataLog_Day_offset { get; set; }
    /// [Tmd]
    /// Current Data Log Day Offset - 
    [SunSpecProperty(offset: 52, length: 1)]
    public UInt16 CC_Config_DataLog_Cur_Day_off { get; set; }
    /// [Ah]
    /// Data Log Daily (Ah) - 
    [SunSpecProperty(offset: 53, length: 1)]
    public UInt16 CC_Config_DataLog_Daily_AH { get; set; }
    /// [kWh]
    /// Data Log Daily (kWh) - 
    [SunSpecProperty(offset: 54, length: 1)]
    public UInt16 CC_Config_DataLog_Daily_KWH { get; set; }
    /// [A]
    /// Data Log Daily Maximum Output (A) - 
    [SunSpecProperty(offset: 55, length: 1)]
    public UInt16 CC_Config_DataLog_Max_Out_A { get; set; }
    /// [W]
    /// Data Log Daily Maximum Output (W) - 
    [SunSpecProperty(offset: 56, length: 1)]
    public UInt16 CC_Config_DataLog_Max_Out_W { get; set; }
    /// [Tms]
    /// Data Log Daily Absorb Time - 
    [SunSpecProperty(offset: 57, length: 1)]
    public UInt16 CC_Config_DataLog_Absorb_T { get; set; }
    /// [Tms]
    /// Data Log Daily Float Time - 
    [SunSpecProperty(offset: 58, length: 1)]
    public UInt16 CC_Config_DataLog_Float_T { get; set; }
    /// [V]
    /// Data Log Daily Minimum Battery - 
    [SunSpecProperty(offset: 59, length: 1)]
    public UInt16 CC_Config_DataLog_Min_Batt_V { get; set; }
    /// [V]
    /// Data Log Daily Maximum Battery - 
    [SunSpecProperty(offset: 60, length: 1)]
    public UInt16 CC_Config_DataLog_Max_Batt_V { get; set; }
    /// [V]
    /// Data Log Daily Maximum Input - 
    [SunSpecProperty(offset: 61, length: 1)]
    public UInt16 CC_Config_DataLog_Max_Input_V { get; set; }
    /// Data Log Clear - 
    [SunSpecProperty(offset: 62, length: 1)]
    public UInt16 CC_Config_DataLog_Clear { get; set; }
    /// Data Log Clear Complement - 
    [SunSpecProperty(offset: 63, length: 1)]
    public UInt16 CC_Config_DataLog_Clr_Comp { get; set; }
  }
}
