// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BaseViewModel.cs" company="Magic Bullet Ltd">
//      Copyright (c) Magic Bullet Ltd. All rights reserved. 
// </copyright>
// <summary>
//   The base view model.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace MagicBullet.Sample.Forms.ViewModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;
    using System.Threading.Tasks;

    using FreshMvvm;

    using MagicBullet.Sample.Core.Interfaces;

    /// <summary>
    /// The base view model.
    /// </summary>
    public class BaseViewModel : FreshBasePageModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BaseViewModel"/> class.
        /// </summary>
        /// <param name="breatheServices">
        /// The breathe services.
        /// </param>
        public BaseViewModel(IBreatheServices breatheServices)
        {
            this.BreatheServices = breatheServices;
        }

        /// <summary>
        /// Occurs when property changed.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        ///     Gets the breathe services.
        /// </summary>
        protected IBreatheServices BreatheServices { get; }

       

        /// <summary>
        /// The dismiss async.
        /// </summary>
        /// <param name="modal">
        /// The modal.
        /// </param>
        /// <param name="animate">
        /// The animate.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        public Task DismissAsync(bool modal = true, bool animate = true)
        {
            return this.BreatheServices.DispatcherService.RunOnUiThreadAsync(
                async () =>
                    {
                        try
                        {
                            await this.CoreMethods.PopPageModel(modal, animate);
                        }
                        catch (Exception)
                        {
                            await this.CoreMethods.PopPageModel(!modal, animate);
                        }
                    });
        }

        /// <summary>
        /// The navigate async.
        /// </summary>
        /// <param name="data">
        /// The data.
        /// </param>
        /// <param name="modal">
        /// The modal.
        /// </param>
        /// <param name="animate">
        /// The animate.
        /// </param>
        /// <typeparam name="T">
        /// The page model type.
        /// </typeparam>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        protected Task NavigateAsync<T>(object data = null, bool modal = false, bool animate = true)
            where T : BaseViewModel
        {
            return this.CoreMethods.PushPageModel<T>(data, modal, animate);
        }

        /// <summary>
        /// Sets the property.
        /// </summary>
        /// <returns><c>true</c>, if property was set, <c>false</c> otherwise.</returns>
        /// <param name="backingStore">Backing store.</param>
        /// <param name="value">Value.</param>
        /// <param name="validateValue">Validates value.</param>
        /// <param name="propertyName">Property name.</param>
        /// <param name="onChanged">On changed.</param>
        /// <typeparam name="T">The 1st type parameter.</typeparam>
        protected virtual bool SetProperty<T>(
            ref T backingStore,
            T value,
            [CallerMemberName]string propertyName = "",
            Action onChanged = null,
            Func<T, T, bool> validateValue = null)
        {
            // if value didn't change
            if (EqualityComparer<T>.Default.Equals(backingStore, value))
            {
                return false;
            }

            // if value changed but didn't validate
            if (validateValue != null && !validateValue(backingStore, value))
            {
                return false;
            }

            backingStore = value;
            onChanged?.Invoke();
            this.OnPropertyChanged(propertyName);
            return true;
        }

        /// <summary>
        /// Raises the property changed event.
        /// </summary>
        /// <param name="propertyName">Property name.</param>
        protected virtual void OnPropertyChanged([CallerMemberName]string propertyName = "") =>
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

    }
}