// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MainViewModel.cs" company="Magic Bullet Ltd">
//     Copyright (c) Magic Bullet Ltd. All rights reserved. 
// </copyright>
// <summary>
//   The main view model.
// </summary>
// 
// --------------------------------------------------------------------------------------------------------------------

namespace MagicBullet.Sample.Forms.ViewModels
{
    using System;
    using System.Windows.Input;

    using FreshMvvm;

    using MagicBullet.Sample.Core.Interfaces;

    /// <summary>
    /// The main view model.
    /// </summary>
    public class MainViewModel : BaseViewModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MainViewModel"/> class.
        /// </summary>
        /// <param name="breatheServices">
        /// The breathe services.
        /// </param>
        public MainViewModel(IBreatheServices breatheServices)
            : base(breatheServices)
        {
        }

        /// <summary>
        /// Gets the bluetooth command.
        /// </summary>
        public ICommand BluetoothCommand
        {
            get
            {
                return new FreshAwaitCommand(async (mode, tcs) =>
                    {
                        await this.CoreMethods.PushPageModel<BluetoothViewModel>();
                        tcs.SetResult(true);
                    });
            }
        }

        /// <summary>
        /// Gets the fitbit command.
        /// </summary>
        public ICommand FitbitCommand
        {
            get
            {
                return new FreshAwaitCommand(async (mode, tcs) =>
                    {
                        await this.CoreMethods.PushPageModel<FitbitViewModel>();
                        tcs.SetResult(true);
                    });
            }
        }

        protected override void ViewIsAppearing(object sender, EventArgs e)
        {
            base.ViewIsAppearing(sender, e);
        }
    }
}