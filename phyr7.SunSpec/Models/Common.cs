using System;

{
  /// All SunSpec compliant devices must include this as the first model
  [SunSpecModel(id: 1, length: 66)]
  public class Common
  {
    /// Manufacturer - Well known value registered with SunSpec for compliance
    /// Well known value registered with SunSpec for compliance
    [SunSpecProperty(offset: 0, length: 16)]
    public String Mn { get; set; }
    /// Model - Manufacturer specific value (32 chars)
    /// Manufacturer specific value (32 chars)
    [SunSpecProperty(offset: 16, length: 16)]
    public String Md { get; set; }
    /// Options - Manufacturer specific value (16 chars)
    /// Manufacturer specific value (16 chars)
    [SunSpecProperty(offset: 32, length: 8)]
    public String? Opt { get; set; }
    /// Version - Manufacturer specific value (16 chars)
    /// Manufacturer specific value (16 chars)
    [SunSpecProperty(offset: 40, length: 8)]
    public String? Vr { get; set; }
    /// Serial Number - Manufacturer specific value (32 chars)
    /// Manufacturer specific value (32 chars)
    [SunSpecProperty(offset: 48, length: 16)]
    public String SN { get; set; }
    /// Device Address - Modbus device address
    /// Modbus device address
    [SunSpecProperty(offset: 64, length: 1)]
    public UInt16? DA { get; set; }
    /// Force even alignment
    [SunSpecProperty(offset: 65, length: 1)]
    public UInt16? Pad { get; private set; }
  }
}
