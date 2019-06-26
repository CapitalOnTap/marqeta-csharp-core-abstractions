using System;
using System.CodeDom.Compiler;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    internal class JsonInheritanceAttribute : Attribute
    {
        public JsonInheritanceAttribute(string key, Type type)
        {
            Key = key;
            Type = type;
        }

        public string Key { get; }

        public Type Type { get; }
    }
}