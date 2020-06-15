using System;

{
  [SunSpecModel(id: 64020, length: 46)]
  public class MersenGreenString
  {
    /// [C]
    /// Aux 0 temperature - 
    [SunSpecProperty(offset: 0, length: 1)]
    public Int16? Aux0Tmp { get; set; }
    /// [C]
    /// Aux 1 temperature - 
    [SunSpecProperty(offset: 1, length: 1)]
    public Int16? Aux1Tmp { get; set; }
    /// [C]
    /// Aux 2 temperature - 
    [SunSpecProperty(offset: 2, length: 1)]
    public Int16? Aux2Tmp { get; set; }
    /// [C]
    /// Aux 3 temperature - 
    [SunSpecProperty(offset: 3, length: 1)]
    public Int16? Aux3Tmp { get; set; }
    /// [C]
    /// Aux 4 temperature - 
    [SunSpecProperty(offset: 4, length: 1)]
    public Int16? Aux4Tmp { get; set; }
    /// [C]
    /// Probe Temperature - 
    [SunSpecProperty(offset: 6, length: 1)]
    public Int16 ProbeTmp { get; set; }
    /// [C]
    /// Main Temperature - 
    [SunSpecProperty(offset: 5, length: 1)]
    public Int16 MainTmp { get; set; }
    /// Voltage scale factor for the sensors - 
    [SunSpecProperty(offset: 7, length: 1)]
    public Int16 SensorV_SF { get; set; }
    /// Current scale factor for the sensors - 
    [SunSpecProperty(offset: 8, length: 1)]
    public Int16 SensorA_SF { get; set; }
    /// Frequency scale factor for the sensors - 
    [SunSpecProperty(offset: 9, length: 1)]
    public Int16 SensorHz_SF { get; set; }
    /// [V]
    /// Sensor1 Voltage - scale of 0-10V
    /// scale of 0-10V
    [SunSpecProperty(offset: 10, length: 1)]
    public Int16? Sensor1Voltage { get; set; }
    /// [V]
    /// Sensor2 Voltage - scale of 0-10V
    /// scale of 0-10V
    [SunSpecProperty(offset: 11, length: 1)]
    public Int16? Sensor2Voltage { get; set; }
    /// [V]
    /// Sensor3 Voltage - scale of 0-10V
    /// scale of 0-10V
    [SunSpecProperty(offset: 12, length: 1)]
    public Int16? Sensor3Voltage { get; set; }
    /// [V]
    /// Sensor4 Voltage - scale of 0-10V
    /// scale of 0-10V
    [SunSpecProperty(offset: 13, length: 1)]
    public Int16? Sensor4Voltage { get; set; }
    /// [V]
    /// Sensor5 Voltage - scale of 0-10V
    /// scale of 0-10V
    [SunSpecProperty(offset: 14, length: 1)]
    public Int16? Sensor5Voltage { get; set; }
    /// [V]
    /// Sensor6 Voltage - scale of 0-10V
    /// scale of 0-10V
    [SunSpecProperty(offset: 15, length: 1)]
    public Int16? Sensor6Voltage { get; set; }
    /// [V]
    /// Sensor7 Voltage - scale of 0-10V
    /// scale of 0-10V
    [SunSpecProperty(offset: 16, length: 1)]
    public Int16? Sensor7Voltage { get; set; }
    /// [A]
    /// Sensor1 Current - scale of 4-20mA
    /// scale of 4-20mA
    [SunSpecProperty(offset: 17, length: 1)]
    public Int16? Sensor1Current { get; set; }
    /// [A]
    /// Sensor2 Current - in 4-20mA or 4-20mA
    /// in 4-20mA or 4-20mA
    [SunSpecProperty(offset: 18, length: 1)]
    public Int16? Sensor2Current { get; set; }
    /// [A]
    /// Sensor3 Current - in 4-20mA or 4-20mA
    /// in 4-20mA or 4-20mA
    [SunSpecProperty(offset: 19, length: 1)]
    public Int16? Sensor3Current { get; set; }
    /// [A]
    /// Sensor4 Current - in 4-20mA or 4-20mA
    /// in 4-20mA or 4-20mA
    [SunSpecProperty(offset: 20, length: 1)]
    public Int16? Sensor4Current { get; set; }
    /// [A]
    /// Sensor5 Current - in 4-20mA or 4-20mA
    /// in 4-20mA or 4-20mA
    [SunSpecProperty(offset: 21, length: 1)]
    public Int16? Sensor5Current { get; set; }
    /// [A]
    /// Sensor6 Current - in 4-20mA or 4-20mA
    /// in 4-20mA or 4-20mA
    [SunSpecProperty(offset: 22, length: 1)]
    public Int16? Sensor6Current { get; set; }
    /// [A]
    /// Sensor7 Current - in 4-20mA or 4-20mA
    /// in 4-20mA or 4-20mA
    [SunSpecProperty(offset: 23, length: 1)]
    public Int16? Sensor7Current { get; set; }
    /// [Hz]
    /// Sensor8 frequency - frequency in Hz
    /// frequency in Hz
    [SunSpecProperty(offset: 24, length: 1)]
    public UInt16? Sensor8 { get; set; }
    /// Relay 1 state - 
    [SunSpecProperty(offset: 25, length: 1)]
    public UInt16? Relay1 { get; set; }
    /// Relay 2 state - 
    [SunSpecProperty(offset: 26, length: 1)]
    public UInt16? Relay2 { get; set; }
    /// Relay 3 state - 
    [SunSpecProperty(offset: 27, length: 1)]
    public UInt16? Relay3 { get; set; }
    /// Reset the accumulators - always 0 in reading, used the code 0xC0DA during the writing for resetting them
    /// always 0 in reading, used the code 0xC0DA during the writing for resetting them
    [SunSpecProperty(offset: 28, length: 1)]
    public UInt16? ResetAccumulators { get; set; }
    /// Reset the system - always 0 in reading, used the code 0xC0DA during the writing for resetting the system
    /// always 0 in reading, used the code 0xC0DA during the writing for resetting the system
    [SunSpecProperty(offset: 29, length: 1)]
    public UInt16? Reset { get; set; }
    public struct 
    {
      /// Serial number - strings of 16 characters
      /// strings of 16 characters
      [SunSpecProperty(offset: 0, length: 9)]
      public String SerialNumber { get; set; }
      /// Firmware version - string of 11 characters
      /// string of 11 characters
      [SunSpecProperty(offset: 9, length: 6)]
      public String Firmware { get; set; }
      /// Hardware version - 
      [SunSpecProperty(offset: 15, length: 1)]
      public UInt16 Hardware { get; set; }
    }[];
  }
}
