// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Magic Bullet Ltd" file="EnumerableExtensions.cs">
//     Copyright (c) Magic Bullet Ltd. All rights reserved.
// </copyright>
// <summary>
//   The enumerable extensions.
// </summary>
// 
// --------------------------------------------------------------------------------------------------------------------

namespace MagicBullet.Sample.Core.Helpers
{
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The enumerable extensions.
    /// </summary>
    public static class EnumerableExtensions
    {
        /// <summary>
        /// The add range.
        /// </summary>
        /// <param name="destination">
        /// The destination.
        /// </param>
        /// <param name="source">
        /// The source.
        /// </param>
        /// <typeparam name="T">
        /// The type
        /// </typeparam>
        public static void AddRange<T>(this IList<T> destination, IEnumerable<T> source)
        {
            if (source != null && source.Any())
            {
                foreach (T item in source)
                {
                    destination.Add(item);
                }
            }
        }
    }
}