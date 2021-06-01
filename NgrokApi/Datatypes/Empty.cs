
using System;
using System.Runtime;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NgrokApi
{
    public class Empty
    {

        public override string ToString()
        {
            return $"Empty";
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                return hash;
            }
        }


    }
}
