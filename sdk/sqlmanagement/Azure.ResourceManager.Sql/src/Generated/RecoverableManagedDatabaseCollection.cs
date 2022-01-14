// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.Sql
{
    /// <summary> A class representing collection of RecoverableManagedDatabase and their operations over its parent. </summary>
    public partial class RecoverableManagedDatabaseCollection : ArmCollection, IEnumerable<RecoverableManagedDatabase>, IAsyncEnumerable<RecoverableManagedDatabase>
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly RecoverableManagedDatabasesRestOperations _recoverableManagedDatabasesRestClient;

        /// <summary> Initializes a new instance of the <see cref="RecoverableManagedDatabaseCollection"/> class for mocking. </summary>
        protected RecoverableManagedDatabaseCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="RecoverableManagedDatabaseCollection"/> class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal RecoverableManagedDatabaseCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _recoverableManagedDatabasesRestClient = new RecoverableManagedDatabasesRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ManagedInstance.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ManagedInstance.ResourceType), nameof(id));
        }

        // Collection level operations.

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/recoverableDatabases/{recoverableDatabaseName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}
        /// OperationId: RecoverableManagedDatabases_Get
        /// <summary> Gets a recoverable managed database. </summary>
        /// <param name="recoverableDatabaseName"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="recoverableDatabaseName"/> is null. </exception>
        public virtual Response<RecoverableManagedDatabase> Get(string recoverableDatabaseName, CancellationToken cancellationToken = default)
        {
            if (recoverableDatabaseName == null)
            {
                throw new ArgumentNullException(nameof(recoverableDatabaseName));
            }

            using var scope = _clientDiagnostics.CreateScope("RecoverableManagedDatabaseCollection.Get");
            scope.Start();
            try
            {
                var response = _recoverableManagedDatabasesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, recoverableDatabaseName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new RecoverableManagedDatabase(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/recoverableDatabases/{recoverableDatabaseName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}
        /// OperationId: RecoverableManagedDatabases_Get
        /// <summary> Gets a recoverable managed database. </summary>
        /// <param name="recoverableDatabaseName"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="recoverableDatabaseName"/> is null. </exception>
        public async virtual Task<Response<RecoverableManagedDatabase>> GetAsync(string recoverableDatabaseName, CancellationToken cancellationToken = default)
        {
            if (recoverableDatabaseName == null)
            {
                throw new ArgumentNullException(nameof(recoverableDatabaseName));
            }

            using var scope = _clientDiagnostics.CreateScope("RecoverableManagedDatabaseCollection.Get");
            scope.Start();
            try
            {
                var response = await _recoverableManagedDatabasesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, recoverableDatabaseName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new RecoverableManagedDatabase(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="recoverableDatabaseName"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="recoverableDatabaseName"/> is null. </exception>
        public virtual Response<RecoverableManagedDatabase> GetIfExists(string recoverableDatabaseName, CancellationToken cancellationToken = default)
        {
            if (recoverableDatabaseName == null)
            {
                throw new ArgumentNullException(nameof(recoverableDatabaseName));
            }

            using var scope = _clientDiagnostics.CreateScope("RecoverableManagedDatabaseCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _recoverableManagedDatabasesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, recoverableDatabaseName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<RecoverableManagedDatabase>(null, response.GetRawResponse());
                return Response.FromValue(new RecoverableManagedDatabase(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="recoverableDatabaseName"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="recoverableDatabaseName"/> is null. </exception>
        public async virtual Task<Response<RecoverableManagedDatabase>> GetIfExistsAsync(string recoverableDatabaseName, CancellationToken cancellationToken = default)
        {
            if (recoverableDatabaseName == null)
            {
                throw new ArgumentNullException(nameof(recoverableDatabaseName));
            }

            using var scope = _clientDiagnostics.CreateScope("RecoverableManagedDatabaseCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _recoverableManagedDatabasesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, recoverableDatabaseName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<RecoverableManagedDatabase>(null, response.GetRawResponse());
                return Response.FromValue(new RecoverableManagedDatabase(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="recoverableDatabaseName"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="recoverableDatabaseName"/> is null. </exception>
        public virtual Response<bool> Exists(string recoverableDatabaseName, CancellationToken cancellationToken = default)
        {
            if (recoverableDatabaseName == null)
            {
                throw new ArgumentNullException(nameof(recoverableDatabaseName));
            }

            using var scope = _clientDiagnostics.CreateScope("RecoverableManagedDatabaseCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(recoverableDatabaseName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="recoverableDatabaseName"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="recoverableDatabaseName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string recoverableDatabaseName, CancellationToken cancellationToken = default)
        {
            if (recoverableDatabaseName == null)
            {
                throw new ArgumentNullException(nameof(recoverableDatabaseName));
            }

            using var scope = _clientDiagnostics.CreateScope("RecoverableManagedDatabaseCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(recoverableDatabaseName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/recoverableDatabases
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}
        /// OperationId: RecoverableManagedDatabases_ListByInstance
        /// <summary> Gets a list of recoverable managed databases. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="RecoverableManagedDatabase" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<RecoverableManagedDatabase> GetAll(CancellationToken cancellationToken = default)
        {
            Page<RecoverableManagedDatabase> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("RecoverableManagedDatabaseCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _recoverableManagedDatabasesRestClient.ListByInstance(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new RecoverableManagedDatabase(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<RecoverableManagedDatabase> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("RecoverableManagedDatabaseCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _recoverableManagedDatabasesRestClient.ListByInstanceNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new RecoverableManagedDatabase(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/recoverableDatabases
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}
        /// OperationId: RecoverableManagedDatabases_ListByInstance
        /// <summary> Gets a list of recoverable managed databases. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="RecoverableManagedDatabase" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<RecoverableManagedDatabase> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<RecoverableManagedDatabase>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("RecoverableManagedDatabaseCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _recoverableManagedDatabasesRestClient.ListByInstanceAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new RecoverableManagedDatabase(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<RecoverableManagedDatabase>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("RecoverableManagedDatabaseCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _recoverableManagedDatabasesRestClient.ListByInstanceNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new RecoverableManagedDatabase(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        IEnumerator<RecoverableManagedDatabase> IEnumerable<RecoverableManagedDatabase>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<RecoverableManagedDatabase> IAsyncEnumerable<RecoverableManagedDatabase>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.Core.ResourceIdentifier, RecoverableManagedDatabase, RecoverableManagedDatabaseData> Construct() { }
    }
}
