<!-- Code generated for API Clients. DO NOT EDIT. -->

# ngrok API client library for .NET

This library wraps the [ngrok HTTP API](https://ngrok.com/docs/api) to make it
easier to consume in C# and .NET.

## Installation

This library is published on [nuget](https://www.nuget.org/packages/NgrokApi/)

    dotnet add package NgrokApi --version <version>

## Support

The best place to get support using this library is through the [ngrok Slack Community](https://ngrok.com/slack). If you find any bugs, please contribute by opening a [new GitHub issue](https://github.com/ngrok/ngrok-api-dotnet/issues/new/choose).

## Documentation

All objects, methods and properties are documented with the .NET documentation
markup tags for integration with an IDE like Visual Studio or Visual Studio
Code.

Beyond that, this readme is the best source of documentation for the library.
There is no API reference documentation published on the web at this time.

### Versioning

This class library is published to Nuget using semantic versioning. Breaking
changes to the API will only be release with a bump of the major version number.
Each released commit is tagged in this repository.

No compatibility promises are made for versions < 1.0.0.

### Quickstart

### Create an IP Policy that allows traffic from some subnets

```csharp
using NgrokApi;

public class Example
{
    public static async Task Main()
    {
        var ngrok = new Ngrok(Environment.GetEnvironmentVariable("NGROK_API_KEY"));
        var policy = await ngrok.IpPolicies.Create(new IpPolicyCreate());

        foreach (var cidr in new string[] { "24.0.0.0/8", "12.0.0.0/8" })
        {
            await ngrok.IpPolicyRules.Create(new IpPolicyRuleCreate
            {
                Cidr = cidr,
                IpPolicyId = policy.Id,
                Action = "allow",
            });
        }
    }
}
```

### List all online tunnels

```csharp
using NgrokApi;

public class Example
{
    public static async Task Main()
    {
        var ngrok = new Ngrok(Environment.GetEnvironmentVariable("NGROK_API_KEY"));
        await foreach (var t in ngrok.Tunnels.List())
        {
            Console.Out.WriteLine(t.ToString());
        }
    }
}
```

### Conventions

Conventional usage of this package is to construct the root `Ngrok` API client
object with an API key and then to access API resources as properties of that
object. Do not construct the individual API resource Client classes in your
application code.

```csharp
// create the root api client
var ngrok = new Ngrok(apiKey);

// clients for all api resources (like ip policies) are acccessible as properties of the root client
var policy = await ngrok.IpPolicies.Get(policyId);

// some api resources are 'namespaced' through another property
var compression = await ngrok.EdgeModules.HttpsEdgeRouteCompression.Get(edgeRouteItem);
```

### Automatic Paging

All list responses from the ngrok API are paged. This library provides an
abstraction to make it easier to consume theses paged list resources. Instead
of returning the page of results, all `List()` methods instead return an
`IAsyncEnumerable` that can be iterated over with a `foreach` loop. The iterator
will automatically fetch new pages of results from the API as needed.

```csharp
using NgrokApi;

public class Example
{
    public static async Task Main()
    {
        var ngrok = new Ngrok(Environment.GetEnvironmentVariable("NGROK_API_KEY"));
        await foreach (var t in ngrok.Tunnels.List())
        {
            Console.Out.WriteLine(t.ToString());
        }
    }
}
```

### Error Handling

All errors returned by the ngrok API are serialized as structured payloads for
easy error handling.  If a structured error is returned by the ngrok API, this
library will throw an `NgrokException`.

To handle a structured error from the API, catch the `NgrokException` type in
your code. This object will allow you to check the unique ngrok error code and
the http status code of a failed response. Use the `ErrorCode` property to
check for unique ngrok error codes returned by the API. All error codes are
documented at https://ngrok.com/docs/errors. There is also an `IsErrorCode()`
method on the exception object to check against multiple error codes. The
`HttpStatusCode` property can be used to check not found errors.

Other non-structured errors encountered while making an API call from e.g. networking
or serialization failures are not wrapped in any way and will bubble up as normal.

```csharp
using NgrokApi;

public class Example
{
    public static async Task Main()
    {
        try
        {
            var ngrok = new Ngrok(Environment.GetEnvironmentVariable("NGROK_API_KEY"));
            var domain = await ngrok.ReservedDomains.Create(new ReservedDomainCreate()
            {
                Name = "foo.*.bar.ngrok.io",
                Description = "example domain",
            });
        }
        catch (NgrokException e)
        {
            if (e.IsErrorCode("ERR_NGROK_402", "ERR_NGROK_403"))
            {
                Console.Out.WriteLine("Ignoring invalid wildcard domain.");
            }
            else
            {
                throw;
            }
        }
    }
}
```


### Datatype Overrides

All datatype objects in the NgrokApi library property override `Equal()` and `GetHashCode()`
so that the objects can be compared. Similarly, they override `ToString()` for more helpful
pretty printing of ngrok domain objects.

### Sync / Async Interfaces

All library interfaces are async. Another version of the library will follow up
with separate side-by-side synchronous interfaces before reaching 1.0.0.
