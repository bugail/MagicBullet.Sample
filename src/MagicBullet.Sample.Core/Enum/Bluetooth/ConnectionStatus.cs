//-----------------------------------------------------------------------
// <copyright file="ConnectionStatus.cs" company="Magic Bullet Ltd">
//     Copyright (c) Magic Bullet Ltd. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace MagicBullet.Sample.Core.Enum.Bluetooth
{
    /// <summary>
    /// The bluetooth peripheral state.
    /// </summary>
    public enum ConnectionStatus
    {
        /// <summary>The disconnected.</summary>
        Disconnected = 0,

        /// <summary>The disconnecting.</summary>
        Disconnecting = 1,

        /// <summary>The connected.</summary>
        Connected = 2,

        /// <summary>The connecting.</summary>
        Connecting = 3,

        /// <summary>The unknown.</summary>
        Unknown = 4
    }
}