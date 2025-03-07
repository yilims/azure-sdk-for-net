// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.NetApp.Models
{
    /// <summary> Properties of key vault. </summary>
    public partial class NetAppKeyVaultProperties
    {
        /// <summary> Initializes a new instance of <see cref="NetAppKeyVaultProperties"/>. </summary>
        /// <param name="keyVaultUri"> The Uri of KeyVault. </param>
        /// <param name="keyName"> The name of KeyVault key. </param>
        /// <param name="keyVaultResourceId"> The resource ID of KeyVault. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="keyVaultUri"/>, <paramref name="keyName"/> or <paramref name="keyVaultResourceId"/> is null. </exception>
        public NetAppKeyVaultProperties(Uri keyVaultUri, string keyName, string keyVaultResourceId)
        {
            Argument.AssertNotNull(keyVaultUri, nameof(keyVaultUri));
            Argument.AssertNotNull(keyName, nameof(keyName));
            Argument.AssertNotNull(keyVaultResourceId, nameof(keyVaultResourceId));

            KeyVaultUri = keyVaultUri;
            KeyName = keyName;
            KeyVaultResourceId = keyVaultResourceId;
        }

        /// <summary> Initializes a new instance of <see cref="NetAppKeyVaultProperties"/>. </summary>
        /// <param name="keyVaultId"> UUID v4 used to identify the Azure Key Vault configuration. </param>
        /// <param name="keyVaultUri"> The Uri of KeyVault. </param>
        /// <param name="keyName"> The name of KeyVault key. </param>
        /// <param name="keyVaultResourceId"> The resource ID of KeyVault. </param>
        /// <param name="status"> Status of the KeyVault connection. </param>
        internal NetAppKeyVaultProperties(string keyVaultId, Uri keyVaultUri, string keyName, string keyVaultResourceId, NetAppKeyVaultStatus? status)
        {
            KeyVaultId = keyVaultId;
            KeyVaultUri = keyVaultUri;
            KeyName = keyName;
            KeyVaultResourceId = keyVaultResourceId;
            Status = status;
        }

        /// <summary> UUID v4 used to identify the Azure Key Vault configuration. </summary>
        public string KeyVaultId { get; }
        /// <summary> The Uri of KeyVault. </summary>
        public Uri KeyVaultUri { get; set; }
        /// <summary> The name of KeyVault key. </summary>
        public string KeyName { get; set; }
        /// <summary> The resource ID of KeyVault. </summary>
        public string KeyVaultResourceId { get; set; }
        /// <summary> Status of the KeyVault connection. </summary>
        public NetAppKeyVaultStatus? Status { get; }
    }
}
