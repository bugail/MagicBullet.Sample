// -----------------------------------------------------------------------
//  <copyright file="BluetoothExtensions.cs" company="Magic Bullet Ltd">
//      Copyright (c) Magic Bullet Ltd. All rights reserved.
//  </copyright>
// -----------------------------------------------------------------------

namespace MagicBullet.Sample.Forms.Helpers.Bluetooth
{
    using System;

    using MagicBullet.Sample.Core.Enum.Bluetooth;

    /// <summary>The bluetooth extensions.</summary>
    public static class BluetoothExtensions
    {
        /// <summary>Converts from Native Phone Bluetooth status to Project Breathe status.</summary>
        /// <param name="status">The status.</param>
        /// <returns>The <see cref="AdapterStatus"/>.</returns>
        public static AdapterStatus ToBluetoothAdapterStatus(this Plugin.BluetoothLE.AdapterStatus status)
        {
            AdapterStatus newStatus = AdapterStatus.Unknown;

            switch (status)
            {
                case Plugin.BluetoothLE.AdapterStatus.Resetting:
                    newStatus = AdapterStatus.Resetting;
                    break;
                case Plugin.BluetoothLE.AdapterStatus.Unsupported:
                    newStatus = AdapterStatus.Unsupported;
                    break;
                case Plugin.BluetoothLE.AdapterStatus.Unauthorized:
                    newStatus = AdapterStatus.Unauthorized;
                    break;
                case Plugin.BluetoothLE.AdapterStatus.PoweredOff:
                    newStatus = AdapterStatus.PoweredOff;
                    break;
                case Plugin.BluetoothLE.AdapterStatus.PoweredOn:
                    newStatus = AdapterStatus.PoweredOn;
                    break;
            }

            return newStatus;
        }

        /// <summary>Converts from Native Device Connection status to Project Breathe status.</summary>
        /// <param name="status">The status.</param>
        /// <returns>The <see cref="ConnectionStatus"/>The converted connection status</returns>
        /// <exception cref="ArgumentOutOfRangeException">Not implemented.</exception>
        public static ConnectionStatus ToConnectionStatus(
            this Plugin.BluetoothLE.ConnectionStatus status)
        {
            ConnectionStatus newStatus = ConnectionStatus.Unknown;
            switch (status)
            {
                case Plugin.BluetoothLE.ConnectionStatus.Disconnected:
                    newStatus = ConnectionStatus.Disconnected;
                    break;
                case Plugin.BluetoothLE.ConnectionStatus.Disconnecting:
                    newStatus = ConnectionStatus.Disconnecting;
                    break;
                case Plugin.BluetoothLE.ConnectionStatus.Connected:
                    newStatus = ConnectionStatus.Connected;
                    break;
                case Plugin.BluetoothLE.ConnectionStatus.Connecting:
                    newStatus = ConnectionStatus.Connecting;
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(status), status, null);
            }

            return newStatus;
        }
    }
}