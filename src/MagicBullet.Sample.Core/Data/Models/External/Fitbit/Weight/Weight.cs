//-----------------------------------------------------------------------
// <copyright file="Weight.cs" company="Magic Bullet Ltd">
//     Copyright (c) Magic Bullet Ltd. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace MagicBullet.Sample.Core.Data.Models.External.Fitbit.Weight
{
    using Newtonsoft.Json;

    /// <summary>
    /// The activity collection model
    /// </summary>
    public class Weight
    {
        /// <summary>
        /// Gets or sets the bmi.
        /// </summary>
        /// <value>
        /// The bmi.
        /// </value>
        [JsonProperty(PropertyName = "bmi")]
        public double Bmi { get; set; }

        /// <summary>
        /// Gets or sets the fat.
        /// </summary>
        /// <value>
        /// The fat.
        /// </value>
        [JsonProperty(PropertyName = "fat")]
        public int Fat { get; set; }

        /// <summary>
        /// Gets or sets the log identifier.
        /// </summary>
        /// <value>
        /// The log identifier.
        /// </value>
        [JsonProperty(PropertyName = "logId")]
        public long LogId { get; set; }

        /// <summary>
        /// Gets or sets the source.
        /// </summary>
        /// <value>
        /// The source.
        /// </value>
        [JsonProperty(PropertyName = "source")]
        public string Source { get; set; }

        /// <summary>
        /// Gets or sets the time.
        /// </summary>
        /// <value>
        /// The time.
        /// </value>
        [JsonProperty(PropertyName = "time")]
        public string Time { get; set; }

        /// <summary>
        /// Gets or sets the weight.
        /// </summary>
        /// <value>
        /// The weight.
        /// </value>
        [JsonProperty(PropertyName = "weight")]
        public double WeightValue { get; set; }

        /// <summary>
        /// Gets or sets the time.
        /// </summary>
        /// <value>
        /// The time.
        /// </value>
        [JsonProperty(PropertyName = "date")]
        public string Date { get; set; }
    }
}