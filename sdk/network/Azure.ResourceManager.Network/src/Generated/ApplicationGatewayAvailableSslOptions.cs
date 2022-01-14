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
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.Network
{
    /// <summary> A Class representing a ApplicationGatewayAvailableSslOptions along with the instance operations that can be performed on it. </summary>
    public partial class ApplicationGatewayAvailableSslOptions : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="ApplicationGatewayAvailableSslOptions"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/providers/Microsoft.Network/applicationGatewayAvailableSslOptions/default";
            return new ResourceIdentifier(resourceId);
        }
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly ApplicationGatewaysRestOperations _applicationGatewaysRestClient;
        private readonly ApplicationGatewayAvailableSslOptionsData _data;

        /// <summary> Initializes a new instance of the <see cref="ApplicationGatewayAvailableSslOptions"/> class for mocking. </summary>
        protected ApplicationGatewayAvailableSslOptions()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "ApplicationGatewayAvailableSslOptions"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal ApplicationGatewayAvailableSslOptions(ArmResource options, ApplicationGatewayAvailableSslOptionsData data) : base(options, new ResourceIdentifier(data.Id))
        {
            HasData = true;
            _data = data;
            Parent = options;
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _applicationGatewaysRestClient = new ApplicationGatewaysRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Initializes a new instance of the <see cref="ApplicationGatewayAvailableSslOptions"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ApplicationGatewayAvailableSslOptions(ArmResource options, ResourceIdentifier id) : base(options, id)
        {
            Parent = options;
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _applicationGatewaysRestClient = new ApplicationGatewaysRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Initializes a new instance of the <see cref="ApplicationGatewayAvailableSslOptions"/> class. </summary>
        /// <param name="clientOptions"> The client options to build client context. </param>
        /// <param name="credential"> The credential to build client context. </param>
        /// <param name="uri"> The uri to build client context. </param>
        /// <param name="pipeline"> The pipeline to build client context. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ApplicationGatewayAvailableSslOptions(ArmClientOptions clientOptions, TokenCredential credential, Uri uri, HttpPipeline pipeline, ResourceIdentifier id) : base(clientOptions, credential, uri, pipeline, id)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _applicationGatewaysRestClient = new ApplicationGatewaysRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Network/applicationGatewayAvailableSslOptions";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual ApplicationGatewayAvailableSslOptionsData Data
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

        /// <summary> Gets the parent resource of this resource. </summary>
        public ArmResource Parent { get; }

        /// <summary> Lists available Ssl options for configuring Ssl policy. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<ApplicationGatewayAvailableSslOptions>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ApplicationGatewayAvailableSslOptions.Get");
            scope.Start();
            try
            {
                var response = await _applicationGatewaysRestClient.ListAvailableSslOptionsAsync(Id.SubscriptionId, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new ApplicationGatewayAvailableSslOptions(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists available Ssl options for configuring Ssl policy. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ApplicationGatewayAvailableSslOptions> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ApplicationGatewayAvailableSslOptions.Get");
            scope.Start();
            try
            {
                var response = _applicationGatewaysRestClient.ListAvailableSslOptions(Id.SubscriptionId, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ApplicationGatewayAvailableSslOptions(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists all available geo-locations. </summary>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of locations that may take multiple service requests to iterate over. </returns>
        public async virtual Task<IEnumerable<AzureLocation>> GetAvailableLocationsAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ApplicationGatewayAvailableSslOptions.GetAvailableLocations");
            scope.Start();
            try
            {
                return await ListAvailableLocationsAsync(ResourceType, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists all available geo-locations. </summary>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of locations that may take multiple service requests to iterate over. </returns>
        public virtual IEnumerable<AzureLocation> GetAvailableLocations(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ApplicationGatewayAvailableSslOptions.GetAvailableLocations");
            scope.Start();
            try
            {
                return ListAvailableLocations(ResourceType, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        #region ApplicationGatewaySslPredefinedPolicy

        /// <summary> Gets a collection of ApplicationGatewaySslPredefinedPolicies in the ApplicationGatewayAvailableSslOptions. </summary>
        /// <returns> An object representing collection of ApplicationGatewaySslPredefinedPolicies and their operations over a ApplicationGatewayAvailableSslOptions. </returns>
        public virtual ApplicationGatewaySslPredefinedPolicyCollection GetApplicationGatewaySslPredefinedPolicies()
        {
            return new ApplicationGatewaySslPredefinedPolicyCollection(this);
        }
        #endregion
    }
}
