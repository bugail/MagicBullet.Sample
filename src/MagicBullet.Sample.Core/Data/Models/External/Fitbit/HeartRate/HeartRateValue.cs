//-----------------------------------------------------------------------
// <copyright file="HeartRateValue.cs" company="Magic Bullet Ltd">
//     Copyright (c) Magic Bullet Ltd. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace MagicBullet.Sample.Core.Data.Models.External.Fitbit.HeartRate
{
    using System.Collections.Generic;

    using Newtonsoft.Json;

    /// <summary>
    /// The heart rate model
    /// </summary>
    public class HeartRateValue
    {
        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        /// <value>
        /// The value.
        /// </value>
        [JsonProperty(PropertyName = "restingHeartRate")]
        public int RestingHeartRate { get; set; }

        [JsonProperty(PropertyName = "heartRateZones")]
        public IEnumerable<HeartRateZone> HeartRateZones { get; set; }
    }
}
