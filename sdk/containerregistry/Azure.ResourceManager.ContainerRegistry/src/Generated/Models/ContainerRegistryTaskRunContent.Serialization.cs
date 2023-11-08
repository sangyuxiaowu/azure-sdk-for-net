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
    public partial class ContainerRegistryTaskRunContent : IUtf8JsonSerializable, IJsonModel<ContainerRegistryTaskRunContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ContainerRegistryTaskRunContent>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<ContainerRegistryTaskRunContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("taskId"u8);
            writer.WriteStringValue(TaskId);
            if (Optional.IsDefined(OverrideTaskStepProperties))
            {
                writer.WritePropertyName("overrideTaskStepProperties"u8);
                writer.WriteObjectValue(OverrideTaskStepProperties);
            }
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(RunRequestType);
            if (Optional.IsDefined(IsArchiveEnabled))
            {
                writer.WritePropertyName("isArchiveEnabled"u8);
                writer.WriteBooleanValue(IsArchiveEnabled.Value);
            }
            if (Optional.IsDefined(AgentPoolName))
            {
                writer.WritePropertyName("agentPoolName"u8);
                writer.WriteStringValue(AgentPoolName);
            }
            if (Optional.IsDefined(LogTemplate))
            {
                writer.WritePropertyName("logTemplate"u8);
                writer.WriteStringValue(LogTemplate);
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

        ContainerRegistryTaskRunContent IJsonModel<ContainerRegistryTaskRunContent>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ContainerRegistryTaskRunContent)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeContainerRegistryTaskRunContent(document.RootElement, options);
        }

        internal static ContainerRegistryTaskRunContent DeserializeContainerRegistryTaskRunContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier taskId = default;
            Optional<ContainerRegistryOverrideTaskStepProperties> overrideTaskStepProperties = default;
            string type = default;
            Optional<bool> isArchiveEnabled = default;
            Optional<string> agentPoolName = default;
            Optional<string> logTemplate = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("taskId"u8))
                {
                    taskId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("overrideTaskStepProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    overrideTaskStepProperties = ContainerRegistryOverrideTaskStepProperties.DeserializeContainerRegistryOverrideTaskStepProperties(property.Value);
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isArchiveEnabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isArchiveEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("agentPoolName"u8))
                {
                    agentPoolName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("logTemplate"u8))
                {
                    logTemplate = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ContainerRegistryTaskRunContent(type, Optional.ToNullable(isArchiveEnabled), agentPoolName.Value, logTemplate.Value, serializedAdditionalRawData, taskId, overrideTaskStepProperties.Value);
        }

        BinaryData IModel<ContainerRegistryTaskRunContent>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ContainerRegistryTaskRunContent)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        ContainerRegistryTaskRunContent IModel<ContainerRegistryTaskRunContent>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ContainerRegistryTaskRunContent)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeContainerRegistryTaskRunContent(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<ContainerRegistryTaskRunContent>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
