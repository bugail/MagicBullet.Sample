// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AppleContainerService.cs" company="Magic Bullet Ltd">
//     Copyright (c) Magic Bullet Ltd. All rights reserved.
// </copyright>
// <summary>
//   The apple container service.
// </summary>
// 
// --------------------------------------------------------------------------------------------------------------------

namespace MagicBullet.Sample.iOS.Infrastructure
{
    using MagicBullet.Sample.Forms.Infrastructure;

    /// <summary>
    /// The apple container service.
    /// </summary>
    public class AppleContainerService : BreatheContainerService
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