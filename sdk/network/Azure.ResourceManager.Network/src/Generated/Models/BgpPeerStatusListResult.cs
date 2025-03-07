// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Response for list BGP peer status API service call. </summary>
    public partial class BgpPeerStatusListResult
    {
        /// <summary> Initializes a new instance of <see cref="BgpPeerStatusListResult"/>. </summary>
        internal BgpPeerStatusListResult()
        {
            Value = new ChangeTrackingList<BgpPeerStatus>();
        }

        /// <summary> Initializes a new instance of <see cref="BgpPeerStatusListResult"/>. </summary>
        /// <param name="value"> List of BGP peers. </param>
        internal BgpPeerStatusListResult(IReadOnlyList<BgpPeerStatus> value)
        {
            Value = value;
        }

        /// <summary> List of BGP peers. </summary>
        public IReadOnlyList<BgpPeerStatus> Value { get; }
    }
}
