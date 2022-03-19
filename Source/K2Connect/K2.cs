namespace K2Connect;

using K2Connect.Services;

/// <summary>
/// This is the entry point for the K2Connect package.
/// </summary>
///
public class K2
{
    private const string Version = "v1";
    private readonly K2Options options;

    /// <summary>
    /// Initializes a new instance of the <see cref="K2"/> class.
    /// </summary>
    /// <param name="options">The <see cref="K2Options"/> to use while creating an instance of K2.</param>
    public K2(K2Options options) => this.options = options with { BaseUrl = $"{options.BaseUrl.TrimEnd('/')}/api/{Version}" };

    /// <summary>
    /// Gets an instance of the  <see cref="TokenService"/> class.
    /// </summary>
    public TokenService TokenService => new(this.options);

    /// <summary>
    /// Gets an instance of the <see cref="WebhookService"/> class.
    /// </summary>
    public WebhookService WebhookService => new(this.options);

    /// <summary>
    /// Gets an instance of the <see cref="StkService"/> class.
    /// </summary>
    public StkService StkService => new(this.options);

    /// <summary>
    /// Gets an instance of the <see cref="PayService"/> class.
    /// </summary>
    public PayService PayService => new(this.options);

    /// <summary>
    /// Gets an instance of the <see cref="SettlementTransferService"/> class.
    /// </summary>
    public SettlementTransferService SettlementTransferService => new(this.options);

    /// <summary>
    /// Gets an instance of the <see cref="PollingService"/> class.
    /// </summary>
    public PollingService PollingService => new(this.options);

    /// <summary>
    /// Gets an instance of the <see cref="SmsNotificationService"/> class.
    /// </summary>
    public SmsNotificationService SmsNotificationService => new(this.options);
}
