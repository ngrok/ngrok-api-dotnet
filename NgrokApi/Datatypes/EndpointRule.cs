/* Code generated for API Clients. DO NOT EDIT. */


using System;
using System.Runtime;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NgrokApi
{
    public class EndpointRule
    {
        // <summary>
        // cel expressions that filter traffic the policy rule applies to.
        // </summary>
        [JsonProperty("expressions")]
        public List<string> Expressions { get; set; }
        // <summary>
        // the set of actions on a policy rule.
        // </summary>
        [JsonProperty("actions")]
        public List<EndpointAction> Actions { get; set; }
        // <summary>
        // the name of the rule that is part of the traffic policy.
        // </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        public override string ToString()
        {
            return $"EndpointRule Expressions={ Expressions }  Actions={ Actions }  Name={ Name } ";
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + (Expressions?.GetHashCode() ?? 0);

                hash = hash * 23 + (Actions?.GetHashCode() ?? 0);

                hash = hash * 23 + (Name?.GetHashCode() ?? 0);

                return hash;
            }
        }


        public override bool Equals(object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            var other = (EndpointRule)obj;
            return (
                 this.Expressions == other.Expressions
                && this.Actions == other.Actions
                && this.Name == other.Name
            );
        }

    }
}
