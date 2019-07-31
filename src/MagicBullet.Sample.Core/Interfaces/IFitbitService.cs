// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IFitbitService.cs" company="Magic Bullet Ltd">
//     Copyright (c) Magic Bullet Ltd. All rights reserved. 
// </copyright>
// <summary>
//   The FitbitService interface.
// </summary>
// 
// --------------------------------------------------------------------------------------------------------------------

namespace MagicBullet.Sample.Core.Interfaces
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using MagicBullet.Sample.Core.Data.Models.External.Fitbit.Activity;
    using MagicBullet.Sample.Core.Data.Models.External.Fitbit.HeartRate;
    using MagicBullet.Sample.Core.Data.Models.External.Fitbit.Sleep;
    using MagicBullet.Sample.Core.Data.Models.External.Fitbit.Weight;

    /// <summary>
    /// The FitbitService interface.
    /// </summary>
    public interface IFitbitService
    {
        /// <summary>
        /// The get activity data async.
        /// </summary>
        /// <param name="token">
        /// The token.
        /// </param>
        /// <param name="startDate">
        /// The start date.
        /// </param>
        /// <param name="endDate">
        /// The end date.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        Task<IEnumerable<Activity>> GetActivityDataAsync(string token, DateTime startDate, DateTime endDate);

        /// <summary>
        /// The get heart rate data async.
        /// </summary>
        /// <param name="token">
        /// The token.
        /// </param>
        /// <param name="startDate">
        /// The start date.
        /// </param>
        /// <param name="endDate">
        /// The end date.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        Task<IEnumerable<HeartRate>> GetHeartRateDataAsync(string token, DateTime startDate, DateTime endDate);

        /// <summary>
        /// The get sleep data async.
        /// </summary>
        /// <param name="token">
        /// The token.
        /// </param>
        /// <param name="startDate">
        /// The start date.
        /// </param>
        /// <param name="endDate">
        /// The end date.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        Task<IEnumerable<Sleep>> GetSleepDataAsync(string token, DateTime startDate, DateTime endDate);

        /// <summary>
        /// The get weight data async.
        /// </summary>
        /// <param name="token">
        /// The token.
        /// </param>
        /// <param name="startDate">
        /// The start date.
        /// </param>
        /// <param name="endDate">
        /// The end date.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        Task<IEnumerable<Weight>> GetWeightDataAsync(string token, DateTime startDate, DateTime endDate);

        /// <summary>
        /// The login async.
        /// </summary>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        Task<bool> LoginAsync();

        /// <summary>
        /// The logout.
        /// </summary>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        bool Logout();
    }
}