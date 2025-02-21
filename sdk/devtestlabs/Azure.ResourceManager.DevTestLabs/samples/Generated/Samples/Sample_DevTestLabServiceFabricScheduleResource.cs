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
using Azure.ResourceManager.DevTestLabs;
using Azure.ResourceManager.DevTestLabs.Models;

namespace Azure.ResourceManager.DevTestLabs.Samples
{
    public partial class Sample_DevTestLabServiceFabricScheduleResource
    {
        // ServiceFabricSchedules_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_ServiceFabricSchedulesGet()
        {
            // Generated from example definition: specification/devtestlabs/resource-manager/Microsoft.DevTestLab/stable/2018-09-15/examples/ServiceFabricSchedules_Get.json
            // this example is just showing the usage of "ServiceFabricSchedules_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DevTestLabServiceFabricScheduleResource created on azure
            // for more information of creating DevTestLabServiceFabricScheduleResource, please refer to the document of DevTestLabServiceFabricScheduleResource
            string subscriptionId = "{subscriptionId}";
            string resourceGroupName = "resourceGroupName";
            string labName = "{labName}";
            string userName = "@me";
            string serviceFabricName = "{serviceFrabicName}";
            string name = "{scheduleName}";
            ResourceIdentifier devTestLabServiceFabricScheduleResourceId = DevTestLabServiceFabricScheduleResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, labName, userName, serviceFabricName, name);
            DevTestLabServiceFabricScheduleResource devTestLabServiceFabricSchedule = client.GetDevTestLabServiceFabricScheduleResource(devTestLabServiceFabricScheduleResourceId);

            // invoke the operation
            DevTestLabServiceFabricScheduleResource result = await devTestLabServiceFabricSchedule.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DevTestLabScheduleData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // ServiceFabricSchedules_Delete
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_ServiceFabricSchedulesDelete()
        {
            // Generated from example definition: specification/devtestlabs/resource-manager/Microsoft.DevTestLab/stable/2018-09-15/examples/ServiceFabricSchedules_Delete.json
            // this example is just showing the usage of "ServiceFabricSchedules_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DevTestLabServiceFabricScheduleResource created on azure
            // for more information of creating DevTestLabServiceFabricScheduleResource, please refer to the document of DevTestLabServiceFabricScheduleResource
            string subscriptionId = "{subscriptionId}";
            string resourceGroupName = "resourceGroupName";
            string labName = "{labName}";
            string userName = "@me";
            string serviceFabricName = "{serviceFrabicName}";
            string name = "{scheduleName}";
            ResourceIdentifier devTestLabServiceFabricScheduleResourceId = DevTestLabServiceFabricScheduleResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, labName, userName, serviceFabricName, name);
            DevTestLabServiceFabricScheduleResource devTestLabServiceFabricSchedule = client.GetDevTestLabServiceFabricScheduleResource(devTestLabServiceFabricScheduleResourceId);

            // invoke the operation
            await devTestLabServiceFabricSchedule.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // ServiceFabricSchedules_Update
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_ServiceFabricSchedulesUpdate()
        {
            // Generated from example definition: specification/devtestlabs/resource-manager/Microsoft.DevTestLab/stable/2018-09-15/examples/ServiceFabricSchedules_Update.json
            // this example is just showing the usage of "ServiceFabricSchedules_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DevTestLabServiceFabricScheduleResource created on azure
            // for more information of creating DevTestLabServiceFabricScheduleResource, please refer to the document of DevTestLabServiceFabricScheduleResource
            string subscriptionId = "{subscriptionId}";
            string resourceGroupName = "resourceGroupName";
            string labName = "{labName}";
            string userName = "@me";
            string serviceFabricName = "{serviceFrabicName}";
            string name = "{scheduleName}";
            ResourceIdentifier devTestLabServiceFabricScheduleResourceId = DevTestLabServiceFabricScheduleResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, labName, userName, serviceFabricName, name);
            DevTestLabServiceFabricScheduleResource devTestLabServiceFabricSchedule = client.GetDevTestLabServiceFabricScheduleResource(devTestLabServiceFabricScheduleResourceId);

            // invoke the operation
            DevTestLabSchedulePatch patch = new DevTestLabSchedulePatch()
            {
                Tags =
{
["tagName1"] = "tagValue1",
},
            };
            DevTestLabServiceFabricScheduleResource result = await devTestLabServiceFabricSchedule.UpdateAsync(patch);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DevTestLabScheduleData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // ServiceFabricSchedules_Execute
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Execute_ServiceFabricSchedulesExecute()
        {
            // Generated from example definition: specification/devtestlabs/resource-manager/Microsoft.DevTestLab/stable/2018-09-15/examples/ServiceFabricSchedules_Execute.json
            // this example is just showing the usage of "ServiceFabricSchedules_Execute" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DevTestLabServiceFabricScheduleResource created on azure
            // for more information of creating DevTestLabServiceFabricScheduleResource, please refer to the document of DevTestLabServiceFabricScheduleResource
            string subscriptionId = "{subscriptionId}";
            string resourceGroupName = "resourceGroupName";
            string labName = "{labName}";
            string userName = "@me";
            string serviceFabricName = "{serviceFrabicName}";
            string name = "{scheduleName}";
            ResourceIdentifier devTestLabServiceFabricScheduleResourceId = DevTestLabServiceFabricScheduleResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, labName, userName, serviceFabricName, name);
            DevTestLabServiceFabricScheduleResource devTestLabServiceFabricSchedule = client.GetDevTestLabServiceFabricScheduleResource(devTestLabServiceFabricScheduleResourceId);

            // invoke the operation
            await devTestLabServiceFabricSchedule.ExecuteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }
    }
}
