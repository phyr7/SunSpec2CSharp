using System;

{
  /// Request a digital signature over a specified set of data registers
  /// NOTES: Used in conjunction with Secure Dataset Read Response Model
  [SunSpecModel(id: 3, length: 59)]
  public class SecureDatasetReadRequestModel
  {
    /// X - Number of registers being requested
    /// Number of registers being requested
    /// NOTES: A max of 50 registers are allowed
    [SunSpecProperty(offset: 0, length: 1)]
    public UInt16 X { get; set; }
    /// Offset1 - Offset of value to read
    /// Offset of value to read
    [SunSpecProperty(offset: 1, length: 1)]
    public UInt16 Off1 { get; set; }
    [SunSpecProperty(offset: 2, length: 1)]
    public UInt16 Off2 { get; set; }
    [SunSpecProperty(offset: 3, length: 1)]
    public UInt16 Off3 { get; set; }
    [SunSpecProperty(offset: 4, length: 1)]
    public UInt16 Off4 { get; set; }
    [SunSpecProperty(offset: 5, length: 1)]
    public UInt16 Off5 { get; set; }
    [SunSpecProperty(offset: 6, length: 1)]
    public UInt16 Off6 { get; set; }
    [SunSpecProperty(offset: 7, length: 1)]
    public UInt16 Off7 { get; set; }
    [SunSpecProperty(offset: 8, length: 1)]
    public UInt16 Off8 { get; set; }
    [SunSpecProperty(offset: 9, length: 1)]
    public UInt16 Off9 { get; set; }
    [SunSpecProperty(offset: 10, length: 1)]
    public UInt16 Off10 { get; set; }
    [SunSpecProperty(offset: 11, length: 1)]
    public UInt16 Off11 { get; set; }
    [SunSpecProperty(offset: 12, length: 1)]
    public UInt16 Off12 { get; set; }
    [SunSpecProperty(offset: 13, length: 1)]
    public UInt16 Off13 { get; set; }
    [SunSpecProperty(offset: 14, length: 1)]
    public UInt16 Off14 { get; set; }
    [SunSpecProperty(offset: 15, length: 1)]
    public UInt16 Off15 { get; set; }
    [SunSpecProperty(offset: 16, length: 1)]
    public UInt16 Off16 { get; set; }
    [SunSpecProperty(offset: 17, length: 1)]
    public UInt16 Off17 { get; set; }
    [SunSpecProperty(offset: 18, length: 1)]
    public UInt16 Off18 { get; set; }
    [SunSpecProperty(offset: 19, length: 1)]
    public UInt16 Off19 { get; set; }
    [SunSpecProperty(offset: 20, length: 1)]
    public UInt16 Off20 { get; set; }
    [SunSpecProperty(offset: 21, length: 1)]
    public UInt16 Off21 { get; set; }
    [SunSpecProperty(offset: 22, length: 1)]
    public UInt16 Off22 { get; set; }
    [SunSpecProperty(offset: 23, length: 1)]
    public UInt16 Off23 { get; set; }
    [SunSpecProperty(offset: 24, length: 1)]
    public UInt16 Off24 { get; set; }
    [SunSpecProperty(offset: 25, length: 1)]
    public UInt16 Off25 { get; set; }
    [SunSpecProperty(offset: 26, length: 1)]
    public UInt16 Off26 { get; set; }
    [SunSpecProperty(offset: 27, length: 1)]
    public UInt16 Off27 { get; set; }
    [SunSpecProperty(offset: 28, length: 1)]
    public UInt16 Off28 { get; set; }
    [SunSpecProperty(offset: 29, length: 1)]
    public UInt16 Off29 { get; set; }
    [SunSpecProperty(offset: 30, length: 1)]
    public UInt16 Off30 { get; set; }
    [SunSpecProperty(offset: 31, length: 1)]
    public UInt16 Off31 { get; set; }
    [SunSpecProperty(offset: 32, length: 1)]
    public UInt16 Off32 { get; set; }
    [SunSpecProperty(offset: 33, length: 1)]
    public UInt16 Off33 { get; set; }
    [SunSpecProperty(offset: 34, length: 1)]
    public UInt16 Off34 { get; set; }
    [SunSpecProperty(offset: 35, length: 1)]
    public UInt16 Off35 { get; set; }
    [SunSpecProperty(offset: 36, length: 1)]
    public UInt16 Off36 { get; set; }
    [SunSpecProperty(offset: 37, length: 1)]
    public UInt16 Off37 { get; set; }
    [SunSpecProperty(offset: 38, length: 1)]
    public UInt16 Off38 { get; set; }
    [SunSpecProperty(offset: 39, length: 1)]
    public UInt16 Off39 { get; set; }
    [SunSpecProperty(offset: 40, length: 1)]
    public UInt16 Off40 { get; set; }
    [SunSpecProperty(offset: 41, length: 1)]
    public UInt16 Off41 { get; set; }
    [SunSpecProperty(offset: 42, length: 1)]
    public UInt16 Off42 { get; set; }
    [SunSpecProperty(offset: 43, length: 1)]
    public UInt16 Off43 { get; set; }
    [SunSpecProperty(offset: 44, length: 1)]
    public UInt16 Off44 { get; set; }
    [SunSpecProperty(offset: 45, length: 1)]
    public UInt16 Off45 { get; set; }
    [SunSpecProperty(offset: 46, length: 1)]
    public UInt16 Off46 { get; set; }
    [SunSpecProperty(offset: 47, length: 1)]
    public UInt16 Off47 { get; set; }
    [SunSpecProperty(offset: 48, length: 1)]
    public UInt16 Off48 { get; set; }
    [SunSpecProperty(offset: 49, length: 1)]
    public UInt16 Off49 { get; set; }
    [SunSpecProperty(offset: 50, length: 1)]
    public UInt16 Off50 { get; set; }
    /// Timestamp - Timestamp value is the number of seconds since January 1, 2000
    /// Timestamp value is the number of seconds since January 1, 2000
    [SunSpecProperty(offset: 51, length: 1)]
    public UInt32 Ts { get; set; }
    /// Milliseconds - Millisecond counter 0-999
    /// Millisecond counter 0-999
    [SunSpecProperty(offset: 53, length: 1)]
    public UInt16 Ms { get; set; }
    /// Sequence - Sequence number of request
    /// Sequence number of request
    /// NOTES: Shall be advanced for each request
    [SunSpecProperty(offset: 54, length: 1)]
    public UInt16 Seq { get; set; }
    /// Role - Digital Signature ID
    /// Digital Signature ID
    /// NOTES: User's role id 0-5
    [SunSpecProperty(offset: 55, length: 1)]
    public UInt16 Role { get; set; }
    public enum E_Alg : UInt16
    {
      NONE = 0,
      AES_GMAC_64 = 1,
      ECC_256 = 2,
    }
    /// Algorithm - Algorithm used to compute the digital signature
    /// Algorithm used to compute the digital signature
    /// NOTES: For future proof
    [SunSpecProperty(offset: 56, length: 1)]
    public E_Alg Alg { get; private set; }
    /// N - Number of registers comprising the digital signature.
    /// Number of registers comprising the digital signature.
    /// NOTES: The value of N must be at least 4 (64 bits)
    [SunSpecProperty(offset: 57, length: 1)]
    public UInt16 N { get; private set; }
    public struct 
    {
      /// DS - Digital Signature
      /// Digital Signature
      /// NOTES: The DS covers all registers from X to N and is N registers in length
      [SunSpecProperty(offset: 0, length: 1)]
      public UInt16 DS { get; private set; }
    }[];
  }
}
