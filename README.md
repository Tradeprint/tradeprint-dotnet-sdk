# Tradeprint .NET SDK

[![CircleCI](https://circleci.com/gh/Tradeprint/tradeprint-dotnet-sdk.svg?style=svg)](https://circleci.com/gh/Tradeprint/tradeprint-dotnet-sdk)

## Introduction

Microsoft .NET SDK allows you to easily add your print on demand functionality to your app or website within minutes!
Print Postcards, Business Cards, Posters, Stickers on a roll, T-Shirts, etc.
Our .NET SDK industry standardised documentation and instructions are easy to follow and would take a software engineer no longer than a few days to complete the full integration.

Microsoft .NET Core empowers organisations to create quick, robust network applications that can tackle parallel connections with increased throughput.
Our Sandbox print API environment allows you to interact with the API endpoints through the .NET SDK.

As the API is created by our in-house team, we provide support to ensure it is set up and running smoothly.
Once up and running, we do not anticipate a need for further maintenance from our side. However, we do expect some work to maintain your product catalogue.
This work includes adding, removing and editing products and can completed manually by your team, or parts can be automated.

Tradeprint API Documentation: https://docs.sandbox.tradeprint.io.

## Requirements

* Microsoft .NET Core 2.2 (https://dotnet.microsoft.com/download)
* Microsoft Visual Studio (https://visualstudio.microsoft.com/)

## Installation

Within your Visual Studio project you can install a new NuGet package (https://www.nuget.org/packages/TradeprintSdk).

Using the DotNet CLI:
```sh
dotnet add package TradeprintSdk
```
or via PowerShell:
```sh
Install-Package TradeprintSdk
```

## API Credentials

You need a set of valid *Sandbox* or *Production* credentials to access the Tradeprint Ordering and Products services.

Please get in touch at api(at)tradeprint.io or through our main https://www.tradeprint.co.uk/tradeprint-api website to be provided with a username and a password.

When you have a set of credentials then you can specify them in your code, e.g.:
```
var sdk = SDK.GetInstance();
sdk.SetEnvironment(EnvironmentName.Sandbox);
sdk.SetCredentials("YOUR_API_USERNAME", "YOUR_API_PASSWORD");
```

**IMPORTANT** 

A solution configured with valid Production credentials and pointing at the Production environment will be communicating with live Tradeprint ordering system!

## Usage

For read the [Samples README](Samples/README.md) for usage details.
