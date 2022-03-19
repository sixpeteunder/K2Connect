namespace K2Connect.Services;

/// <summary>
/// K2 Polling Service.
/// </summary>
public class PollingService : Service
{
    /// <summary>
    /// Initializes a new instance of the <see cref="PollingService"/> class.
    /// </summary>
    /// <param name="options">K2 Options.</param>
    public PollingService(K2Options options)
        : base(options)
    {
    }
}
