// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IContainerService.cs" company="Magic Bullet Ltd">
//     Copyright (c) Magic Bullet Ltd. All rights reserved.
// </copyright>
// <summary>
//   The ContainerService interface.
// </summary>
// 
// --------------------------------------------------------------------------------------------------------------------

namespace MagicBullet.Core.Abstractions
{
    /// <summary>
    /// The ContainerService interface.
    /// </summary>
    public interface IContainerService
    {
        /// <summary>
        /// The init.
        /// </summary>
        void Init();

        /// <summary>
        /// The run app launch.
        /// </summary>
        void RunAppLaunch();
    }
}