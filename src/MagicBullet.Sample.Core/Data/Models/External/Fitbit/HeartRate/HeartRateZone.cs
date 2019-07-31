//-----------------------------------------------------------------------
// <copyright file="HeartRateZone.cs" company="Magic Bullet Ltd">
//     Copyright (c) Magic Bullet Ltd. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace MagicBullet.Sample.Core.Data.Models.External.Fitbit.HeartRate
{
    using Newtonsoft.Json;

    public class HeartRateZone
    {
        [JsonProperty(PropertyName = "caloriesOut")]
        public double CaloriesOut { get; set; }

        [JsonProperty(PropertyName = "max")]
        public int Max { get; set; }

        [JsonProperty(PropertyName = "min")]
        public int Min { get; set; }

        [JsonProperty(PropertyName = "minutes")]
        public int Minutes { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
    }
}