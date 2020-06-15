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
  /// Security model for PKI
  [SunSpecModel(id: 8, length: 3)]
  public struct GetDeviceSecurityCertificate
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
    public struct S_Block2
    {
      /// Cert - X.509 Certificate of the device
      /// X.509 Certificate of the device
      [SunSpecProperty(offset: 0, length: 1)]
      public UInt16 Cert { get; private set; }
    };
    public S_Block2[] Block2;
  }
}
