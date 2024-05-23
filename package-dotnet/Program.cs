using System;
using System.Threading.Tasks;
using Azure;
using Azure.Identity;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.Resources.Models;

class Program
{
    static async Task Main(string[] args)
    {
        // Define your Azure subscription ID
        //string subscriptionId = "4ea324a6-6d16-4156-98a8-3485ecaf0a1e";

        // Define the resource group and storage account names
        string resourceGroupName = "my-sdk-rg";
        string location = "westus";

        // Authenticate
        var credential = new DefaultAzureCredential();
        var client = new ArmClient(credential);

        // Get the subscription object
        SubscriptionResource subscription = await client.GetDefaultSubscriptionAsync();
        /*  SubscriptionResource subscription = await client.GetSubscriptionAsync(); */
        /* resourceGroupCollection resourceGroup = subscription.GetResourceGroups();  */
        ResourceGroupCollection resourceGroups = subscription.GetResourceGroups();

        // Create a resource group
        ResourceGroupData resourceGroupData = new ResourceGroupData(location);

        /* resourceGroupData resourceGroupData = new ResourceGroupData(location); */
        ArmOperation<ResourceGroupResource> operation = await resourceGroups.CreateOrUpdateAsync(WaitUntil.Completed, resourceGroupName, resourceGroupData);
        /* ResourceGroupResource resourceGroup = operation.Value; */
    }
}