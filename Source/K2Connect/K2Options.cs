namespace K2Connect;

/// <summary>
/// Initializes a new instance of the <see cref="K2Options"/> class.
/// </summary>
/// <param name="ApiKey">The api key of the merchant.</param>
/// <param name="BaseUrl">The url to send requests to.</param>
/// <param name="ClientId">The client id of the merchant.</param>
/// <param name="ClientSecret">The client secret of the merchant.</param>
public record class K2Options(string ApiKey, string BaseUrl, string ClientId, string ClientSecret);
