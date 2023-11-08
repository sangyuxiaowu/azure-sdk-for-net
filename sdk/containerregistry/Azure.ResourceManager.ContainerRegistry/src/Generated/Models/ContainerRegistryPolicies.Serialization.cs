// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    public partial class ContainerRegistryPolicies : IUtf8JsonSerializable, IJsonModel<ContainerRegistryPolicies>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ContainerRegistryPolicies>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<ContainerRegistryPolicies>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(QuarantinePolicy))
            {
                writer.WritePropertyName("quarantinePolicy"u8);
                writer.WriteObjectValue(QuarantinePolicy);
            }
            if (Optional.IsDefined(TrustPolicy))
            {
                writer.WritePropertyName("trustPolicy"u8);
                writer.WriteObjectValue(TrustPolicy);
            }
            if (Optional.IsDefined(RetentionPolicy))
            {
                writer.WritePropertyName("retentionPolicy"u8);
                writer.WriteObjectValue(RetentionPolicy);
            }
            if (Optional.IsDefined(ExportPolicy))
            {
                writer.WritePropertyName("exportPolicy"u8);
                writer.WriteObjectValue(ExportPolicy);
            }
            if (_serializedAdditionalRawData != null && options.Format == ModelReaderWriterFormat.Json)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        ContainerRegistryPolicies IJsonModel<ContainerRegistryPolicies>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ContainerRegistryPolicies)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeContainerRegistryPolicies(document.RootElement, options);
        }

        internal static ContainerRegistryPolicies DeserializeContainerRegistryPolicies(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ContainerRegistryQuarantinePolicy> quarantinePolicy = default;
            Optional<ContainerRegistryTrustPolicy> trustPolicy = default;
            Optional<ContainerRegistryRetentionPolicy> retentionPolicy = default;
            Optional<ContainerRegistryExportPolicy> exportPolicy = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("quarantinePolicy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    quarantinePolicy = ContainerRegistryQuarantinePolicy.DeserializeContainerRegistryQuarantinePolicy(property.Value);
                    continue;
                }
                if (property.NameEquals("trustPolicy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    trustPolicy = ContainerRegistryTrustPolicy.DeserializeContainerRegistryTrustPolicy(property.Value);
                    continue;
                }
                if (property.NameEquals("retentionPolicy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    retentionPolicy = ContainerRegistryRetentionPolicy.DeserializeContainerRegistryRetentionPolicy(property.Value);
                    continue;
                }
                if (property.NameEquals("exportPolicy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    exportPolicy = ContainerRegistryExportPolicy.DeserializeContainerRegistryExportPolicy(property.Value);
                    continue;
                }
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ContainerRegistryPolicies(quarantinePolicy.Value, trustPolicy.Value, retentionPolicy.Value, exportPolicy.Value, serializedAdditionalRawData);
        }

        BinaryData IModel<ContainerRegistryPolicies>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ContainerRegistryPolicies)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        ContainerRegistryPolicies IModel<ContainerRegistryPolicies>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ContainerRegistryPolicies)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeContainerRegistryPolicies(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<ContainerRegistryPolicies>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
