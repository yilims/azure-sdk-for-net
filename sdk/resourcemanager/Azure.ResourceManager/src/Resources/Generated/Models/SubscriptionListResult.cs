// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Resources.Models
{
    /// <summary> Subscription list operation response. </summary>
    internal partial class SubscriptionListResult
    {
        /// <summary> Initializes a new instance of <see cref="SubscriptionListResult"/>. </summary>
        /// <param name="nextLink"> The URL to get the next set of results. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> is null. </exception>
        internal SubscriptionListResult(string nextLink)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));

            Value = new ChangeTrackingList<SubscriptionData>();
            NextLink = nextLink;
        }

        /// <summary> Initializes a new instance of <see cref="SubscriptionListResult"/>. </summary>
        /// <param name="value"> An array of subscriptions. </param>
        /// <param name="nextLink"> The URL to get the next set of results. </param>
        internal SubscriptionListResult(IReadOnlyList<SubscriptionData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> An array of subscriptions. </summary>
        public IReadOnlyList<SubscriptionData> Value { get; }
        /// <summary> The URL to get the next set of results. </summary>
        public string NextLink { get; }
    }
}
