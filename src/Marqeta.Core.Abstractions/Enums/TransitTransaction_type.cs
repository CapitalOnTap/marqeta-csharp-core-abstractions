namespace Marqeta.Core.Abstractions
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public enum TransitTransaction_type
    {
        [System.Runtime.Serialization.EnumMember(Value = @"PRE_FUNDED")]
        PRE_FUNDED = 0,
    
        [System.Runtime.Serialization.EnumMember(Value = @"REAL_TIME_AUTHORIZED")]
        REAL_TIME_AUTHORIZED = 1,
    
        [System.Runtime.Serialization.EnumMember(Value = @"POST_AUTHORIZED_AGGREGATED")]
        POST_AUTHORIZED_AGGREGATED = 2,
    
        [System.Runtime.Serialization.EnumMember(Value = @"AUTHORIZED_AGGREGATED_SPLIT_CLEARING")]
        AUTHORIZED_AGGREGATED_SPLIT_CLEARING = 3,
    
        [System.Runtime.Serialization.EnumMember(Value = @"OTHER")]
        OTHER = 4,
    
        [System.Runtime.Serialization.EnumMember(Value = @"DEBIT_RECOVERY")]
        DEBIT_RECOVERY = 5,
    
    }
}