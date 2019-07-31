//-----------------------------------------------------------------------
// <copyright file="HeartRateCollection.cs" company="Magic Bullet Ltd">
//     Copyright (c) Magic Bullet Ltd. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace MagicBullet.Sample.Core.Data.Models.External.Fitbit.HeartRate
{
    using System.Collections.Generic;

    using Newtonsoft.Json;

    /// <summary>
    /// The heart rate collection model
    /// </summary>
    public class HeartRateCollection
    {
        /// <summary>
        /// Gets or sets the collection.
        /// </summary>
        /// <value>
        /// The collection.
        /// </value>
        [JsonProperty(PropertyName = "activities-heart")]
        public List<HeartRate> Collection { get; set; }
    }
}
