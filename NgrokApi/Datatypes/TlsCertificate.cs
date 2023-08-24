/* Code generated for API Clients. DO NOT EDIT. */


using System;
using System.Runtime;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NgrokApi
{
    public class TlsCertificate : HasId
    {
        // <summary>
        // unique identifier for this TLS certificate
        // </summary>
        [JsonProperty("id")]
        public string Id { get; set; }
        // <summary>
        // URI of the TLS certificate API resource
        // </summary>
        [JsonProperty("uri")]
        public Uri Uri { get; set; }
        // <summary>
        // timestamp when the TLS certificate was created, RFC 3339 format
        // </summary>
        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }
        // <summary>
        // human-readable description of this TLS certificate. optional, max 255 bytes.
        // </summary>
        [JsonProperty("description")]
        public string Description { get; set; }
        // <summary>
        // arbitrary user-defined machine-readable data of this TLS certificate. optional,
        // max 4096 bytes.
        // </summary>
        [JsonProperty("metadata")]
        public string Metadata { get; set; }
        // <summary>
        // chain of PEM-encoded certificates, leaf first. See <see
        // href="https://ngrok.com/docs/cloud-edge/endpoints#certificate-chains">Certificate
        // Bundles</see>.
        // </summary>
        [JsonProperty("certificate_pem")]
        public string CertificatePem { get; set; }
        // <summary>
        // subject common name from the leaf of this TLS certificate
        // </summary>
        [JsonProperty("subject_common_name")]
        public string SubjectCommonName { get; set; }
        // <summary>
        // subject alternative names (SANs) from the leaf of this TLS certificate
        // </summary>
        [JsonProperty("subject_alternative_names")]
        public TlsCertificateSaNs SubjectAlternativeNames { get; set; }
        // <summary>
        // timestamp (in RFC 3339 format) when this TLS certificate was issued
        // automatically, or null if this certificate was user-uploaded
        // </summary>
        [JsonProperty("issued_at")]
        public string IssuedAt { get; set; }
        // <summary>
        // timestamp when this TLS certificate becomes valid, RFC 3339 format
        // </summary>
        [JsonProperty("not_before")]
        public string NotBefore { get; set; }
        // <summary>
        // timestamp when this TLS certificate becomes invalid, RFC 3339 format
        // </summary>
        [JsonProperty("not_after")]
        public string NotAfter { get; set; }
        // <summary>
        // set of actions the private key of this TLS certificate can be used for
        // </summary>
        [JsonProperty("key_usages")]
        public List<string> KeyUsages { get; set; }
        // <summary>
        // extended set of actions the private key of this TLS certificate can be used for
        // </summary>
        [JsonProperty("extended_key_usages")]
        public List<string> ExtendedKeyUsages { get; set; }
        // <summary>
        // type of the private key of this TLS certificate. One of rsa, ecdsa, or ed25519.
        // </summary>
        [JsonProperty("private_key_type")]
        public string PrivateKeyType { get; set; }
        // <summary>
        // issuer common name from the leaf of this TLS certificate
        // </summary>
        [JsonProperty("issuer_common_name")]
        public string IssuerCommonName { get; set; }
        // <summary>
        // serial number of the leaf of this TLS certificate
        // </summary>
        [JsonProperty("serial_number")]
        public string SerialNumber { get; set; }
        // <summary>
        // subject organization from the leaf of this TLS certificate
        // </summary>
        [JsonProperty("subject_organization")]
        public string SubjectOrganization { get; set; }
        // <summary>
        // subject organizational unit from the leaf of this TLS certificate
        // </summary>
        [JsonProperty("subject_organizational_unit")]
        public string SubjectOrganizationalUnit { get; set; }
        // <summary>
        // subject locality from the leaf of this TLS certificate
        // </summary>
        [JsonProperty("subject_locality")]
        public string SubjectLocality { get; set; }
        // <summary>
        // subject province from the leaf of this TLS certificate
        // </summary>
        [JsonProperty("subject_province")]
        public string SubjectProvince { get; set; }
        // <summary>
        // subject country from the leaf of this TLS certificate
        // </summary>
        [JsonProperty("subject_country")]
        public string SubjectCountry { get; set; }

        public override string ToString()
        {
            return $"TlsCertificate Id={ Id }  Uri={ Uri }  CreatedAt={ CreatedAt }  Description={ Description }  Metadata={ Metadata }  CertificatePem={ CertificatePem }  SubjectCommonName={ SubjectCommonName }  SubjectAlternativeNames={ SubjectAlternativeNames }  IssuedAt={ IssuedAt }  NotBefore={ NotBefore }  NotAfter={ NotAfter }  KeyUsages={ KeyUsages }  ExtendedKeyUsages={ ExtendedKeyUsages }  PrivateKeyType={ PrivateKeyType }  IssuerCommonName={ IssuerCommonName }  SerialNumber={ SerialNumber }  SubjectOrganization={ SubjectOrganization }  SubjectOrganizationalUnit={ SubjectOrganizationalUnit }  SubjectLocality={ SubjectLocality }  SubjectProvince={ SubjectProvince }  SubjectCountry={ SubjectCountry } ";
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + (Id?.GetHashCode() ?? 0);

                hash = hash * 23 + (Uri?.GetHashCode() ?? 0);

                hash = hash * 23 + (CreatedAt?.GetHashCode() ?? 0);

                hash = hash * 23 + (Description?.GetHashCode() ?? 0);

                hash = hash * 23 + (Metadata?.GetHashCode() ?? 0);

                hash = hash * 23 + (CertificatePem?.GetHashCode() ?? 0);

                hash = hash * 23 + (SubjectCommonName?.GetHashCode() ?? 0);

                hash = hash * 23 + (SubjectAlternativeNames?.GetHashCode() ?? 0);

                hash = hash * 23 + (IssuedAt?.GetHashCode() ?? 0);

                hash = hash * 23 + (NotBefore?.GetHashCode() ?? 0);

                hash = hash * 23 + (NotAfter?.GetHashCode() ?? 0);

                hash = hash * 23 + (KeyUsages?.GetHashCode() ?? 0);

                hash = hash * 23 + (ExtendedKeyUsages?.GetHashCode() ?? 0);

                hash = hash * 23 + (PrivateKeyType?.GetHashCode() ?? 0);

                hash = hash * 23 + (IssuerCommonName?.GetHashCode() ?? 0);

                hash = hash * 23 + (SerialNumber?.GetHashCode() ?? 0);

                hash = hash * 23 + (SubjectOrganization?.GetHashCode() ?? 0);

                hash = hash * 23 + (SubjectOrganizationalUnit?.GetHashCode() ?? 0);

                hash = hash * 23 + (SubjectLocality?.GetHashCode() ?? 0);

                hash = hash * 23 + (SubjectProvince?.GetHashCode() ?? 0);

                hash = hash * 23 + (SubjectCountry?.GetHashCode() ?? 0);

                return hash;
            }
        }


        public override bool Equals(object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            var other = (TlsCertificate)obj;
            return (
                 this.Id == other.Id
                && this.Uri == other.Uri
                && this.CreatedAt == other.CreatedAt
                && this.Description == other.Description
                && this.Metadata == other.Metadata
                && this.CertificatePem == other.CertificatePem
                && this.SubjectCommonName == other.SubjectCommonName
                && this.SubjectAlternativeNames == other.SubjectAlternativeNames
                && this.IssuedAt == other.IssuedAt
                && this.NotBefore == other.NotBefore
                && this.NotAfter == other.NotAfter
                && this.KeyUsages == other.KeyUsages
                && this.ExtendedKeyUsages == other.ExtendedKeyUsages
                && this.PrivateKeyType == other.PrivateKeyType
                && this.IssuerCommonName == other.IssuerCommonName
                && this.SerialNumber == other.SerialNumber
                && this.SubjectOrganization == other.SubjectOrganization
                && this.SubjectOrganizationalUnit == other.SubjectOrganizationalUnit
                && this.SubjectLocality == other.SubjectLocality
                && this.SubjectProvince == other.SubjectProvince
                && this.SubjectCountry == other.SubjectCountry
            );
        }

    }
}
