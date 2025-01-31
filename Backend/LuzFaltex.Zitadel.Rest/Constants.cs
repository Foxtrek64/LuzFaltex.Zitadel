﻿//
//  Constants.cs
//
//  Author:
//       LuzFaltex Contributors
//
//  Copyright (c) 2022 LuzFaltex
//
//  This program is free software: you can redistribute it and/or modify
//  it under the terms of the GNU Lesser General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
//
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU Lesser General Public License for more details.
//
//  You should have received a copy of the GNU Lesser General Public License
//  along with this program.  If not, see <http://www.gnu.org/licenses/>.
//

using System;
using JetBrains.Annotations;
using LuzFaltex.Zitadel.API.Abstractions;

namespace LuzFaltex.Zitadel.Rest
{
    /// <summary>
    /// Holds various Rest API constants.
    /// </summary>
    [PublicAPI]
    public static class Constants
    {
        /// <summary>
        /// Gets the base API URL.
        /// </summary>
        public static Uri BaseUrl { get; } = new("https://api.zitadel.ch");

        /// <summary>
        /// Gets the base issuer API URL.
        /// </summary>
        public static Uri Issuer { get; } = new("https://issuer.zitadel.ch");

        /// <summary>
        /// Gets the Zitadel project id used for accessing the Zitadel REST API.
        /// </summary>
        public static ulong ZitadelApiProjectId { get; } = 69234237810729019;

        // The following strings are assumptions. Waiting on confirmation on their names.

        /// <summary>
        /// Gets the name of the rate limit header.
        /// </summary>
        public static string RateLimitHeaderName { get; } = "X-RateLimit-Limit";

        /// <summary>
        /// Gets the name of the remaining rate limit token header.
        /// </summary>
        public static string RateLimitRemainingHeaderName { get; } = "X-RateLimit-Remaining";

        /// <summary>
        /// Gets the name of the rate limit reset time header.
        /// </summary>
        public static string RateLimitResetHeaderName { get; } = "X-RateLimit-Reset";

        /// <summary>
        /// Gets the name of the rate limit bucket header.
        /// </summary>
        public static string RateLimitBucketHeaderName { get; } = "X-RateLimit-Bucket";

        /// <summary>
        /// Gets the name of the global rate limit header.
        /// </summary>
        public static string RateLimitGlobalHeaderName { get; } = "X-RateLimit-Bucket";
    }
}
