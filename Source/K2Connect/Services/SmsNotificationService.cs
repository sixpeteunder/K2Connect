namespace K2Connect.Services;

/// <summary>
/// K2 Sms Notification Service.
/// </summary>
public class SmsNotificationService : Service
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SmsNotificationService"/> class.
    /// </summary>
    /// <param name="options">K2 Options.</param>
    public SmsNotificationService(K2Options options)
        : base(options)
    {
    }
}
