// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    /// <summary> The parameters for updating a token. </summary>
    public partial class ContainerRegistryTokenPatch
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ContainerRegistryTokenPatch"/>. </summary>
        public ContainerRegistryTokenPatch()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ContainerRegistryTokenPatch"/>. </summary>
        /// <param name="scopeMapId"> The resource ID of the scope map to which the token will be associated with. </param>
        /// <param name="status"> The status of the token example enabled or disabled. </param>
        /// <param name="credentials"> The credentials that can be used for authenticating the token. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ContainerRegistryTokenPatch(ResourceIdentifier scopeMapId, ContainerRegistryTokenStatus? status, ContainerRegistryTokenCredentials credentials, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ScopeMapId = scopeMapId;
            Status = status;
            Credentials = credentials;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The resource ID of the scope map to which the token will be associated with. </summary>
        public ResourceIdentifier ScopeMapId { get; set; }
        /// <summary> The status of the token example enabled or disabled. </summary>
        public ContainerRegistryTokenStatus? Status { get; set; }
        /// <summary> The credentials that can be used for authenticating the token. </summary>
        public ContainerRegistryTokenCredentials Credentials { get; set; }
    }
}
