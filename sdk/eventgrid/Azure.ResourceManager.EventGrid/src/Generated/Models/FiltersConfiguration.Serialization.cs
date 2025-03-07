// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.EventGrid.Models
{
    public partial class FiltersConfiguration : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(IncludedEventTypes))
            {
                writer.WritePropertyName("includedEventTypes"u8);
                writer.WriteStartArray();
                foreach (var item in IncludedEventTypes)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Filters))
            {
                writer.WritePropertyName("filters"u8);
                writer.WriteStartArray();
                foreach (var item in Filters)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static FiltersConfiguration DeserializeFiltersConfiguration(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<string>> includedEventTypes = default;
            Optional<IList<EventGridFilter>> filters = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("includedEventTypes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    includedEventTypes = array;
                    continue;
                }
                if (property.NameEquals("filters"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<EventGridFilter> array = new List<EventGridFilter>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(EventGridFilter.DeserializeEventGridFilter(item));
                    }
                    filters = array;
                    continue;
                }
            }
            return new FiltersConfiguration(Optional.ToList(includedEventTypes), Optional.ToList(filters));
        }
    }
}
