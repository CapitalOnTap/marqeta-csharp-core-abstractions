using System.CodeDom.Compiler;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class Pos
    {
        [JsonProperty("pan_entry_mode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(StringEnumConverter))]
        public PosPan_entry_mode? Pan_entry_mode { get; set; }

        [JsonProperty("pin_entry_mode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(StringEnumConverter))]
        public PosPin_entry_mode? Pin_entry_mode { get; set; }

        [JsonProperty("terminal_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Terminal_id { get; set; }

        [JsonProperty("terminal_attendance", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(StringEnumConverter))]
        public PosTerminal_attendance? Terminal_attendance { get; set; }

        [JsonProperty("terminal_location", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(StringEnumConverter))]
        public PosTerminal_location? Terminal_location { get; set; }

        [JsonProperty("card_holder_presence", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public bool? Card_holder_presence { get; set; } = false;

        [JsonProperty("cardholder_authentication_method", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(StringEnumConverter))]
        public PosCardholder_authentication_method? Cardholder_authentication_method { get; set; }

        [JsonProperty("card_presence", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Card_presence { get; set; } = false;

        [JsonProperty("terminal_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(StringEnumConverter))]
        public PosTerminal_type? Terminal_type { get; set; }

        [JsonProperty("card_data_input_capability", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(StringEnumConverter))]
        public PosCard_data_input_capability? Card_data_input_capability { get; set; }

        [JsonProperty("country_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Country_code { get; set; }

        [JsonProperty("zip", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Zip { get; set; }

        [JsonProperty("partial_approval_capable", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public bool? Partial_approval_capable { get; set; } = false;

        [JsonProperty("purchase_amount_only", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public bool? Purchase_amount_only { get; set; } = false;

        [JsonProperty("is_recurring", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Is_recurring { get; set; } = false;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}