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
  /// Include a digital signature over the response
  /// NOTES: Used in conjunction with a Secure Write Request
  [SunSpecModel(id: 7, length: 11)]
  public struct SecurityWriteResponseModel
  {
    /// Request Sequence - Sequence number from the request
    /// Sequence number from the request
    [SunSpecProperty(offset: 0, length: 1)]
    public UInt16 RqSeq { get; private set; }
    public enum E_Sts : UInt16
    {
      SUCCESS = 0,
      DS = 1,
      ACL = 2,
      OFF = 3,
      VAL = 4,
    }
    /// Status - Status of last write operation
    /// Status of last write operation
    [SunSpecProperty(offset: 1, length: 1)]
    public E_Sts Sts { get; private set; }
    /// Timestamp - Timestamp value is the number of seconds since January 1, 2000
    /// Timestamp value is the number of seconds since January 1, 2000
    [SunSpecProperty(offset: 2, length: 1)]
    public UInt32 Ts { get; private set; }
    /// Milliseconds - Millisecond counter 0-999
    /// Millisecond counter 0-999
    [SunSpecProperty(offset: 4, length: 1)]
    public UInt16 Ms { get; private set; }
    /// Sequence - Sequence number of response
    /// Sequence number of response
    /// NOTES: Shall be advanced for each response
    [SunSpecProperty(offset: 5, length: 1)]
    public UInt16 Seq { get; private set; }
    public enum E_Alm : UInt16
    {
      NONE = 0,
      ALM = 1,
    }
    /// Alarm - Bitmask alarm code
    /// Bitmask alarm code
    [SunSpecProperty(offset: 6, length: 1)]
    public E_Alm Alm { get; set; }
    [SunSpecProperty(offset: 7, length: 1)]
    public UInt16 Rsrvd { get; private set; }
    public enum E_Alg : UInt16
    {
      NONE = 0,
      AES_GMAC_64 = 1,
      ECC_256 = 2,
    }
    /// Algorithm - Algorithm used to compute the digital signature
    /// Algorithm used to compute the digital signature
    /// NOTES: For future proof
    [SunSpecProperty(offset: 8, length: 1)]
    public E_Alg Alg { get; private set; }
    /// N - Number of registers comprising the digital signature.
    /// Number of registers comprising the digital signature.
    /// NOTES: The value of N must be at least 4 (64 bits)
    [SunSpecProperty(offset: 9, length: 1)]
    public UInt16 N { get; set; }
    public struct S_Block2
    {
      /// DS - Digital Signature
      /// Digital Signature
      /// NOTES: The DS covers all registers from X to N and is N registers in length
      [SunSpecProperty(offset: 0, length: 1)]
      public UInt16 DS { get; set; }
    };
    public S_Block2[] Block2;
  }
}
