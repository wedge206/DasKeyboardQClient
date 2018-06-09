namespace Wedge.DasKeyboardQClient
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using IdentityModel.Client;
    using Wedge.DasKeyboardQClient.DataContracts;

    public class CloudQClient : QClient
    {
        private const string CloudHost = "q.daskeyboard.com";

        private string ClientId;
        private string Secret;

        private TokenResponse Token;

        /// <summary>
        /// Creates a Cloud QClient using the specified credentials
        /// </summary>
        /// <param name="clientId">Cloud Client Id</param>
        /// <param name="secret">Cloud Secret</param>
        public CloudQClient(string clientId, string secret) : base($"https://{CloudHost}")
        {
            ClientId = clientId;
            Secret = secret;
        }

        private async Task<string> GetAuthToken()
        {
            // TODO: Check if token is expired/invalid/etc, and renew when necessary
            if (Token == null)
            {
                using (var tokenClient = new TokenClient($"{Url}/oauth/1.4/token", ClientId, Secret, null, AuthenticationStyle.PostValues))
                {
                    var tokenResponse = await tokenClient.RequestClientCredentialsAsync();

                    if (tokenResponse.HttpStatusCode != System.Net.HttpStatusCode.OK || tokenResponse.Exception != null)
                    {
                        throw new Exception($"Failed to authenticate. \r\n {tokenResponse.Error} \r\n {tokenResponse.ErrorDescription}", tokenResponse.Exception);
                    }

                    Token = tokenResponse;
                }
            }

            return Token.AccessToken;
        }

        public async override Task<List<AuthorizedClient>> GetAuthorizedClientsAsync()
        {
            return await HttpGetAsync<List<AuthorizedClient>>("users/authorized_clients", await GetAuthToken());
        }

        public async override Task RevokeClientAsync(AuthorizedClient client)
        {
            await HttpPostAsync("users/revoke_client", client.ToJSON(), await GetAuthToken());
        }

        public async override Task<List<Device>> GetDevicesAsync()
        {
            return await HttpGetAsync<List<Device>>("devices", await GetAuthToken());
        }

        public async override Task<List<DeviceDefinition>> GetDeviceDefinitionsAsync()
        {
            return await HttpGetAsync<List<DeviceDefinition>>("device_definitions", await GetAuthToken());
        }

        public async override Task<List<Color>> GetColorsAsync()
        {
            return await HttpGetAsync<List<Color>>("colors", await GetAuthToken());
        }

        public async override Task<List<Zone>> GetZonesAsync(string pid)
        {
            return await HttpGetAsync<List<Zone>>($"{pid}/zones", await GetAuthToken());
        }

        public async override Task<List<Effect>> GetEffectsAsync(string pid)
        {
            return await HttpGetAsync<List<Effect>>($"{pid}/effects", await GetAuthToken());
        }

        public async override Task CreateSignalAsync(Signal signal)
        {
            await HttpPostAsync("signals", signal.ToJSON(), await GetAuthToken());
        }

        public async override Task<List<Signal>> GetSignalsAsync(int? afterTime = null)
        {
            // TODO: implement additional query parameters
            // TODO: auto-detect multiple pages and retrieve/return complete result set
            // TODO: implement sort parameters
            return await HttpGetAsync<List<Signal>>($"signals{(afterTime.HasValue ? $"/after/{afterTime.ToString()}" : String.Empty)}", await GetAuthToken());
        }

        public async override Task UpdateSignalAsync(string id, Signal signal)
        {
            await HttpPatchAsync($"signals/{id}/status", signal.ToJSON(), await GetAuthToken());
        }

        public async override Task DeleteSignalAsync(string id)
        {
            await HttpDeleteAsync($"signals/{id}", await GetAuthToken());
        }

        public async override Task<string> GetZoneColorAsync(string pid, string zoneId)
        {
            return await HttpGetAsync<string>($"signals/{pid}/{zoneId}", await GetAuthToken());
        }

        public async override Task<List<Signal>> GetDeviceShadowAsync(string pid)
        {
            return await HttpGetAsync<List<Signal>>($"signals/shadows/{pid}", await GetAuthToken());
        }
    }
}
