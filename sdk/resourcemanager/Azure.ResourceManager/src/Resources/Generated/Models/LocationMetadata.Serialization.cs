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

namespace Azure.ResourceManager.Resources.Models
{
    public partial class LocationMetadata : IUtf8JsonSerializable, IJsonModel<LocationMetadata>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<LocationMetadata>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<LocationMetadata>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(RegionType))
                {
                    writer.WritePropertyName("regionType"u8);
                    writer.WriteStringValue(RegionType.Value.ToString());
                }
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(RegionCategory))
                {
                    writer.WritePropertyName("regionCategory"u8);
                    writer.WriteStringValue(RegionCategory.Value.ToString());
                }
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(Geography))
                {
                    writer.WritePropertyName("geography"u8);
                    writer.WriteStringValue(Geography);
                }
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(GeographyGroup))
                {
                    writer.WritePropertyName("geographyGroup"u8);
                    writer.WriteStringValue(GeographyGroup);
                }
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(Longitude))
                {
                    writer.WritePropertyName("longitude"u8);
                    WriteLongitude(writer);
                }
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(Latitude))
                {
                    writer.WritePropertyName("latitude"u8);
                    WriteLatitude(writer);
                }
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(PhysicalLocation))
                {
                    writer.WritePropertyName("physicalLocation"u8);
                    writer.WriteStringValue(PhysicalLocation);
                }
            }
            if (Optional.IsCollectionDefined(PairedRegions))
            {
                writer.WritePropertyName("pairedRegion"u8);
                writer.WriteStartArray();
                foreach (var item in PairedRegions)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(HomeLocation))
                {
                    writer.WritePropertyName("homeLocation"u8);
                    writer.WriteStringValue(HomeLocation);
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

        LocationMetadata IJsonModel<LocationMetadata>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(LocationMetadata)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeLocationMetadata(document.RootElement, options);
        }

        internal static LocationMetadata DeserializeLocationMetadata(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<RegionType> regionType = default;
            Optional<RegionCategory> regionCategory = default;
            Optional<string> geography = default;
            Optional<string> geographyGroup = default;
            Optional<double> longitude = default;
            Optional<double> latitude = default;
            Optional<string> physicalLocation = default;
            Optional<IReadOnlyList<PairedRegion>> pairedRegion = default;
            Optional<string> homeLocation = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("regionType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    regionType = new RegionType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("regionCategory"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    regionCategory = new RegionCategory(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("geography"u8))
                {
                    geography = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("geographyGroup"u8))
                {
                    geographyGroup = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("longitude"u8))
                {
                    ReadLongitude(property, ref longitude);
                    continue;
                }
                if (property.NameEquals("latitude"u8))
                {
                    ReadLatitude(property, ref latitude);
                    continue;
                }
                if (property.NameEquals("physicalLocation"u8))
                {
                    physicalLocation = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("pairedRegion"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<PairedRegion> array = new List<PairedRegion>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PairedRegion.DeserializePairedRegion(item));
                    }
                    pairedRegion = array;
                    continue;
                }
                if (property.NameEquals("homeLocation"u8))
                {
                    homeLocation = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new LocationMetadata(Optional.ToNullable(regionType), Optional.ToNullable(regionCategory), geography.Value, geographyGroup.Value, Optional.ToNullable(longitude), Optional.ToNullable(latitude), physicalLocation.Value, Optional.ToList(pairedRegion), homeLocation.Value, serializedAdditionalRawData);
        }

        BinaryData IModel<LocationMetadata>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(LocationMetadata)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        LocationMetadata IModel<LocationMetadata>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(LocationMetadata)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeLocationMetadata(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<LocationMetadata>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
