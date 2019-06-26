namespace Marqeta.Core.Abstractions
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public enum Chargeback_transition_requestState
    {
        [System.Runtime.Serialization.EnumMember(Value = @"REPRESENTMENT")]
        REPRESENTMENT = 0,
    
        [System.Runtime.Serialization.EnumMember(Value = @"PREARBITRATION")]
        PREARBITRATION = 1,
    
        [System.Runtime.Serialization.EnumMember(Value = @"ARBITRATION")]
        ARBITRATION = 2,
    
        [System.Runtime.Serialization.EnumMember(Value = @"CASE_WON")]
        CASE_WON = 3,
    
        [System.Runtime.Serialization.EnumMember(Value = @"CASE_LOST")]
        CASE_LOST = 4,
    
        [System.Runtime.Serialization.EnumMember(Value = @"WRITTEN_OFF_ISSUER")]
        WRITTEN_OFF_ISSUER = 5,
    
        [System.Runtime.Serialization.EnumMember(Value = @"WRITTEN_OFF_PROGRAM")]
        WRITTEN_OFF_PROGRAM = 6,
    
    }
}