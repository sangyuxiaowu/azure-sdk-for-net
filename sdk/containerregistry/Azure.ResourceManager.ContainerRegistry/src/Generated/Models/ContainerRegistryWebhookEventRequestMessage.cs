// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    /// <summary> The event request message sent to the service URI. </summary>
    public partial class ContainerRegistryWebhookEventRequestMessage
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ContainerRegistryWebhookEventRequestMessage"/>. </summary>
        internal ContainerRegistryWebhookEventRequestMessage()
        {
            Headers = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="ContainerRegistryWebhookEventRequestMessage"/>. </summary>
        /// <param name="content"> The content of the event request message. </param>
        /// <param name="headers"> The headers of the event request message. </param>
        /// <param name="method"> The HTTP method used to send the event request message. </param>
        /// <param name="requestUri"> The URI used to send the event request message. </param>
        /// <param name="version"> The HTTP message version. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ContainerRegistryWebhookEventRequestMessage(ContainerRegistryWebhookEventContent content, IReadOnlyDictionary<string, string> headers, string method, Uri requestUri, string version, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Content = content;
            Headers = headers;
            Method = method;
            RequestUri = requestUri;
            Version = version;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The content of the event request message. </summary>
        public ContainerRegistryWebhookEventContent Content { get; }
        /// <summary> The headers of the event request message. </summary>
        public IReadOnlyDictionary<string, string> Headers { get; }
        /// <summary> The HTTP method used to send the event request message. </summary>
        public string Method { get; }
        /// <summary> The URI used to send the event request message. </summary>
        public Uri RequestUri { get; }
        /// <summary> The HTTP message version. </summary>
        public string Version { get; }
    }
}
