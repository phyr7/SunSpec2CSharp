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
  [SunSpecModel(id: 805, length: 46)]
  public struct LithiumIonModule
  {
    /// String Index - Index of the string containing the module.
    /// Index of the string containing the module.
    /// NOTES: Indices are one-based.
    [SunSpecProperty(offset: 0, length: 1)]
    public UInt16 StrIdx { get; set; }
    /// Module Index - Index of the module within the string.
    /// Index of the module within the string.
    /// NOTES: Indices are one-based.
    [SunSpecProperty(offset: 1, length: 1)]
    public UInt16 ModIdx { get; set; }
    /// Module Cell Count - Count of all cells in the module.
    /// Count of all cells in the module.
    [SunSpecProperty(offset: 2, length: 1)]
    public UInt16 NCell { get; set; }
    /// [%]
    /// Module SoC - Module state of charge, expressed as a percentage.
    /// Module state of charge, expressed as a percentage.
    [SunSpecProperty(offset: 3, length: 1)]
    public UInt16? SoC { get; set; }
    /// [%]
    /// Depth of Discharge - Depth of discharge for the module.
    /// Depth of discharge for the module.
    /// NOTES: Measurement.
    [SunSpecProperty(offset: 4, length: 1)]
    public UInt16? DoD { get; set; }
    /// [%]
    /// Module SoH - Module state of health, expressed as a percentage.
    /// Module state of health, expressed as a percentage.
    [SunSpecProperty(offset: 5, length: 1)]
    public UInt16? SoH { get; set; }
    /// Cycle Count - Count of cycles executed.
    /// Count of cycles executed.
    [SunSpecProperty(offset: 6, length: 1)]
    public UInt32? NCyc { get; set; }
    /// [V]
    /// Module Voltage - Voltage of the module.
    /// Voltage of the module.
    /// NOTES: Measurement.
    [SunSpecProperty(offset: 8, length: 1)]
    public UInt16 V { get; set; }
    /// [V]
    /// Max Cell Voltage - Maximum voltage for all cells in the module.
    /// Maximum voltage for all cells in the module.
    /// NOTES: Measurement.
    [SunSpecProperty(offset: 9, length: 1)]
    public UInt16 CellVMax { get; set; }
    /// Max Cell Voltage Cell - Cell with the maximum voltage.
    /// Cell with the maximum voltage.
    [SunSpecProperty(offset: 10, length: 1)]
    public UInt16? CellVMaxCell { get; set; }
    /// [V]
    /// Min Cell Voltage - Minimum voltage for all cells in the module.
    /// Minimum voltage for all cells in the module.
    /// NOTES: Measurement.
    [SunSpecProperty(offset: 11, length: 1)]
    public UInt16 CellVMin { get; set; }
    /// Min Cell Voltage Cell - Cell with the minimum voltage.
    /// Cell with the minimum voltage.
    [SunSpecProperty(offset: 12, length: 1)]
    public UInt16? CellVMinCell { get; set; }
    /// [V]
    /// Average Cell Voltage - Average voltage for all cells in the module.
    /// Average voltage for all cells in the module.
    /// NOTES: Calculation based on measurements.
    [SunSpecProperty(offset: 13, length: 1)]
    public UInt16 CellVAvg { get; set; }
    /// [C]
    /// Max Cell Temperature - Maximum temperature for all cells in the module.
    /// Maximum temperature for all cells in the module.
    /// NOTES: Measurement.
    [SunSpecProperty(offset: 14, length: 1)]
    public Int16 CellTmpMax { get; set; }
    /// Max Cell Temperature Cell - Cell with the maximum cell temperature.
    /// Cell with the maximum cell temperature.
    [SunSpecProperty(offset: 15, length: 1)]
    public UInt16? CellTmpMaxCell { get; set; }
    /// [C]
    /// Min Cell Temperature - Minimum temperature for all cells in the module.
    /// Minimum temperature for all cells in the module.
    /// NOTES: Measurement.
    [SunSpecProperty(offset: 16, length: 1)]
    public Int16 CellTmpMin { get; set; }
    /// Min Cell Temperature Cell - Cell with the minimum cell temperature.
    /// Cell with the minimum cell temperature.
    [SunSpecProperty(offset: 17, length: 1)]
    public UInt16? CellTmpMinCell { get; set; }
    /// [C]
    /// Average Cell Temperature - Average temperature for all cells in the module.
    /// Average temperature for all cells in the module.
    /// NOTES: Calculation based on measurements.
    [SunSpecProperty(offset: 18, length: 1)]
    public Int16 CellTmpAvg { get; set; }
    /// Balanced Cell Count - Number of cells currently being balanced in the module.
    /// Number of cells currently being balanced in the module.
    [SunSpecProperty(offset: 19, length: 1)]
    public UInt16? NCellBal { get; set; }
    /// Serial Number - Serial number for the module.
    /// Serial number for the module.
    [SunSpecProperty(offset: 20, length: 16)]
    public String? SN { get; set; }
    /// Scale factor for module state of charge.
    [SunSpecProperty(offset: 36, length: 1)]
    public Int16? SoC_SF { get; set; }
    /// Scale factor for module state of health.
    [SunSpecProperty(offset: 37, length: 1)]
    public Int16? SoH_SF { get; set; }
    /// Scale factor for module depth of discharge.
    [SunSpecProperty(offset: 38, length: 1)]
    public Int16? DoD_SF { get; set; }
    /// Scale factor for module voltage.
    [SunSpecProperty(offset: 39, length: 1)]
    public Int16 V_SF { get; set; }
    /// Scale factor for cell voltage.
    [SunSpecProperty(offset: 40, length: 1)]
    public Int16 CellV_SF { get; set; }
    /// Scale factor for module temperature.
    [SunSpecProperty(offset: 41, length: 1)]
    public Int16 Tmp_SF { get; set; }
    public struct S_LithiumIonModuleCell
    {
      /// [V]
      /// Cell Voltage - Cell terminal voltage.
      /// Cell terminal voltage.
      /// NOTES: Measurement.
      [SunSpecProperty(offset: 0, length: 1)]
      public UInt16 CellV { get; set; }
      /// [C]
      /// Cell Temperature - Cell temperature.
      /// Cell temperature.
      /// NOTES: Measurement.
      [SunSpecProperty(offset: 1, length: 1)]
      public Int16 CellTmp { get; set; }
      [Flags]
      public enum E_CellSt : UInt32
      {
        CELL_IS_BALANCING = 0,
      }
      /// Cell Status - Status of the cell.
      /// Status of the cell.
      [SunSpecProperty(offset: 2, length: 1)]
      public E_CellSt? CellSt { get; set; }
    };
    public S_LithiumIonModuleCell[] LithiumIonModuleCell;
  }
}
