// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure;

namespace Azure.AI.Vision.ImageAnalysis
{
    public partial class ImagePoint
    {
        internal static ImagePoint DeserializeImagePoint(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int x = default;
            int y = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("x"u8))
                {
                    x = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("y"u8))
                {
                    y = property.Value.GetInt32();
                    continue;
                }
            }
            return new ImagePoint(x, y);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static ImagePoint FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeImagePoint(document.RootElement);
        }
    }
}
