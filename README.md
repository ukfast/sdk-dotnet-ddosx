# sdk-dotnet-ddosx

This is the official .NET SDK for UKFast DDoSX

You should refer to the [Getting Started](https://developers.ukfast.io/getting-started) section of the API documentation before proceeding below

## Basic usage

To get started, we'll first instantiate an instance of `IUKFastDDoSXClient`:

```csharp
IUKFastDDoSXClient client = new UKFastDDoSXClient(new ClientConnection("myapikey"));
```

Next, we'll obtain an instance of IDomainOperations to perform operations on DDoSX Domains:

```csharp
var domainOps = client.DomainOperations();
```

Finally, we'll retrieve all DDoSX domains using the instance of `IDomainOperations`:

```csharp
IList<Domain> domains = await domainOps.GetDomainsAsync();
```

## Operations

All operations available via the SDK are exposed via the client (`IUKFastDDoSXClient`)
