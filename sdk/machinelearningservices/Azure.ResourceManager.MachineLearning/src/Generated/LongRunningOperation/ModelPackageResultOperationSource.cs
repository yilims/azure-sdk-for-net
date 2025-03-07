// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager.MachineLearning.Models;

namespace Azure.ResourceManager.MachineLearning
{
    internal class ModelPackageResultOperationSource : IOperationSource<ModelPackageResult>
    {
        ModelPackageResult IOperationSource<ModelPackageResult>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            return ModelPackageResult.DeserializeModelPackageResult(document.RootElement);
        }

        async ValueTask<ModelPackageResult> IOperationSource<ModelPackageResult>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            return ModelPackageResult.DeserializeModelPackageResult(document.RootElement);
        }
    }
}
