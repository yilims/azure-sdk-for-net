// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.ContainerService.Models
{
    /// <summary> The state of a private link service connection. </summary>
    public partial class ContainerServicePrivateLinkServiceConnectionState
    {
        /// <summary> Initializes a new instance of <see cref="ContainerServicePrivateLinkServiceConnectionState"/>. </summary>
        public ContainerServicePrivateLinkServiceConnectionState()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ContainerServicePrivateLinkServiceConnectionState"/>. </summary>
        /// <param name="status"> The private link service connection status. </param>
        /// <param name="description"> The private link service connection description. </param>
        internal ContainerServicePrivateLinkServiceConnectionState(ContainerServicePrivateLinkServiceConnectionStatus? status, string description)
        {
            Status = status;
            Description = description;
        }

        /// <summary> The private link service connection status. </summary>
        public ContainerServicePrivateLinkServiceConnectionStatus? Status { get; set; }
        /// <summary> The private link service connection description. </summary>
        public string Description { get; set; }
    }
}
