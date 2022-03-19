namespace K2Connect.Services;

/// <summary>
/// Base class for K2 services.
/// </summary>
public abstract class Service
{

    /// <summary>
    /// Initializes a new instance of the <see cref="Service"/> class.
    /// </summary>
    /// <param name="options">K2 Options.</param>
    public Service(K2Options options) => this.Options = options;

    /// <summary>
    /// Gets or sets K2 options.
    /// </summary>
    protected K2Options Options { get; set; }
}
