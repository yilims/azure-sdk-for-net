// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;
using Azure.ResourceManager.ApiManagement;

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary> The response of the List API Management services operation. </summary>
    internal partial class ApiManagementServiceListResult
    {
        /// <summary> Initializes a new instance of <see cref="ApiManagementServiceListResult"/>. </summary>
        /// <param name="value"> Result of the List API Management services operation. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal ApiManagementServiceListResult(IEnumerable<ApiManagementServiceData> value)
        {
            Argument.AssertNotNull(value, nameof(value));

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="ApiManagementServiceListResult"/>. </summary>
        /// <param name="value"> Result of the List API Management services operation. </param>
        /// <param name="nextLink"> Link to the next set of results. Not empty if Value contains incomplete list of API Management services. </param>
        internal ApiManagementServiceListResult(IReadOnlyList<ApiManagementServiceData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Result of the List API Management services operation. </summary>
        public IReadOnlyList<ApiManagementServiceData> Value { get; }
        /// <summary> Link to the next set of results. Not empty if Value contains incomplete list of API Management services. </summary>
        public string NextLink { get; }
    }
}
