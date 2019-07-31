// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AdapterStatus.cs" company="Magic Bullet Ltd">
//     Copyright (c) Magic Bullet Ltd. All rights reserved.
// </copyright>
// <summary>
//   The bluetooth adapter status of the phone.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace MagicBullet.Sample.Core.Enum.Bluetooth
{
    /// <summary>The adapter status.</summary>
    public enum AdapterStatus
    {
        /// <summary>The unknown.</summary>
        Unknown,

        /// <summary>The resetting.</summary>
        Resetting,

        /// <summary>The unsupported.</summary>
        Unsupported,

        /// <summary>The unauthorized.</summary>
        Unauthorized,

        /// <summary>The powered off.</summary>
        PoweredOff,

        /// <summary>The powered on.</summary>
        PoweredOn,
    }
}