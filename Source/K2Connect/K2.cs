namespace K2Connect;

/// <summary>
/// This is the entry point for the K2Connect package.
/// </summary>
///
public class K2
{
    private readonly K2Options options;

    /// <summary>
    /// Initializes a new instance of the <see cref="K2"/> class.
    /// </summary>
    /// <param name="options">The <see cref="K2Options"/> to use while creating an instance of K2.</param>
    public K2(K2Options options) => this.options = options with { BaseUrl = $"{options.BaseUrl.TrimEnd('/')}/api/v1" };
}
