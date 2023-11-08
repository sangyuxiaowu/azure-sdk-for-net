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
    [ModelReaderProxy(typeof(UnknownValidationInputResponse))]
    public partial class DataBoxValidationInputResult : IUtf8JsonSerializable, IJsonModel<DataBoxValidationInputResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DataBoxValidationInputResult>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<DataBoxValidationInputResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("validationType"u8);
            writer.WriteStringValue(ValidationType.ToSerialString());
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(Error))
                {
                    writer.WritePropertyName("error"u8);
                    writer.WriteObjectValue(Error);
                }
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

        DataBoxValidationInputResult IJsonModel<DataBoxValidationInputResult>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(DataBoxValidationInputResult)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDataBoxValidationInputResult(document.RootElement, options);
        }

        internal static DataBoxValidationInputResult DeserializeDataBoxValidationInputResult(JsonElement element, ModelReaderWriterOptions options = null)
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
                    case "ValidateCreateOrderLimit": return CreateOrderLimitForSubscriptionValidationResult.DeserializeCreateOrderLimitForSubscriptionValidationResult(element);
                    case "ValidateDataTransferDetails": return DataTransferDetailsValidationResult.DeserializeDataTransferDetailsValidationResult(element);
                    case "ValidatePreferences": return PreferencesValidationResult.DeserializePreferencesValidationResult(element);
                    case "ValidateSkuAvailability": return SkuAvailabilityValidationResult.DeserializeSkuAvailabilityValidationResult(element);
                    case "ValidateSubscriptionIsAllowedToCreateJob": return SubscriptionIsAllowedToCreateJobValidationResult.DeserializeSubscriptionIsAllowedToCreateJobValidationResult(element);
                    case "ValidateAddress": return AddressValidationResult.DeserializeAddressValidationResult(element);
                }
            }
            return UnknownValidationInputResponse.DeserializeUnknownValidationInputResponse(element);
        }

        BinaryData IModel<DataBoxValidationInputResult>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(DataBoxValidationInputResult)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        DataBoxValidationInputResult IModel<DataBoxValidationInputResult>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(DataBoxValidationInputResult)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeDataBoxValidationInputResult(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<DataBoxValidationInputResult>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
