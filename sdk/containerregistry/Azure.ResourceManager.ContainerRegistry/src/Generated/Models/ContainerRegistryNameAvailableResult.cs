// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    /// <summary> The result of a request to check the availability of a container registry name. </summary>
    public partial class ContainerRegistryNameAvailableResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ContainerRegistryNameAvailableResult"/>. </summary>
        internal ContainerRegistryNameAvailableResult()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ContainerRegistryNameAvailableResult"/>. </summary>
        /// <param name="isNameAvailable"> The value that indicates whether the name is available. </param>
        /// <param name="reason"> If any, the reason that the name is not available. </param>
        /// <param name="message"> If any, the error message that provides more detail for the reason that the name is not available. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ContainerRegistryNameAvailableResult(bool? isNameAvailable, string reason, string message, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            IsNameAvailable = isNameAvailable;
            Reason = reason;
            Message = message;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The value that indicates whether the name is available. </summary>
        public bool? IsNameAvailable { get; }
        /// <summary> If any, the reason that the name is not available. </summary>
        public string Reason { get; }
        /// <summary> If any, the error message that provides more detail for the reason that the name is not available. </summary>
        public string Message { get; }
    }
}
