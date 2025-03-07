// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ApiManagement.Models
{
    public partial class KeyVaultContractCreateProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(SecretIdentifier))
            {
                writer.WritePropertyName("secretIdentifier"u8);
                writer.WriteStringValue(SecretIdentifier);
            }
            if (Optional.IsDefined(IdentityClientId))
            {
                writer.WritePropertyName("identityClientId"u8);
                writer.WriteStringValue(IdentityClientId);
            }
            writer.WriteEndObject();
        }

        internal static KeyVaultContractCreateProperties DeserializeKeyVaultContractCreateProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> secretIdentifier = default;
            Optional<string> identityClientId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("secretIdentifier"u8))
                {
                    secretIdentifier = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("identityClientId"u8))
                {
                    identityClientId = property.Value.GetString();
                    continue;
                }
            }
            return new KeyVaultContractCreateProperties(secretIdentifier.Value, identityClientId.Value);
        }
    }
}
