SmartPiXL SDK
=============
This package is a C# implementation
for the SmartPiXL REST API.

The API doesn't use a request header so in the `HttpLogginHandler` 
I move it from the header into the URL so that each request doesn't
need for it to be appended.

```
builder.Services.AddSmartPixlApiClient(httpClient =>
{
    httpClient.BaseAddress = new Uri("https://smartpixl.net/API2.0");
    httpClient.DefaultRequestHeaders.Add("UserTokenId", "");
})
.AddHttpMessageHandler<HttpLoggingHandler>();
```