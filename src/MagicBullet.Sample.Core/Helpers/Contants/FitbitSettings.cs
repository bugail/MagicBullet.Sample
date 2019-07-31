// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FitbitSettings.cs" company="Magic Bullet Ltd">
//     Copyright (c) Magic Bullet Ltd. All rights reserved.
// </copyright>
// <summary>
//   The fitbit settings.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace MagicBullet.Sample.Core.Helpers.Contants
{
    /// <summary>
    /// The fitbit settings.
    /// </summary>
    public static class FitbitSettings
    {
        /// <summary>
        /// The client id.
        /// </summary>
        public const string ClientID = "22CSGC";

        /// <summary>
        /// The client secret.
        /// </summary>
        public const string ClientSecret = "955202d9cc98f84f2611e2c011eed2ce";

        /// <summary>The fitbit token key.</summary>
        public const string FitbitTokenKey = "fitbit_token";

        /// <summary>The fitbit user calories activity url.</summary>
        public const string FitbitUserCaloriesActivityUrl =
            "https://api.fitbit.com/1/user/-/activities/tracker/calories/date/{0}/{1}.json?CacheBuster={2}";

        /// <summary>
        /// The fitbit user heart rate
        /// </summary>
        public const string FitbitUserHeartRate =
            "https://api.fitbit.com/1/user/-/activities/heart/date/{0}/{1}.json?CacheBuster={2}";

        /// <summary>The fitbit user id key.</summary>
        public const string FitbitUserIdKey = "fitbit_userId";

        /// <summary>
        /// The fitbit user sleep
        /// </summary>
        public const string FitbitUserSleep = "https://api.fitbit.com/1.2/user/-/sleep/date/{0}/{1}.json?CacheBuster={2}";

        /// <summary>
        /// The fitbit user weight URL
        /// </summary>
        public const string FitbitUserWeightUrl = "https://api.fitbit.com/1/user/-/body/log/weight/date/{0}/{1}.json?CacheBuster={2}";

        /// <summary>
        /// The redirect url.
        /// </summary>
        public const string RedirectUrl = "projectbreathe://loggedin";

        /// <summary>
        /// The scope.
        /// </summary>
        public const string Scope = "activity weight heartrate sleep";
    }
}