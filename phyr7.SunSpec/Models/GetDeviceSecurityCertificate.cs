using System;

{
  /// Security model for PKI
  [SunSpecModel(id: 8, length: 3)]
  public class GetDeviceSecurityCertificate
  {
    public enum E_Fmt : UInt16
    {
      NONE = 0,
      X509_PEM = 1,
      X509_DER = 2,
    }
    /// Format - X.509 format of the certificate. DER or PEM.
    /// X.509 format of the certificate. DER or PEM.
    [SunSpecProperty(offset: 0, length: 1)]
    public E_Fmt Fmt { get; private set; }
    /// N - Number of registers to follow for the certificate
    /// Number of registers to follow for the certificate
    [SunSpecProperty(offset: 1, length: 1)]
    public UInt16 N { get; private set; }
    public struct 
    {
      /// Cert - X.509 Certificate of the device
      /// X.509 Certificate of the device
      [SunSpecProperty(offset: 0, length: 1)]
      public UInt16 Cert { get; private set; }
    }[];
  }
}
