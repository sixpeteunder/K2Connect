namespace K2Connect.Requests;

/// <summary>
/// Webhook subscribe request.
/// </summary>
/// <param name="EventType">Event type.</param>
/// <param name="Url">URL.</param>
/// <param name="Scope">Scope.</param>
/// <param name="ScopeRef">Scope Ref.</param>
public record class WebhookSubscribeRequest(string EventType, string Url, string Scope, string ScopeRef);
