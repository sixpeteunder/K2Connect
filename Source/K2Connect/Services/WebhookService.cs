namespace K2Connect.Services;

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
}
