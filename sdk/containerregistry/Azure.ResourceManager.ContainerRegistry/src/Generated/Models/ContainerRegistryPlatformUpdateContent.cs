// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    /// <summary> The properties for updating the platform configuration. </summary>
    public partial class ContainerRegistryPlatformUpdateContent
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ContainerRegistryPlatformUpdateContent"/>. </summary>
        public ContainerRegistryPlatformUpdateContent()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ContainerRegistryPlatformUpdateContent"/>. </summary>
        /// <param name="os"> The operating system type required for the run. </param>
        /// <param name="architecture"> The OS architecture. </param>
        /// <param name="variant"> Variant of the CPU. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ContainerRegistryPlatformUpdateContent(ContainerRegistryOS? os, ContainerRegistryOSArchitecture? architecture, ContainerRegistryCpuVariant? variant, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            OS = os;
            Architecture = architecture;
            Variant = variant;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The operating system type required for the run. </summary>
        public ContainerRegistryOS? OS { get; set; }
        /// <summary> The OS architecture. </summary>
        public ContainerRegistryOSArchitecture? Architecture { get; set; }
        /// <summary> Variant of the CPU. </summary>
        public ContainerRegistryCpuVariant? Variant { get; set; }
    }
}
