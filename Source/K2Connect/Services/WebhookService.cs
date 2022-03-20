namespace K2Connect.Services;

using System.Diagnostics.CodeAnalysis;
using System.Net;
using System.Security.Authentication;
using System.Text.Json;
using Flurl.Http;
using K2Connect.Helpers;
using K2Connect.Requests;

/// <summary>
/// K2 Webhook Service.
/// </summary>
public class WebhookService : Service
{
    /// <summary>
    /// Initializes a new instance of the <see cref="WebhookService"/> class.
    /// </summary>
    /// <param name="options">K2 Options.</param>
    public WebhookService(K2Options options)
        : base(options)
    {
    }

    /// <summary>
    ///     Webhook handler.
    /// </summary>
    /// <param name="payload">Payload.</param>
    /// <param name="signature">Signature.</param>
    /// <typeparam name="T">Return type.</typeparam>
    /// <returns>Processed payload.</returns>
    [UnconditionalSuppressMessage(
        "Trimming",
        "IL2026:Members annotated with 'RequiresUnreferencedCodeAttribute' require dynamic access otherwise can break functionality when trimming application code",
        Justification = "<Pending>")]
    public T WebHookHandler<T>(T payload, string signature)
    {
        // TODO: Figure out trimming
        var statusCode = AuthHelper.Auth(JsonSerializer.Serialize(payload), signature, this.Options.ApiKey);
        if (statusCode is not HttpStatusCode.OK)
        {
            throw new AuthenticationException($"{statusCode}: Webhook not authenticated.");
        }

        return payload;
    }

    /// <summary>
    /// Handles the webhook subscribe operations.
    /// </summary>
    /// <param name="request">The <see cref="WebhookSubscribeRequest"/> sent as the request body.</param>
    /// <returns>A <see cref="Task{TResult}"/> location url of the resource.</returns>
    public async Task<string> SubscribeAsync(WebhookSubscribeRequest request)
    {
        var response = await this.Options.BaseUrl.PostJsonAsync(request).ConfigureAwait(false);
        return response.Headers.FirstOrDefault("location");
    }
}
