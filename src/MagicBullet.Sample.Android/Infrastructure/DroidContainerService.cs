// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DroidContainerService.cs" company="Magic Bullet Ltd">
//     Copyright (c) Magic Bullet Ltd. All rights reserved.
// </copyright>
// <summary>
//   The droid container service.
// </summary>
// 
// --------------------------------------------------------------------------------------------------------------------

namespace MagicBullet.Sample.Droid.Infrastructure
{
    using MagicBullet.Sample.Forms.Infrastructure;

    /// <summary>
    /// The droid container service.
    /// </summary>
    public class DroidContainerService : BreatheContainerService
    {
        /// <summary>The init.</summary>
        public override void Init()
        {
            if (!this.Initialised)
            {
                base.Init();
            }
        }
    }
}