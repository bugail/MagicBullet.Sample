// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DeviceType.cs" company="Magic Bullet Ltd">
//     Copyright (c) Magic Bullet Ltd. All rights reserved.
// </copyright>
// <summary>
//   The bluetooth capture device type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace MagicBullet.Sample.Core.Enum.Bluetooth
{
    /// <summary>The device type.</summary>
    public enum DeviceType
    {
        /// <summary>
        /// The none. Used to search for all bluetooth devices
        /// </summary>
        None, 

        /// <summary>The spirometer.</summary>
        Spirometer,

        /// <summary>The oximeter.</summary>
        Oximeter,
    }
}