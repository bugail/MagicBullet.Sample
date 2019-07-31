// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IScanResultWrapper.cs" company="Magic Bullet Ltd">
//     Copyright (c) Magic Bullet Ltd. All rights reserved.
// </copyright>
// <summary>
//   The ScanResultWrapper interface.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace MagicBullet.Sample.Core.Interfaces.Bluetooth
{
    /// <summary>The ScanResultWrapper interface.</summary>
    public interface IScanResultWrapper
    {
        /// <summary>Gets the device.</summary>
        IDeviceWrapper Device { get; }

        /// <summary>Gets the rssi.</summary>
        int Rssi { get; }
    }
}