//-----------------------------------------------------------------------
// <copyright file="SleepCollection.cs" company="Magic Bullet Ltd">
//     Copyright (c) Magic Bullet Ltd. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace MagicBullet.Sample.Core.Data.Models.External.Fitbit.Sleep
{
    using System.Collections.Generic;

    using Newtonsoft.Json;

    /// <summary>
    /// The sleep collection model
    /// </summary>
    public class SleepCollection
    {
        /// <summary>
        /// Gets or sets the sleep summary.
        /// </summary>
        /// <value>
        /// The sleep summary.
        /// </value>
        [JsonProperty(PropertyName = "sleep")]
        public IEnumerable<Sleep> Collection { get; set; }
    }
}
