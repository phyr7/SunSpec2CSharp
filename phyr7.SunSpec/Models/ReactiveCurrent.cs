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
  /// Dynamic Reactive Current 
  /// NOTES: Ref 3: 8.10.1.2; Ref 4: 12
  [SunSpecModel(id: 128, length: 14)]
  public struct ReactiveCurrent
  {
    public enum E_ArGraMod : UInt16
    {
      EDGE = 0,
      CENTER = 1,
    }
    /// ArGraMod - Indicates if gradients trend toward zero at the edges of the deadband or trend toward zero at the center of the deadband.
    /// Indicates if gradients trend toward zero at the edges of the deadband or trend toward zero at the center of the deadband.
    [SunSpecProperty(offset: 0, length: 1)]
    public E_ArGraMod ArGraMod { get; set; }
    /// [%ARtg/%dV]
    /// ArGraSag - The gradient used to increase capacitive dynamic current. A value of 0 indicates no additional reactive current support.
    /// The gradient used to increase capacitive dynamic current. A value of 0 indicates no additional reactive current support.
    [SunSpecProperty(offset: 1, length: 1)]
    public UInt16 ArGraSag { get; set; }
    /// [%ARtg/%dV]
    /// ArGraSwell - The gradient used to increase inductive dynamic current.  A value of 0 indicates no additional reactive current support.
    /// The gradient used to increase inductive dynamic current.  A value of 0 indicates no additional reactive current support.
    [SunSpecProperty(offset: 2, length: 1)]
    public UInt16 ArGraSwell { get; set; }
    [Flags]
    public enum E_ModEna : UInt16
    {
      ENABLED = 0,
    }
    /// ModEna - Activate dynamic reactive current model
    /// Activate dynamic reactive current model
    [SunSpecProperty(offset: 3, length: 1)]
    public E_ModEna ModEna { get; set; }
    /// [Secs]
    /// FilTms - The time window used to calculate the moving average voltage.
    /// The time window used to calculate the moving average voltage.
    [SunSpecProperty(offset: 4, length: 1)]
    public UInt16? FilTms { get; set; }
    /// [% VRef]
    /// DbVMin - The lower delta voltage limit for which negative voltage deviations less than this value no dynamic vars are produced.
    /// The lower delta voltage limit for which negative voltage deviations less than this value no dynamic vars are produced.
    [SunSpecProperty(offset: 5, length: 1)]
    public UInt16? DbVMin { get; set; }
    /// [% VRef]
    /// DbVMax - The upper delta voltage limit for which positive voltage deviations less than this value no dynamic current produced.
    /// The upper delta voltage limit for which positive voltage deviations less than this value no dynamic current produced.
    [SunSpecProperty(offset: 6, length: 1)]
    public UInt16? DbVMax { get; set; }
    /// [% VRef]
    /// BlkZnV - Block zone voltage which defines a lower voltage boundary below which no dynamic current is produced.
    /// Block zone voltage which defines a lower voltage boundary below which no dynamic current is produced.
    [SunSpecProperty(offset: 7, length: 1)]
    public UInt16? BlkZnV { get; set; }
    /// [% VRef]
    /// HysBlkZnV - Hysteresis voltage used with BlkZnV.
    /// Hysteresis voltage used with BlkZnV.
    [SunSpecProperty(offset: 8, length: 1)]
    public UInt16? HysBlkZnV { get; set; }
    /// [mSecs]
    /// BlkZnTmms - Block zone time the time before which reactive current support remains active regardless of how low the voltage drops.
    /// Block zone time the time before which reactive current support remains active regardless of how low the voltage drops.
    [SunSpecProperty(offset: 9, length: 1)]
    public UInt16? BlkZnTmms { get; set; }
    /// [mSecs]
    /// HoldTmms - Hold time during which reactive current support continues after the average voltage has entered the dead zone.
    /// Hold time during which reactive current support continues after the average voltage has entered the dead zone.
    [SunSpecProperty(offset: 10, length: 1)]
    public UInt16? HoldTmms { get; set; }
    /// ArGra_SF - Scale factor for the gradients.
    /// Scale factor for the gradients.
    [SunSpecProperty(offset: 11, length: 1)]
    public Int16 ArGra_SF { get; private set; }
    /// VRefPct_SF - Scale factor for the voltage zone and limit settings.
    /// Scale factor for the voltage zone and limit settings.
    [SunSpecProperty(offset: 12, length: 1)]
    public Int16? VRefPct_SF { get; private set; }
    [SunSpecProperty(offset: 13, length: 1)]
    public UInt16? Pad { get; private set; }
  }
}
