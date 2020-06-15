using System;

{
  /// Inverter controls extended settings 
  [SunSpecModel(id: 145, length: 8)]
  public class ExtSettings
  {
    /// [Pct]
    /// Ramp Up Rate - Ramp up rate as a percentage of max current.
    /// Ramp up rate as a percentage of max current.
    [SunSpecProperty(offset: 0, length: 1)]
    public UInt16? NomRmpUpRte { get; set; }
    /// [Pct]
    /// NomRmpDnRte - Ramp down rate as a percentage of max current.
    /// Ramp down rate as a percentage of max current.
    [SunSpecProperty(offset: 1, length: 1)]
    public UInt16? NomRmpDnRte { get; set; }
    /// [Pct]
    /// Emergency Ramp Up Rate - Emergency ramp up rate as a percentage of max current.
    /// Emergency ramp up rate as a percentage of max current.
    [SunSpecProperty(offset: 2, length: 1)]
    public UInt16? EmgRmpUpRte { get; set; }
    /// [Pct]
    /// Emergency Ramp Down Rate - Emergency ramp down rate as a percentage of max current.
    /// Emergency ramp down rate as a percentage of max current.
    [SunSpecProperty(offset: 3, length: 1)]
    public UInt16? EmgRmpDnRte { get; set; }
    /// [Pct]
    /// Connect Ramp Up Rate - Connect ramp up rate as a percentage of max current.
    /// Connect ramp up rate as a percentage of max current.
    [SunSpecProperty(offset: 4, length: 1)]
    public UInt16? ConnRmpUpRte { get; set; }
    /// [Pct]
    /// Connect Ramp Down Rate - Connect ramp down rate as a percentage of max current.
    /// Connect ramp down rate as a percentage of max current.
    [SunSpecProperty(offset: 5, length: 1)]
    public UInt16? ConnRmpDnRte { get; set; }
    /// [Pct]
    /// Default Ramp Rate - Ramp rate specified in percent of max current.
    /// Ramp rate specified in percent of max current.
    [SunSpecProperty(offset: 6, length: 1)]
    public UInt16? AGra { get; set; }
    /// Ramp Rate Scale Factor - Ramp Rate Scale Factor
    /// Ramp Rate Scale Factor
    [SunSpecProperty(offset: 7, length: 1)]
    public Int16? Rmp_SF { get; private set; }
  }
}
