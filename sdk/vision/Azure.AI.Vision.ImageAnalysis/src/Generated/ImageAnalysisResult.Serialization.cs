// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure;
using Azure.Core;

namespace Azure.AI.Vision.ImageAnalysis
{
    public partial class ImageAnalysisResult
    {
        internal static ImageAnalysisResult DeserializeImageAnalysisResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<CaptionResult> captionResult = default;
            Optional<DenseCaptionsResult> denseCaptionsResult = default;
            ImageMetadata metadata = default;
            string modelVersion = default;
            Optional<ObjectsResult> objectsResult = default;
            Optional<PeopleResult> peopleResult = default;
            Optional<ReadResult> readResult = default;
            Optional<SmartCropsResult> smartCropsResult = default;
            Optional<TagsResult> tagsResult = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("captionResult"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    captionResult = CaptionResult.DeserializeCaptionResult(property.Value);
                    continue;
                }
                if (property.NameEquals("denseCaptionsResult"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    denseCaptionsResult = DenseCaptionsResult.DeserializeDenseCaptionsResult(property.Value);
                    continue;
                }
                if (property.NameEquals("metadata"u8))
                {
                    metadata = ImageMetadata.DeserializeImageMetadata(property.Value);
                    continue;
                }
                if (property.NameEquals("modelVersion"u8))
                {
                    modelVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("objectsResult"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    objectsResult = ObjectsResult.DeserializeObjectsResult(property.Value);
                    continue;
                }
                if (property.NameEquals("peopleResult"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    peopleResult = PeopleResult.DeserializePeopleResult(property.Value);
                    continue;
                }
                if (property.NameEquals("readResult"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    readResult = ReadResult.DeserializeReadResult(property.Value);
                    continue;
                }
                if (property.NameEquals("smartCropsResult"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    smartCropsResult = SmartCropsResult.DeserializeSmartCropsResult(property.Value);
                    continue;
                }
                if (property.NameEquals("tagsResult"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    tagsResult = TagsResult.DeserializeTagsResult(property.Value);
                    continue;
                }
            }
            return new ImageAnalysisResult(captionResult.Value, denseCaptionsResult.Value, metadata, modelVersion, objectsResult.Value, peopleResult.Value, readResult.Value, smartCropsResult.Value, tagsResult.Value);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static ImageAnalysisResult FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeImageAnalysisResult(document.RootElement);
        }
    }
}
