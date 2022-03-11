using System.Text.Json.Serialization;

namespace NgrokApi
{
    public class AwsRole
    {
        // <summary>
        // An ARN that specifies the role that ngrok should use to deliver to the
        // configured target.
        // </summary>
        [JsonPropertyName("role_arn")]
        public string RoleArn { get; set; }

        public override string ToString()
        {
            return $"AwsRole RoleArn={ RoleArn } ";
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + (RoleArn?.GetHashCode() ?? 0);

                return hash;
            }
        }


        public override bool Equals(object obj)
        {
            var other = (AwsRole)obj;
            return (
                 this.RoleArn == other.RoleArn
            );
        }

    }
}
