// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.CostManagement.Models
{
    /// <summary> Result of forecast. It contains all columns listed under groupings and aggregation. </summary>
    public partial class ForecastResult : ResourceData
    {
        /// <summary> Initializes a new instance of <see cref="ForecastResult"/>. </summary>
        internal ForecastResult()
        {
            Columns = new ChangeTrackingList<ForecastColumn>();
            Rows = new ChangeTrackingList<IList<BinaryData>>();
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="ForecastResult"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="nextLink"> The link (url) to the next page of results. </param>
        /// <param name="columns"> Array of columns. </param>
        /// <param name="rows"> Array of rows. </param>
        /// <param name="location"> Location of the resource. </param>
        /// <param name="sku"> SKU of the resource. </param>
        /// <param name="eTag"> ETag of the resource. </param>
        /// <param name="tags"> Resource tags. </param>
        internal ForecastResult(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string nextLink, IReadOnlyList<ForecastColumn> columns, IReadOnlyList<IList<BinaryData>> rows, AzureLocation? location, string sku, ETag? eTag, IReadOnlyDictionary<string, string> tags) : base(id, name, resourceType, systemData)
        {
            NextLink = nextLink;
            Columns = columns;
            Rows = rows;
            Location = location;
            Sku = sku;
            ETag = eTag;
            Tags = tags;
        }

        /// <summary> The link (url) to the next page of results. </summary>
        public string NextLink { get; }
        /// <summary> Array of columns. </summary>
        public IReadOnlyList<ForecastColumn> Columns { get; }
        /// <summary> Array of rows. </summary>
        public IReadOnlyList<IList<BinaryData>> Rows { get; }
        /// <summary> Location of the resource. </summary>
        public AzureLocation? Location { get; }
        /// <summary> SKU of the resource. </summary>
        public string Sku { get; }
        /// <summary> ETag of the resource. </summary>
        public ETag? ETag { get; }
        /// <summary> Resource tags. </summary>
        public IReadOnlyDictionary<string, string> Tags { get; }
    }
}
