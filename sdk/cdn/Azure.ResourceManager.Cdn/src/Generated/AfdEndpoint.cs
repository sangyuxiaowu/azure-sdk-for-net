// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Cdn.Models;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.Cdn
{
    /// <summary> A Class representing a AfdEndpoint along with the instance operations that can be performed on it. </summary>
    public partial class AfdEndpoint : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="AfdEndpoint"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string profileName, string endpointName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}/afdEndpoints/{endpointName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _afdEndpointClientDiagnostics;
        private readonly AfdEndpointsRestOperations _afdEndpointRestClient;
        private readonly AfdEndpointData _data;

        /// <summary> Initializes a new instance of the <see cref="AfdEndpoint"/> class for mocking. </summary>
        protected AfdEndpoint()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "AfdEndpoint"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal AfdEndpoint(ArmClient client, AfdEndpointData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="AfdEndpoint"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal AfdEndpoint(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _afdEndpointClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Cdn", ResourceType.Namespace, DiagnosticOptions);
            TryGetApiVersion(ResourceType, out string afdEndpointApiVersion);
            _afdEndpointRestClient = new AfdEndpointsRestOperations(_afdEndpointClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, afdEndpointApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Cdn/profiles/afdEndpoints";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual AfdEndpointData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary> Gets a collection of AfdRoutes in the AfdRoute. </summary>
        /// <returns> An object representing collection of AfdRoutes and their operations over a AfdRoute. </returns>
        public virtual AfdRouteCollection GetAfdRoutes()
        {
            return new AfdRouteCollection(Client, Id);
        }

        /// <summary>
        /// Gets an existing AzureFrontDoor endpoint with the specified endpoint name under the specified subscription, resource group and profile.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}/afdEndpoints/{endpointName}
        /// Operation Id: AfdEndpoints_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<AfdEndpoint>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _afdEndpointClientDiagnostics.CreateScope("AfdEndpoint.Get");
            scope.Start();
            try
            {
                var response = await _afdEndpointRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _afdEndpointClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new AfdEndpoint(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets an existing AzureFrontDoor endpoint with the specified endpoint name under the specified subscription, resource group and profile.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}/afdEndpoints/{endpointName}
        /// Operation Id: AfdEndpoints_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<AfdEndpoint> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _afdEndpointClientDiagnostics.CreateScope("AfdEndpoint.Get");
            scope.Start();
            try
            {
                var response = _afdEndpointRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw _afdEndpointClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AfdEndpoint(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes an existing AzureFrontDoor endpoint with the specified endpoint name under the specified subscription, resource group and profile.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}/afdEndpoints/{endpointName}
        /// Operation Id: AfdEndpoints_Delete
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<ArmOperation> DeleteAsync(bool waitForCompletion, CancellationToken cancellationToken = default)
        {
            using var scope = _afdEndpointClientDiagnostics.CreateScope("AfdEndpoint.Delete");
            scope.Start();
            try
            {
                var response = await _afdEndpointRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new CdnArmOperation(_afdEndpointClientDiagnostics, Pipeline, _afdEndpointRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitForCompletion)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes an existing AzureFrontDoor endpoint with the specified endpoint name under the specified subscription, resource group and profile.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}/afdEndpoints/{endpointName}
        /// Operation Id: AfdEndpoints_Delete
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(bool waitForCompletion, CancellationToken cancellationToken = default)
        {
            using var scope = _afdEndpointClientDiagnostics.CreateScope("AfdEndpoint.Delete");
            scope.Start();
            try
            {
                var response = _afdEndpointRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new CdnArmOperation(_afdEndpointClientDiagnostics, Pipeline, _afdEndpointRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitForCompletion)
                    operation.WaitForCompletionResponse(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Updates an existing AzureFrontDoor endpoint with the specified endpoint name under the specified subscription, resource group and profile. Only tags can be updated after creating an endpoint. To update origins, use the Update Origin operation. To update origin groups, use the Update Origin group operation. To update domains, use the Update Custom Domain operation.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}/afdEndpoints/{endpointName}
        /// Operation Id: AfdEndpoints_Update
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="data"> Endpoint update properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public async virtual Task<ArmOperation<AfdEndpoint>> UpdateAsync(bool waitForCompletion, PatchableAfdEndpointData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _afdEndpointClientDiagnostics.CreateScope("AfdEndpoint.Update");
            scope.Start();
            try
            {
                var response = await _afdEndpointRestClient.UpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new CdnArmOperation<AfdEndpoint>(new AfdEndpointOperationSource(Client), _afdEndpointClientDiagnostics, Pipeline, _afdEndpointRestClient.CreateUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data).Request, response, OperationFinalStateVia.OriginalUri);
                if (waitForCompletion)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Updates an existing AzureFrontDoor endpoint with the specified endpoint name under the specified subscription, resource group and profile. Only tags can be updated after creating an endpoint. To update origins, use the Update Origin operation. To update origin groups, use the Update Origin group operation. To update domains, use the Update Custom Domain operation.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}/afdEndpoints/{endpointName}
        /// Operation Id: AfdEndpoints_Update
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="data"> Endpoint update properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<AfdEndpoint> Update(bool waitForCompletion, PatchableAfdEndpointData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _afdEndpointClientDiagnostics.CreateScope("AfdEndpoint.Update");
            scope.Start();
            try
            {
                var response = _afdEndpointRestClient.Update(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken);
                var operation = new CdnArmOperation<AfdEndpoint>(new AfdEndpointOperationSource(Client), _afdEndpointClientDiagnostics, Pipeline, _afdEndpointRestClient.CreateUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data).Request, response, OperationFinalStateVia.OriginalUri);
                if (waitForCompletion)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Removes a content from AzureFrontDoor.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}/afdEndpoints/{endpointName}/purge
        /// Operation Id: AfdEndpoints_PurgeContent
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="contents"> The list of paths to the content and the list of linked domains to be purged. Path can be a full URL, e.g. &apos;/pictures/city.png&apos; which removes a single file, or a directory with a wildcard, e.g. &apos;/pictures/*&apos; which removes all folders and files in the directory. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="contents"/> is null. </exception>
        public async virtual Task<ArmOperation> PurgeContentAsync(bool waitForCompletion, AfdPurgeOptions contents, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(contents, nameof(contents));

            using var scope = _afdEndpointClientDiagnostics.CreateScope("AfdEndpoint.PurgeContent");
            scope.Start();
            try
            {
                var response = await _afdEndpointRestClient.PurgeContentAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, contents, cancellationToken).ConfigureAwait(false);
                var operation = new CdnArmOperation(_afdEndpointClientDiagnostics, Pipeline, _afdEndpointRestClient.CreatePurgeContentRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, contents).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitForCompletion)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Removes a content from AzureFrontDoor.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}/afdEndpoints/{endpointName}/purge
        /// Operation Id: AfdEndpoints_PurgeContent
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="contents"> The list of paths to the content and the list of linked domains to be purged. Path can be a full URL, e.g. &apos;/pictures/city.png&apos; which removes a single file, or a directory with a wildcard, e.g. &apos;/pictures/*&apos; which removes all folders and files in the directory. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="contents"/> is null. </exception>
        public virtual ArmOperation PurgeContent(bool waitForCompletion, AfdPurgeOptions contents, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(contents, nameof(contents));

            using var scope = _afdEndpointClientDiagnostics.CreateScope("AfdEndpoint.PurgeContent");
            scope.Start();
            try
            {
                var response = _afdEndpointRestClient.PurgeContent(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, contents, cancellationToken);
                var operation = new CdnArmOperation(_afdEndpointClientDiagnostics, Pipeline, _afdEndpointRestClient.CreatePurgeContentRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, contents).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitForCompletion)
                    operation.WaitForCompletionResponse(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks the quota and actual usage of endpoints under the given CDN profile.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}/afdEndpoints/{endpointName}/usages
        /// Operation Id: AfdEndpoints_ListResourceUsage
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="Usage" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<Usage> GetResourceUsageAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<Usage>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _afdEndpointClientDiagnostics.CreateScope("AfdEndpoint.GetResourceUsage");
                scope.Start();
                try
                {
                    var response = await _afdEndpointRestClient.ListResourceUsageAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<Usage>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _afdEndpointClientDiagnostics.CreateScope("AfdEndpoint.GetResourceUsage");
                scope.Start();
                try
                {
                    var response = await _afdEndpointRestClient.ListResourceUsageNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Checks the quota and actual usage of endpoints under the given CDN profile.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}/afdEndpoints/{endpointName}/usages
        /// Operation Id: AfdEndpoints_ListResourceUsage
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="Usage" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<Usage> GetResourceUsage(CancellationToken cancellationToken = default)
        {
            Page<Usage> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _afdEndpointClientDiagnostics.CreateScope("AfdEndpoint.GetResourceUsage");
                scope.Start();
                try
                {
                    var response = _afdEndpointRestClient.ListResourceUsage(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<Usage> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _afdEndpointClientDiagnostics.CreateScope("AfdEndpoint.GetResourceUsage");
                scope.Start();
                try
                {
                    var response = _afdEndpointRestClient.ListResourceUsageNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Validates the custom domain mapping to ensure it maps to the correct CDN endpoint in DNS.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}/afdEndpoints/{endpointName}/validateCustomDomain
        /// Operation Id: AfdEndpoints_ValidateCustomDomain
        /// </summary>
        /// <param name="customDomainProperties"> Custom domain to be validated. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="customDomainProperties"/> is null. </exception>
        public async virtual Task<Response<ValidateCustomDomainOutput>> ValidateCustomDomainAsync(ValidateCustomDomainInput customDomainProperties, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(customDomainProperties, nameof(customDomainProperties));

            using var scope = _afdEndpointClientDiagnostics.CreateScope("AfdEndpoint.ValidateCustomDomain");
            scope.Start();
            try
            {
                var response = await _afdEndpointRestClient.ValidateCustomDomainAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, customDomainProperties, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Validates the custom domain mapping to ensure it maps to the correct CDN endpoint in DNS.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}/afdEndpoints/{endpointName}/validateCustomDomain
        /// Operation Id: AfdEndpoints_ValidateCustomDomain
        /// </summary>
        /// <param name="customDomainProperties"> Custom domain to be validated. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="customDomainProperties"/> is null. </exception>
        public virtual Response<ValidateCustomDomainOutput> ValidateCustomDomain(ValidateCustomDomainInput customDomainProperties, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(customDomainProperties, nameof(customDomainProperties));

            using var scope = _afdEndpointClientDiagnostics.CreateScope("AfdEndpoint.ValidateCustomDomain");
            scope.Start();
            try
            {
                var response = _afdEndpointRestClient.ValidateCustomDomain(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, customDomainProperties, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Add a tag to the current resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}/afdEndpoints/{endpointName}
        /// Operation Id: AfdEndpoints_Get
        /// </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="value"> The value for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> or <paramref name="value"/> is null. </exception>
        public async virtual Task<Response<AfdEndpoint>> AddTagAsync(string key, string value, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(key, nameof(key));
            Argument.AssertNotNull(value, nameof(value));

            using var scope = _afdEndpointClientDiagnostics.CreateScope("AfdEndpoint.AddTag");
            scope.Start();
            try
            {
                var originalTags = await TagResource.GetAsync(cancellationToken).ConfigureAwait(false);
                originalTags.Value.Data.TagValues[key] = value;
                await TagResource.CreateOrUpdateAsync(true, originalTags.Value.Data, cancellationToken: cancellationToken).ConfigureAwait(false);
                var originalResponse = await _afdEndpointRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new AfdEndpoint(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Add a tag to the current resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}/afdEndpoints/{endpointName}
        /// Operation Id: AfdEndpoints_Get
        /// </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="value"> The value for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> or <paramref name="value"/> is null. </exception>
        public virtual Response<AfdEndpoint> AddTag(string key, string value, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(key, nameof(key));
            Argument.AssertNotNull(value, nameof(value));

            using var scope = _afdEndpointClientDiagnostics.CreateScope("AfdEndpoint.AddTag");
            scope.Start();
            try
            {
                var originalTags = TagResource.Get(cancellationToken);
                originalTags.Value.Data.TagValues[key] = value;
                TagResource.CreateOrUpdate(true, originalTags.Value.Data, cancellationToken: cancellationToken);
                var originalResponse = _afdEndpointRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                return Response.FromValue(new AfdEndpoint(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Replace the tags on the resource with the given set.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}/afdEndpoints/{endpointName}
        /// Operation Id: AfdEndpoints_Get
        /// </summary>
        /// <param name="tags"> The set of tags to use as replacement. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tags"/> is null. </exception>
        public async virtual Task<Response<AfdEndpoint>> SetTagsAsync(IDictionary<string, string> tags, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(tags, nameof(tags));

            using var scope = _afdEndpointClientDiagnostics.CreateScope("AfdEndpoint.SetTags");
            scope.Start();
            try
            {
                await TagResource.DeleteAsync(true, cancellationToken: cancellationToken).ConfigureAwait(false);
                var originalTags = await TagResource.GetAsync(cancellationToken).ConfigureAwait(false);
                originalTags.Value.Data.TagValues.ReplaceWith(tags);
                await TagResource.CreateOrUpdateAsync(true, originalTags.Value.Data, cancellationToken: cancellationToken).ConfigureAwait(false);
                var originalResponse = await _afdEndpointRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new AfdEndpoint(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Replace the tags on the resource with the given set.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}/afdEndpoints/{endpointName}
        /// Operation Id: AfdEndpoints_Get
        /// </summary>
        /// <param name="tags"> The set of tags to use as replacement. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tags"/> is null. </exception>
        public virtual Response<AfdEndpoint> SetTags(IDictionary<string, string> tags, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(tags, nameof(tags));

            using var scope = _afdEndpointClientDiagnostics.CreateScope("AfdEndpoint.SetTags");
            scope.Start();
            try
            {
                TagResource.Delete(true, cancellationToken: cancellationToken);
                var originalTags = TagResource.Get(cancellationToken);
                originalTags.Value.Data.TagValues.ReplaceWith(tags);
                TagResource.CreateOrUpdate(true, originalTags.Value.Data, cancellationToken: cancellationToken);
                var originalResponse = _afdEndpointRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                return Response.FromValue(new AfdEndpoint(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Removes a tag by key from the resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}/afdEndpoints/{endpointName}
        /// Operation Id: AfdEndpoints_Get
        /// </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> is null. </exception>
        public async virtual Task<Response<AfdEndpoint>> RemoveTagAsync(string key, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(key, nameof(key));

            using var scope = _afdEndpointClientDiagnostics.CreateScope("AfdEndpoint.RemoveTag");
            scope.Start();
            try
            {
                var originalTags = await TagResource.GetAsync(cancellationToken).ConfigureAwait(false);
                originalTags.Value.Data.TagValues.Remove(key);
                await TagResource.CreateOrUpdateAsync(true, originalTags.Value.Data, cancellationToken: cancellationToken).ConfigureAwait(false);
                var originalResponse = await _afdEndpointRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new AfdEndpoint(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Removes a tag by key from the resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}/afdEndpoints/{endpointName}
        /// Operation Id: AfdEndpoints_Get
        /// </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> is null. </exception>
        public virtual Response<AfdEndpoint> RemoveTag(string key, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(key, nameof(key));

            using var scope = _afdEndpointClientDiagnostics.CreateScope("AfdEndpoint.RemoveTag");
            scope.Start();
            try
            {
                var originalTags = TagResource.Get(cancellationToken);
                originalTags.Value.Data.TagValues.Remove(key);
                TagResource.CreateOrUpdate(true, originalTags.Value.Data, cancellationToken: cancellationToken);
                var originalResponse = _afdEndpointRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                return Response.FromValue(new AfdEndpoint(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
