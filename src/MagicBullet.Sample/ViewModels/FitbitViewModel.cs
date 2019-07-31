// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FitbitViewModel.cs" company="Magic Bullet Ltd">
//     Copyright (c) Magic Bullet Ltd. All rights reserved.
// </copyright>
// <summary>
//   The fitbit view model.
// </summary>
// 
// --------------------------------------------------------------------------------------------------------------------

namespace MagicBullet.Sample.Forms.ViewModels
{
    using System;
    using System.Threading.Tasks;
    using System.Windows.Input;

    using FreshMvvm;

    using MagicBullet.Sample.Core.Interfaces;

    /// <summary>
    /// The fitbit view model.
    /// </summary>
    public class FitbitViewModel : BaseViewModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FitbitViewModel"/> class.
        /// </summary>
        /// <param name="breatheServices">
        /// The breathe services.
        /// </param>
        public FitbitViewModel(IBreatheServices breatheServices)
            : base(breatheServices)
        {
        }

        /// <summary>
        /// Gets the fitbit login command.
        /// </summary>
        public ICommand LoginCommand
        {
            get
            {
                return new FreshAwaitCommand(async (mode, tcs) =>
                    {
                        await this.HandleFitbitLoginCommandAsync();
                        tcs.SetResult(true);
                    });
            }
        }

        /// <summary>
        /// Gets the fitbit logout command.
        /// </summary>
        public ICommand LogoutCommand
        {
            get
            {
                return new FreshAwaitCommand( (mode, tcs) =>
                    {
                        this.HandleFitbitLogoutCommand();
                        tcs.SetResult(true);
                    });
            }
        }

        public ICommand GetDataCommand
        {
            get
            {
                return new FreshAwaitCommand(async (mode, tcs) =>
                    {
                        await this.HandleGetDataCommandAsync();
                        tcs.SetResult(true);
                    });
            }
        }

        /// <summary>
        /// The handle fitbit login command async.
        /// </summary>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        private async Task HandleFitbitLoginCommandAsync()
        {
            try
            {
                var result = await this.BreatheServices.FitbitService.LoginAsync();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        /// <summary>
        /// The handle fitbit command.
        /// </summary>
        private void HandleFitbitLogoutCommand()
        {
            try
            {
                var result = this.BreatheServices.FitbitService.Logout();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        /// <summary>
        /// The handle get data command async.
        /// </summary>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        private async Task HandleGetDataCommandAsync()
        {
            try
            {
                var data = await this.BreatheServices.FitbitService.GetActivityDataAsync(
                               string.Empty,
                               DateTime.Now.AddDays(-1),
                               DateTime.Now);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}