// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IGattCharacteristicWrapper.cs" company="Magic Bullet Ltd">
//     Copyright (c) Magic Bullet Ltd. All rights reserved.
// </copyright>
// <summary>
//   The GattCharacteristicWrapper interface.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace MagicBullet.Sample.Core.Interfaces.Bluetooth
{
    using System;
    using System.Threading.Tasks;

    /// <summary>The GattCharacteristicWrapper interface.</summary>
    public interface IGattCharacteristicWrapper : IDisposable
    {
        /// <summary>The value updated.</summary>
        event EventHandler<byte[]> ValueUpdated;

        /// <summary>Gets the description.</summary>
        string Description { get; }

        /// <summary>Gets a value indicating whether is notifying.</summary>
        bool IsNotifying { get; }

        /// <summary>Gets the uuid.</summary>
        Guid Uuid { get; }

        /// <summary>Gets or sets the value.</summary>
        string Value { get; set; }

        /// <summary>The start notify.</summary>
        void StartNotify();

        /// <summary>The stop notify.</summary>
        void StopNotify();

        /// <summary>The write.</summary>
        /// <param name="bytes">The bytes.</param>
        void Write(byte[] bytes);

        Task<string> ReadAsync();
    }
}