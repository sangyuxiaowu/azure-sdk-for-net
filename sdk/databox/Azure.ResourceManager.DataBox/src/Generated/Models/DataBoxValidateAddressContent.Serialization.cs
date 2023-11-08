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

namespace Azure.ResourceManager.DataBox.Models
{
    public partial class DataBoxValidateAddressContent : IUtf8JsonSerializable, IJsonModel<DataBoxValidateAddressContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DataBoxValidateAddressContent>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<DataBoxValidateAddressContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("shippingAddress"u8);
            writer.WriteObjectValue(ShippingAddress);
            writer.WritePropertyName("deviceType"u8);
            writer.WriteStringValue(DeviceType.ToSerialString());
            if (Optional.IsDefined(TransportPreferences))
            {
                writer.WritePropertyName("transportPreferences"u8);
                writer.WriteObjectValue(TransportPreferences);
            }
            writer.WritePropertyName("validationType"u8);
            writer.WriteStringValue(ValidationType.ToSerialString());
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

        DataBoxValidateAddressContent IJsonModel<DataBoxValidateAddressContent>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(DataBoxValidateAddressContent)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDataBoxValidateAddressContent(document.RootElement, options);
        }

        internal static DataBoxValidateAddressContent DeserializeDataBoxValidateAddressContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DataBoxShippingAddress shippingAddress = default;
            DataBoxSkuName deviceType = default;
            Optional<TransportPreferences> transportPreferences = default;
            DataBoxValidationInputDiscriminator validationType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("shippingAddress"u8))
                {
                    shippingAddress = DataBoxShippingAddress.DeserializeDataBoxShippingAddress(property.Value);
                    continue;
                }
                if (property.NameEquals("deviceType"u8))
                {
                    deviceType = property.Value.GetString().ToDataBoxSkuName();
                    continue;
                }
                if (property.NameEquals("transportPreferences"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    transportPreferences = TransportPreferences.DeserializeTransportPreferences(property.Value);
                    continue;
                }
                if (property.NameEquals("validationType"u8))
                {
                    validationType = property.Value.GetString().ToDataBoxValidationInputDiscriminator();
                    continue;
                }
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DataBoxValidateAddressContent(validationType, serializedAdditionalRawData, shippingAddress, deviceType, transportPreferences.Value);
        }

        BinaryData IModel<DataBoxValidateAddressContent>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(DataBoxValidateAddressContent)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        DataBoxValidateAddressContent IModel<DataBoxValidateAddressContent>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(DataBoxValidateAddressContent)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeDataBoxValidateAddressContent(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<DataBoxValidateAddressContent>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
