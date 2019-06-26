using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace Marqeta.Core.Abstractions
{
    [GeneratedCode("NJsonSchema", "10.0.20.0 (Newtonsoft.Json v11.0.0.0)")]
    public enum TransitTransportation_mode
    {
        [EnumMember(Value = @"BUS")] BUS = 0,

        [EnumMember(Value = @"TRAIN")] TRAIN = 1,

        [EnumMember(Value = @"WATER_BORNE_VEHICLE")]
        WATER_BORNE_VEHICLE = 2,

        [EnumMember(Value = @"TOLL")] TOLL = 3,

        [EnumMember(Value = @"PARKING")] PARKING = 4,

        [EnumMember(Value = @"TAXI")] TAXI = 5,

        [EnumMember(Value = @"PARA_TRANSIT")] PARA_TRANSIT = 6,

        [EnumMember(Value = @"SELF_DRIVE_VEHICLE")]
        SELF_DRIVE_VEHICLE = 7,

        [EnumMember(Value = @"COACH")] COACH = 8,

        [EnumMember(Value = @"LOCOMOTIVE")] LOCOMOTIVE = 9,

        [EnumMember(Value = @"POWERED_MOTOR_VEHICLE")]
        POWERED_MOTOR_VEHICLE = 10,

        [EnumMember(Value = @"TRAILER")] TRAILER = 11,

        [EnumMember(Value = @"INTER_CITY")] INTER_CITY = 12,

        [EnumMember(Value = @"CABLE_CAR")] CABLE_CAR = 13
    }
}