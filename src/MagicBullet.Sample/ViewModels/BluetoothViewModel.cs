// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BluetoothViewModel.cs" company="Magic Bullet Ltd">
//     Copyright (c) Magic Bullet Ltd. All rights reserved.
// </copyright>
// <summary>
//   The bluetooth view model.
// </summary>
// 
// --------------------------------------------------------------------------------------------------------------------

namespace MagicBullet.Sample.Forms.ViewModels
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Linq;
    using System.Threading.Tasks;

    using MagicBullet.Sample.Core.Enum.Bluetooth;
    using MagicBullet.Sample.Core.Helpers;
    using MagicBullet.Sample.Core.Interfaces;
    using MagicBullet.Sample.Core.Interfaces.Bluetooth;

    /// <summary>
    /// The bluetooth view model.
    /// </summary>
    public class BluetoothViewModel : BaseViewModel
    {
        /// <summary>
        /// The bluetooth manager.
        /// </summary>
        private readonly IAdapterWrapper bluetoothManager;

        /// <summary>
        /// The scan results lock.
        /// </summary>
        private readonly object scanResultsLock;

        /// <summary>The devices.</summary>
        private ObservableCollection<ScanResultViewModel> devices;

        /// <summary>
        /// Initializes a new instance of the <see cref="BluetoothViewModel"/> class.
        /// </summary>
        /// <param name="breatheServices">
        /// The breathe services.
        /// </param>
        public BluetoothViewModel(IBreatheServices breatheServices)
            : base(breatheServices)
        {
            this.bluetoothManager = this.BreatheServices.BluetoothManager;
            this.scanResultsLock = new object();
        }

        /// <summary>Gets or sets the devices.</summary>
        public ObservableCollection<ScanResultViewModel> Devices
        {
            get => this.devices;
            set => this.SetProperty(ref this.devices, value);
        }

        /// <summary>
        /// The view is appearing.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        protected override async void ViewIsAppearing(object sender, EventArgs e)
        {
            await this.SetupAsync();
            base.ViewIsAppearing(sender, e);
        }

        /// <summary>
        /// The view is disappearing.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        protected override void ViewIsDisappearing(object sender, EventArgs e)
        {
            this.CleanUp();
            base.ViewIsDisappearing(sender, e);
        }

        /// <summary>
        /// The setup async.
        /// </summary>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        private async Task SetupAsync()
        {
            this.bluetoothManager.ScanResultUpdated += this.BluetoothManager_ScanResultUpdated;
            this.bluetoothManager.AdapterStatusChanged += this.BluetoothManager_AdapterStatusChanged;
            this.BluetoothManager_AdapterStatusChanged(this, this.bluetoothManager.Status);
        }

        /// <summary>
        /// The clean up.
        /// </summary>
        private void CleanUp()
        {
            this.bluetoothManager.ScanResultUpdated -= this.BluetoothManager_ScanResultUpdated;
            this.bluetoothManager.AdapterStatusChanged -= this.BluetoothManager_AdapterStatusChanged;

            if (this.bluetoothManager.IsScanning)
            {
                this.bluetoothManager.StopScan();
            }
        }

        /// <summary>The bluetooth manager_ adapter status changed.</summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The e.</param>
        private void BluetoothManager_AdapterStatusChanged(object sender, AdapterStatus e)
        {
            switch (e)
            {
                case AdapterStatus.Unknown:
                    break;
                case AdapterStatus.Resetting:
                    break;
                case AdapterStatus.Unsupported:
                    break;
                case AdapterStatus.Unauthorized:
                    break;
                case AdapterStatus.PoweredOff:

                    // This will tidy up the connections.
                    this.bluetoothManager.StopScan();

                    this.BreatheServices.DispatcherService.RunOnUiThread(
                        () =>
                            {
                                this.BreatheServices.DialogService.Alert(
                                    "Bluetooth turned off",
                                    "Error",
                                   "Ok");
                            });

                    break;
                case AdapterStatus.PoweredOn:
                    this.ScanAsync();
                    break;
            }
        }

        /// <summary>The bluetooth manager_ scan result updated.</summary>
        /// <param name="sender">The sender.</param>
        /// <param name="results">The results.</param>
        private void BluetoothManager_ScanResultUpdated(object sender, IEnumerable<IScanResultWrapper> results)
        {
            var list = new List<ScanResultViewModel>();

            lock (this.scanResultsLock)
            {
                foreach (var result in results)
                {
                    var device = this.Devices.FirstOrDefault(x => x.Uuid.Equals(result.Device.Uuid));

                    if (device != null)
                    {
                        device.TrySet(result);
                    }
                    else
                    {
                        var currentList = list.FirstOrDefault(x => x.Uuid.Equals(result.Device.Uuid));
                        if (currentList == null)
                        {
                            device = new ScanResultViewModel();
                            device.TrySet(result);
                            list.Add(device);
                        }
                    }
                }

                if (list.Any())
                {
                    this.BreatheServices.DispatcherService.RunOnUiThread(() => { this.Devices.AddRange(list); });
                }
            }
        }

        /// <summary>
        /// The scan.
        /// </summary>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        private Task ScanAsync()
        {
            return Task.Run(
                () =>
                    {
                        try
                        {
                            if (!this.bluetoothManager.IsScanning)
                            {
                                this.bluetoothManager.StartScan(DeviceType.None);
                            }
                        }
                        catch (Exception e)
                        {
                            this.BreatheServices.DispatcherService.RunOnUiThread(
                                () =>
                                    {
                                        this.BreatheServices.DialogService.Alert(
                                            e.Message,
                                           "Error",
                                            "Ok");
                                    });
                        }
                    });
        }
    }
}