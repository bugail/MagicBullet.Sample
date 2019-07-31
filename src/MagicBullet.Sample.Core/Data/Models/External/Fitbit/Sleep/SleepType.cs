//-----------------------------------------------------------------------
// <copyright file="SleepType.cs" company="Magic Bullet Ltd">
//     Copyright (c) Magic Bullet Ltd. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace MagicBullet.Sample.Core.Data.Models.External.Fitbit.Sleep
{
    using Newtonsoft.Json;

    public class SleepType
    {
        [JsonProperty(PropertyName = "count")]
        public int Count { get; set; }

        [JsonProperty(PropertyName = "minutes")]
        public int Minutes { get; set; }

        [JsonProperty(PropertyName = "thirtyDayAvgMinutes")]
        public int ThirtyDayAvgMinutes { get; set; }
    }
}
