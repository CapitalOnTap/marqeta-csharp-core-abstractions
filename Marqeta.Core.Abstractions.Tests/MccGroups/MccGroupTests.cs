using DeepEqual.Syntax;
using Marqeta.Core.Abstractions.MccGroups;
using Newtonsoft.Json;
using Xunit;

namespace Marqeta.Core.Abstractions.Tests.MccGroups
{
    public class MccGroupTests : BaseAbstractionTests<MccGroup>
    {
        protected const string Json = @"
            {
              ""token"": ""my_mccgroup_01"",
              ""name"": ""My MCC Group 01"",
              ""mccs"": [
                ""0123"",
                ""2224-2230"",
                ""3876""
              ],
              ""active"": true,
              ""config"": {
                ""authorization_controls"": {
                  ""hold_increase"": {
                    ""type"": ""PERCENT"",
                    ""value"": 20
                  },
                  ""hold_expiration_days"": 2
                }
              }
            }
            ";

        protected MccGroup MccGroup = new MccGroup
        {
            Token = "my_mccgroup_01",
            Name = "My MCC Group 01",
            Mccs = new[] {"0123", "2224-2230", "3876"},
            Active = true,
            Config = new Config
            {
                AuthorizationControls = new AuthorizationControls
                {
                    HoldIncrease = new HoldIncrease
                    {
                        Type = HoldIncrease.HoldType.Percent,
                        Value = 20,
                    },
                    HoldExpirationDays = 2
                }
            },
        };

        [Fact]
        public void Deserialise()
        {
            var mccGroup = JsonConvert.DeserializeObject<MccGroup>(Json);
            mccGroup.ShouldDeepEqual(MccGroup);
        }
    }
}