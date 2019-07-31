// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IBreatheServices.cs" company="Magic Bullet Ltd">
//     Copyright (c) Magic Bullet Ltd. All rights reserved.
// </copyright>
// <summary>
//   The BreatheServices interface.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace MagicBullet.Sample.Core.Interfaces
{
    using MagicBullet.Core.Abstractions;
    using MagicBullet.Sample.Core.Interfaces.Bluetooth;

    /// <summary>The BreatheServices interface.</summary>
    public interface IBreatheServices
    {
        /// <summary>Gets the dispatcher service.</summary>
        IDispatcherService DispatcherService { get; }

        /// <summary>Gets the dialog service.</summary>
        IDialogService DialogService { get; }

        /// <summary>
        /// Sets the fitbit service.
        /// </summary>
        IFitbitService FitbitService { get; }

        /// <summary>
        /// Gets the bluetooth manager.
        /// </summary>
        IAdapterWrapper BluetoothManager { get; }
    }
}
