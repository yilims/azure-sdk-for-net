// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.HDInsight.Models
{
    /// <summary> The response of cluster create request validation. </summary>
    public partial class HDInsightClusterCreationValidateResult
    {
        /// <summary> Initializes a new instance of <see cref="HDInsightClusterCreationValidateResult"/>. </summary>
        internal HDInsightClusterCreationValidateResult()
        {
            ValidationErrors = new ChangeTrackingList<HDInsightClusterValidationErrorInfo>();
            ValidationWarnings = new ChangeTrackingList<HDInsightClusterValidationErrorInfo>();
            AaddsResourcesDetails = new ChangeTrackingList<HDInsightClusterAaddsDetail>();
        }

        /// <summary> Initializes a new instance of <see cref="HDInsightClusterCreationValidateResult"/>. </summary>
        /// <param name="validationErrors"> The validation errors. </param>
        /// <param name="validationWarnings"> The validation warnings. </param>
        /// <param name="estimatedCreationDuration"> The estimated creation duration. </param>
        /// <param name="aaddsResourcesDetails"> The Azure active directory domain service resource details. </param>
        internal HDInsightClusterCreationValidateResult(IReadOnlyList<HDInsightClusterValidationErrorInfo> validationErrors, IReadOnlyList<HDInsightClusterValidationErrorInfo> validationWarnings, TimeSpan? estimatedCreationDuration, IReadOnlyList<HDInsightClusterAaddsDetail> aaddsResourcesDetails)
        {
            ValidationErrors = validationErrors;
            ValidationWarnings = validationWarnings;
            EstimatedCreationDuration = estimatedCreationDuration;
            AaddsResourcesDetails = aaddsResourcesDetails;
        }

        /// <summary> The validation errors. </summary>
        public IReadOnlyList<HDInsightClusterValidationErrorInfo> ValidationErrors { get; }
        /// <summary> The validation warnings. </summary>
        public IReadOnlyList<HDInsightClusterValidationErrorInfo> ValidationWarnings { get; }
        /// <summary> The estimated creation duration. </summary>
        public TimeSpan? EstimatedCreationDuration { get; }
        /// <summary> The Azure active directory domain service resource details. </summary>
        public IReadOnlyList<HDInsightClusterAaddsDetail> AaddsResourcesDetails { get; }
    }
}
