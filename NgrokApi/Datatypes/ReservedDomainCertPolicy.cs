/* Code generated for API Clients. DO NOT EDIT. */


using System;
using System.Runtime;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NgrokApi
{
    public class ReservedDomainCertPolicy
    {
        // <summary>
        // certificate authority to request certificates from. The only supported value is
        // letsencrypt.
        // </summary>
        [JsonProperty("authority")]
        public string Authority { get; set; }
        // <summary>
        // type of private key to use when requesting certificates. Defaults to rsa, can be
        // either rsa or ecdsa.
        // </summary>
        [JsonProperty("private_key_type")]
        public string PrivateKeyType { get; set; }

        public override string ToString()
        {
            return $"ReservedDomainCertPolicy Authority={ Authority }  PrivateKeyType={ PrivateKeyType } ";
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + (Authority?.GetHashCode() ?? 0);

                hash = hash * 23 + (PrivateKeyType?.GetHashCode() ?? 0);

                return hash;
            }
        }


        public override bool Equals(object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            var other = (ReservedDomainCertPolicy)obj;
            return (
                 this.Authority == other.Authority
                && this.PrivateKeyType == other.PrivateKeyType
            );
        }

    }
}
