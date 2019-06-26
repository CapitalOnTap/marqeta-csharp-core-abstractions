namespace Marqeta.Core.Abstractions
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public enum Chargeback_transition_responseType
    {
        [System.Runtime.Serialization.EnumMember(Value = @"initiated")]
        Initiated = 0,
    
        [System.Runtime.Serialization.EnumMember(Value = @"representment")]
        Representment = 1,
    
        [System.Runtime.Serialization.EnumMember(Value = @"prearbitration")]
        Prearbitration = 2,
    
        [System.Runtime.Serialization.EnumMember(Value = @"arbitration")]
        Arbitration = 3,
    
        [System.Runtime.Serialization.EnumMember(Value = @"case_won")]
        Case_won = 4,
    
        [System.Runtime.Serialization.EnumMember(Value = @"case_lost")]
        Case_lost = 5,
    
        [System.Runtime.Serialization.EnumMember(Value = @"network_rejected")]
        Network_rejected = 6,
    
        [System.Runtime.Serialization.EnumMember(Value = @"written_off_issuer")]
        Written_off_issuer = 7,
    
        [System.Runtime.Serialization.EnumMember(Value = @"written_off_program")]
        Written_off_program = 8,
    
    }
}