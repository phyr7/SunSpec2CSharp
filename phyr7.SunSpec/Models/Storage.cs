using System;

{
  /// This model has been deprecated.
  [SunSpecModel(id: 801, length: 1)]
  public class Storage
  {
    public enum E_DEPRECATED : UInt16
    {
    }
    /// Deprecated Model - This model has been deprecated.
    /// This model has been deprecated.
    [SunSpecProperty(offset: 0, length: 1)]
    public E_DEPRECATED DEPRECATED { get; set; }
  }
}
