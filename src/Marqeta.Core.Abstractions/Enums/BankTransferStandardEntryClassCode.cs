using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public enum BankTransferStandardEntryClassCode
    {
        [EnumMember(Value = @"WEB")] WEB = 0,

        [EnumMember(Value = @"PPD")] PPD = 1,

        [EnumMember(Value = @"CCD")] CCD = 2
    }
}