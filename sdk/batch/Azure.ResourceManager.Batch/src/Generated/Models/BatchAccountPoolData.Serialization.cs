// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Batch.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Batch
{
    public partial class BatchAccountPoolData : IUtf8JsonSerializable, IJsonModel<BatchAccountPoolData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BatchAccountPoolData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<BatchAccountPoolData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BatchAccountPoolData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BatchAccountPoolData)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Identity))
            {
                writer.WritePropertyName("identity"u8);
                JsonSerializer.Serialize(writer, Identity);
            }
            if (options.Format != "W" && Optional.IsDefined(ETag))
            {
                writer.WritePropertyName("etag"u8);
                writer.WriteStringValue(ETag.Value.ToString());
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format != "W" && Optional.IsDefined(SystemData))
            {
                writer.WritePropertyName("systemData"u8);
                JsonSerializer.Serialize(writer, SystemData);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(DisplayName))
            {
                writer.WritePropertyName("displayName"u8);
                writer.WriteStringValue(DisplayName);
            }
            if (options.Format != "W" && Optional.IsDefined(LastModifiedOn))
            {
                writer.WritePropertyName("lastModified"u8);
                writer.WriteStringValue(LastModifiedOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(CreatedOn))
            {
                writer.WritePropertyName("creationTime"u8);
                writer.WriteStringValue(CreatedOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningStateTransitOn))
            {
                writer.WritePropertyName("provisioningStateTransitionTime"u8);
                writer.WriteStringValue(ProvisioningStateTransitOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(AllocationState))
            {
                writer.WritePropertyName("allocationState"u8);
                writer.WriteStringValue(AllocationState.Value.ToSerialString());
            }
            if (options.Format != "W" && Optional.IsDefined(AllocationStateTransitionOn))
            {
                writer.WritePropertyName("allocationStateTransitionTime"u8);
                writer.WriteStringValue(AllocationStateTransitionOn.Value, "O");
            }
            if (Optional.IsDefined(VmSize))
            {
                writer.WritePropertyName("vmSize"u8);
                writer.WriteStringValue(VmSize);
            }
            if (Optional.IsDefined(DeploymentConfiguration))
            {
                writer.WritePropertyName("deploymentConfiguration"u8);
                writer.WriteObjectValue(DeploymentConfiguration);
            }
            if (options.Format != "W" && Optional.IsDefined(CurrentDedicatedNodes))
            {
                writer.WritePropertyName("currentDedicatedNodes"u8);
                writer.WriteNumberValue(CurrentDedicatedNodes.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(CurrentLowPriorityNodes))
            {
                writer.WritePropertyName("currentLowPriorityNodes"u8);
                writer.WriteNumberValue(CurrentLowPriorityNodes.Value);
            }
            if (Optional.IsDefined(ScaleSettings))
            {
                writer.WritePropertyName("scaleSettings"u8);
                writer.WriteObjectValue(ScaleSettings);
            }
            if (options.Format != "W" && Optional.IsDefined(AutoScaleRun))
            {
                writer.WritePropertyName("autoScaleRun"u8);
                writer.WriteObjectValue(AutoScaleRun);
            }
            if (Optional.IsDefined(InterNodeCommunication))
            {
                writer.WritePropertyName("interNodeCommunication"u8);
                writer.WriteStringValue(InterNodeCommunication.Value.ToSerialString());
            }
            if (Optional.IsDefined(NetworkConfiguration))
            {
                writer.WritePropertyName("networkConfiguration"u8);
                writer.WriteObjectValue(NetworkConfiguration);
            }
            if (Optional.IsDefined(TaskSlotsPerNode))
            {
                writer.WritePropertyName("taskSlotsPerNode"u8);
                writer.WriteNumberValue(TaskSlotsPerNode.Value);
            }
            if (Optional.IsDefined(TaskSchedulingPolicy))
            {
                writer.WritePropertyName("taskSchedulingPolicy"u8);
                writer.WriteObjectValue(TaskSchedulingPolicy);
            }
            if (Optional.IsCollectionDefined(UserAccounts))
            {
                writer.WritePropertyName("userAccounts"u8);
                writer.WriteStartArray();
                foreach (var item in UserAccounts)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Metadata))
            {
                writer.WritePropertyName("metadata"u8);
                writer.WriteStartArray();
                foreach (var item in Metadata)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(StartTask))
            {
                writer.WritePropertyName("startTask"u8);
                writer.WriteObjectValue(StartTask);
            }
            if (Optional.IsCollectionDefined(Certificates))
            {
                writer.WritePropertyName("certificates"u8);
                writer.WriteStartArray();
                foreach (var item in Certificates)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ApplicationPackages))
            {
                writer.WritePropertyName("applicationPackages"u8);
                writer.WriteStartArray();
                foreach (var item in ApplicationPackages)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ApplicationLicenses))
            {
                writer.WritePropertyName("applicationLicenses"u8);
                writer.WriteStartArray();
                foreach (var item in ApplicationLicenses)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(ResizeOperationStatus))
            {
                writer.WritePropertyName("resizeOperationStatus"u8);
                writer.WriteObjectValue(ResizeOperationStatus);
            }
            if (Optional.IsCollectionDefined(MountConfiguration))
            {
                writer.WritePropertyName("mountConfiguration"u8);
                writer.WriteStartArray();
                foreach (var item in MountConfiguration)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(TargetNodeCommunicationMode))
            {
                writer.WritePropertyName("targetNodeCommunicationMode"u8);
                writer.WriteStringValue(TargetNodeCommunicationMode.Value.ToSerialString());
            }
            if (options.Format != "W" && Optional.IsDefined(CurrentNodeCommunicationMode))
            {
                if (CurrentNodeCommunicationMode != null)
                {
                    writer.WritePropertyName("currentNodeCommunicationMode"u8);
                    writer.WriteStringValue(CurrentNodeCommunicationMode.Value.ToSerialString());
                }
                else
                {
                    writer.WriteNull("currentNodeCommunicationMode");
                }
            }
            if (Optional.IsCollectionDefined(ResourceTags))
            {
                writer.WritePropertyName("resourceTags"u8);
                writer.WriteStartObject();
                foreach (var item in ResourceTags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WriteEndObject();
            if (options.Format != "W" && _serializedAdditionalRawData != null)
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

        BatchAccountPoolData IJsonModel<BatchAccountPoolData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BatchAccountPoolData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BatchAccountPoolData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBatchAccountPoolData(document.RootElement, options);
        }

        internal static BatchAccountPoolData DeserializeBatchAccountPoolData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ManagedServiceIdentity> identity = default;
            Optional<ETag> etag = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> displayName = default;
            Optional<DateTimeOffset> lastModified = default;
            Optional<DateTimeOffset> creationTime = default;
            Optional<BatchAccountPoolProvisioningState> provisioningState = default;
            Optional<DateTimeOffset> provisioningStateTransitionTime = default;
            Optional<BatchAccountPoolAllocationState> allocationState = default;
            Optional<DateTimeOffset> allocationStateTransitionTime = default;
            Optional<string> vmSize = default;
            Optional<BatchDeploymentConfiguration> deploymentConfiguration = default;
            Optional<int> currentDedicatedNodes = default;
            Optional<int> currentLowPriorityNodes = default;
            Optional<BatchAccountPoolScaleSettings> scaleSettings = default;
            Optional<BatchAccountPoolAutoScaleRun> autoScaleRun = default;
            Optional<InterNodeCommunicationState> interNodeCommunication = default;
            Optional<BatchNetworkConfiguration> networkConfiguration = default;
            Optional<int> taskSlotsPerNode = default;
            Optional<TaskSchedulingPolicy> taskSchedulingPolicy = default;
            Optional<IList<BatchUserAccount>> userAccounts = default;
            Optional<IList<BatchAccountPoolMetadataItem>> metadata = default;
            Optional<BatchAccountPoolStartTask> startTask = default;
            Optional<IList<BatchCertificateReference>> certificates = default;
            Optional<IList<BatchApplicationPackageReference>> applicationPackages = default;
            Optional<IList<string>> applicationLicenses = default;
            Optional<BatchResizeOperationStatus> resizeOperationStatus = default;
            Optional<IList<BatchMountConfiguration>> mountConfiguration = default;
            Optional<NodeCommunicationMode> targetNodeCommunicationMode = default;
            Optional<NodeCommunicationMode?> currentNodeCommunicationMode = default;
            Optional<IDictionary<string, string>> resourceTags = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("identity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    identity = JsonSerializer.Deserialize<ManagedServiceIdentity>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("etag"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    etag = new ETag(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("displayName"u8))
                        {
                            displayName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("lastModified"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            lastModified = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("creationTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            creationTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new BatchAccountPoolProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("provisioningStateTransitionTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningStateTransitionTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("allocationState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            allocationState = property0.Value.GetString().ToBatchAccountPoolAllocationState();
                            continue;
                        }
                        if (property0.NameEquals("allocationStateTransitionTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            allocationStateTransitionTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("vmSize"u8))
                        {
                            vmSize = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("deploymentConfiguration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            deploymentConfiguration = BatchDeploymentConfiguration.DeserializeBatchDeploymentConfiguration(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("currentDedicatedNodes"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            currentDedicatedNodes = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("currentLowPriorityNodes"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            currentLowPriorityNodes = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("scaleSettings"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            scaleSettings = BatchAccountPoolScaleSettings.DeserializeBatchAccountPoolScaleSettings(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("autoScaleRun"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            autoScaleRun = BatchAccountPoolAutoScaleRun.DeserializeBatchAccountPoolAutoScaleRun(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("interNodeCommunication"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            interNodeCommunication = property0.Value.GetString().ToInterNodeCommunicationState();
                            continue;
                        }
                        if (property0.NameEquals("networkConfiguration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            networkConfiguration = BatchNetworkConfiguration.DeserializeBatchNetworkConfiguration(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("taskSlotsPerNode"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            taskSlotsPerNode = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("taskSchedulingPolicy"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            taskSchedulingPolicy = TaskSchedulingPolicy.DeserializeTaskSchedulingPolicy(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("userAccounts"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<BatchUserAccount> array = new List<BatchUserAccount>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(BatchUserAccount.DeserializeBatchUserAccount(item));
                            }
                            userAccounts = array;
                            continue;
                        }
                        if (property0.NameEquals("metadata"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<BatchAccountPoolMetadataItem> array = new List<BatchAccountPoolMetadataItem>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(BatchAccountPoolMetadataItem.DeserializeBatchAccountPoolMetadataItem(item));
                            }
                            metadata = array;
                            continue;
                        }
                        if (property0.NameEquals("startTask"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            startTask = BatchAccountPoolStartTask.DeserializeBatchAccountPoolStartTask(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("certificates"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<BatchCertificateReference> array = new List<BatchCertificateReference>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(BatchCertificateReference.DeserializeBatchCertificateReference(item));
                            }
                            certificates = array;
                            continue;
                        }
                        if (property0.NameEquals("applicationPackages"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<BatchApplicationPackageReference> array = new List<BatchApplicationPackageReference>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(BatchApplicationPackageReference.DeserializeBatchApplicationPackageReference(item));
                            }
                            applicationPackages = array;
                            continue;
                        }
                        if (property0.NameEquals("applicationLicenses"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            applicationLicenses = array;
                            continue;
                        }
                        if (property0.NameEquals("resizeOperationStatus"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            resizeOperationStatus = BatchResizeOperationStatus.DeserializeBatchResizeOperationStatus(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("mountConfiguration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<BatchMountConfiguration> array = new List<BatchMountConfiguration>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(BatchMountConfiguration.DeserializeBatchMountConfiguration(item));
                            }
                            mountConfiguration = array;
                            continue;
                        }
                        if (property0.NameEquals("targetNodeCommunicationMode"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            targetNodeCommunicationMode = property0.Value.GetString().ToNodeCommunicationMode();
                            continue;
                        }
                        if (property0.NameEquals("currentNodeCommunicationMode"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                currentNodeCommunicationMode = null;
                                continue;
                            }
                            currentNodeCommunicationMode = property0.Value.GetString().ToNodeCommunicationMode();
                            continue;
                        }
                        if (property0.NameEquals("resourceTags"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            Dictionary<string, string> dictionary = new Dictionary<string, string>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                dictionary.Add(property1.Name, property1.Value.GetString());
                            }
                            resourceTags = dictionary;
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new BatchAccountPoolData(id, name, type, systemData.Value, identity, displayName.Value, Optional.ToNullable(lastModified), Optional.ToNullable(creationTime), Optional.ToNullable(provisioningState), Optional.ToNullable(provisioningStateTransitionTime), Optional.ToNullable(allocationState), Optional.ToNullable(allocationStateTransitionTime), vmSize.Value, deploymentConfiguration.Value, Optional.ToNullable(currentDedicatedNodes), Optional.ToNullable(currentLowPriorityNodes), scaleSettings.Value, autoScaleRun.Value, Optional.ToNullable(interNodeCommunication), networkConfiguration.Value, Optional.ToNullable(taskSlotsPerNode), taskSchedulingPolicy.Value, Optional.ToList(userAccounts), Optional.ToList(metadata), startTask.Value, Optional.ToList(certificates), Optional.ToList(applicationPackages), Optional.ToList(applicationLicenses), resizeOperationStatus.Value, Optional.ToList(mountConfiguration), Optional.ToNullable(targetNodeCommunicationMode), Optional.ToNullable(currentNodeCommunicationMode), Optional.ToDictionary(resourceTags), Optional.ToNullable(etag), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<BatchAccountPoolData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BatchAccountPoolData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(BatchAccountPoolData)} does not support '{options.Format}' format.");
            }
        }

        BatchAccountPoolData IPersistableModel<BatchAccountPoolData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BatchAccountPoolData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeBatchAccountPoolData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(BatchAccountPoolData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<BatchAccountPoolData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
