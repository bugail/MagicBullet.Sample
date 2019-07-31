// --------------------------------------------------------------------------------------------------------------------
// <copyright file="App.xaml.cs" company="Magic Bullet Ltd">
//     Copyright (c) Magic Bullet Ltd. All rights reserved.  
// </copyright>
// <summary>
//   The app.
// </summary>
// 
// --------------------------------------------------------------------------------------------------------------------

namespace MagicBullet.Sample.Forms
{
    using System;

    using MagicBullet.Core.Abstractions;

    using Xamarin.Forms;

    /// <summary>
    /// The app.
    /// </summary>
    public partial class App : Application
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="App"/> class.
        /// </summary>
        /// <param name="containerService">
        /// The container Service.
        /// </param>
        public App(IContainerService containerService)
        {
            try
            {
                this.InitializeComponent();

                containerService.Init();
                containerService.RunAppLaunch();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        /// <summary>
        /// The on resume.
        /// </summary>
        protected override void OnResume()
        {
            // Handle when your app resumes
        }

        /// <summary>
        /// The on sleep.
        /// </summary>
        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        /// <summary>
        /// The on start.
        /// </summary>
        protected override void OnStart()
        {
            // Handle when your app starts
        }
    }
}