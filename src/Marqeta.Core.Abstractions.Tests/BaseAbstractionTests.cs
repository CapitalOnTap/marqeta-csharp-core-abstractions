using AutoFixture;
using DeepEqual.Syntax;
using Newtonsoft.Json;
using Xunit;

namespace Marqeta.Core.Abstractions.Tests
{
    public abstract class BaseAbstractionTests<T> where T : class
    {
        [Fact]
        public void Roundtrip()
        {
            var fixture = new Fixture();
            var original = fixture.Create<T>();
            var originalJson = JsonConvert.SerializeObject(original);
            var actual = JsonConvert.DeserializeObject<T>(originalJson);
            original.ShouldDeepEqual(actual);
        }
    }
}