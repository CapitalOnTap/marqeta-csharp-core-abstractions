using System;
using System.CodeDom.Compiler;
using System.Linq;
using System.Reflection;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    internal class JsonInheritanceConverter : JsonConverter
    {
        internal static readonly string DefaultDiscriminatorName = "discriminator";

        [ThreadStatic] private static bool _isReading;

        [ThreadStatic] private static bool _isWriting;

        private readonly string _discriminator;

        public JsonInheritanceConverter()
        {
            _discriminator = DefaultDiscriminatorName;
        }

        public JsonInheritanceConverter(string discriminator)
        {
            _discriminator = discriminator;
        }

        public override bool CanWrite
        {
            get
            {
                if (_isWriting)
                {
                    _isWriting = false;
                    return false;
                }

                return true;
            }
        }

        public override bool CanRead
        {
            get
            {
                if (_isReading)
                {
                    _isReading = false;
                    return false;
                }

                return true;
            }
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            try
            {
                _isWriting = true;

                var jObject = JObject.FromObject(value, serializer);
                jObject.AddFirst(new JProperty(_discriminator, GetSubtypeDiscriminator(value.GetType())));
                writer.WriteToken(jObject.CreateReader());
            }
            finally
            {
                _isWriting = false;
            }
        }

        public override bool CanConvert(Type objectType)
        {
            return true;
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue,
            JsonSerializer serializer)
        {
            var jObject = serializer.Deserialize<JObject>(reader);
            if (jObject == null)
                return null;

            var discriminator = Extensions.Value<string>(jObject.GetValue(_discriminator));
            var subtype = GetObjectSubtype(objectType, discriminator);

            var objectContract = serializer.ContractResolver.ResolveContract(subtype) as JsonObjectContract;
            if (objectContract == null ||
                Enumerable.All(objectContract.Properties, p => p.PropertyName != _discriminator))
                jObject.Remove(_discriminator);

            try
            {
                _isReading = true;
                return serializer.Deserialize(jObject.CreateReader(), subtype);
            }
            finally
            {
                _isReading = false;
            }
        }

        private Type GetObjectSubtype(Type objectType, string discriminator)
        {
            foreach (var attribute in CustomAttributeExtensions.GetCustomAttributes<JsonInheritanceAttribute>(
                IntrospectionExtensions.GetTypeInfo(objectType), true))
                if (attribute.Key == discriminator)
                    return attribute.Type;

            return objectType;
        }

        private string GetSubtypeDiscriminator(Type objectType)
        {
            foreach (var attribute in CustomAttributeExtensions.GetCustomAttributes<JsonInheritanceAttribute>(
                IntrospectionExtensions.GetTypeInfo(objectType), true))
                if (attribute.Type == objectType)
                    return attribute.Key;

            return objectType.Name;
        }
    }
}