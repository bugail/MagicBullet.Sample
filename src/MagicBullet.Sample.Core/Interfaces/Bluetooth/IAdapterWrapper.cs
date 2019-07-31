// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IAdapterWrapper.cs" company="Magic Bullet Ltd">
//     Copyright (c) Magic Bullet Ltd. All rights reserved.
// </copyright>
// <summary>
//   The AdapterWrapper interface.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace MagicBullet.Sample.Core.Interfaces.Bluetooth
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using MagicBullet.Sample.Core.Enum.Bluetooth;

    /// <summary>The AdapterWrapper interface.</summary>
    public interface IAdapterWrapper
    {
        /// <summary>The adapter status changed.</summary>
        event EventHandler<AdapterStatus> AdapterStatusChanged;

        /// <summary>The scan result updated.</summary>
        event EventHandler<IEnumerable<IScanResultWrapper>> ScanResultUpdated;

        /// <summary>Gets a value indicating whether is scanning.</summary>
        bool IsScanning { get; }

        /// <summary>Gets the status.</summary>
        AdapterStatus Status { get; }

        /// <summary>The get device async.</summary>
        /// <param name="uuid">The uuid.</param>
        /// <returns>The <see cref="Task"/>.</returns>
        Task<IDeviceWrapper> GetDeviceAsync(Guid uuid);

        /// <summary>The start scan.</summary>
        /// <param name="deviceType">The device type.</param>
        void StartScan(DeviceType deviceType);

        /// <summary>The stop scan.</summary>
        void StopScan();
    }
}