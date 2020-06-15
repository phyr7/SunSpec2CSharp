using System;

{
  /// Inverter Controls Nameplate Ratings 
  /// NOTES: Ref 3: 8.14.3.2, Ref 4: 17
  [SunSpecModel(id: 120, length: 26)]
  public class Nameplate
  {
    public enum E_DERTyp : UInt16
    {
      PV = 4,
      PV_STOR = 82,
    }
    /// DERTyp - Type of DER device. Default value is 4 to indicate PV device.
    /// Type of DER device. Default value is 4 to indicate PV device.
    [SunSpecProperty(offset: 0, length: 1)]
    public E_DERTyp DERTyp { get; private set; }
    /// [W]
    /// WRtg - Continuous power output capability of the inverter.
    /// Continuous power output capability of the inverter.
    [SunSpecProperty(offset: 1, length: 1)]
    public UInt16 WRtg { get; private set; }
    /// WRtg_SF - Scale factor
    /// Scale factor
    [SunSpecProperty(offset: 2, length: 1)]
    public Int16 WRtg_SF { get; private set; }
    /// [VA]
    /// VARtg - Continuous Volt-Ampere capability of the inverter.
    /// Continuous Volt-Ampere capability of the inverter.
    [SunSpecProperty(offset: 3, length: 1)]
    public UInt16 VARtg { get; private set; }
    /// VARtg_SF - Scale factor
    /// Scale factor
    [SunSpecProperty(offset: 4, length: 1)]
    public Int16 VARtg_SF { get; private set; }
    /// [var]
    /// VArRtgQ1 - Continuous VAR capability of the inverter in quadrant 1.
    /// Continuous VAR capability of the inverter in quadrant 1.
    [SunSpecProperty(offset: 5, length: 1)]
    public Int16 VArRtgQ1 { get; private set; }
    /// [var]
    /// VArRtgQ2 - Continuous VAR capability of the inverter in quadrant 2.
    /// Continuous VAR capability of the inverter in quadrant 2.
    [SunSpecProperty(offset: 6, length: 1)]
    public Int16 VArRtgQ2 { get; private set; }
    /// [var]
    /// VArRtgQ3 - Continuous VAR capability of the inverter in quadrant 3.
    /// Continuous VAR capability of the inverter in quadrant 3.
    [SunSpecProperty(offset: 7, length: 1)]
    public Int16 VArRtgQ3 { get; private set; }
    /// [var]
    /// VArRtgQ4 - Continuous VAR capability of the inverter in quadrant 4.
    /// Continuous VAR capability of the inverter in quadrant 4.
    [SunSpecProperty(offset: 8, length: 1)]
    public Int16 VArRtgQ4 { get; private set; }
    /// VArRtg_SF - Scale factor
    /// Scale factor
    [SunSpecProperty(offset: 9, length: 1)]
    public Int16 VArRtg_SF { get; private set; }
    /// [A]
    /// ARtg - Maximum RMS AC current level capability of the inverter.
    /// Maximum RMS AC current level capability of the inverter.
    /// NOTES: Sum of all connected phases.  Current rating under nominal voltage under nominal power factor.
    [SunSpecProperty(offset: 10, length: 1)]
    public UInt16 ARtg { get; private set; }
    /// ARtg_SF - Scale factor
    /// Scale factor
    [SunSpecProperty(offset: 11, length: 1)]
    public Int16 ARtg_SF { get; private set; }
    /// [cos()]
    /// PFRtgQ1 - Minimum power factor capability of the inverter in quadrant 1.
    /// Minimum power factor capability of the inverter in quadrant 1.
    /// NOTES: EEI sign convention.
    [SunSpecProperty(offset: 12, length: 1)]
    public Int16 PFRtgQ1 { get; private set; }
    /// [cos()]
    /// PFRtgQ2 - Minimum power factor capability of the inverter in quadrant 2.
    /// Minimum power factor capability of the inverter in quadrant 2.
    /// NOTES: EEI sign convention.
    [SunSpecProperty(offset: 13, length: 1)]
    public Int16 PFRtgQ2 { get; private set; }
    /// [cos()]
    /// PFRtgQ3 - Minimum power factor capability of the inverter in quadrant 3.
    /// Minimum power factor capability of the inverter in quadrant 3.
    /// NOTES: EEI sign convention.
    [SunSpecProperty(offset: 14, length: 1)]
    public Int16 PFRtgQ3 { get; private set; }
    /// [cos()]
    /// PFRtgQ4 - Minimum power factor capability of the inverter in quadrant 4.
    /// Minimum power factor capability of the inverter in quadrant 4.
    /// NOTES: EEI sign convention.
    [SunSpecProperty(offset: 15, length: 1)]
    public Int16 PFRtgQ4 { get; private set; }
    /// PFRtg_SF - Scale factor
    /// Scale factor
    [SunSpecProperty(offset: 16, length: 1)]
    public Int16 PFRtg_SF { get; private set; }
    /// [Wh]
    /// WHRtg - Nominal energy rating of storage device.
    /// Nominal energy rating of storage device.
    [SunSpecProperty(offset: 17, length: 1)]
    public UInt16? WHRtg { get; private set; }
    /// WHRtg_SF - Scale factor
    /// Scale factor
    [SunSpecProperty(offset: 18, length: 1)]
    public Int16? WHRtg_SF { get; private set; }
    /// [AH]
    /// AhrRtg - The usable capacity of the battery.  Maximum charge minus minimum charge from a technology capability perspective (Amp-hour capacity rating).
    /// The usable capacity of the battery.  Maximum charge minus minimum charge from a technology capability perspective (Amp-hour capacity rating).
    [SunSpecProperty(offset: 19, length: 1)]
    public UInt16? AhrRtg { get; private set; }
    /// AhrRtg_SF - Scale factor for amp-hour rating.
    /// Scale factor for amp-hour rating.
    [SunSpecProperty(offset: 20, length: 1)]
    public Int16? AhrRtg_SF { get; private set; }
    /// [W]
    /// MaxChaRte - Maximum rate of energy transfer into the storage device.
    /// Maximum rate of energy transfer into the storage device.
    [SunSpecProperty(offset: 21, length: 1)]
    public UInt16? MaxChaRte { get; private set; }
    /// MaxChaRte_SF - Scale factor
    /// Scale factor
    [SunSpecProperty(offset: 22, length: 1)]
    public Int16? MaxChaRte_SF { get; private set; }
    /// [W]
    /// MaxDisChaRte - Maximum rate of energy transfer out of the storage device.
    /// Maximum rate of energy transfer out of the storage device.
    [SunSpecProperty(offset: 23, length: 1)]
    public UInt16? MaxDisChaRte { get; private set; }
    /// MaxDisChaRte_SF - Scale factor
    /// Scale factor
    [SunSpecProperty(offset: 24, length: 1)]
    public Int16? MaxDisChaRte_SF { get; private set; }
    /// Pad - Pad register.
    /// Pad register.
    [SunSpecProperty(offset: 25, length: 1)]
    public UInt16? Pad { get; private set; }
  }
}
