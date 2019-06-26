using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public enum Balance_inquiry_request_modelAccount_type
    {
        [EnumMember(Value = @"checking")] Checking = 0,

        [EnumMember(Value = @"savings")] Savings = 1,

        [EnumMember(Value = @"credit")] Credit = 2
    }
}