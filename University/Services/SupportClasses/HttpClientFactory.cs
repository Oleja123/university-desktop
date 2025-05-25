using System.Net.Http;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;

public static class HttpClientFactory
{
    public static HttpClient CreateUnsafeClient()
    {
        var handler = new HttpClientHandler
        {
            ServerCertificateCustomValidationCallback = IgnoreCertificateValidation
        };

        return new HttpClient(handler);
    }

    private static bool IgnoreCertificateValidation(HttpRequestMessage request, X509Certificate2 cert, X509Chain chain, SslPolicyErrors errors)
    {
        return true;
    }
}