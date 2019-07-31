// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ScanResultViewModel.cs" company="Magic Bullet Ltd">
//     Copyright (c) Magic Bullet Ltd. All rights reserved.
// </copyright>
// <summary>
//   The scan result view model.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace MagicBullet.Sample.Forms.ViewModels
{
    using System;
    using System.Diagnostics;

    using MagicBullet.Sample.Core.Interfaces.Bluetooth;

    /// <summary>The scan result view model.</summary>
    public class ScanResultViewModel
    {
        /// <summary>Gets the device.</summary>
        public IDeviceWrapper Device { get; private set; }

        /// <summary>Gets the name.</summary>
        public string Name { get; private set; }

        /// <summary>Gets the rssi.</summary>
        public int Rssi { get; private set; }

        /// <summary>Gets the uuid.</summary>
        public Guid Uuid { get; private set; }

        /// <summary>The uuid display.</summary>
        public string UuidDisplay => this.Uuid.ToString();

        /// <summary>The try set.</summary>
        /// <param name="result">The result.</param>
        /// <returns>The <see cref="bool"/>.</returns>
        public bool TrySet(IScanResultWrapper result)
        {
            var response = false;

            if (this.Uuid == Guid.Empty)
            {
                this.Device = result.Device;
                this.Uuid = this.Device.Uuid;

                response = true;
            }

            try
            {
                if (this.Uuid == result.Device.Uuid)
                {
                    response = true;

                    this.Name = result.Device.Name;
                    this.Rssi = result.Rssi;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
            }

            return response;
        }
    }
}