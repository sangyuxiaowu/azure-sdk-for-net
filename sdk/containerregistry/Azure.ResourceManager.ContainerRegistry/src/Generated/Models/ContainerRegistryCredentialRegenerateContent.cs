// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    /// <summary> The parameters used to regenerate the login credential. </summary>
    public partial class ContainerRegistryCredentialRegenerateContent
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ContainerRegistryCredentialRegenerateContent"/>. </summary>
        /// <param name="name"> Specifies name of the password which should be regenerated -- password or password2. </param>
        public ContainerRegistryCredentialRegenerateContent(ContainerRegistryPasswordName name)
        {
            Name = name;
        }

        /// <summary> Initializes a new instance of <see cref="ContainerRegistryCredentialRegenerateContent"/>. </summary>
        /// <param name="name"> Specifies name of the password which should be regenerated -- password or password2. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ContainerRegistryCredentialRegenerateContent(ContainerRegistryPasswordName name, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ContainerRegistryCredentialRegenerateContent"/> for deserialization. </summary>
        internal ContainerRegistryCredentialRegenerateContent()
        {
        }

        /// <summary> Specifies name of the password which should be regenerated -- password or password2. </summary>
        public ContainerRegistryPasswordName Name { get; }
    }
}
