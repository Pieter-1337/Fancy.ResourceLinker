﻿namespace Fancy.ResourceLinker.Gateway.Authentication;

public class GatewayAuthenticationSettings
{
    public const string SectionName = "GatewayAuthentication";

    public string Url { get; set; } = "";
    public int SessionTimeoutInMin { get; set; }
    public string Authority { get; set; } = "";
    public string ClientId { get; set; } = "";
    public string ClientSecret { get; set; } = "";
    public string UniqueIdentifierClaimType { get; set; } = "";
    public string[] AuthorizationCodeScopes { get; set; } = Array.Empty<string>();
    public string ClientCredentialsScope { get; set; } = "";
    public string LogoutUrl { get; set; } = "";
    public bool QueryUserInfoEndpoint { get; set; } = true;

    public void Validate()
    {
        // ToDo: Implement settings validation
    }
}