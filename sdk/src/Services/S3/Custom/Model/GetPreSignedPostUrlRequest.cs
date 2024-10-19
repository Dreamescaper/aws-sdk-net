using Amazon.RuntimeDependencies;
using System;
using System.Collections.Generic;
using System.Text;


#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

namespace Amazon.S3.Model
{
    /// <summary>
    /// The parameters to create a pre-signed POST URL to a bucket or object. 
    /// </summary>
    public class GetPreSignedPostUrlRequest
    {
        public string BucketName { get; set; }
        public string Key { get; set; }
        public IList<Condition> Conditions { get; set; } = new List<Condition>();
        public TimeSpan? Expires { get; set; }

        public class Condition
        {
            private object[] values;

            private Condition(params object[] values)
            {
                this.values = values;
            }

            public static Condition ExactMatch(string key, string value)
            {
                return new Condition("eq", key, value);
            }

            public static Condition StartsWith(string key, string value)
            {
                return new Condition("starts-with", key, value);
            }

            public static Condition ContentLengthRange(long start, long end)
            {
                return new Condition("content-length-range", start, end);
            }
        }
    }
}
