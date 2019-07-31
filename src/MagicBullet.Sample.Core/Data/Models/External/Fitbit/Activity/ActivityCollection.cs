//-----------------------------------------------------------------------
// <copyright file="ActivityCollection.cs" company="Microsoft">
//     Copyright (c) Microsoft. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace MagicBullet.Sample.Core.Data.Models.External.Fitbit.Activity
{
    using System.Collections.Generic;

    using Newtonsoft.Json;

    /// <summary>
    /// The activity collection model
    /// </summary>
    public class ActivityCollection
    {
        /// <summary>
        /// Gets or sets the collection.
        /// </summary>
        /// <value>
        /// The collection.
        /// </value>
        [JsonProperty(PropertyName = "activities-tracker-calories")]
        public List<Activity> Collection { get; set; }
    }
}
