using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Marqeta.Core.Abstractions
{
    [JsonConverter(typeof(JsonInheritanceConverter), "type")]
    [JsonInheritance("payment_card_funding_source_model", typeof(Payment_card_funding_source_model))]
    [JsonInheritance("program_funding_source_model", typeof(Program_funding_source_model))]
    [JsonInheritance("direct_deposit_funding_source_model", typeof(Direct_deposit_funding_source_model))]
    [JsonInheritance("chargeback_funding_source_model", typeof(Chargeback_funding_source_model))]
    [JsonInheritance("bank_account_funding_source_model", typeof(Bank_account_funding_source_model))]
    [JsonInheritance("program_gateway_funding_source_model", typeof(Program_gateway_funding_source_model))]
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class Funding_source_model
    {
        [JsonProperty("token", Required = Required.Always)]
        [Required(AllowEmptyStrings = true)]
        public string Token { get; set; }

        [JsonProperty("active", Required = Required.Always)]
        public bool Active { get; set; }

        [JsonProperty("is_default_account", Required = Required.Always)]
        public bool Is_default_account { get; set; }

        [JsonProperty("created_time", Required = Required.Always)]
        [Required(AllowEmptyStrings = true)]
        public DateTimeOffset Created_time { get; set; }

        [JsonProperty("last_modified_time", Required = Required.Always)]
        [Required(AllowEmptyStrings = true)]
        public DateTimeOffset Last_modified_time { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}