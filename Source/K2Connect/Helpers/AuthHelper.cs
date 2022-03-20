namespace K2Connect.Helpers;

using System.Net;
using System.Security.Cryptography;
using System.Text;

/// <summary>
/// This is used to authenticate results and webhooks from Kopo Kopo.
/// </summary>
public class AuthHelper
{
    /// <summary>
    /// This is used to authenticate results and webhooks from Kopo Kopo.
    /// </summary>
    /// <param name="payload">Payload.</param>
    /// <param name="signature">Signature.</param>
    /// <param name="apiKey">API Key.</param>
    /// <returns>result.</returns>
    public static HttpStatusCode Auth(string payload, string signature, string apiKey)
    {
        using var hmac = new HMACSHA256(Encoding.UTF8.GetBytes(apiKey));
        var expectedSignature = hmac.ComputeHash(Encoding.UTF8.GetBytes(payload));
        var signatureBytes = Encoding.UTF8.GetBytes(signature);
        return CryptographicOperations.FixedTimeEquals(expectedSignature, signatureBytes) ? HttpStatusCode.OK : HttpStatusCode.Unauthorized;
    }
}
