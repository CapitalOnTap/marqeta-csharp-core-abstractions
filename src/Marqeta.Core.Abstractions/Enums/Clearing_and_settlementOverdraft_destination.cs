using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public enum Clearing_and_settlementOverdraft_destination
    {
        [EnumMember(Value = @"GPA")] GPA = 0,

        [EnumMember(Value = @"MSA")] MSA = 1,

        [EnumMember(Value = @"MERCHANT_CAMPAIGN_ACCOUNT")]
        MERCHANT_CAMPAIGN_ACCOUNT = 2,

        [EnumMember(Value = @"GLOBAL_OVERDRAFT_ACCOUNT")]
        GLOBAL_OVERDRAFT_ACCOUNT = 3
    }
}