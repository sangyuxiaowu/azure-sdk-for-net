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
    public partial class ContainerRegistrySourceTrigger : IUtf8JsonSerializable, IJsonModel<ContainerRegistrySourceTrigger>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ContainerRegistrySourceTrigger>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<ContainerRegistrySourceTrigger>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("sourceRepository"u8);
            writer.WriteObjectValue(SourceRepository);
            writer.WritePropertyName("sourceTriggerEvents"u8);
            writer.WriteStartArray();
            foreach (var item in SourceTriggerEvents)
            {
                writer.WriteStringValue(item.ToString());
            }
            writer.WriteEndArray();
            if (Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status.Value.ToString());
            }
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
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

        ContainerRegistrySourceTrigger IJsonModel<ContainerRegistrySourceTrigger>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ContainerRegistrySourceTrigger)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeContainerRegistrySourceTrigger(document.RootElement, options);
        }

        internal static ContainerRegistrySourceTrigger DeserializeContainerRegistrySourceTrigger(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            SourceCodeRepoProperties sourceRepository = default;
            IList<ContainerRegistrySourceTriggerEvent> sourceTriggerEvents = default;
            Optional<ContainerRegistryTriggerStatus> status = default;
            string name = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sourceRepository"u8))
                {
                    sourceRepository = SourceCodeRepoProperties.DeserializeSourceCodeRepoProperties(property.Value);
                    continue;
                }
                if (property.NameEquals("sourceTriggerEvents"u8))
                {
                    List<ContainerRegistrySourceTriggerEvent> array = new List<ContainerRegistrySourceTriggerEvent>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new ContainerRegistrySourceTriggerEvent(item.GetString()));
                    }
                    sourceTriggerEvents = array;
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = new ContainerRegistryTriggerStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ContainerRegistrySourceTrigger(sourceRepository, sourceTriggerEvents, Optional.ToNullable(status), name, serializedAdditionalRawData);
        }

        BinaryData IModel<ContainerRegistrySourceTrigger>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ContainerRegistrySourceTrigger)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        ContainerRegistrySourceTrigger IModel<ContainerRegistrySourceTrigger>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ContainerRegistrySourceTrigger)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeContainerRegistrySourceTrigger(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<ContainerRegistrySourceTrigger>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
