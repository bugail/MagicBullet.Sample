//-----------------------------------------------------------------------
// <copyright file="IDispatcherService.cs" company="Magic Bullet Ltd">
//     Copyright (c) Magic Bullet Ltd. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace MagicBullet.Core.Abstractions
{
    using System;
    using System.Threading.Tasks;

    /// <summary>
    /// The DispatcherService interface.
    /// </summary>
    public interface IDispatcherService
    {
        /// <summary>
        /// The run on ui thread.
        /// </summary>
        /// <param name="action">
        /// The action.
        /// </param>
        void RunOnUiThread(Action action);

        Task RunOnUiThreadAsync(Action action);
    }
}