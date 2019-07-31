//-----------------------------------------------------------------------
// <copyright file="ShortData.cs" company="Magic Bullet Ltd">
//     Copyright (c) Magic Bullet Ltd. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace MagicBullet.Sample.Core.Data.Models.External.Fitbit.Sleep
{
    using System;

    public class ShortData
    {
        public DateTime dateTime { get; set; }

        public string level { get; set; }

        public int seconds { get; set; }
    }
}
