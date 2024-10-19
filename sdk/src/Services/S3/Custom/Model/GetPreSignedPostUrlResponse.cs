using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

namespace Amazon.S3.Model
{
    public class GetPreSignedPostUrlResponse
    {
        public string Url { get; set; }
        public Dictionary<string, string> Fields { get; set; }
    }
}
