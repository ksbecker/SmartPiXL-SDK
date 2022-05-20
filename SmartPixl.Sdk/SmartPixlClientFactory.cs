using System.Net.Http.Headers;

namespace SmartPixl.Sdk;

internal static class SmartPixlClientFactory
{
    internal static void ConfigureHttpClientCore(HttpClient httpClient)
    {
        httpClient.DefaultRequestHeaders.Accept.Clear();
        httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
    }
}