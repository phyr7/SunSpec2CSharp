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
  /// Aggregates a collection of models for a given model id
  [SunSpecModel(id: 2, length: 14)]
  public struct Aggregator
  {
    /// AID - Aggregated model id
    /// Aggregated model id
    [SunSpecProperty(offset: 0, length: 1)]
    public UInt16 AID { get; set; }
    /// N - Number of aggregated models
    /// Number of aggregated models
    [SunSpecProperty(offset: 1, length: 1)]
    public UInt16 N { get; set; }
    /// UN - Update Number.  Incrementing number each time the mapping is changed.  If the number is not changed from the last reading the direct access to a specific offset will result in reading the same logical model as before.  Otherwise the entire model must be read to refresh the changes
    /// Update Number.  Incrementing number each time the mapping is changed.  If the number is not changed from the last reading the direct access to a specific offset will result in reading the same logical model as before.  Otherwise the entire model must be read to refresh the changes
    [SunSpecProperty(offset: 2, length: 1)]
    public UInt16 UN { get; set; }
    public enum E_St : UInt16
    {
      OFF = 1,
      ON = 2,
      FULL = 3,
      FAULT = 4,
    }
    /// Status - Enumerated status code
    /// Enumerated status code
    [SunSpecProperty(offset: 3, length: 1)]
    public E_St St { get; set; }
    public enum E_StVnd : UInt16
    {
    }
    /// Vendor Status - Vendor specific status code
    /// Vendor specific status code
    [SunSpecProperty(offset: 4, length: 1)]
    public E_StVnd? StVnd { get; set; }
    [Flags]
    public enum E_Evt : UInt32
    {
      GROUND_FAULT = 0,
      INPUT_OVER_VOLTAGE = 1,
      RESERVED_2 = 2,
      DC_DISCONNECT = 3,
      RESERVED_4 = 4,
      RESERVED_5 = 5,
      MANUAL_SHUTDOWN = 6,
      OVER_TEMPERATURE = 7,
      RESERVED_8 = 8,
      RESERVED_9 = 9,
      RESERVED_10 = 10,
      RESERVED_11 = 11,
      BLOWN_FUSE = 12,
      UNDER_TEMPERATURE = 13,
      MEMORY_LOSS = 14,
      ARC_DETECTION = 15,
      THEFT_DETECTION = 16,
      OUTPUT_OVER_CURRENT = 17,
      OUTPUT_OVER_VOLTAGE = 18,
      OUTPUT_UNDER_VOLTAGE = 19,
      TEST_FAILED = 20,
    }
    /// Event Code - Bitmask event code
    /// Bitmask event code
    [SunSpecProperty(offset: 5, length: 1)]
    public E_Evt Evt { get; set; }
    [Flags]
    public enum E_EvtVnd : UInt32
    {
    }
    /// Vendor Event Code - Vendor specific event code
    /// Vendor specific event code
    [SunSpecProperty(offset: 7, length: 1)]
    public E_EvtVnd? EvtVnd { get; set; }
    public enum E_Ctl : UInt16
    {
      NONE = 0,
      AUTOMATIC = 1,
      FORCE_OFF = 2,
      TEST = 3,
      THROTTLE = 4,
    }
    /// Control - Control register for all aggregated devices
    /// Control register for all aggregated devices
    [SunSpecProperty(offset: 9, length: 1)]
    public E_Ctl? Ctl { get; set; }
    public enum E_CtlVnd : UInt32
    {
    }
    /// Vendor Control - Vendor control register for all aggregated devices
    /// Vendor control register for all aggregated devices
    [SunSpecProperty(offset: 10, length: 1)]
    public E_CtlVnd? CtlVnd { get; set; }
    public enum E_CtlVl : UInt32
    {
    }
    /// Control Value - Numerical value used as a parameter to the control
    /// Numerical value used as a parameter to the control
    [SunSpecProperty(offset: 12, length: 1)]
    public E_CtlVl? CtlVl { get; set; }
  }
}
