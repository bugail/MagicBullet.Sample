//-----------------------------------------------------------------------
// <copyright file="Activity.cs" company="Magic Bullet Ltd">
//     Copyright (c) Magic Bullet Ltd. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace MagicBullet.Sample.Core.Data.Models.External.Fitbit.Activity
{
    using Newtonsoft.Json;

    /// <summary>
    /// The activity model
    /// </summary>
    public class Activity
    {
        /// <summary>
        /// Gets or sets the last edited.
        /// </summary>
        [JsonProperty(PropertyName = "dateTime")]
        public string Date { get; set; }

        /// <summary>
        /// Gets or sets the calories.
        /// </summary>
        /// <value>
        /// The calories.
        /// </value>
        [JsonProperty(PropertyName = "value")]
        public int Calories { get; set; }
    }
}
