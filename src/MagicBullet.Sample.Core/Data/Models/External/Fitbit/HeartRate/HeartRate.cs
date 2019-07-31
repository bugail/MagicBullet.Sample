//-----------------------------------------------------------------------
// <copyright file="HeartRate.cs" company="Magic Bullet Ltd">
//     Copyright (c) Magic Bullet Ltd. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace MagicBullet.Sample.Core.Data.Models.External.Fitbit.HeartRate
{
    using Newtonsoft.Json;

    /// <summary>
    /// The fitbit heart rate model
    /// </summary>
    public class HeartRate 
    {
        /// <summary>
        /// Gets or sets the date.
        /// </summary>
        /// <value>
        /// The date.
        /// </value>
        [JsonProperty(PropertyName = "dateTime")]
        public string DateString { get; set; }

        /// <summary>
        /// Gets or sets the resting heart rate.
        /// </summary>
        /// <value>
        /// The resting heart rate.
        /// </value>
        [JsonProperty(PropertyName = "value")]
        public HeartRateValue Value { get; set; }
    }
}
