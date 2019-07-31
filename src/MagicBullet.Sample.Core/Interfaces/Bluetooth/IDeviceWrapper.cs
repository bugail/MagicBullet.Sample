// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IDeviceWrapper.cs" company="Magic Bullet Ltd">
//     Copyright (c) Magic Bullet Ltd. All rights reserved.
// </copyright>
// <summary>
//   The DeviceWrapper interface.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace MagicBullet.Sample.Core.Interfaces.Bluetooth
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using MagicBullet.Sample.Core.Enum.Bluetooth;

    /// <summary>The DeviceWrapper interface.</summary>
    public interface IDeviceWrapper
    {
        /// <summary>The characteristic found.</summary>
        event EventHandler<IGattCharacteristicWrapper> CharacteristicFound;

        /// <summary>The status changed.</summary>
        event EventHandler<ConnectionStatus> StatusChanged;

        /// <summary>Gets the gatt characteristics.</summary>
        IList<IGattCharacteristicWrapper> GattCharacteristics { get; }

        /// <summary>Gets the name.</summary>
        string Name { get; }

        /// <summary>Gets the status.</summary>
        ConnectionStatus Status { get; }

        /// <summary>Gets the uuid.</summary>
        Guid Uuid { get; }

        /// <summary>The connect.</summary>
        void Connect();

        Task ConnectAsync();

        /// <summary>The disconnect.</summary>
        /// <returns>The <see cref="Task"/>.</returns>
        Task DisconnectAsync();

        /// <summary>The get known characteristic.</summary>
        /// <param name="serviceUuid">The service uuid.</param>
        /// <param name="characteristicUuid">The characteristic uuid.</param>
        /// <returns>The <see cref="Task"/>.</returns>
        Task<IGattCharacteristicWrapper> GetKnownCharacteristic(Guid serviceUuid, Guid characteristicUuid);
    }
}