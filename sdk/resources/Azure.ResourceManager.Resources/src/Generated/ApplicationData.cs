// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Resources
{
    /// <summary> A class representing the Application data model. </summary>
    public partial class ApplicationData : GenericResourceAutoGenerated
    {
        /// <summary> Initializes a new instance of ApplicationData. </summary>
        /// <param name="location"> The location. </param>
        /// <param name="kind"> The kind of the managed application. Allowed values are MarketPlace and ServiceCatalog. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="kind"/> is null. </exception>
        public ApplicationData(AzureLocation location, string kind) : base(location)
        {
            if (kind == null)
            {
                throw new ArgumentNullException(nameof(kind));
            }

            Kind = kind;
            Authorizations = new ChangeTrackingList<ApplicationAuthorization>();
            Artifacts = new ChangeTrackingList<ApplicationArtifact>();
        }

        /// <summary> Initializes a new instance of ApplicationData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="managedBy"> ID of the resource that manages this resource. </param>
        /// <param name="sku"> The SKU of the resource. </param>
        /// <param name="plan"> The plan information. </param>
        /// <param name="kind"> The kind of the managed application. Allowed values are MarketPlace and ServiceCatalog. </param>
        /// <param name="identity"> The identity of the resource. </param>
        /// <param name="managedResourceGroupId"> The managed resource group Id. </param>
        /// <param name="applicationDefinitionId"> The fully qualified path of managed application definition Id. </param>
        /// <param name="parameters"> Name and value pairs that define the managed application parameters. It can be a JObject or a well formed JSON string. </param>
        /// <param name="outputs"> Name and value pairs that define the managed application outputs. </param>
        /// <param name="provisioningState"> The managed application provisioning state. </param>
        /// <param name="billingDetails"> The managed application billing details. </param>
        /// <param name="jitAccessPolicy"> The managed application Jit access policy. </param>
        /// <param name="publisherTenantId"> The publisher tenant Id. </param>
        /// <param name="authorizations"> The  read-only authorizations property that is retrieved from the application package. </param>
        /// <param name="managementMode"> The managed application management mode. </param>
        /// <param name="customerSupport"> The read-only customer support property that is retrieved from the application package. </param>
        /// <param name="supportUrls"> The read-only support URLs property that is retrieved from the application package. </param>
        /// <param name="artifacts"> The collection of managed application artifacts. </param>
        /// <param name="createdBy"> The client entity that created the JIT request. </param>
        /// <param name="updatedBy"> The client entity that last updated the JIT request. </param>
        internal ApplicationData(ResourceIdentifier id, string name, ResourceType type, IDictionary<string, string> tags, AzureLocation location, string managedBy, SkuAutoGenerated sku, Plan plan, string kind, IdentityAutoGenerated identity, string managedResourceGroupId, string applicationDefinitionId, object parameters, object outputs, ProvisioningState? provisioningState, ApplicationBillingDetailsDefinition billingDetails, ApplicationJitAccessPolicy jitAccessPolicy, string publisherTenantId, IReadOnlyList<ApplicationAuthorization> authorizations, ApplicationManagementMode? managementMode, ApplicationPackageContact customerSupport, ApplicationPackageSupportUrls supportUrls, IReadOnlyList<ApplicationArtifact> artifacts, ApplicationClientDetails createdBy, ApplicationClientDetails updatedBy) : base(id, name, type, tags, location, managedBy, sku)
        {
            Plan = plan;
            Kind = kind;
            Identity = identity;
            ManagedResourceGroupId = managedResourceGroupId;
            ApplicationDefinitionId = applicationDefinitionId;
            Parameters = parameters;
            Outputs = outputs;
            ProvisioningState = provisioningState;
            BillingDetails = billingDetails;
            JitAccessPolicy = jitAccessPolicy;
            PublisherTenantId = publisherTenantId;
            Authorizations = authorizations;
            ManagementMode = managementMode;
            CustomerSupport = customerSupport;
            SupportUrls = supportUrls;
            Artifacts = artifacts;
            CreatedBy = createdBy;
            UpdatedBy = updatedBy;
        }

        /// <summary> The plan information. </summary>
        public Plan Plan { get; set; }
        /// <summary> The kind of the managed application. Allowed values are MarketPlace and ServiceCatalog. </summary>
        public string Kind { get; set; }
        /// <summary> The identity of the resource. </summary>
        public IdentityAutoGenerated Identity { get; set; }
        /// <summary> The managed resource group Id. </summary>
        public string ManagedResourceGroupId { get; set; }
        /// <summary> The fully qualified path of managed application definition Id. </summary>
        public string ApplicationDefinitionId { get; set; }
        /// <summary> Name and value pairs that define the managed application parameters. It can be a JObject or a well formed JSON string. </summary>
        public object Parameters { get; set; }
        /// <summary> Name and value pairs that define the managed application outputs. </summary>
        public object Outputs { get; }
        /// <summary> The managed application provisioning state. </summary>
        public ProvisioningState? ProvisioningState { get; }
        /// <summary> The managed application billing details. </summary>
        public ApplicationBillingDetailsDefinition BillingDetails { get; }
        /// <summary> The managed application Jit access policy. </summary>
        public ApplicationJitAccessPolicy JitAccessPolicy { get; set; }
        /// <summary> The publisher tenant Id. </summary>
        public string PublisherTenantId { get; }
        /// <summary> The  read-only authorizations property that is retrieved from the application package. </summary>
        public IReadOnlyList<ApplicationAuthorization> Authorizations { get; }
        /// <summary> The managed application management mode. </summary>
        public ApplicationManagementMode? ManagementMode { get; }
        /// <summary> The read-only customer support property that is retrieved from the application package. </summary>
        public ApplicationPackageContact CustomerSupport { get; }
        /// <summary> The read-only support URLs property that is retrieved from the application package. </summary>
        public ApplicationPackageSupportUrls SupportUrls { get; }
        /// <summary> The collection of managed application artifacts. </summary>
        public IReadOnlyList<ApplicationArtifact> Artifacts { get; }
        /// <summary> The client entity that created the JIT request. </summary>
        public ApplicationClientDetails CreatedBy { get; }
        /// <summary> The client entity that last updated the JIT request. </summary>
        public ApplicationClientDetails UpdatedBy { get; }
    }
}
