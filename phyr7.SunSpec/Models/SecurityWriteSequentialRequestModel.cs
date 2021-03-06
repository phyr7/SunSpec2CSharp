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
  /// Include a digital signature along with the control data
  [SunSpecModel(id: 6, length: 91)]
  public struct SecurityWriteSequentialRequestModel
  {
    /// X - Number of (offset, value) pairs being written
    /// Number of (offset, value) pairs being written
    /// NOTES: A max of 50 (offset, value) pairs are allocated
    [SunSpecProperty(offset: 0, length: 1)]
    public UInt16 X { get; set; }
    /// Offset - Starting offset for write operation
    /// Starting offset for write operation
    /// NOTES: X values to follow 
    [SunSpecProperty(offset: 1, length: 1)]
    public UInt16 Off { get; set; }
    /// Value1 - Value to write to control register at offset
    /// Value to write to control register at offset
    [SunSpecProperty(offset: 2, length: 1)]
    public UInt16 Val1 { get; set; }
    [SunSpecProperty(offset: 3, length: 1)]
    public UInt16 Val2 { get; set; }
    [SunSpecProperty(offset: 4, length: 1)]
    public UInt16 Val3 { get; set; }
    [SunSpecProperty(offset: 5, length: 1)]
    public UInt16 Val4 { get; set; }
    [SunSpecProperty(offset: 6, length: 1)]
    public UInt16 Val5 { get; set; }
    [SunSpecProperty(offset: 7, length: 1)]
    public UInt16 Val6 { get; set; }
    [SunSpecProperty(offset: 8, length: 1)]
    public UInt16 Val7 { get; set; }
    [SunSpecProperty(offset: 9, length: 1)]
    public UInt16 Val8 { get; set; }
    [SunSpecProperty(offset: 10, length: 1)]
    public UInt16 Val9 { get; set; }
    [SunSpecProperty(offset: 11, length: 1)]
    public UInt16 Val10 { get; set; }
    [SunSpecProperty(offset: 12, length: 1)]
    public UInt16 Val11 { get; set; }
    [SunSpecProperty(offset: 13, length: 1)]
    public UInt16 Val12 { get; set; }
    [SunSpecProperty(offset: 14, length: 1)]
    public UInt16 Val13 { get; set; }
    [SunSpecProperty(offset: 15, length: 1)]
    public UInt16 Val14 { get; set; }
    [SunSpecProperty(offset: 16, length: 1)]
    public UInt16 Val15 { get; set; }
    [SunSpecProperty(offset: 17, length: 1)]
    public UInt16 Val16 { get; set; }
    [SunSpecProperty(offset: 18, length: 1)]
    public UInt16 Val17 { get; set; }
    [SunSpecProperty(offset: 19, length: 1)]
    public UInt16 Val18 { get; set; }
    [SunSpecProperty(offset: 20, length: 1)]
    public UInt16 Val19 { get; set; }
    [SunSpecProperty(offset: 21, length: 1)]
    public UInt16 Val20 { get; set; }
    [SunSpecProperty(offset: 22, length: 1)]
    public UInt16 Val21 { get; set; }
    [SunSpecProperty(offset: 23, length: 1)]
    public UInt16 Val22 { get; set; }
    [SunSpecProperty(offset: 24, length: 1)]
    public UInt16 Val23 { get; set; }
    [SunSpecProperty(offset: 25, length: 1)]
    public UInt16 Val24 { get; set; }
    [SunSpecProperty(offset: 26, length: 1)]
    public UInt16 Val25 { get; set; }
    [SunSpecProperty(offset: 27, length: 1)]
    public UInt16 Val26 { get; set; }
    [SunSpecProperty(offset: 28, length: 1)]
    public UInt16 Val27 { get; set; }
    [SunSpecProperty(offset: 29, length: 1)]
    public UInt16 Val28 { get; set; }
    [SunSpecProperty(offset: 30, length: 1)]
    public UInt16 Val29 { get; set; }
    [SunSpecProperty(offset: 31, length: 1)]
    public UInt16 Val30 { get; set; }
    [SunSpecProperty(offset: 32, length: 1)]
    public UInt16 Val31 { get; set; }
    [SunSpecProperty(offset: 33, length: 1)]
    public UInt16 Val32 { get; set; }
    [SunSpecProperty(offset: 34, length: 1)]
    public UInt16 Val33 { get; set; }
    [SunSpecProperty(offset: 35, length: 1)]
    public UInt16 Val34 { get; set; }
    [SunSpecProperty(offset: 36, length: 1)]
    public UInt16 Val35 { get; set; }
    [SunSpecProperty(offset: 37, length: 1)]
    public UInt16 Val36 { get; set; }
    [SunSpecProperty(offset: 38, length: 1)]
    public UInt16 Val37 { get; set; }
    [SunSpecProperty(offset: 39, length: 1)]
    public UInt16 Val38 { get; set; }
    [SunSpecProperty(offset: 40, length: 1)]
    public UInt16 Val39 { get; set; }
    [SunSpecProperty(offset: 41, length: 1)]
    public UInt16 Val40 { get; set; }
    [SunSpecProperty(offset: 42, length: 1)]
    public UInt16 Val41 { get; set; }
    [SunSpecProperty(offset: 43, length: 1)]
    public UInt16 Val42 { get; set; }
    [SunSpecProperty(offset: 44, length: 1)]
    public UInt16 Val43 { get; set; }
    [SunSpecProperty(offset: 45, length: 1)]
    public UInt16 Val44 { get; set; }
    [SunSpecProperty(offset: 46, length: 1)]
    public UInt16 Val45 { get; set; }
    [SunSpecProperty(offset: 47, length: 1)]
    public UInt16 Val46 { get; set; }
    [SunSpecProperty(offset: 48, length: 1)]
    public UInt16 Val47 { get; set; }
    [SunSpecProperty(offset: 49, length: 1)]
    public UInt16 Val48 { get; set; }
    [SunSpecProperty(offset: 50, length: 1)]
    public UInt16 Val49 { get; set; }
    [SunSpecProperty(offset: 51, length: 1)]
    public UInt16 Val50 { get; set; }
    [SunSpecProperty(offset: 52, length: 1)]
    public UInt16 Val51 { get; set; }
    [SunSpecProperty(offset: 53, length: 1)]
    public UInt16 Val52 { get; set; }
    [SunSpecProperty(offset: 54, length: 1)]
    public UInt16 Val53 { get; set; }
    [SunSpecProperty(offset: 55, length: 1)]
    public UInt16 Val54 { get; set; }
    [SunSpecProperty(offset: 56, length: 1)]
    public UInt16 Val55 { get; set; }
    [SunSpecProperty(offset: 57, length: 1)]
    public UInt16 Val56 { get; set; }
    [SunSpecProperty(offset: 58, length: 1)]
    public UInt16 Val57 { get; set; }
    [SunSpecProperty(offset: 59, length: 1)]
    public UInt16 Val58 { get; set; }
    [SunSpecProperty(offset: 60, length: 1)]
    public UInt16 Val59 { get; set; }
    [SunSpecProperty(offset: 61, length: 1)]
    public UInt16 Val60 { get; set; }
    [SunSpecProperty(offset: 62, length: 1)]
    public UInt16 Val61 { get; set; }
    [SunSpecProperty(offset: 63, length: 1)]
    public UInt16 Val62 { get; set; }
    [SunSpecProperty(offset: 64, length: 1)]
    public UInt16 Val63 { get; set; }
    [SunSpecProperty(offset: 65, length: 1)]
    public UInt16 Val64 { get; set; }
    [SunSpecProperty(offset: 66, length: 1)]
    public UInt16 Val65 { get; set; }
    [SunSpecProperty(offset: 67, length: 1)]
    public UInt16 Val66 { get; set; }
    [SunSpecProperty(offset: 68, length: 1)]
    public UInt16 Val67 { get; set; }
    [SunSpecProperty(offset: 69, length: 1)]
    public UInt16 Val68 { get; set; }
    [SunSpecProperty(offset: 70, length: 1)]
    public UInt16 Val69 { get; set; }
    [SunSpecProperty(offset: 71, length: 1)]
    public UInt16 Val70 { get; set; }
    [SunSpecProperty(offset: 72, length: 1)]
    public UInt16 Val71 { get; set; }
    [SunSpecProperty(offset: 73, length: 1)]
    public UInt16 Val72 { get; set; }
    [SunSpecProperty(offset: 74, length: 1)]
    public UInt16 Val73 { get; set; }
    [SunSpecProperty(offset: 75, length: 1)]
    public UInt16 Val74 { get; set; }
    [SunSpecProperty(offset: 76, length: 1)]
    public UInt16 Val75 { get; set; }
    [SunSpecProperty(offset: 77, length: 1)]
    public UInt16 Val76 { get; set; }
    [SunSpecProperty(offset: 78, length: 1)]
    public UInt16 Val77 { get; set; }
    [SunSpecProperty(offset: 79, length: 1)]
    public UInt16 Val78 { get; set; }
    [SunSpecProperty(offset: 80, length: 1)]
    public UInt16 Val79 { get; set; }
    [SunSpecProperty(offset: 81, length: 1)]
    public UInt16 Val80 { get; set; }
    /// Timestamp - Timestamp value is the number of seconds since January 1, 2000
    /// Timestamp value is the number of seconds since January 1, 2000
    [SunSpecProperty(offset: 82, length: 1)]
    public UInt32 Ts { get; set; }
    /// Milliseconds - Millisecond counter 0-999
    /// Millisecond counter 0-999
    [SunSpecProperty(offset: 84, length: 1)]
    public UInt16 Ms { get; set; }
    /// Sequence - Sequence number of request
    /// Sequence number of request
    /// NOTES: Shall be advanced for each request
    [SunSpecProperty(offset: 85, length: 1)]
    public UInt16 Seq { get; set; }
    /// Role - Signing key used 0-5
    /// Signing key used 0-5
    /// NOTES: Each controller is assigned a key index that maps to their access control role
    [SunSpecProperty(offset: 86, length: 1)]
    public UInt16 Role { get; set; }
    [SunSpecProperty(offset: 87, length: 1)]
    public UInt16 Rsrvd { get; set; }
    public enum E_Alg : UInt16
    {
      NONE = 0,
      AES_GMAC_64 = 1,
      ECC_256 = 2,
    }
    /// Algorithm - Algorithm used to compute the digital signature
    /// Algorithm used to compute the digital signature
    /// NOTES: For future proof
    [SunSpecProperty(offset: 88, length: 1)]
    public E_Alg Alg { get; set; }
    /// N - Number of registers comprising the digital signature.
    /// Number of registers comprising the digital signature.
    /// NOTES: The value of N must be at least 4 (64 bits)
    [SunSpecProperty(offset: 89, length: 1)]
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
