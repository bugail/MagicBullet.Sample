// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BaseContainerService.cs" company="Magic Bullet Ltd">
//     Copyright (c) Magic Bullet Ltd. All rights reserved.
// </copyright>
// <summary>
//   The base container service.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace MagicBullet.Core.Services
{
    using System.Threading.Tasks;

    using MagicBullet.Core.Abstractions;

    /// <summary>The base container service.</summary>
    public abstract class BaseContainerService : IContainerService
    {
        /// <summary>
        /// The initialised.
        /// </summary>
        private bool initialised;

        /// <summary>
        /// Gets or sets a value indicating whether initialised.
        /// </summary>
        protected bool Initialised
        {
            get => initialised;
            set => initialised = value;
        }

        /// <summary>The init.</summary>
        /// <returns>The <see cref="Task"/>.</returns>
        public abstract void Init();

        /// <summary>The register.</summary>
        /// <typeparam name="TInterface"></typeparam>
        /// <typeparam name="TClass"></typeparam>
        protected abstract void Register<TInterface, TClass>()
            where TInterface : class where TClass : class, TInterface;

        /// <summary>
        /// The get instance.
        /// </summary>
        /// <typeparam name="TClass">
        /// </typeparam>
        /// <returns>
        /// The <see cref="TClass"/>.
        /// </returns>
        public abstract TInterface GetInstance<TInterface>() 
            where TInterface : class;

        /// <summary>
        /// The run app launch.
        /// </summary>
        public abstract void RunAppLaunch();
    }
}