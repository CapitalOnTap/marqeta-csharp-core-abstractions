namespace Marqeta.Core.Abstractions
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public enum Bank_transfer_transition_request_modelStatus
    {
        [System.Runtime.Serialization.EnumMember(Value = @"PENDING")]
        PENDING = 0,
    
        [System.Runtime.Serialization.EnumMember(Value = @"PROCESSING")]
        PROCESSING = 1,
    
        [System.Runtime.Serialization.EnumMember(Value = @"SUBMITTED")]
        SUBMITTED = 2,
    
        [System.Runtime.Serialization.EnumMember(Value = @"RETURNED")]
        RETURNED = 3,
    
        [System.Runtime.Serialization.EnumMember(Value = @"COMPLETED")]
        COMPLETED = 4,
    
        [System.Runtime.Serialization.EnumMember(Value = @"CANCELED")]
        CANCELED = 5,
    
    }
}