// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Resources.Models
{
    /// <summary> List of resource groups. </summary>
    internal partial class ResourceGroupListResult
    {
        /// <summary> Initializes a new instance of <see cref="ResourceGroupListResult"/>. </summary>
        internal ResourceGroupListResult()
        {
            Value = new ChangeTrackingList<ResourceGroupData>();
        }

        /// <summary> Initializes a new instance of <see cref="ResourceGroupListResult"/>. </summary>
        /// <param name="value"> An array of resource groups. </param>
        /// <param name="nextLink"> The URL to use for getting the next set of results. </param>
        internal ResourceGroupListResult(IReadOnlyList<ResourceGroupData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> An array of resource groups. </summary>
        public IReadOnlyList<ResourceGroupData> Value { get; }
        /// <summary> The URL to use for getting the next set of results. </summary>
        public string NextLink { get; }
    }
}
