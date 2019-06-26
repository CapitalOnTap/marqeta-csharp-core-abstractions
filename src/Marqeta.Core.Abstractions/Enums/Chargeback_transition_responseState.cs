namespace Marqeta.Core.Abstractions
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public enum Chargeback_transition_responseState
    {
        [System.Runtime.Serialization.EnumMember(Value = @"INITIATED")]
        INITIATED = 0,
    
        [System.Runtime.Serialization.EnumMember(Value = @"REPRESENTMENT")]
        REPRESENTMENT = 1,
    
        [System.Runtime.Serialization.EnumMember(Value = @"PREARBITRATION")]
        PREARBITRATION = 2,
    
        [System.Runtime.Serialization.EnumMember(Value = @"ARBITRATION")]
        ARBITRATION = 3,
    
        [System.Runtime.Serialization.EnumMember(Value = @"CASE_WON")]
        CASE_WON = 4,
    
        [System.Runtime.Serialization.EnumMember(Value = @"CASE_LOST")]
        CASE_LOST = 5,
    
        [System.Runtime.Serialization.EnumMember(Value = @"NETWORK_REJECTED")]
        NETWORK_REJECTED = 6,
    
        [System.Runtime.Serialization.EnumMember(Value = @"WRITTEN_OFF_ISSUER")]
        WRITTEN_OFF_ISSUER = 7,
    
        [System.Runtime.Serialization.EnumMember(Value = @"WRITTEN_OFF_PROGRAM")]
        WRITTEN_OFF_PROGRAM = 8,
    
    }
}