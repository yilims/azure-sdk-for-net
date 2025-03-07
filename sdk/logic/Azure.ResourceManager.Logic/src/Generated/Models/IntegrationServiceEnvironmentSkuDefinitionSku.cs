// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Logic.Models
{
    /// <summary> The sku. </summary>
    public partial class IntegrationServiceEnvironmentSkuDefinitionSku
    {
        /// <summary> Initializes a new instance of <see cref="IntegrationServiceEnvironmentSkuDefinitionSku"/>. </summary>
        internal IntegrationServiceEnvironmentSkuDefinitionSku()
        {
        }

        /// <summary> Initializes a new instance of <see cref="IntegrationServiceEnvironmentSkuDefinitionSku"/>. </summary>
        /// <param name="name"> The sku name. </param>
        /// <param name="tier"> The sku tier. </param>
        internal IntegrationServiceEnvironmentSkuDefinitionSku(IntegrationServiceEnvironmentSkuName? name, string tier)
        {
            Name = name;
            Tier = tier;
        }

        /// <summary> The sku name. </summary>
        public IntegrationServiceEnvironmentSkuName? Name { get; }
        /// <summary> The sku tier. </summary>
        public string Tier { get; }
    }
}
