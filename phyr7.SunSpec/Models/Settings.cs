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
  /// Inverter Controls Basic Settings 
  /// NOTES: Ref 3: 8.4.2.1, Ref 4: 17
  [SunSpecModel(id: 121, length: 30)]
  public struct Settings
  {
    /// [W]
    /// WMax - Setting for maximum power output. Default to WRtg.
    /// Setting for maximum power output. Default to WRtg.
    [SunSpecProperty(offset: 0, length: 1)]
    public UInt16 WMax { get; set; }
    /// [V]
    /// VRef - Voltage at the PCC.
    /// Voltage at the PCC.
    [SunSpecProperty(offset: 1, length: 1)]
    public UInt16 VRef { get; set; }
    /// [V]
    /// VRefOfs - Offset  from PCC to inverter.
    /// Offset  from PCC to inverter.
    [SunSpecProperty(offset: 2, length: 1)]
    public Int16 VRefOfs { get; set; }
    /// [V]
    /// VMax - Setpoint for maximum voltage.
    /// Setpoint for maximum voltage.
    [SunSpecProperty(offset: 3, length: 1)]
    public UInt16? VMax { get; set; }
    /// [V]
    /// VMin - Setpoint for minimum voltage.
    /// Setpoint for minimum voltage.
    [SunSpecProperty(offset: 4, length: 1)]
    public UInt16? VMin { get; set; }
    /// [VA]
    /// VAMax - Setpoint for maximum apparent power. Default to VARtg.
    /// Setpoint for maximum apparent power. Default to VARtg.
    [SunSpecProperty(offset: 5, length: 1)]
    public UInt16? VAMax { get; set; }
    /// [var]
    /// VArMaxQ1 - Setting for maximum reactive power in quadrant 1. Default to VArRtgQ1.
    /// Setting for maximum reactive power in quadrant 1. Default to VArRtgQ1.
    [SunSpecProperty(offset: 6, length: 1)]
    public Int16? VArMaxQ1 { get; set; }
    /// [var]
    /// VArMaxQ2 - Setting for maximum reactive power in quadrant 2. Default to VArRtgQ2.
    /// Setting for maximum reactive power in quadrant 2. Default to VArRtgQ2.
    [SunSpecProperty(offset: 7, length: 1)]
    public Int16? VArMaxQ2 { get; set; }
    /// [var]
    /// VArMaxQ3 - Setting for maximum reactive power in quadrant 3. Default to VArRtgQ3.
    /// Setting for maximum reactive power in quadrant 3. Default to VArRtgQ3.
    [SunSpecProperty(offset: 8, length: 1)]
    public Int16? VArMaxQ3 { get; set; }
    /// [var]
    /// VArMaxQ4 - Setting for maximum reactive power in quadrant 4. Default to VArRtgQ4.
    /// Setting for maximum reactive power in quadrant 4. Default to VArRtgQ4.
    [SunSpecProperty(offset: 9, length: 1)]
    public Int16? VArMaxQ4 { get; set; }
    /// [% WMax/sec]
    /// WGra - Default ramp rate of change of active power due to command or internal action.
    /// Default ramp rate of change of active power due to command or internal action.
    [SunSpecProperty(offset: 10, length: 1)]
    public UInt16? WGra { get; set; }
    /// [cos()]
    /// PFMinQ1 - Setpoint for minimum power factor value in quadrant 1. Default to PFRtgQ1.
    /// Setpoint for minimum power factor value in quadrant 1. Default to PFRtgQ1.
    /// NOTES: EEI sign convention.
    [SunSpecProperty(offset: 11, length: 1)]
    public Int16? PFMinQ1 { get; set; }
    /// [cos()]
    /// PFMinQ2 - Setpoint for minimum power factor value in quadrant 2. Default to PFRtgQ2.
    /// Setpoint for minimum power factor value in quadrant 2. Default to PFRtgQ2.
    /// NOTES: EEI sign convention. 
    [SunSpecProperty(offset: 12, length: 1)]
    public Int16? PFMinQ2 { get; set; }
    /// [cos()]
    /// PFMinQ3 - Setpoint for minimum power factor value in quadrant 3. Default to PFRtgQ3.
    /// Setpoint for minimum power factor value in quadrant 3. Default to PFRtgQ3.
    /// NOTES: EEI sign convention. 
    [SunSpecProperty(offset: 13, length: 1)]
    public Int16? PFMinQ3 { get; set; }
    /// [cos()]
    /// PFMinQ4 - Setpoint for minimum power factor value in quadrant 4. Default to PFRtgQ4.
    /// Setpoint for minimum power factor value in quadrant 4. Default to PFRtgQ4.
    /// NOTES: EEI sign convention. 
    [SunSpecProperty(offset: 14, length: 1)]
    public Int16? PFMinQ4 { get; set; }
    public enum E_VArAct : UInt16
    {
      SWITCH = 1,
      MAINTAIN = 2,
    }
    /// VArAct - VAR action on change between charging and discharging: 1=switch 2=maintain VAR characterization.
    /// VAR action on change between charging and discharging: 1=switch 2=maintain VAR characterization.
    [SunSpecProperty(offset: 15, length: 1)]
    public E_VArAct? VArAct { get; set; }
    public enum E_ClcTotVA : UInt16
    {
      VECTOR = 1,
      ARITHMETIC = 2,
    }
    /// ClcTotVA - Calculation method for total apparent power. 1=vector 2=arithmetic.
    /// Calculation method for total apparent power. 1=vector 2=arithmetic.
    [SunSpecProperty(offset: 16, length: 1)]
    public E_ClcTotVA? ClcTotVA { get; set; }
    /// [% WGra]
    /// MaxRmpRte - Setpoint for maximum ramp rate as percentage of nominal maximum ramp rate. This setting will limit the rate that watts delivery to the grid can increase or decrease in response to intermittent PV generation.
    /// Setpoint for maximum ramp rate as percentage of nominal maximum ramp rate. This setting will limit the rate that watts delivery to the grid can increase or decrease in response to intermittent PV generation.
    [SunSpecProperty(offset: 17, length: 1)]
    public UInt16? MaxRmpRte { get; set; }
    /// [Hz]
    /// ECPNomHz - Setpoint for nominal frequency at the ECP.
    /// Setpoint for nominal frequency at the ECP.
    [SunSpecProperty(offset: 18, length: 1)]
    public UInt16? ECPNomHz { get; set; }
    public enum E_ConnPh : UInt16
    {
      A = 1,
      B = 2,
      C = 3,
    }
    /// ConnPh - Identity of connected phase for single phase inverters. A=1 B=2 C=3.
    /// Identity of connected phase for single phase inverters. A=1 B=2 C=3.
    [SunSpecProperty(offset: 19, length: 1)]
    public E_ConnPh? ConnPh { get; set; }
    /// WMax_SF - Scale factor for real power.
    /// Scale factor for real power.
    [SunSpecProperty(offset: 20, length: 1)]
    public Int16 WMax_SF { get; private set; }
    /// VRef_SF - Scale factor for voltage at the PCC.
    /// Scale factor for voltage at the PCC.
    [SunSpecProperty(offset: 21, length: 1)]
    public Int16 VRef_SF { get; private set; }
    /// VRefOfs_SF - Scale factor for offset voltage.
    /// Scale factor for offset voltage.
    [SunSpecProperty(offset: 22, length: 1)]
    public Int16 VRefOfs_SF { get; private set; }
    /// VMinMax_SF - Scale factor for min/max voltages.
    /// Scale factor for min/max voltages.
    [SunSpecProperty(offset: 23, length: 1)]
    public Int16? VMinMax_SF { get; private set; }
    /// VAMax_SF - Scale factor for apparent power.
    /// Scale factor for apparent power.
    [SunSpecProperty(offset: 24, length: 1)]
    public Int16? VAMax_SF { get; private set; }
    /// VArMax_SF - Scale factor for reactive power.
    /// Scale factor for reactive power.
    [SunSpecProperty(offset: 25, length: 1)]
    public Int16? VArMax_SF { get; private set; }
    /// WGra_SF - Scale factor for default ramp rate.
    /// Scale factor for default ramp rate.
    [SunSpecProperty(offset: 26, length: 1)]
    public Int16? WGra_SF { get; private set; }
    /// PFMin_SF - Scale factor for minimum power factor.
    /// Scale factor for minimum power factor.
    [SunSpecProperty(offset: 27, length: 1)]
    public Int16? PFMin_SF { get; private set; }
    /// MaxRmpRte_SF - Scale factor for maximum ramp percentage.
    /// Scale factor for maximum ramp percentage.
    [SunSpecProperty(offset: 28, length: 1)]
    public Int16? MaxRmpRte_SF { get; private set; }
    /// ECPNomHz_SF - Scale factor for nominal frequency.
    /// Scale factor for nominal frequency.
    [SunSpecProperty(offset: 29, length: 1)]
    public Int16? ECPNomHz_SF { get; private set; }
  }
}
