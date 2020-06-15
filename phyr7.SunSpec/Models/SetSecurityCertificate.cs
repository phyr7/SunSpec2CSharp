using System;

{
  /// Security model for PKI
  [SunSpecModel(id: 9, length: 93)]
  public class SetSecurityCertificate
  {
    /// Cert_UID - User ID for this certificate
    /// User ID for this certificate
    [SunSpecProperty(offset: 0, length: 1)]
    public UInt16 CertUID { get; set; }
    /// Cert_Role - Role for this certificate
    /// Role for this certificate
    [SunSpecProperty(offset: 1, length: 1)]
    public UInt16 CertRole { get; set; }
    public enum E_Fmt : UInt16
    {
      NONE = 0,
      X509_PEM = 1,
      X509_DER = 2,
    }
    /// Format - X.509 format of the certificate. DER or PEM.
    /// X.509 format of the certificate. DER or PEM.
    [SunSpecProperty(offset: 2, length: 1)]
    public E_Fmt Fmt { get; set; }
    public enum E_Typ : UInt16
    {
      DEV_KEY_PAIR = 0,
      DEV_SHARED_KEY = 1,
      OPERATOR_PUB = 2,
      OPERATOR_SHARED = 3,
      CA_PUB = 4,
    }
    /// Type - Type of this certificate
    /// Type of this certificate
    [SunSpecProperty(offset: 3, length: 1)]
    public E_Typ Typ { get; set; }
    /// Total Length - Total Length of the Certificate
    /// Total Length of the Certificate
    /// NOTES: In registers, zero padded.
    [SunSpecProperty(offset: 4, length: 1)]
    public UInt16 TotLn { get; set; }
    /// Fragment length - Length of this fragment
    /// Length of this fragment
    /// NOTES: Maximum fragment length is 80 registers
    [SunSpecProperty(offset: 5, length: 1)]
    public UInt16 FrgLn { get; set; }
    /// Frag1 - First word of this fragment
    /// First word of this fragment
    [SunSpecProperty(offset: 6, length: 1)]
    public UInt16 Frg1 { get; set; }
    [SunSpecProperty(offset: 7, length: 1)]
    public UInt16 Frg2 { get; set; }
    [SunSpecProperty(offset: 8, length: 1)]
    public UInt16 Frg3 { get; set; }
    [SunSpecProperty(offset: 9, length: 1)]
    public UInt16 Frg4 { get; set; }
    [SunSpecProperty(offset: 10, length: 1)]
    public UInt16 Frg5 { get; set; }
    [SunSpecProperty(offset: 11, length: 1)]
    public UInt16 Frg6 { get; set; }
    [SunSpecProperty(offset: 12, length: 1)]
    public UInt16 Frg7 { get; set; }
    [SunSpecProperty(offset: 13, length: 1)]
    public UInt16 Frg8 { get; set; }
    [SunSpecProperty(offset: 14, length: 1)]
    public UInt16 Frg9 { get; set; }
    [SunSpecProperty(offset: 15, length: 1)]
    public UInt16 Frg10 { get; set; }
    [SunSpecProperty(offset: 16, length: 1)]
    public UInt16 Frg11 { get; set; }
    [SunSpecProperty(offset: 17, length: 1)]
    public UInt16 Frg12 { get; set; }
    [SunSpecProperty(offset: 18, length: 1)]
    public UInt16 Frg13 { get; set; }
    [SunSpecProperty(offset: 19, length: 1)]
    public UInt16 Frg14 { get; set; }
    [SunSpecProperty(offset: 20, length: 1)]
    public UInt16 Frg15 { get; set; }
    [SunSpecProperty(offset: 21, length: 1)]
    public UInt16 Frg16 { get; set; }
    [SunSpecProperty(offset: 22, length: 1)]
    public UInt16 Frg17 { get; set; }
    [SunSpecProperty(offset: 23, length: 1)]
    public UInt16 Frg18 { get; set; }
    [SunSpecProperty(offset: 24, length: 1)]
    public UInt16 Frg19 { get; set; }
    [SunSpecProperty(offset: 25, length: 1)]
    public UInt16 Frg20 { get; set; }
    [SunSpecProperty(offset: 26, length: 1)]
    public UInt16 Frg21 { get; set; }
    [SunSpecProperty(offset: 27, length: 1)]
    public UInt16 Frg22 { get; set; }
    [SunSpecProperty(offset: 28, length: 1)]
    public UInt16 Frg23 { get; set; }
    [SunSpecProperty(offset: 29, length: 1)]
    public UInt16 Frg24 { get; set; }
    [SunSpecProperty(offset: 30, length: 1)]
    public UInt16 Frg25 { get; set; }
    [SunSpecProperty(offset: 31, length: 1)]
    public UInt16 Frg26 { get; set; }
    [SunSpecProperty(offset: 32, length: 1)]
    public UInt16 Frg27 { get; set; }
    [SunSpecProperty(offset: 33, length: 1)]
    public UInt16 Frg28 { get; set; }
    [SunSpecProperty(offset: 34, length: 1)]
    public UInt16 Frg29 { get; set; }
    [SunSpecProperty(offset: 35, length: 1)]
    public UInt16 Frg30 { get; set; }
    [SunSpecProperty(offset: 36, length: 1)]
    public UInt16 Frg31 { get; set; }
    [SunSpecProperty(offset: 37, length: 1)]
    public UInt16 Frg32 { get; set; }
    [SunSpecProperty(offset: 38, length: 1)]
    public UInt16 Frg33 { get; set; }
    [SunSpecProperty(offset: 39, length: 1)]
    public UInt16 Frg34 { get; set; }
    [SunSpecProperty(offset: 40, length: 1)]
    public UInt16 Frg35 { get; set; }
    [SunSpecProperty(offset: 41, length: 1)]
    public UInt16 Frg36 { get; set; }
    [SunSpecProperty(offset: 42, length: 1)]
    public UInt16 Frg37 { get; set; }
    [SunSpecProperty(offset: 43, length: 1)]
    public UInt16 Frg38 { get; set; }
    [SunSpecProperty(offset: 44, length: 1)]
    public UInt16 Frg39 { get; set; }
    [SunSpecProperty(offset: 45, length: 1)]
    public UInt16 Frg40 { get; set; }
    [SunSpecProperty(offset: 46, length: 1)]
    public UInt16 Frg41 { get; set; }
    [SunSpecProperty(offset: 47, length: 1)]
    public UInt16 Frg42 { get; set; }
    [SunSpecProperty(offset: 48, length: 1)]
    public UInt16 Frg43 { get; set; }
    [SunSpecProperty(offset: 49, length: 1)]
    public UInt16 Frg44 { get; set; }
    [SunSpecProperty(offset: 50, length: 1)]
    public UInt16 Frg45 { get; set; }
    [SunSpecProperty(offset: 51, length: 1)]
    public UInt16 Frg46 { get; set; }
    [SunSpecProperty(offset: 52, length: 1)]
    public UInt16 Frg47 { get; set; }
    [SunSpecProperty(offset: 53, length: 1)]
    public UInt16 Frg48 { get; set; }
    [SunSpecProperty(offset: 54, length: 1)]
    public UInt16 Frg49 { get; set; }
    [SunSpecProperty(offset: 55, length: 1)]
    public UInt16 Frg50 { get; set; }
    [SunSpecProperty(offset: 56, length: 1)]
    public UInt16 Frg51 { get; set; }
    [SunSpecProperty(offset: 57, length: 1)]
    public UInt16 Frg52 { get; set; }
    [SunSpecProperty(offset: 58, length: 1)]
    public UInt16 Frg53 { get; set; }
    [SunSpecProperty(offset: 59, length: 1)]
    public UInt16 Frg54 { get; set; }
    [SunSpecProperty(offset: 60, length: 1)]
    public UInt16 Frg55 { get; set; }
    [SunSpecProperty(offset: 61, length: 1)]
    public UInt16 Frg56 { get; set; }
    [SunSpecProperty(offset: 62, length: 1)]
    public UInt16 Frg57 { get; set; }
    [SunSpecProperty(offset: 63, length: 1)]
    public UInt16 Frg58 { get; set; }
    [SunSpecProperty(offset: 64, length: 1)]
    public UInt16 Frg59 { get; set; }
    [SunSpecProperty(offset: 65, length: 1)]
    public UInt16 Frg60 { get; set; }
    [SunSpecProperty(offset: 66, length: 1)]
    public UInt16 Frg61 { get; set; }
    [SunSpecProperty(offset: 67, length: 1)]
    public UInt16 Frg62 { get; set; }
    [SunSpecProperty(offset: 68, length: 1)]
    public UInt16 Frg63 { get; set; }
    [SunSpecProperty(offset: 69, length: 1)]
    public UInt16 Frg64 { get; set; }
    [SunSpecProperty(offset: 70, length: 1)]
    public UInt16 Frg65 { get; set; }
    [SunSpecProperty(offset: 71, length: 1)]
    public UInt16 Frg66 { get; set; }
    [SunSpecProperty(offset: 72, length: 1)]
    public UInt16 Frg67 { get; set; }
    [SunSpecProperty(offset: 73, length: 1)]
    public UInt16 Frg68 { get; set; }
    [SunSpecProperty(offset: 74, length: 1)]
    public UInt16 Frg69 { get; set; }
    [SunSpecProperty(offset: 75, length: 1)]
    public UInt16 Frg70 { get; set; }
    [SunSpecProperty(offset: 76, length: 1)]
    public UInt16 Frg71 { get; set; }
    [SunSpecProperty(offset: 77, length: 1)]
    public UInt16 Frg72 { get; set; }
    [SunSpecProperty(offset: 78, length: 1)]
    public UInt16 Frg73 { get; set; }
    [SunSpecProperty(offset: 79, length: 1)]
    public UInt16 Frg74 { get; set; }
    [SunSpecProperty(offset: 80, length: 1)]
    public UInt16 Frg75 { get; set; }
    [SunSpecProperty(offset: 81, length: 1)]
    public UInt16 Frg78 { get; set; }
    [SunSpecProperty(offset: 82, length: 1)]
    public UInt16 Frg79 { get; set; }
    /// Frag80 - Last word of this fragment
    /// Last word of this fragment
    [SunSpecProperty(offset: 83, length: 1)]
    public UInt16 Frg80 { get; set; }
    /// Timestamp - Timestamp value is the number of seconds since January 1, 2000
    /// Timestamp value is the number of seconds since January 1, 2000
    [SunSpecProperty(offset: 84, length: 1)]
    public UInt32 Ts { get; set; }
    /// Milliseconds - Millisecond counter 0-999
    /// Millisecond counter 0-999
    [SunSpecProperty(offset: 86, length: 1)]
    public UInt16 Ms { get; set; }
    /// Sequence - Sequence number of request
    /// Sequence number of request
    /// NOTES: Shall be advanced for each request
    [SunSpecProperty(offset: 87, length: 1)]
    public UInt16 Seq { get; set; }
    /// UID - User ID for the request signature
    /// User ID for the request signature
    [SunSpecProperty(offset: 88, length: 1)]
    public UInt16 UID { get; set; }
    /// Role - Signing key used 0-5
    /// Signing key used 0-5
    /// NOTES: Each controller is assigned a key index that maps to their access control role
    [SunSpecProperty(offset: 89, length: 1)]
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
    [SunSpecProperty(offset: 90, length: 1)]
    public E_Alg Alg { get; set; }
    /// N - Number of registers to follow for the certificate
    /// Number of registers to follow for the certificate
    [SunSpecProperty(offset: 91, length: 1)]
    public UInt16 N { get; set; }
    public struct 
    {
      [SunSpecProperty(offset: 0, length: 1)]
      public UInt16 Cert { get; set; }
    }[];
  }
}
