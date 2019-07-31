// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ScanResultWrapper.cs" company="Magic Bullet Ltd">
//     Copyright (c) Magic Bullet Ltd. All rights reserved.
// </copyright>
// <summary>
//   The scan result wrapper.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace MagicBullet.Sample.Forms.Services.Bluetooth
{
    using MagicBullet.Sample.Core.Interfaces.Bluetooth;

    using Plugin.BluetoothLE;

    /// <summary>The scan result wrapper.</summary>
    public class ScanResultWrapper : IScanResultWrapper
    {
        /// <summary>Initializes a new instance of the <see cref="ScanResultWrapper"/> class.</summary>
        /// <param name="result">The result.</param>
        public ScanResultWrapper(IScanResult result)
        {
            this.Setup(result);
        }

        /// <summary>Gets the device.</summary>
        public IDeviceWrapper Device { get; private set; }

        /// <summary>Gets the rssi.</summary>
        public int Rssi { get; private set; }

        /// <summary>The setup.</summary>
        /// <param name="result">The result.</param>
        private void Setup(IScanResult result)
        {
            this.Device = new DeviceWrapper(result.Device, false);
            this.Rssi = result.Rssi;
        }
    }
}