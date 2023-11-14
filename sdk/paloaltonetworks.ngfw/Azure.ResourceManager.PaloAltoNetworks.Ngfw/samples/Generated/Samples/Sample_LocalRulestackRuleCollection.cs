// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager;
using Azure.ResourceManager.PaloAltoNetworks.Ngfw;
using Azure.ResourceManager.PaloAltoNetworks.Ngfw.Models;

namespace Azure.ResourceManager.PaloAltoNetworks.Ngfw.Samples
{
    public partial class Sample_LocalRulestackRuleCollection
    {
        // LocalRules_ListByLocalRulestacks_MaximumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_LocalRulesListByLocalRulestacksMaximumSetGen()
        {
            // Generated from example definition: specification/paloaltonetworks/resource-manager/PaloAltoNetworks.Cloudngfw/stable/2023-09-01/examples/LocalRules_ListByLocalRulestacks_MaximumSet_Gen.json
            // this example is just showing the usage of "LocalRules_ListByLocalRulestacks" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this LocalRulestackResource created on azure
            // for more information of creating LocalRulestackResource, please refer to the document of LocalRulestackResource
            string subscriptionId = "2bf4a339-294d-4c25-b0b2-ef649e9f5c27";
            string resourceGroupName = "firewall-rg";
            string localRulestackName = "lrs1";
            ResourceIdentifier localRulestackResourceId = LocalRulestackResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, localRulestackName);
            LocalRulestackResource localRulestack = client.GetLocalRulestackResource(localRulestackResourceId);

            // get the collection of this LocalRulestackRuleResource
            LocalRulestackRuleCollection collection = localRulestack.GetLocalRulestackRules();

            // invoke the operation and iterate over the result
            await foreach (LocalRulestackRuleResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                LocalRulestackRuleData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // LocalRules_ListByLocalRulestacks_MinimumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_LocalRulesListByLocalRulestacksMinimumSetGen()
        {
            // Generated from example definition: specification/paloaltonetworks/resource-manager/PaloAltoNetworks.Cloudngfw/stable/2023-09-01/examples/LocalRules_ListByLocalRulestacks_MinimumSet_Gen.json
            // this example is just showing the usage of "LocalRules_ListByLocalRulestacks" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this LocalRulestackResource created on azure
            // for more information of creating LocalRulestackResource, please refer to the document of LocalRulestackResource
            string subscriptionId = "2bf4a339-294d-4c25-b0b2-ef649e9f5c27";
            string resourceGroupName = "firewall-rg";
            string localRulestackName = "lrs1";
            ResourceIdentifier localRulestackResourceId = LocalRulestackResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, localRulestackName);
            LocalRulestackResource localRulestack = client.GetLocalRulestackResource(localRulestackResourceId);

            // get the collection of this LocalRulestackRuleResource
            LocalRulestackRuleCollection collection = localRulestack.GetLocalRulestackRules();

            // invoke the operation and iterate over the result
            await foreach (LocalRulestackRuleResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                LocalRulestackRuleData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // LocalRules_Get_MaximumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_LocalRulesGetMaximumSetGen()
        {
            // Generated from example definition: specification/paloaltonetworks/resource-manager/PaloAltoNetworks.Cloudngfw/stable/2023-09-01/examples/LocalRules_Get_MaximumSet_Gen.json
            // this example is just showing the usage of "LocalRules_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this LocalRulestackResource created on azure
            // for more information of creating LocalRulestackResource, please refer to the document of LocalRulestackResource
            string subscriptionId = "2bf4a339-294d-4c25-b0b2-ef649e9f5c27";
            string resourceGroupName = "firewall-rg";
            string localRulestackName = "lrs1";
            ResourceIdentifier localRulestackResourceId = LocalRulestackResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, localRulestackName);
            LocalRulestackResource localRulestack = client.GetLocalRulestackResource(localRulestackResourceId);

            // get the collection of this LocalRulestackRuleResource
            LocalRulestackRuleCollection collection = localRulestack.GetLocalRulestackRules();

            // invoke the operation
            string priority = "1";
            LocalRulestackRuleResource result = await collection.GetAsync(priority);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            LocalRulestackRuleData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // LocalRules_Get_MaximumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_LocalRulesGetMaximumSetGen()
        {
            // Generated from example definition: specification/paloaltonetworks/resource-manager/PaloAltoNetworks.Cloudngfw/stable/2023-09-01/examples/LocalRules_Get_MaximumSet_Gen.json
            // this example is just showing the usage of "LocalRules_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this LocalRulestackResource created on azure
            // for more information of creating LocalRulestackResource, please refer to the document of LocalRulestackResource
            string subscriptionId = "2bf4a339-294d-4c25-b0b2-ef649e9f5c27";
            string resourceGroupName = "firewall-rg";
            string localRulestackName = "lrs1";
            ResourceIdentifier localRulestackResourceId = LocalRulestackResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, localRulestackName);
            LocalRulestackResource localRulestack = client.GetLocalRulestackResource(localRulestackResourceId);

            // get the collection of this LocalRulestackRuleResource
            LocalRulestackRuleCollection collection = localRulestack.GetLocalRulestackRules();

            // invoke the operation
            string priority = "1";
            bool result = await collection.ExistsAsync(priority);

            Console.WriteLine($"Succeeded: {result}");
        }

        // LocalRules_Get_MaximumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_LocalRulesGetMaximumSetGen()
        {
            // Generated from example definition: specification/paloaltonetworks/resource-manager/PaloAltoNetworks.Cloudngfw/stable/2023-09-01/examples/LocalRules_Get_MaximumSet_Gen.json
            // this example is just showing the usage of "LocalRules_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this LocalRulestackResource created on azure
            // for more information of creating LocalRulestackResource, please refer to the document of LocalRulestackResource
            string subscriptionId = "2bf4a339-294d-4c25-b0b2-ef649e9f5c27";
            string resourceGroupName = "firewall-rg";
            string localRulestackName = "lrs1";
            ResourceIdentifier localRulestackResourceId = LocalRulestackResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, localRulestackName);
            LocalRulestackResource localRulestack = client.GetLocalRulestackResource(localRulestackResourceId);

            // get the collection of this LocalRulestackRuleResource
            LocalRulestackRuleCollection collection = localRulestack.GetLocalRulestackRules();

            // invoke the operation
            string priority = "1";
            NullableResponse<LocalRulestackRuleResource> response = await collection.GetIfExistsAsync(priority);
            LocalRulestackRuleResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                LocalRulestackRuleData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // LocalRules_Get_MinimumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_LocalRulesGetMinimumSetGen()
        {
            // Generated from example definition: specification/paloaltonetworks/resource-manager/PaloAltoNetworks.Cloudngfw/stable/2023-09-01/examples/LocalRules_Get_MinimumSet_Gen.json
            // this example is just showing the usage of "LocalRules_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this LocalRulestackResource created on azure
            // for more information of creating LocalRulestackResource, please refer to the document of LocalRulestackResource
            string subscriptionId = "2bf4a339-294d-4c25-b0b2-ef649e9f5c27";
            string resourceGroupName = "firewall-rg";
            string localRulestackName = "lrs1";
            ResourceIdentifier localRulestackResourceId = LocalRulestackResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, localRulestackName);
            LocalRulestackResource localRulestack = client.GetLocalRulestackResource(localRulestackResourceId);

            // get the collection of this LocalRulestackRuleResource
            LocalRulestackRuleCollection collection = localRulestack.GetLocalRulestackRules();

            // invoke the operation
            string priority = "1";
            LocalRulestackRuleResource result = await collection.GetAsync(priority);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            LocalRulestackRuleData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // LocalRules_Get_MinimumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_LocalRulesGetMinimumSetGen()
        {
            // Generated from example definition: specification/paloaltonetworks/resource-manager/PaloAltoNetworks.Cloudngfw/stable/2023-09-01/examples/LocalRules_Get_MinimumSet_Gen.json
            // this example is just showing the usage of "LocalRules_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this LocalRulestackResource created on azure
            // for more information of creating LocalRulestackResource, please refer to the document of LocalRulestackResource
            string subscriptionId = "2bf4a339-294d-4c25-b0b2-ef649e9f5c27";
            string resourceGroupName = "firewall-rg";
            string localRulestackName = "lrs1";
            ResourceIdentifier localRulestackResourceId = LocalRulestackResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, localRulestackName);
            LocalRulestackResource localRulestack = client.GetLocalRulestackResource(localRulestackResourceId);

            // get the collection of this LocalRulestackRuleResource
            LocalRulestackRuleCollection collection = localRulestack.GetLocalRulestackRules();

            // invoke the operation
            string priority = "1";
            bool result = await collection.ExistsAsync(priority);

            Console.WriteLine($"Succeeded: {result}");
        }

        // LocalRules_Get_MinimumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_LocalRulesGetMinimumSetGen()
        {
            // Generated from example definition: specification/paloaltonetworks/resource-manager/PaloAltoNetworks.Cloudngfw/stable/2023-09-01/examples/LocalRules_Get_MinimumSet_Gen.json
            // this example is just showing the usage of "LocalRules_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this LocalRulestackResource created on azure
            // for more information of creating LocalRulestackResource, please refer to the document of LocalRulestackResource
            string subscriptionId = "2bf4a339-294d-4c25-b0b2-ef649e9f5c27";
            string resourceGroupName = "firewall-rg";
            string localRulestackName = "lrs1";
            ResourceIdentifier localRulestackResourceId = LocalRulestackResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, localRulestackName);
            LocalRulestackResource localRulestack = client.GetLocalRulestackResource(localRulestackResourceId);

            // get the collection of this LocalRulestackRuleResource
            LocalRulestackRuleCollection collection = localRulestack.GetLocalRulestackRules();

            // invoke the operation
            string priority = "1";
            NullableResponse<LocalRulestackRuleResource> response = await collection.GetIfExistsAsync(priority);
            LocalRulestackRuleResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                LocalRulestackRuleData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // LocalRules_CreateOrUpdate_MaximumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_LocalRulesCreateOrUpdateMaximumSetGen()
        {
            // Generated from example definition: specification/paloaltonetworks/resource-manager/PaloAltoNetworks.Cloudngfw/stable/2023-09-01/examples/LocalRules_CreateOrUpdate_MaximumSet_Gen.json
            // this example is just showing the usage of "LocalRules_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this LocalRulestackResource created on azure
            // for more information of creating LocalRulestackResource, please refer to the document of LocalRulestackResource
            string subscriptionId = "2bf4a339-294d-4c25-b0b2-ef649e9f5c27";
            string resourceGroupName = "firewall-rg";
            string localRulestackName = "lrs1";
            ResourceIdentifier localRulestackResourceId = LocalRulestackResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, localRulestackName);
            LocalRulestackResource localRulestack = client.GetLocalRulestackResource(localRulestackResourceId);

            // get the collection of this LocalRulestackRuleResource
            LocalRulestackRuleCollection collection = localRulestack.GetLocalRulestackRules();

            // invoke the operation
            string priority = "1";
            LocalRulestackRuleData data = new LocalRulestackRuleData("localRule1")
            {
                ETag = new ETag("c18e6eef-ba3e-49ee-8a85-2b36c863a9d0"),
                Description = "description of local rule",
                RuleState = RulestackStateType.Disabled,
                Source = new SourceAddressInfo()
                {
                    Cidrs =
{
"1.0.0.1/10"
},
                    Countries =
{
"India"
},
                    Feeds =
{
"feed"
},
                    PrefixLists =
{
"PL1"
},
                },
                NegateSource = FirewallBooleanType.True,
                Destination = new DestinationAddressInfo()
                {
                    Cidrs =
{
"1.0.0.1/10"
},
                    Countries =
{
"India"
},
                    Feeds =
{
"feed"
},
                    PrefixLists =
{
"PL1"
},
                    FqdnLists =
{
"FQDN1"
},
                },
                NegateDestination = FirewallBooleanType.True,
                Applications =
{
"app1"
},
                Category = new EdlMatchCategory(new string[]
            {
"https://microsoft.com"
            }, new string[]
            {
"feed"
            }),
                Protocol = "HTTP",
                ProtocolPortList =
{
"80"
},
                InboundInspectionCertificate = "cert1",
                AuditComment = "example comment",
                ActionType = RulestackActionType.Allow,
                EnableLogging = RulestackStateType.Disabled,
                DecryptionRuleType = DecryptionRuleType.SslOutboundInspection,
                Tags =
{
new RulestackTagInfo("keyName","value")
},
            };
            ArmOperation<LocalRulestackRuleResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, priority, data);
            LocalRulestackRuleResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            LocalRulestackRuleData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // LocalRules_CreateOrUpdate_MinimumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_LocalRulesCreateOrUpdateMinimumSetGen()
        {
            // Generated from example definition: specification/paloaltonetworks/resource-manager/PaloAltoNetworks.Cloudngfw/stable/2023-09-01/examples/LocalRules_CreateOrUpdate_MinimumSet_Gen.json
            // this example is just showing the usage of "LocalRules_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this LocalRulestackResource created on azure
            // for more information of creating LocalRulestackResource, please refer to the document of LocalRulestackResource
            string subscriptionId = "2bf4a339-294d-4c25-b0b2-ef649e9f5c27";
            string resourceGroupName = "firewall-rg";
            string localRulestackName = "lrs1";
            ResourceIdentifier localRulestackResourceId = LocalRulestackResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, localRulestackName);
            LocalRulestackResource localRulestack = client.GetLocalRulestackResource(localRulestackResourceId);

            // get the collection of this LocalRulestackRuleResource
            LocalRulestackRuleCollection collection = localRulestack.GetLocalRulestackRules();

            // invoke the operation
            string priority = "1";
            LocalRulestackRuleData data = new LocalRulestackRuleData("localRule1");
            ArmOperation<LocalRulestackRuleResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, priority, data);
            LocalRulestackRuleResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            LocalRulestackRuleData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
