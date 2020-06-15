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
  /// Interface counters
  [SunSpecModel(id: 15, length: 24)]
  public struct InterfaceCounters
  {
    /// Clear - Write a "1" to clear all counters
    /// Write a "1" to clear all counters
    [SunSpecProperty(offset: 0, length: 1)]
    public UInt16? Clr { get; set; }
    /// Input Count - Number of bytes received
    /// Number of bytes received
    [SunSpecProperty(offset: 1, length: 1)]
    public UInt32? InCnt { get; set; }
    /// Input Unicast Count - Number of Unicast packets received
    /// Number of Unicast packets received
    [SunSpecProperty(offset: 3, length: 1)]
    public UInt32? InUcCnt { get; set; }
    /// Input Non-Unicast Count - Number of non-Unicast packets received
    /// Number of non-Unicast packets received
    [SunSpecProperty(offset: 5, length: 1)]
    public UInt32? InNUcCnt { get; set; }
    /// Input Discarded Count - Number of inbound packets received on the interface but discarded
    /// Number of inbound packets received on the interface but discarded
    [SunSpecProperty(offset: 7, length: 1)]
    public UInt32? InDscCnt { get; set; }
    /// Input Error Count - Number of inbound packets that contain errors (excluding discards)
    /// Number of inbound packets that contain errors (excluding discards)
    [SunSpecProperty(offset: 9, length: 1)]
    public UInt32? InErrCnt { get; set; }
    /// Input Unknown Count - Number of inbound packets with unknown protocol
    /// Number of inbound packets with unknown protocol
    [SunSpecProperty(offset: 11, length: 1)]
    public UInt32? InUnkCnt { get; set; }
    /// Output Count - Total number of bytes transmitted on this interface
    /// Total number of bytes transmitted on this interface
    [SunSpecProperty(offset: 13, length: 1)]
    public UInt32? OutCnt { get; set; }
    /// Output Unicast Count - Number of Unicast packets transmitted
    /// Number of Unicast packets transmitted
    [SunSpecProperty(offset: 15, length: 1)]
    public UInt32? OutUcCnt { get; set; }
    /// Output Non-Unicast Count - Number of Non-Unicast packets transmitted
    /// Number of Non-Unicast packets transmitted
    [SunSpecProperty(offset: 17, length: 1)]
    public UInt32? OutNUcCnt { get; set; }
    /// Output Discarded Count - Number of Discarded output packets
    /// Number of Discarded output packets
    [SunSpecProperty(offset: 19, length: 1)]
    public UInt32? OutDscCnt { get; set; }
    /// Output Error Count - Number of outbound error packets
    /// Number of outbound error packets
    [SunSpecProperty(offset: 21, length: 1)]
    public UInt32? OutErrCnt { get; set; }
    [SunSpecProperty(offset: 23, length: 1)]
    public UInt16? Pad { get; set; }
  }
}
