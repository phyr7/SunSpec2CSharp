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
  /// Compute a digital signature over a specified set of data registers
  [SunSpecModel(id: 4, length: 61)]
  public struct SecureDatasetReadResponseModel
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
    }
    /// Status - Status of last read operation
    /// Status of last read operation
    [SunSpecProperty(offset: 1, length: 1)]
    public E_Sts Sts { get; private set; }
    /// X - Number of values from the request
    /// Number of values from the request
    /// NOTES: A max of 50 values are allocated
    [SunSpecProperty(offset: 2, length: 1)]
    public UInt16 X { get; private set; }
    /// Value1 - Copy of value from register Off1.
    /// Copy of value from register Off1.
    /// NOTES: Unused values shall return 0xFFFF (unimplemented)
    [SunSpecProperty(offset: 3, length: 1)]
    public UInt16 Val1 { get; private set; }
    [SunSpecProperty(offset: 4, length: 1)]
    public UInt16 Val2 { get; private set; }
    [SunSpecProperty(offset: 5, length: 1)]
    public UInt16 Val3 { get; private set; }
    [SunSpecProperty(offset: 6, length: 1)]
    public UInt16 Val4 { get; private set; }
    [SunSpecProperty(offset: 7, length: 1)]
    public UInt16 Val5 { get; private set; }
    [SunSpecProperty(offset: 8, length: 1)]
    public UInt16 Val6 { get; private set; }
    [SunSpecProperty(offset: 9, length: 1)]
    public UInt16 Val7 { get; private set; }
    [SunSpecProperty(offset: 10, length: 1)]
    public UInt16 Val8 { get; private set; }
    [SunSpecProperty(offset: 11, length: 1)]
    public UInt16 Val9 { get; private set; }
    [SunSpecProperty(offset: 12, length: 1)]
    public UInt16 Val10 { get; private set; }
    [SunSpecProperty(offset: 13, length: 1)]
    public UInt16 Val11 { get; private set; }
    [SunSpecProperty(offset: 14, length: 1)]
    public UInt16 Val12 { get; private set; }
    [SunSpecProperty(offset: 15, length: 1)]
    public UInt16 Val13 { get; private set; }
    [SunSpecProperty(offset: 16, length: 1)]
    public UInt16 Val14 { get; private set; }
    [SunSpecProperty(offset: 17, length: 1)]
    public UInt16 Val15 { get; private set; }
    [SunSpecProperty(offset: 18, length: 1)]
    public UInt16 Val16 { get; private set; }
    [SunSpecProperty(offset: 19, length: 1)]
    public UInt16 Val17 { get; private set; }
    [SunSpecProperty(offset: 20, length: 1)]
    public UInt16 Val18 { get; private set; }
    [SunSpecProperty(offset: 21, length: 1)]
    public UInt16 Val19 { get; private set; }
    [SunSpecProperty(offset: 22, length: 1)]
    public UInt16 Val20 { get; private set; }
    [SunSpecProperty(offset: 23, length: 1)]
    public UInt16 Val21 { get; private set; }
    [SunSpecProperty(offset: 24, length: 1)]
    public UInt16 Val22 { get; private set; }
    [SunSpecProperty(offset: 25, length: 1)]
    public UInt16 Val23 { get; private set; }
    [SunSpecProperty(offset: 26, length: 1)]
    public UInt16 Val24 { get; private set; }
    [SunSpecProperty(offset: 27, length: 1)]
    public UInt16 Val25 { get; private set; }
    [SunSpecProperty(offset: 28, length: 1)]
    public UInt16 Val26 { get; private set; }
    [SunSpecProperty(offset: 29, length: 1)]
    public UInt16 Val27 { get; private set; }
    [SunSpecProperty(offset: 30, length: 1)]
    public UInt16 Val28 { get; private set; }
    [SunSpecProperty(offset: 31, length: 1)]
    public UInt16 Val29 { get; private set; }
    [SunSpecProperty(offset: 32, length: 1)]
    public UInt16 Val30 { get; private set; }
    [SunSpecProperty(offset: 33, length: 1)]
    public UInt16 Val31 { get; private set; }
    [SunSpecProperty(offset: 34, length: 1)]
    public UInt16 Val32 { get; private set; }
    [SunSpecProperty(offset: 35, length: 1)]
    public UInt16 Val33 { get; private set; }
    [SunSpecProperty(offset: 36, length: 1)]
    public UInt16 Val34 { get; private set; }
    [SunSpecProperty(offset: 37, length: 1)]
    public UInt16 Val35 { get; private set; }
    [SunSpecProperty(offset: 38, length: 1)]
    public UInt16 Val36 { get; private set; }
    [SunSpecProperty(offset: 39, length: 1)]
    public UInt16 Val37 { get; private set; }
    [SunSpecProperty(offset: 40, length: 1)]
    public UInt16 Val38 { get; private set; }
    [SunSpecProperty(offset: 41, length: 1)]
    public UInt16 Val39 { get; private set; }
    [SunSpecProperty(offset: 42, length: 1)]
    public UInt16 Val40 { get; private set; }
    [SunSpecProperty(offset: 43, length: 1)]
    public UInt16 Val41 { get; private set; }
    [SunSpecProperty(offset: 44, length: 1)]
    public UInt16 Val42 { get; private set; }
    [SunSpecProperty(offset: 45, length: 1)]
    public UInt16 Val43 { get; private set; }
    [SunSpecProperty(offset: 46, length: 1)]
    public UInt16 Val44 { get; private set; }
    [SunSpecProperty(offset: 47, length: 1)]
    public UInt16 Val45 { get; private set; }
    [SunSpecProperty(offset: 48, length: 1)]
    public UInt16 Val46 { get; private set; }
    [SunSpecProperty(offset: 49, length: 1)]
    public UInt16 Val47 { get; private set; }
    [SunSpecProperty(offset: 50, length: 1)]
    public UInt16 Val48 { get; private set; }
    [SunSpecProperty(offset: 51, length: 1)]
    public UInt16 Val49 { get; private set; }
    [SunSpecProperty(offset: 52, length: 1)]
    public UInt16 Val50 { get; private set; }
    /// Timestamp - Timestamp value is the number of seconds since January 1, 2000
    /// Timestamp value is the number of seconds since January 1, 2000
    [SunSpecProperty(offset: 53, length: 1)]
    public UInt32 Ts { get; private set; }
    /// Milliseconds - Millisecond counter 0-999
    /// Millisecond counter 0-999
    [SunSpecProperty(offset: 55, length: 1)]
    public UInt16 Ms { get; private set; }
    /// Sequence - Sequence number of response
    /// Sequence number of response
    /// NOTES: Shall be advanced for each response
    [SunSpecProperty(offset: 56, length: 1)]
    public UInt16 Seq { get; private set; }
    public enum E_Alm : UInt16
    {
      NONE = 0,
      ALM = 1,
    }
    /// Alarm - Bitmask alarm code
    /// Bitmask alarm code
    [SunSpecProperty(offset: 57, length: 1)]
    public E_Alm Alm { get; set; }
    public enum E_Alg : UInt16
    {
      NONE = 0,
      AES_GMAC_64 = 1,
      ECC_256 = 2,
    }
    /// Algorithm - Algorithm used to compute the digital signature
    /// Algorithm used to compute the digital signature
    /// NOTES: For future proof
    [SunSpecProperty(offset: 58, length: 1)]
    public E_Alg Alg { get; private set; }
    /// N - Number of registers comprising the digital signature.
    /// Number of registers comprising the digital signature.
    /// NOTES: The value of N must be at least 4 (64 bits)
    [SunSpecProperty(offset: 59, length: 1)]
    public UInt16 N { get; private set; }
    public struct S_Block2
    {
      /// DS - Digital Signature
      /// Digital Signature
      /// NOTES: The DS covers all registers from X to N and is N registers in length
      [SunSpecProperty(offset: 0, length: 1)]
      public UInt16 DS { get; private set; }
    };
    public S_Block2[] Block2;
  }
}
