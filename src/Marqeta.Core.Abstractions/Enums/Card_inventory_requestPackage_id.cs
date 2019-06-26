using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public enum Card_inventory_requestPackage_id
    {
        [EnumMember(Value = @"Package")] Package = 0,

        [EnumMember(Value = @"Id")] Id = 1,

        [EnumMember(Value = @"assigned")] Assigned = 2,

        [EnumMember(Value = @"by")] By = 3,

        [EnumMember(Value = @"card")] Card = 4,

        [EnumMember(Value = @"fulfillment")] Fulfillment = 5
    }
}