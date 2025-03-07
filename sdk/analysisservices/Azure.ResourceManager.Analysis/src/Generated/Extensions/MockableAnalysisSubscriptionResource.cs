// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Analysis;
using Azure.ResourceManager.Analysis.Models;

namespace Azure.ResourceManager.Analysis.Mocking
{
    /// <summary> A class to add extension methods to SubscriptionResource. </summary>
    public partial class MockableAnalysisSubscriptionResource : ArmResource
    {
        private ClientDiagnostics _analysisServerServersClientDiagnostics;
        private ServersRestOperations _analysisServerServersRestClient;

        /// <summary> Initializes a new instance of the <see cref="MockableAnalysisSubscriptionResource"/> class for mocking. </summary>
        protected MockableAnalysisSubscriptionResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableAnalysisSubscriptionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableAnalysisSubscriptionResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics AnalysisServerServersClientDiagnostics => _analysisServerServersClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.Analysis", AnalysisServerResource.ResourceType.Namespace, Diagnostics);
        private ServersRestOperations AnalysisServerServersRestClient => _analysisServerServersRestClient ??= new ServersRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(AnalysisServerResource.ResourceType));

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Lists all the Analysis Services servers for the given subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.AnalysisServices/servers</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Servers_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="AnalysisServerResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<AnalysisServerResource> GetAnalysisServersAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => AnalysisServerServersRestClient.CreateListRequest(Id.SubscriptionId);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, null, e => new AnalysisServerResource(Client, AnalysisServerData.DeserializeAnalysisServerData(e)), AnalysisServerServersClientDiagnostics, Pipeline, "MockableAnalysisSubscriptionResource.GetAnalysisServers", "value", null, cancellationToken);
        }

        /// <summary>
        /// Lists all the Analysis Services servers for the given subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.AnalysisServices/servers</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Servers_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="AnalysisServerResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<AnalysisServerResource> GetAnalysisServers(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => AnalysisServerServersRestClient.CreateListRequest(Id.SubscriptionId);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, null, e => new AnalysisServerResource(Client, AnalysisServerData.DeserializeAnalysisServerData(e)), AnalysisServerServersClientDiagnostics, Pipeline, "MockableAnalysisSubscriptionResource.GetAnalysisServers", "value", null, cancellationToken);
        }

        /// <summary>
        /// Lists eligible SKUs for Analysis Services resource provider.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.AnalysisServices/skus</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Servers_ListSkusForNew</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="AnalysisResourceSku"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<AnalysisResourceSku> GetEligibleSkusAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => AnalysisServerServersRestClient.CreateListSkusForNewRequest(Id.SubscriptionId);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, null, AnalysisResourceSku.DeserializeAnalysisResourceSku, AnalysisServerServersClientDiagnostics, Pipeline, "MockableAnalysisSubscriptionResource.GetEligibleSkus", "value", null, cancellationToken);
        }

        /// <summary>
        /// Lists eligible SKUs for Analysis Services resource provider.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.AnalysisServices/skus</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Servers_ListSkusForNew</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="AnalysisResourceSku"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<AnalysisResourceSku> GetEligibleSkus(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => AnalysisServerServersRestClient.CreateListSkusForNewRequest(Id.SubscriptionId);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, null, AnalysisResourceSku.DeserializeAnalysisResourceSku, AnalysisServerServersClientDiagnostics, Pipeline, "MockableAnalysisSubscriptionResource.GetEligibleSkus", "value", null, cancellationToken);
        }

        /// <summary>
        /// Check the name availability in the target location.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.AnalysisServices/locations/{location}/checkNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Servers_CheckNameAvailability</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> The region name which the operation will lookup into. </param>
        /// <param name="content"> Contains the information used to provision the Analysis Services server. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual async Task<Response<AnalysisServerNameAvailabilityResult>> CheckAnalysisServerNameAvailabilityAsync(AzureLocation location, AnalysisServerNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = AnalysisServerServersClientDiagnostics.CreateScope("MockableAnalysisSubscriptionResource.CheckAnalysisServerNameAvailability");
            scope.Start();
            try
            {
                var response = await AnalysisServerServersRestClient.CheckNameAvailabilityAsync(Id.SubscriptionId, location, content, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Check the name availability in the target location.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.AnalysisServices/locations/{location}/checkNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Servers_CheckNameAvailability</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> The region name which the operation will lookup into. </param>
        /// <param name="content"> Contains the information used to provision the Analysis Services server. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual Response<AnalysisServerNameAvailabilityResult> CheckAnalysisServerNameAvailability(AzureLocation location, AnalysisServerNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = AnalysisServerServersClientDiagnostics.CreateScope("MockableAnalysisSubscriptionResource.CheckAnalysisServerNameAvailability");
            scope.Start();
            try
            {
                var response = AnalysisServerServersRestClient.CheckNameAvailability(Id.SubscriptionId, location, content, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
