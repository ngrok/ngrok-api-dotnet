using System;
using System.Collections.Generic;

namespace NgrokApi
{
    public class NgrokException : Exception
    {
        private Error err;

        internal NgrokException(Error err)
          : base(err.Msg)
        {
            this.err = err;
        }

        public bool IsErrorCode(params string[] codes)
        {
            foreach (var code in codes)
            {
                if (err.ErrorCode == code)
                {
                    return true;
                }
            }
            return false;
        }

        public string OperationId()
        {
            if (this.Details == null)
            {
                return null;
            }
            string opId;
            this.Details.TryGetValue("operation_id", out opId);
            return opId;
        }

        public string ErrorCode
        {
            get { return err.ErrorCode; }
        }

        public int HttpStatusCode
        {
            get { return err.StatusCode; }
        }

        public Dictionary<string, string> Details
        {
            get { return err.Details; }
        }
    }
}
