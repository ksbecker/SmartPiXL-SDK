using Microsoft.Extensions.DependencyInjection;

using Refit;

namespace SmartPixl.Sdk;

public static class ServiceCollectionExtensions
{
    public static IHttpClientBuilder AddSmartPixlApiClient(this IServiceCollection services, Action<HttpClient> configureClient)
    {
        var settings = new RefitSettings(new XmlContentSerializer());

        return services.AddRefitClient<ISmartPixlApiClient>(settings)
            .ConfigureHttpClient((httpClient) =>
            {
                SmartPixlClientFactory.ConfigureHttpClientCore(httpClient);
                configureClient(httpClient);
            });
    }
}
