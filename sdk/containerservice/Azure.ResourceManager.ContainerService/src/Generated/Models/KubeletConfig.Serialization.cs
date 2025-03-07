// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ContainerService.Models
{
    public partial class KubeletConfig : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(CpuManagerPolicy))
            {
                writer.WritePropertyName("cpuManagerPolicy"u8);
                writer.WriteStringValue(CpuManagerPolicy);
            }
            if (Optional.IsDefined(IsCpuCfsQuotaEnabled))
            {
                writer.WritePropertyName("cpuCfsQuota"u8);
                writer.WriteBooleanValue(IsCpuCfsQuotaEnabled.Value);
            }
            if (Optional.IsDefined(CpuCfsQuotaPeriod))
            {
                writer.WritePropertyName("cpuCfsQuotaPeriod"u8);
                writer.WriteStringValue(CpuCfsQuotaPeriod);
            }
            if (Optional.IsDefined(ImageGcHighThreshold))
            {
                writer.WritePropertyName("imageGcHighThreshold"u8);
                writer.WriteNumberValue(ImageGcHighThreshold.Value);
            }
            if (Optional.IsDefined(ImageGcLowThreshold))
            {
                writer.WritePropertyName("imageGcLowThreshold"u8);
                writer.WriteNumberValue(ImageGcLowThreshold.Value);
            }
            if (Optional.IsDefined(TopologyManagerPolicy))
            {
                writer.WritePropertyName("topologyManagerPolicy"u8);
                writer.WriteStringValue(TopologyManagerPolicy);
            }
            if (Optional.IsCollectionDefined(AllowedUnsafeSysctls))
            {
                writer.WritePropertyName("allowedUnsafeSysctls"u8);
                writer.WriteStartArray();
                foreach (var item in AllowedUnsafeSysctls)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(FailStartWithSwapOn))
            {
                writer.WritePropertyName("failSwapOn"u8);
                writer.WriteBooleanValue(FailStartWithSwapOn.Value);
            }
            if (Optional.IsDefined(ContainerLogMaxSizeInMB))
            {
                writer.WritePropertyName("containerLogMaxSizeMB"u8);
                writer.WriteNumberValue(ContainerLogMaxSizeInMB.Value);
            }
            if (Optional.IsDefined(ContainerLogMaxFiles))
            {
                writer.WritePropertyName("containerLogMaxFiles"u8);
                writer.WriteNumberValue(ContainerLogMaxFiles.Value);
            }
            if (Optional.IsDefined(PodMaxPids))
            {
                writer.WritePropertyName("podMaxPids"u8);
                writer.WriteNumberValue(PodMaxPids.Value);
            }
            writer.WriteEndObject();
        }

        internal static KubeletConfig DeserializeKubeletConfig(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> cpuManagerPolicy = default;
            Optional<bool> cpuCfsQuota = default;
            Optional<string> cpuCfsQuotaPeriod = default;
            Optional<int> imageGcHighThreshold = default;
            Optional<int> imageGcLowThreshold = default;
            Optional<string> topologyManagerPolicy = default;
            Optional<IList<string>> allowedUnsafeSysctls = default;
            Optional<bool> failSwapOn = default;
            Optional<int> containerLogMaxSizeMB = default;
            Optional<int> containerLogMaxFiles = default;
            Optional<int> podMaxPids = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("cpuManagerPolicy"u8))
                {
                    cpuManagerPolicy = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("cpuCfsQuota"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    cpuCfsQuota = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("cpuCfsQuotaPeriod"u8))
                {
                    cpuCfsQuotaPeriod = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("imageGcHighThreshold"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    imageGcHighThreshold = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("imageGcLowThreshold"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    imageGcLowThreshold = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("topologyManagerPolicy"u8))
                {
                    topologyManagerPolicy = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("allowedUnsafeSysctls"u8))
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
                    allowedUnsafeSysctls = array;
                    continue;
                }
                if (property.NameEquals("failSwapOn"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    failSwapOn = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("containerLogMaxSizeMB"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    containerLogMaxSizeMB = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("containerLogMaxFiles"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    containerLogMaxFiles = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("podMaxPids"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    podMaxPids = property.Value.GetInt32();
                    continue;
                }
            }
            return new KubeletConfig(cpuManagerPolicy.Value, Optional.ToNullable(cpuCfsQuota), cpuCfsQuotaPeriod.Value, Optional.ToNullable(imageGcHighThreshold), Optional.ToNullable(imageGcLowThreshold), topologyManagerPolicy.Value, Optional.ToList(allowedUnsafeSysctls), Optional.ToNullable(failSwapOn), Optional.ToNullable(containerLogMaxSizeMB), Optional.ToNullable(containerLogMaxFiles), Optional.ToNullable(podMaxPids));
        }
    }
}
