# Azure Storage Account Creation with C# and .NET

This repository provides a simple example demonstrating how to create a storage account on Azure using C# and .NET Core. By following this guide, you'll be able to quickly set up a storage account programmatically, which can be useful for automating infrastructure provisioning or integrating storage account creation into your applications.

## Prerequisites

Before you begin, ensure you have:

- [.NET SDK](https://dotnet.microsoft.com/download) installed.
- An [Azure account](https://azure.microsoft.com/free/) (if you don't have one).
- Azure CLI installed or access to Azure Cloud Shell.

## Setup

1. **Clone the Repository**:
   ```bash
   git clone https://github.com/yourusername/azure-storage-account-csharp.git
   cd azure-storage-account-csharp
   ```

2. **Install Dependencies**:
   ```bash
   dotnet restore
   ```

3. **Update Configuration**:
   - Open `appsettings.json`.
   - Update with your Azure subscription ID and other details.

## Usage

1. **Run the Application**:
   ```bash
   dotnet run
   ```

2. **Verify**:
   After successful execution, verify the creation of the storage account in the Azure portal or using Azure CLI.


## Useful Resource
- [Microsoft Azure SDK for .NET](https://github.com/Azure/azure-sdk-for-net)
---
