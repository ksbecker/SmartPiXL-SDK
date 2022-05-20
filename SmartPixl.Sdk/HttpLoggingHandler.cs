using Microsoft.AspNetCore.WebUtilities;

namespace SmartPixl.Sdk;

public class HttpLoggingHandler : DelegatingHandler
{
    protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
    {
        if (request.Headers.Contains("UserTokenId"))
        {
            var apiKey = request.Headers.First(h => h.Key == "UserTokenId").Value.First()!;
            request.Headers.Remove("UserTokenId");

            var newQueryString = QueryHelpers.AddQueryString(request.RequestUri!.Query, "UserTokenId", apiKey);
            request.RequestUri = new Uri(request.RequestUri.Scheme + "://" + request.RequestUri.Host + request.RequestUri.AbsolutePath + newQueryString);
        }

        var response = await base.SendAsync(request, cancellationToken).ConfigureAwait(false);

        return response;
    }
}
