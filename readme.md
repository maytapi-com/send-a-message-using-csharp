# Send a Message Using C# with Maytapi WhatsApp API

This repository demonstrates how to send a WhatsApp message using C# and the Maytapi WhatsApp API. Maytapi provides a powerful and easy-to-use API for integrating WhatsApp messaging into your applications.

## Features

- Send text messages to WhatsApp numbers
- Easy integration with Maytapi WhatsApp API
- Configurable settings for API credentials

## Requirements

- .NET 5.0 or higher
- Newtonsoft.Json NuGet package
- Maytapi account and API credentials


## Installation
1. Clone this repository
```bash
https://github.com/maytapi-com/send-a-message-with-csharp-using-whatsapp-api.git
cd projecgt-folder
```
2. Configure your Maytapi credentials in appsettings.json:
```json
{
  "MaytapiSettings": {
  "ProductId": "your_product_id",
  "PhoneId": "your_phone_id",
  "ApiKey": "your_api_key"
  }
}
```
3. Install required NuGet packages
```powershell
dotnet add package Newtonsoft.Json
dotnet add package Microsoft.Extensions.Configuration.Json
```

## Usage
To send a test message, run:
```csharp
dotnet run
```
This will execute the Program.cs file, which contains the main logic for sending a WhatsApp message using the Maytapi API. The program reads configuration from appsettings.json, constructs the API request, and sends the message.

> [!NOTE]
> **To perform all these operations correctly, you need to register with maytapi.com, get the credentials, and place them in the config file.**


## Quick Start

1. Clone this repository
2. Configure your Maytapi credentials in `appsettings.json`
3. Build the project
4. Run the program to send a test message

## Why Maytapi?

[Maytapi](https://maytapi.com) offers a robust WhatsApp API solution with features like:

- Multi-device support
- Affordable pricing
- Easy integration
- Comprehensive documentation

Learn more about Maytapi's [WhatsApp API](https://maytapi.com) and how it can benefit your projects.

## Contributing

Contributions are welcome! Please feel free to submit a Pull Request.

## Support

For questions about Maytapi's WhatsApp API, visit their [official documentation](https://maytapi.com/whatsapp-api-documentation) or contact their support team.
