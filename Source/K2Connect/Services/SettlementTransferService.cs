namespace K2Connect.Services;

/// <summary>
/// K2 Settlement Transfer Service.
/// </summary>
public class SettlementTransferService : Service
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SettlementTransferService"/> class.
    /// </summary>
    /// <param name="options">K2 Options.</param>
    public SettlementTransferService(K2Options options)
        : base(options)
    {
    }
}
