using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public enum BankTransferType
    {
        [EnumMember(Value = @"PUSH")] PUSH = 0,

        [EnumMember(Value = @"PULL")] PULL = 1
    }
}