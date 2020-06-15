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
  /// Static Volt-VAR Arrays 
  /// NOTES: Ref 3: 8.8.1.2
  [SunSpecModel(id: 126, length: 64)]
  public struct VoltVar
  {
    /// ActCrv - Index of active curve. 0=no active curve.
    /// Index of active curve. 0=no active curve.
    [SunSpecProperty(offset: 0, length: 1)]
    public UInt16 ActCrv { get; set; }
    [Flags]
    public enum E_ModEna : UInt16
    {
      ENABLED = 0,
    }
    /// ModEna - Is Volt-VAR control active.
    /// Is Volt-VAR control active.
    [SunSpecProperty(offset: 1, length: 1)]
    public E_ModEna ModEna { get; set; }
    /// [Secs]
    /// WinTms - Time window for volt-VAR change.
    /// Time window for volt-VAR change.
    [SunSpecProperty(offset: 2, length: 1)]
    public UInt16? WinTms { get; set; }
    /// [Secs]
    /// RvrtTms - Timeout period for volt-VAR curve selection.
    /// Timeout period for volt-VAR curve selection.
    [SunSpecProperty(offset: 3, length: 1)]
    public UInt16? RvrtTms { get; set; }
    /// [Secs]
    /// RmpTms - Ramp time for moving from current mode to new mode.
    /// Ramp time for moving from current mode to new mode.
    [SunSpecProperty(offset: 4, length: 1)]
    public UInt16? RmpTms { get; set; }
    /// NCrv - Number of curves supported (recommend 4).
    /// Number of curves supported (recommend 4).
    [SunSpecProperty(offset: 5, length: 1)]
    public UInt16 NCrv { get; private set; }
    /// NPt - Number of curve points supported (maximum of 20).
    /// Number of curve points supported (maximum of 20).
    [SunSpecProperty(offset: 6, length: 1)]
    public UInt16 NPt { get; private set; }
    /// V_SF - Scale factor for percent VRef.
    /// Scale factor for percent VRef.
    [SunSpecProperty(offset: 7, length: 1)]
    public Int16 V_SF { get; private set; }
    /// DeptRef_SF - scale factor for dependent variable.
    /// scale factor for dependent variable.
    [SunSpecProperty(offset: 8, length: 1)]
    public Int16 DeptRef_SF { get; private set; }
    [SunSpecProperty(offset: 9, length: 1)]
    public Int16? RmpIncDec_SF { get; private set; }
    public struct S_Curve
    {
      /// ActPt - Number of active points in array.
      /// Number of active points in array.
      [SunSpecProperty(offset: 0, length: 1)]
      public UInt16 ActPt { get; set; }
      public enum E_DeptRef : UInt16
      {
        WMax = 1,
        VArMax = 2,
        VArAval = 3,
      }
      /// DeptRef - Meaning of dependent variable: 1=%WMax 2=%VArMax 3=%VArAval.
      /// Meaning of dependent variable: 1=%WMax 2=%VArMax 3=%VArAval.
      [SunSpecProperty(offset: 1, length: 1)]
      public E_DeptRef DeptRef { get; set; }
      /// [% VRef]
      /// V1 - Point 1 Volts.
      /// Point 1 Volts.
      [SunSpecProperty(offset: 2, length: 1)]
      public UInt16 V1 { get; set; }
      /// VAr1 - Point 1 VARs.
      /// Point 1 VARs.
      [SunSpecProperty(offset: 3, length: 1)]
      public Int16 VAr1 { get; set; }
      /// [% VRef]
      /// V2 - Point 2 Volts.
      /// Point 2 Volts.
      [SunSpecProperty(offset: 4, length: 1)]
      public UInt16? V2 { get; set; }
      /// VAr2 - Point 2 VARs.
      /// Point 2 VARs.
      [SunSpecProperty(offset: 5, length: 1)]
      public Int16? VAr2 { get; set; }
      /// [% VRef]
      /// V3 - Point 2 Volts.
      /// Point 2 Volts.
      [SunSpecProperty(offset: 6, length: 1)]
      public UInt16? V3 { get; set; }
      /// VAr3 - Point 3 VARs.
      /// Point 3 VARs.
      [SunSpecProperty(offset: 7, length: 1)]
      public Int16? VAr3 { get; set; }
      /// [% VRef]
      /// V4 - Point 4 Volts.
      /// Point 4 Volts.
      [SunSpecProperty(offset: 8, length: 1)]
      public UInt16? V4 { get; set; }
      /// VAr4 - Point 4 VARs.
      /// Point 4 VARs.
      [SunSpecProperty(offset: 9, length: 1)]
      public Int16? VAr4 { get; set; }
      /// [% VRef]
      /// V5 - Point 5 Volts.
      /// Point 5 Volts.
      [SunSpecProperty(offset: 10, length: 1)]
      public UInt16? V5 { get; set; }
      /// VAr5 - Point 5 VARs.
      /// Point 5 VARs.
      [SunSpecProperty(offset: 11, length: 1)]
      public Int16? VAr5 { get; set; }
      /// [% VRef]
      /// V6 - Point 6 Volts.
      /// Point 6 Volts.
      [SunSpecProperty(offset: 12, length: 1)]
      public UInt16? V6 { get; set; }
      /// VAr6 - Point 6 VARs.
      /// Point 6 VARs.
      [SunSpecProperty(offset: 13, length: 1)]
      public Int16? VAr6 { get; set; }
      /// [% VRef]
      /// V7 - Point 7 Volts.
      /// Point 7 Volts.
      [SunSpecProperty(offset: 14, length: 1)]
      public UInt16? V7 { get; set; }
      /// VAr7 - Point 7 VARs.
      /// Point 7 VARs.
      [SunSpecProperty(offset: 15, length: 1)]
      public Int16? VAr7 { get; set; }
      /// [% VRef]
      /// V8 - Point 8 Volts.
      /// Point 8 Volts.
      [SunSpecProperty(offset: 16, length: 1)]
      public UInt16? V8 { get; set; }
      /// VAr8 - Point 8 VARs.
      /// Point 8 VARs.
      [SunSpecProperty(offset: 17, length: 1)]
      public Int16? VAr8 { get; set; }
      /// [% VRef]
      /// V9 - Point 9 Volts.
      /// Point 9 Volts.
      [SunSpecProperty(offset: 18, length: 1)]
      public UInt16? V9 { get; set; }
      /// VAr9 - Point 9 VARs.
      /// Point 9 VARs.
      [SunSpecProperty(offset: 19, length: 1)]
      public Int16? VAr9 { get; set; }
      /// [% VRef]
      /// V10 - Point 10 Volts.
      /// Point 10 Volts.
      [SunSpecProperty(offset: 20, length: 1)]
      public UInt16? V10 { get; set; }
      /// VAr10 - Point 10 VARs.
      /// Point 10 VARs.
      [SunSpecProperty(offset: 21, length: 1)]
      public Int16? VAr10 { get; set; }
      /// [% VRef]
      /// V11 - Point 11 Volts.
      /// Point 11 Volts.
      [SunSpecProperty(offset: 22, length: 1)]
      public UInt16? V11 { get; set; }
      /// VAr11 - Point 11 VARs.
      /// Point 11 VARs.
      [SunSpecProperty(offset: 23, length: 1)]
      public Int16? VAr11 { get; set; }
      /// [% VRef]
      /// V12 - Point 12 Volts.
      /// Point 12 Volts.
      [SunSpecProperty(offset: 24, length: 1)]
      public UInt16? V12 { get; set; }
      /// VAr12 - Point 12 VARs.
      /// Point 12 VARs.
      [SunSpecProperty(offset: 25, length: 1)]
      public Int16? VAr12 { get; set; }
      /// [% VRef]
      /// V13 - Point 13 Volts.
      /// Point 13 Volts.
      [SunSpecProperty(offset: 26, length: 1)]
      public UInt16? V13 { get; set; }
      /// VAr13 - Point 13 VARs.
      /// Point 13 VARs.
      [SunSpecProperty(offset: 27, length: 1)]
      public Int16? VAr13 { get; set; }
      /// [% VRef]
      /// V14 - Point 14 Volts.
      /// Point 14 Volts.
      [SunSpecProperty(offset: 28, length: 1)]
      public UInt16? V14 { get; set; }
      /// VAr14 - Point 14 VARs.
      /// Point 14 VARs.
      [SunSpecProperty(offset: 29, length: 1)]
      public Int16? VAr14 { get; set; }
      /// [% VRef]
      /// V15 - Point 15 Volts.
      /// Point 15 Volts.
      [SunSpecProperty(offset: 30, length: 1)]
      public UInt16? V15 { get; set; }
      /// VAr15 - Point 15 VARs.
      /// Point 15 VARs.
      [SunSpecProperty(offset: 31, length: 1)]
      public Int16? VAr15 { get; set; }
      /// [% VRef]
      /// V16 - Point 16 Volts.
      /// Point 16 Volts.
      [SunSpecProperty(offset: 32, length: 1)]
      public UInt16? V16 { get; set; }
      /// VAr16 - Point 16 VARs.
      /// Point 16 VARs.
      [SunSpecProperty(offset: 33, length: 1)]
      public Int16? VAr16 { get; set; }
      /// [% VRef]
      /// V17 - Point 17 Volts.
      /// Point 17 Volts.
      [SunSpecProperty(offset: 34, length: 1)]
      public UInt16? V17 { get; set; }
      /// VAr17 - Point 17 VARs.
      /// Point 17 VARs.
      [SunSpecProperty(offset: 35, length: 1)]
      public Int16? VAr17 { get; set; }
      /// [% VRef]
      /// V18 - Point 18 Volts.
      /// Point 18 Volts.
      [SunSpecProperty(offset: 36, length: 1)]
      public UInt16? V18 { get; set; }
      /// VAr18 - Point 18 VARs.
      /// Point 18 VARs.
      [SunSpecProperty(offset: 37, length: 1)]
      public Int16? VAr18 { get; set; }
      /// [% VRef]
      /// V19 - Point 19 Volts.
      /// Point 19 Volts.
      [SunSpecProperty(offset: 38, length: 1)]
      public UInt16? V19 { get; set; }
      /// VAr19 - Point 19 VARs.
      /// Point 19 VARs.
      [SunSpecProperty(offset: 39, length: 1)]
      public Int16? VAr19 { get; set; }
      /// [% VRef]
      /// V20 - Point 20 Volts.
      /// Point 20 Volts.
      [SunSpecProperty(offset: 40, length: 1)]
      public UInt16? V20 { get; set; }
      /// VAr20 - Point 20 VARs.
      /// Point 20 VARs.
      [SunSpecProperty(offset: 41, length: 1)]
      public Int16? VAr20 { get; set; }
      /// CrvNam - Optional description for curve. (Max 16 chars)
      /// Optional description for curve. (Max 16 chars)
      [SunSpecProperty(offset: 42, length: 8)]
      public String? CrvNam { get; set; }
      /// [Secs]
      /// RmpTms - Ramp time for moving from current mode to new mode.
      /// Ramp time for moving from current mode to new mode.
      [SunSpecProperty(offset: 50, length: 1)]
      public UInt16? RmpTms { get; set; }
      /// [% ref_value/min]
      /// RmpDecTmm - The maximum rate at which the VAR value may be reduced in response to changes in the voltage value. %refVal is %WMax %VArMax or %VArAval depending on value of DeptRef.
      /// The maximum rate at which the VAR value may be reduced in response to changes in the voltage value. %refVal is %WMax %VArMax or %VArAval depending on value of DeptRef.
      [SunSpecProperty(offset: 51, length: 1)]
      public UInt16? RmpDecTmm { get; set; }
      /// [% ref_value/min]
      /// RmpIncTmm - The maximum rate at which the VAR value may be increased in response to changes in the voltage value. %refVal is %WMax %VArMax or %VArAval depending on value of DeptRef.
      /// The maximum rate at which the VAR value may be increased in response to changes in the voltage value. %refVal is %WMax %VArMax or %VArAval depending on value of DeptRef.
      [SunSpecProperty(offset: 52, length: 1)]
      public UInt16? RmpIncTmm { get; set; }
      public enum E_ReadOnly : UInt16
      {
        READWRITE = 0,
        READONLY = 1,
      }
      /// ReadOnly - Boolean flag indicates if curve is read-only or can be modified.
      /// Boolean flag indicates if curve is read-only or can be modified.
      [SunSpecProperty(offset: 53, length: 1)]
      public E_ReadOnly ReadOnly { get; private set; }
    };
    public S_Curve[] Curve;
  }
}
