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
  [SunSpecModel(id: 64101, length: 7)]
  public struct Eltek
  {
    [SunSpecProperty(offset: 0, length: 1)]
    public UInt16? Eltek_Country_Code { get; set; }
    [SunSpecProperty(offset: 1, length: 1)]
    public UInt16? Eltek_Feeding_Phase { get; set; }
    [SunSpecProperty(offset: 2, length: 1)]
    public UInt16? Eltek_APD_Method { get; set; }
    [SunSpecProperty(offset: 3, length: 1)]
    public UInt16? Eltek_APD_Power_Ref { get; set; }
    [SunSpecProperty(offset: 4, length: 1)]
    public UInt16? Eltek_RPS_Method { get; set; }
    [SunSpecProperty(offset: 5, length: 1)]
    public UInt16? Eltek_RPS_Q_Ref { get; set; }
    [SunSpecProperty(offset: 6, length: 1)]
    public Int16? Eltek_RPS_CosPhi_Ref { get; set; }
  }
}
