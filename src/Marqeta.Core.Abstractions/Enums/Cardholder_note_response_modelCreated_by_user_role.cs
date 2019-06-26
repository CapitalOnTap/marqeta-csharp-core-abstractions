using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public enum Cardholder_note_response_modelCreated_by_user_role
    {
        [EnumMember(Value = @"USER")] USER = 0,

        [EnumMember(Value = @"ADMIN")] ADMIN = 1,

        [EnumMember(Value = @"BANK_USER")] BANK_USER = 2,

        [EnumMember(Value = @"BANK_ADMIN")] BANK_ADMIN = 3,

        [EnumMember(Value = @"MARQETA_PD")] MARQETA_PD = 4,

        [EnumMember(Value = @"MARQETA_ADMIN")] MARQETA_ADMIN = 5
    }
}