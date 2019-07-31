//-----------------------------------------------------------------------
// <copyright file="SleepStages.cs" company="Magic Bullet Ltd">
//     Copyright (c) Magic Bullet Ltd. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace MagicBullet.Sample.Core.Data.Models.External.Fitbit.Sleep
{
    using Newtonsoft.Json;

    /// <summary>
    /// The sleep stages model
    /// </summary>
    public class SleepStages
    {
        /// <summary>
        /// Gets or sets the deep.
        /// </summary>
        /// <value>
        /// The deep.
        /// </value>
        [JsonProperty(PropertyName = "deep")]
        public int Deep { get; set; }

        /// <summary>
        /// Gets or sets the light.
        /// </summary>
        /// <value>
        /// The light.
        /// </value>
        [JsonProperty(PropertyName = "light")]
        public int Light { get; set; }

        /// <summary>
        /// Gets or sets the rem.
        /// </summary>
        /// <value>
        /// The rem.
        /// </value>
        [JsonProperty(PropertyName = "rem")]
        public int Rem { get; set; }

        /// <summary>
        /// Gets or sets the wake.
        /// </summary>
        /// <value>
        /// The wake.
        /// </value>
        [JsonProperty(PropertyName = "wake")]
        public int Wake { get; set; }
    }
}
