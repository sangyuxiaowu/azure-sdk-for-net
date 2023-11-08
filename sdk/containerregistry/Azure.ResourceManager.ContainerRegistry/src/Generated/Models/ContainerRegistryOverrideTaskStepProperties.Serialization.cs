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
    public partial class ContainerRegistryOverrideTaskStepProperties : IUtf8JsonSerializable, IJsonModel<ContainerRegistryOverrideTaskStepProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ContainerRegistryOverrideTaskStepProperties>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<ContainerRegistryOverrideTaskStepProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ContextPath))
            {
                writer.WritePropertyName("contextPath"u8);
                writer.WriteStringValue(ContextPath);
            }
            if (Optional.IsDefined(File))
            {
                writer.WritePropertyName("file"u8);
                writer.WriteStringValue(File);
            }
            if (Optional.IsCollectionDefined(Arguments))
            {
                writer.WritePropertyName("arguments"u8);
                writer.WriteStartArray();
                foreach (var item in Arguments)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Target))
            {
                writer.WritePropertyName("target"u8);
                writer.WriteStringValue(Target);
            }
            if (Optional.IsCollectionDefined(Values))
            {
                writer.WritePropertyName("values"u8);
                writer.WriteStartArray();
                foreach (var item in Values)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(UpdateTriggerToken))
            {
                writer.WritePropertyName("updateTriggerToken"u8);
                writer.WriteStringValue(UpdateTriggerToken);
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

        ContainerRegistryOverrideTaskStepProperties IJsonModel<ContainerRegistryOverrideTaskStepProperties>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ContainerRegistryOverrideTaskStepProperties)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeContainerRegistryOverrideTaskStepProperties(document.RootElement, options);
        }

        internal static ContainerRegistryOverrideTaskStepProperties DeserializeContainerRegistryOverrideTaskStepProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> contextPath = default;
            Optional<string> file = default;
            Optional<IList<ContainerRegistryRunArgument>> arguments = default;
            Optional<string> target = default;
            Optional<IList<ContainerRegistryTaskOverridableValue>> values = default;
            Optional<string> updateTriggerToken = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("contextPath"u8))
                {
                    contextPath = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("file"u8))
                {
                    file = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("arguments"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ContainerRegistryRunArgument> array = new List<ContainerRegistryRunArgument>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ContainerRegistryRunArgument.DeserializeContainerRegistryRunArgument(item));
                    }
                    arguments = array;
                    continue;
                }
                if (property.NameEquals("target"u8))
                {
                    target = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("values"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ContainerRegistryTaskOverridableValue> array = new List<ContainerRegistryTaskOverridableValue>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ContainerRegistryTaskOverridableValue.DeserializeContainerRegistryTaskOverridableValue(item));
                    }
                    values = array;
                    continue;
                }
                if (property.NameEquals("updateTriggerToken"u8))
                {
                    updateTriggerToken = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ContainerRegistryOverrideTaskStepProperties(contextPath.Value, file.Value, Optional.ToList(arguments), target.Value, Optional.ToList(values), updateTriggerToken.Value, serializedAdditionalRawData);
        }

        BinaryData IModel<ContainerRegistryOverrideTaskStepProperties>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ContainerRegistryOverrideTaskStepProperties)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        ContainerRegistryOverrideTaskStepProperties IModel<ContainerRegistryOverrideTaskStepProperties>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ContainerRegistryOverrideTaskStepProperties)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeContainerRegistryOverrideTaskStepProperties(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<ContainerRegistryOverrideTaskStepProperties>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
