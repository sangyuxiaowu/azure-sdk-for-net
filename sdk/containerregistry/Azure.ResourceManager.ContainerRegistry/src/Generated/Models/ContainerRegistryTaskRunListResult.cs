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
    /// <summary> The collection of task runs. </summary>
    internal partial class ContainerRegistryTaskRunListResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ContainerRegistryTaskRunListResult"/>. </summary>
        internal ContainerRegistryTaskRunListResult()
        {
            Value = new ChangeTrackingList<ContainerRegistryTaskRunData>();
        }

        /// <summary> Initializes a new instance of <see cref="ContainerRegistryTaskRunListResult"/>. </summary>
        /// <param name="value"> The collection value. </param>
        /// <param name="nextLink"> The URI that can be used to request the next set of paged results. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ContainerRegistryTaskRunListResult(IReadOnlyList<ContainerRegistryTaskRunData> value, string nextLink, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            NextLink = nextLink;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The collection value. </summary>
        public IReadOnlyList<ContainerRegistryTaskRunData> Value { get; }
        /// <summary> The URI that can be used to request the next set of paged results. </summary>
        public string NextLink { get; }
    }
}
