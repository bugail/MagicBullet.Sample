//-----------------------------------------------------------------------
// <copyright file="Levels.cs" company="Magic Bullet Ltd">
//     Copyright (c) Magic Bullet Ltd. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace MagicBullet.Sample.Core.Data.Models.External.Fitbit.Sleep
{
    using System.Collections.Generic;

    public class Levels
    {
        public List<Datum> data { get; set; }

        public List<ShortData> shortData { get; set; }

        public Summary summary { get; set; }
    }
}
