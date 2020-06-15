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
  /// This model has been deprecated.
  [SunSpecModel(id: 801, length: 1)]
  public struct Storage
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
