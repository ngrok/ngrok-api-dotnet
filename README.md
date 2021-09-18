# ngrok API client library for .NET

This library wraps the [ngrok HTTP API](https://ngrok.com/docs/api) to make it
easier to consume in C# and .NET.

## Installation

This library is published on [nuget](https://www.nuget.org/packages/NgrokApi/)

    dotnet add package NgrokApi --version 0.2.0

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
        public static void Main()
        {
                var ngrok = new Ngrok(Environment.GetEnvironmentVariable("NGROK_API_KEY"));
                var policy = ngrok.IpPolicies.Create(new IpPolicyCreate() {
                        Action = "allow",
                });
                foreach (var cidr in new string[] {"24.0.0.0/8", "12.0.0.0/8"}) {
                        ngrok.IpPolicyRules.Create(ngrok.IpPolicyRuleCreate{
                                Cidr: cdir,
                                IpPolicyId: policy.Id,
                        })
                }
        }
}
```

### List all online tunnels

```csharp
using NgrokApi;
using System;

public class Example
{
        public static void Main()
        {
                var ngrok = new Ngrok(Environment.GetEnvironmentVariable("NGROK_API_KEY"));
                foreach (var c = ngrok.Tunnels.List())
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
var policy = ngrok.IpPolicies.Get(policyId);

// some api resources are 'namespaced' through another property
var circuitBreaker = ngrok.PointcfgModules.CircuitBreaker.Get(endpointConfigId);
```

### Automatic Paging

All list responses from the ngrok API are paged. This library provides an
abstraction to make it easier to consume theses paged list resources. Instead
of returning the page of results, all `List()` methods instead return an
`IEnumerable` that can be iterated over with a `foreach` loop. The iterator
will automatically fetch new pages of results from the API as needed.

```csharp
using NgrokApi;
using System;

public class Example
{
        public static void Main()
        {
                var ngrok = new Ngrok(Environment.GetEnvironmentVariable("NGROK_API_KEY"));
                foreach (var c = ngrok.Credentials.List())
                {
                        Console.Out.WriteLine(c);
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
using System;

public class Example
{
        public static void Main()
        {
                try {
                        var ngrok = new Ngrok(Environment.GetEnvironmentVariable("NGROK_API_KEY"));
                        var domain = ngrok.ReservedDomains.Create(new ReservedDomainUpdate() {
                                Name: Environment.GetEnvironmentVariable("NGROK_DOMAIN"),
                                Description = "example domain",
                        })
                } catch (NgrokException e) {
                        if (e.IsErrorCode("NGROK_ERR_402", "NGROK_ERR_403")) {
                                 Console.Out.WriteLine("Ignoring invalid wildcard domain.");
                        } else {
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
