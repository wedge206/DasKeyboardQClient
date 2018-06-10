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

        private AccessTokenHandler tokenHandler;

        public AccessTokenHandler TokenHandler
        {
            get
            {
                if (tokenHandler == null)
                {
                    tokenHandler = new AccessTokenHandler(new TokenClient($"{Url}/oauth/1.4/token", ClientId, Secret, null, AuthenticationStyle.PostValues), String.Empty);
                }

                return tokenHandler;
            }

            private set
            {
                tokenHandler = value;
            }
        }

        /// <summary>
        /// Creates a Cloud QClient without credentials (Only endpoints that do not require authentication will be available)
        /// </summary>
        public CloudQClient() : base($"https://{CloudHost}")
        {
        }

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

        public async override Task<List<AuthorizedClient>> GetAuthorizedClientsAsync()
        {
            return await HttpGetAsync<List<AuthorizedClient>>("users/authorized_clients", TokenHandler);
        }

        public async override Task RevokeClientAsync(AuthorizedClient client)
        {
            await HttpPostAsync("users/revoke_client", client.ToJSON(), TokenHandler);
        }

        public async override Task<List<Device>> GetDevicesAsync()
        {
            return await HttpGetAsync<List<Device>>("devices", TokenHandler);
        }

        public async override Task<List<DeviceDefinition>> GetDeviceDefinitionsAsync()
        {
            return await HttpGetAsync<List<DeviceDefinition>>("device_definitions");
        }

        public async override Task<List<Color>> GetColorsAsync()
        {
            return await HttpGetAsync<List<Color>>("colors");
        }

        public async override Task<List<Zone>> GetZonesAsync(string pid)
        {
            return await HttpGetAsync<List<Zone>>($"{pid}/zones", TokenHandler);
        }

        public async override Task<List<Effect>> GetEffectsAsync(string pid)
        {
            return await HttpGetAsync<List<Effect>>($"{pid}/effects");
        }

        public async override Task CreateSignalAsync(Signal signal)
        {
            await HttpPostAsync("signals", signal.ToJSON(), TokenHandler);
        }

        public async override Task<List<Signal>> GetSignalsAsync(int? afterTime = null)
        {
            // TODO: implement additional query parameters
            // TODO: auto-detect multiple pages and retrieve/return complete result set
            // TODO: implement sort parameters
            return await HttpGetAsync<List<Signal>>($"signals{(afterTime.HasValue ? $"/after/{afterTime.ToString()}" : String.Empty)}", TokenHandler);
        }

        public async override Task UpdateSignalAsync(string id, Signal signal)
        {
            await HttpPatchAsync($"signals/{id}/status", signal.ToJSON(), TokenHandler);
        }

        public async override Task DeleteSignalAsync(string id)
        {
            await HttpDeleteAsync($"signals/{id}", TokenHandler);
        }

        public async override Task<string> GetZoneColorAsync(string pid, string zoneId)
        {
            return await HttpGetAsync<string>($"signals/{pid}/{zoneId}", TokenHandler);
        }

        public async override Task<List<Signal>> GetDeviceShadowAsync(string pid)
        {
            return await HttpGetAsync<List<Signal>>($"signals/shadows/{pid}", TokenHandler);
        }
    }
}
