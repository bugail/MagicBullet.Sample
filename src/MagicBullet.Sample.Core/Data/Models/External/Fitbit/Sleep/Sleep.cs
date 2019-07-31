//-----------------------------------------------------------------------
// <copyright file="Sleep.cs" company="Magic Bullet Ltd">
//     Copyright (c) Magic Bullet Ltd. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace MagicBullet.Sample.Core.Data.Models.External.Fitbit.Sleep
{
    using System;

    using Newtonsoft.Json;

    public class Sleep
    {
        [JsonProperty(PropertyName = "dateOfSleep")]
        public string DateOfSleep { get; set; }

        [JsonProperty(PropertyName = "duration")]
        public int Duration { get; set; }

        [JsonProperty(PropertyName = "efficiency")]
        public int Efficiency { get; set; }

        public DateTime endTime { get; set; }

        public int infoCode { get; set; }

        public Levels levels { get; set; }

        [JsonProperty(PropertyName = "logId")]
        public string LogId { get; set; }

        public int minutesAfterWakeup { get; set; }

        [JsonProperty(PropertyName = "minutesAsleep")]
        public int MinutesAsleep { get; set; }

        [JsonProperty(PropertyName = "minutesAwake")]
        public int MinutesAwake { get; set; }

        [JsonProperty(PropertyName = "minutesToFallAsleep")]
        public int MinutesToFallAsleep { get; set; }

        public DateTime startTime { get; set; }

        [JsonProperty(PropertyName = "timeInBed")]
        public int TimeInBed { get; set; }

        public string type { get; set; }
    }
}
