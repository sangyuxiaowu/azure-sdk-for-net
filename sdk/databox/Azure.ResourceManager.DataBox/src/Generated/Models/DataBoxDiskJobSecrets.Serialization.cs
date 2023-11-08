// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Text.Json;
using Azure;
using Azure.Core;

namespace Azure.ResourceManager.DataBox.Models
{
    public partial class DataBoxDiskJobSecrets : IUtf8JsonSerializable, IJsonModel<DataBoxDiskJobSecrets>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DataBoxDiskJobSecrets>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<DataBoxDiskJobSecrets>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsCollectionDefined(DiskSecrets))
                {
                    writer.WritePropertyName("diskSecrets"u8);
                    writer.WriteStartArray();
                    foreach (var item in DiskSecrets)
                    {
                        writer.WriteObjectValue(item);
                    }
                    writer.WriteEndArray();
                }
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(Passkey))
                {
                    writer.WritePropertyName("passKey"u8);
                    writer.WriteStringValue(Passkey);
                }
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(IsPasskeyUserDefined))
                {
                    writer.WritePropertyName("isPasskeyUserDefined"u8);
                    writer.WriteBooleanValue(IsPasskeyUserDefined.Value);
                }
            }
            writer.WritePropertyName("jobSecretsType"u8);
            writer.WriteStringValue(JobSecretsType.ToSerialString());
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(DataCenterAccessSecurityCode))
                {
                    writer.WritePropertyName("dcAccessSecurityCode"u8);
                    writer.WriteObjectValue(DataCenterAccessSecurityCode);
                }
            }
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

        DataBoxDiskJobSecrets IJsonModel<DataBoxDiskJobSecrets>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(DataBoxDiskJobSecrets)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDataBoxDiskJobSecrets(document.RootElement, options);
        }

        internal static DataBoxDiskJobSecrets DeserializeDataBoxDiskJobSecrets(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<DataBoxDiskSecret>> diskSecrets = default;
            Optional<string> passKey = default;
            Optional<bool> isPasskeyUserDefined = default;
            DataBoxOrderType jobSecretsType = default;
            Optional<DataCenterAccessSecurityCode> dcAccessSecurityCode = default;
            Optional<ResponseError> error = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("diskSecrets"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DataBoxDiskSecret> array = new List<DataBoxDiskSecret>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DataBoxDiskSecret.DeserializeDataBoxDiskSecret(item));
                    }
                    diskSecrets = array;
                    continue;
                }
                if (property.NameEquals("passKey"u8))
                {
                    passKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isPasskeyUserDefined"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isPasskeyUserDefined = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("jobSecretsType"u8))
                {
                    jobSecretsType = property.Value.GetString().ToDataBoxOrderType();
                    continue;
                }
                if (property.NameEquals("dcAccessSecurityCode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dcAccessSecurityCode = DataCenterAccessSecurityCode.DeserializeDataCenterAccessSecurityCode(property.Value);
                    continue;
                }
                if (property.NameEquals("error"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    error = JsonSerializer.Deserialize<ResponseError>(property.Value.GetRawText());
                    continue;
                }
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DataBoxDiskJobSecrets(jobSecretsType, dcAccessSecurityCode.Value, error.Value, serializedAdditionalRawData, Optional.ToList(diskSecrets), passKey.Value, Optional.ToNullable(isPasskeyUserDefined));
        }

        BinaryData IModel<DataBoxDiskJobSecrets>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(DataBoxDiskJobSecrets)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        DataBoxDiskJobSecrets IModel<DataBoxDiskJobSecrets>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(DataBoxDiskJobSecrets)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeDataBoxDiskJobSecrets(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<DataBoxDiskJobSecrets>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
