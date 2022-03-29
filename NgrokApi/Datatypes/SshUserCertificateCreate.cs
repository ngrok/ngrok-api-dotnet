
using System;
using System.Runtime;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NgrokApi
{
    public class SshUserCertificateCreate
    {
        // <summary>
        // the ssh certificate authority that is used to sign this ssh user certificate
        // </summary>
        [JsonProperty("ssh_certificate_authority_id")]
        public string SshCertificateAuthorityId { get; set; }
        // <summary>
        // a public key in OpenSSH Authorized Keys format that this certificate signs
        // </summary>
        [JsonProperty("public_key")]
        public string PublicKey { get; set; }
        // <summary>
        // the list of principals included in the ssh user certificate. This is the list of
        // usernames that the certificate holder may sign in as on a machine authorizing
        // the signing certificate authority. Dangerously, if no principals are specified,
        // this certificate may be used to log in as any user.
        // </summary>
        [JsonProperty("principals")]
        public List<string> Principals { get; set; }
        // <summary>
        // A map of critical options included in the certificate. Only two critical options
        // are currently defined by OpenSSH: <c>force-command</c> and
        // <c>source-address</c>. See <see
        // href="https://github.com/openssh/openssh-portable/blob/master/PROTOCOL.certkeys">the
        // OpenSSH certificate protocol spec</see> for additional details.
        // </summary>
        [JsonProperty("critical_options")]
        public Dictionary<string, string> CriticalOptions { get; set; }
        // <summary>
        // A map of extensions included in the certificate. Extensions are additional
        // metadata that can be interpreted by the SSH server for any purpose. These can be
        // used to permit or deny the ability to open a terminal, do port forwarding, x11
        // forwarding, and more. If unspecified, the certificate will include limited
        // permissions with the following extension map: <c>{"permit-pty": "",
        // "permit-user-rc": ""}</c> OpenSSH understands a number of predefined extensions.
        // See <see
        // href="https://github.com/openssh/openssh-portable/blob/master/PROTOCOL.certkeys">the
        // OpenSSH certificate protocol spec</see> for additional details.
        // </summary>
        [JsonProperty("extensions")]
        public Dictionary<string, string> Extensions { get; set; }
        // <summary>
        // The time when the user certificate becomes valid, in RFC 3339 format. Defaults
        // to the current time if unspecified.
        // </summary>
        [JsonProperty("valid_after")]
        public string ValidAfter { get; set; }
        // <summary>
        // The time when this host certificate becomes invalid, in RFC 3339 format. If
        // unspecified, a default value of 24 hours will be used. The OpenSSH certificates
        // RFC calls this <c>valid_before</c>.
        // </summary>
        [JsonProperty("valid_until")]
        public string ValidUntil { get; set; }
        // <summary>
        // human-readable description of this SSH User Certificate. optional, max 255
        // bytes.
        // </summary>
        [JsonProperty("description")]
        public string Description { get; set; }
        // <summary>
        // arbitrary user-defined machine-readable data of this SSH User Certificate.
        // optional, max 4096 bytes.
        // </summary>
        [JsonProperty("metadata")]
        public string Metadata { get; set; }

        public override string ToString()
        {
            return $"SshUserCertificateCreate SshCertificateAuthorityId={ SshCertificateAuthorityId }  PublicKey={ PublicKey }  Principals={ Principals }  CriticalOptions={ CriticalOptions }  Extensions={ Extensions }  ValidAfter={ ValidAfter }  ValidUntil={ ValidUntil }  Description={ Description }  Metadata={ Metadata } ";
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + (SshCertificateAuthorityId?.GetHashCode() ?? 0);

                hash = hash * 23 + (PublicKey?.GetHashCode() ?? 0);

                hash = hash * 23 + (Principals?.GetHashCode() ?? 0);

                hash = hash * 23 + (CriticalOptions?.GetHashCode() ?? 0);

                hash = hash * 23 + (Extensions?.GetHashCode() ?? 0);

                hash = hash * 23 + (ValidAfter?.GetHashCode() ?? 0);

                hash = hash * 23 + (ValidUntil?.GetHashCode() ?? 0);

                hash = hash * 23 + (Description?.GetHashCode() ?? 0);

                hash = hash * 23 + (Metadata?.GetHashCode() ?? 0);

                return hash;
            }
        }


        public override bool Equals(object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            var other = (SshUserCertificateCreate)obj;
            return (
                 this.SshCertificateAuthorityId == other.SshCertificateAuthorityId
                && this.PublicKey == other.PublicKey
                && this.Principals == other.Principals
                && this.CriticalOptions == other.CriticalOptions
                && this.Extensions == other.Extensions
                && this.ValidAfter == other.ValidAfter
                && this.ValidUntil == other.ValidUntil
                && this.Description == other.Description
                && this.Metadata == other.Metadata
            );
        }

    }
}
