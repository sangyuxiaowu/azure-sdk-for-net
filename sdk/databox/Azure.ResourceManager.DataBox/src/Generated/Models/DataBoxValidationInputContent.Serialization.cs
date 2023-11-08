// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataBox.Models
{
    [ModelReaderProxy(typeof(UnknownValidationInputRequest))]
    public partial class DataBoxValidationInputContent : IUtf8JsonSerializable, IJsonModel<DataBoxValidationInputContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DataBoxValidationInputContent>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<DataBoxValidationInputContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
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

        DataBoxValidationInputContent IJsonModel<DataBoxValidationInputContent>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(DataBoxValidationInputContent)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDataBoxValidationInputContent(document.RootElement, options);
        }

        internal static DataBoxValidationInputContent DeserializeDataBoxValidationInputContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("validationType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "ValidateCreateOrderLimit": return CreateOrderLimitForSubscriptionValidationContent.DeserializeCreateOrderLimitForSubscriptionValidationContent(element);
                    case "ValidateDataTransferDetails": return DataTransferDetailsValidationContent.DeserializeDataTransferDetailsValidationContent(element);
                    case "ValidatePreferences": return PreferencesValidationContent.DeserializePreferencesValidationContent(element);
                    case "ValidateSkuAvailability": return SkuAvailabilityValidationContent.DeserializeSkuAvailabilityValidationContent(element);
                    case "ValidateSubscriptionIsAllowedToCreateJob": return SubscriptionIsAllowedToCreateJobValidationContent.DeserializeSubscriptionIsAllowedToCreateJobValidationContent(element);
                    case "ValidateAddress": return DataBoxValidateAddressContent.DeserializeDataBoxValidateAddressContent(element);
                }
            }
            return UnknownValidationInputRequest.DeserializeUnknownValidationInputRequest(element);
        }

        BinaryData IModel<DataBoxValidationInputContent>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(DataBoxValidationInputContent)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        DataBoxValidationInputContent IModel<DataBoxValidationInputContent>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(DataBoxValidationInputContent)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeDataBoxValidationInputContent(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<DataBoxValidationInputContent>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
