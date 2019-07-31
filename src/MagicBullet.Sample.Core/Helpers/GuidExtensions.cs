//-----------------------------------------------------------------------
//  <copyright file="GuidExtensions.cs" company="Magic Bullet Ltd">
//      Copyright (c) Magic Bullet Ltd. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace MagicBullet.Sample.Core.Helpers
{
    using System;

    /// <summary>The guid extensions.</summary>
    public static class GuidExtensions
    {
        /// <summary>The guid from uuid.</summary>
        /// <param name="uuid">The uuid.</param>
        /// <returns>The <see cref="Guid"/>.</returns>
        public static Guid GuidFromUuid(string uuid)
        {
            var id = uuid;
            if (id.Length == 4)
            {
                id = "0000" + id + "-0000-1000-8000-00805f9b34fb";
            }

            return Guid.ParseExact(id, "d");
        }
    }
}