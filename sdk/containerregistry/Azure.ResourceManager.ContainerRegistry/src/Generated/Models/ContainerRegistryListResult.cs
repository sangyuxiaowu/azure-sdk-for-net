// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.ContainerRegistry;

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    /// <summary> The result of a request to list container registries. </summary>
    internal partial class ContainerRegistryListResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ContainerRegistryListResult"/>. </summary>
        internal ContainerRegistryListResult()
        {
            Value = new ChangeTrackingList<ContainerRegistryData>();
        }

        /// <summary> Initializes a new instance of <see cref="ContainerRegistryListResult"/>. </summary>
        /// <param name="value"> The list of container registries. Since this list may be incomplete, the nextLink field should be used to request the next list of container registries. </param>
        /// <param name="nextLink"> The URI that can be used to request the next list of container registries. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ContainerRegistryListResult(IReadOnlyList<ContainerRegistryData> value, string nextLink, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            NextLink = nextLink;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The list of container registries. Since this list may be incomplete, the nextLink field should be used to request the next list of container registries. </summary>
        public IReadOnlyList<ContainerRegistryData> Value { get; }
        /// <summary> The URI that can be used to request the next list of container registries. </summary>
        public string NextLink { get; }
    }
}
