namespace Application.Extension;

public static class IHttpClientFactory_Extension
{
    public static readonly string BypassClientName = "BypassClient";
    public static HttpClient GetHttpClient(this IHttpClientFactory clientFactory, bool isBypassCert = false)
            => isBypassCert
                ? clientFactory.CreateClient(BypassClientName)
                : clientFactory.CreateClient();
}
