using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public enum Advanced_clearing_request_modelSub_network
    {
        [EnumMember(Value = @"VISANET")] VISANET = 0,

        [EnumMember(Value = @"VISANETDEBIT")] VISANETDEBIT = 1,

        [EnumMember(Value = @"VISAINTERLINK")] VISAINTERLINK = 2,

        [EnumMember(Value = @"VISAPLUS")] VISAPLUS = 3
    }
}