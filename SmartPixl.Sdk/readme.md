SmartPiXL SDK
=============
This package is a C# implementation
for the [SmartPiXL REST API](https://docs.google.com/document/d/1fF0kjXp3vos9z2YoAaqzzXMXnJKHIutRTmOV3dQ2zjE/view).

The API doesn't use a request header so in the `HttpLoggingHandler` 
I move it from the header into the URL so that each request doesn't
need for it to be appended. The same could be done for the `companyId`.
Maybe something for version 2.0.x. It also does not work with Query as
of yet. I haven't needed it, so I don't care.

### Register during startup
```
builder.Services.AddSmartPixlApiClient(httpClient =>
{
    httpClient.BaseAddress = new Uri("https://smartpixl.net/API2.0");
    httpClient.DefaultRequestHeaders.Add("UserTokenId", "{your user token here}");
})
.AddHttpMessageHandler<HttpLoggingHandler>();
```

### Usage

```
private readonly ISmartPixlApiClient _smartPixlApiClient;

SmartPiXLAPIModel[] data = await _smartPixlApiClient
    .GetSmartPixl(
        companyId: 1234567890, 
        pixlId: pixl.PixlId, 
        startDate: monthDate.ToString("yyyy-MM-dd"), 
        endDate: monthDate.AddMonths(1).ToString("yyyy-MM-dd"), 
        cancellationToken: cancellationToken); // cancellationToken is optional
```
The date is a date/time stamp up to the minute.