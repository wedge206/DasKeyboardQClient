namespace Wedge.DasKeyboardQClient
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using IdentityModel.Client;
    using Wedge.DasKeyboardQClient.DataContracts;

    public class CloudQClient : QClient, ICloudQClient
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

        /// <summary>
        /// Get a list of Authorized Clients
        /// </summary>
        /// <returns>List of Authorized Clients</returns>
        public async Task<List<AuthorizedClient>> GetAuthorizedClientsAsync()
        {
            return await HttpGetAsync<List<AuthorizedClient>>("users/authorized_clients", TokenHandler);
        }

        /// <summary>
        /// Revokest a client
        /// </summary>
        /// <param name="client">Client to be revoked</param>
        /// <returns>Async Task</returns>
        public async Task RevokeClientAsync(AuthorizedClient client)
        {
            await HttpPostAsync("users/revoke_client", client.ToJSON(), TokenHandler);
        }

        /// <summary>
        /// Get the list of linked devices
        /// </summary>
        /// <returns>List of Devices</returns>
        public async Task<List<Device>> GetDevicesAsync()
        {
            return await HttpGetAsync<List<Device>>("devices", TokenHandler);
        }

        /// <summary>
        /// Get the list of available devices
        /// </summary>
        /// <returns>List of Device Definitions</returns>
        public async Task<List<DeviceDefinition>> GetDeviceDefinitionsAsync()
        {
            return await HttpGetAsync<List<DeviceDefinition>>("device_definitions");
        }

        /// <summary>
        /// Gets a list of predefined colors
        /// </summary>
        /// <returns>List of Colors</returns>
        public async Task<List<Color>> GetColorsAsync()
        {
            return await HttpGetAsync<List<Color>>("colors");
        }

        /// <summary>
        /// Get a list of a device's Zones
        /// </summary>
        /// <param name="pid">PID of device</param>
        /// <returns>List of Zones</returns>
        public async Task<List<Zone>> GetZonesAsync(string pid)
        {
            return await HttpGetAsync<List<Zone>>($"{pid}/zones", TokenHandler);
        }

        /// <summary>
        /// Get a list of available Effects
        /// </summary>
        /// <param name="pid">ID of device</param>
        /// <returns>List of Effects</returns>
        public async Task<List<Effect>> GetEffectsAsync(string pid)
        {
            return await HttpGetAsync<List<Effect>>($"{pid}/effects");
        }

        /// <summary>
        /// Creates a new signal
        /// </summary>
        /// <param name="signal">Signal to be Created</param>
        /// <returns>Async Task</returns>
        public async Task CreateSignalAsync(Signal signal)
        {
            await HttpPostAsync("signals", signal.ToJSON(), TokenHandler);
        }

        /// <summary>
        /// Get a list of Signals on a device
        /// </summary>
        /// <param name="afterTime">(Optional) Epoch time</param>
        /// <returns>List of Signals</returns>
        public async Task<List<Signal>> GetSignalsAsync(int? afterTime = null)
        {
            // TODO: overload method to accept DateTime object and convert to epoch
            // TODO: implement additional query parameters
            // TODO: auto-detect multiple pages and retrieve/return complete result set
            // TODO: implement sort parameters
            return await HttpGetAsync<List<Signal>>($"signals{(afterTime.HasValue ? $"/after/{afterTime.ToString()}" : String.Empty)}", TokenHandler);
        }

        /// <summary>
        /// Updates an existing Signal
        /// </summary>
        /// <param name="id">Id of Signal to update</param>
        /// <param name="signal">Modified Signal</param>
        /// <returns>Async Task</returns>
        public async Task UpdateSignalAsync(string id, Signal signal)
        {
            await HttpPatchAsync($"signals/{id}/status", signal.ToJSON(), TokenHandler);
        }

        /// <summary>
        /// Deletes an existing Signal
        /// </summary>
        /// <param name="id">Id of the Signal to Delete</param>
        /// <returns>Async Task</returns>
        public async Task DeleteSignalAsync(string id)
        {
            await HttpDeleteAsync($"signals/{id}", TokenHandler);
        }

        /// <summary>
        /// Get the Color of a Zone
        /// </summary>
        /// <param name="pid">PID of the device</param>
        /// <param name="zoneId">ZoneId of the device</param>
        /// <returns>Color of the Zone</returns>
        public async Task<string> GetZoneColorAsync(string pid, string zoneId)
        {
            return await HttpGetAsync<string>($"signals/{pid}/{zoneId}", TokenHandler);
        }

        /// <summary>
        /// Get what is currently displayed on the device
        /// </summary>
        /// <param name="pid">PID of the device</param>
        /// <returns>Device Shadow</returns>
        public async Task<List<Signal>> GetDeviceShadowAsync(string pid)
        {
            return await HttpGetAsync<List<Signal>>($"signals/shadows/{pid}", TokenHandler);
        }

        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    tokenHandler.Dispose();
                }

                disposedValue = true;

                base.Dispose();
            }
        }
    }
}
