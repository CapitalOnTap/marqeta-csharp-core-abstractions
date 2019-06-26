﻿using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public class FileProcessingResponse
    {
        [JsonProperty("created_time", Required = Required.Always)]
        [Required(AllowEmptyStrings = true)]
        public DateTimeOffset Created_time { get; set; }

        [JsonProperty("last_modified_time", Required = Required.Always)]
        [Required(AllowEmptyStrings = true)]
        public DateTimeOffset Last_modified_time { get; set; }

        [JsonProperty("token", Required = Required.Always)]
        [Required]
        [StringLength(36, MinimumLength = 1)]
        public string Token { get; set; }

        [JsonProperty("file_process_type", Required = Required.Always)]
        [Required(AllowEmptyStrings = true)]
        [JsonConverter(typeof(StringEnumConverter))]
        public FileProcessingResponseFile_process_type File_process_type { get; set; }

        [JsonProperty("source_file", Required = Required.Always)]
        [Required(AllowEmptyStrings = true)]
        public string Source_file { get; set; }

        [JsonProperty("archive_file", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Archive_file { get; set; }

        [JsonProperty("file_process_status", Required = Required.Always)]
        [Required(AllowEmptyStrings = true)]
        [JsonConverter(typeof(StringEnumConverter))]
        public FileProcessingResponseFile_process_status File_process_status { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}