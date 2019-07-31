//-----------------------------------------------------------------------
// <copyright file="Summary.cs" company="Magic Bullet Ltd">
//     Copyright (c) Magic Bullet Ltd. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace MagicBullet.Sample.Core.Data.Models.External.Fitbit.Sleep
{
    using Newtonsoft.Json;

    public class Summary
    {
        [JsonProperty(PropertyName = "deep")]
        public SleepType Deep { get; set; }

        [JsonProperty(PropertyName = "light")]
        public SleepType Light { get; set; }

        [JsonProperty(PropertyName = "rem")]
        public SleepType Rem { get; set; }

        [JsonProperty(PropertyName = "wake")]
        public SleepType Wake { get; set; }
    }
}
