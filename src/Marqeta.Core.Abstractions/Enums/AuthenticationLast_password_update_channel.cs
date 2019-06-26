using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public enum AuthenticationLast_password_update_channel
    {
        [EnumMember(Value = @"USER_CHANGE")] USER_CHANGE = 0,

        [EnumMember(Value = @"USER_RESET")] USER_RESET = 1
    }
}