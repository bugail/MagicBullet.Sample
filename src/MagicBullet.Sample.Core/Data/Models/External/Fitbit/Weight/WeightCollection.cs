//-----------------------------------------------------------------------
// <copyright file="WeightCollection.cs" company="Magic Bullet Ltd">
//     Copyright (c) Magic Bullet Ltd. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace MagicBullet.Sample.Core.Data.Models.External.Fitbit.Weight
{
    using System.Collections.Generic;

    using Newtonsoft.Json;

    /// <summary>
    /// The activity collection model
    /// </summary>
    public class WeightCollection
    {
        /// <summary>
        /// Gets or sets the collection.
        /// </summary>
        /// <value>
        /// The collection.
        /// </value>
        [JsonProperty(PropertyName = "weight")]
        public List<Weight> Collection { get; set; }
    }
}
