namespace Wedge.DasKeyboardQClient
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Wedge.DasKeyboardQClient.DataContracts;

    interface ICloudQClient
    {
        /// <summary>
        /// Get a list of Authorized Clients
        /// </summary>
        /// <returns>List of Authorized Clients</returns>
        Task<List<AuthorizedClient>> GetAuthorizedClientsAsync();

        /// <summary>
        /// Revokest a client
        /// </summary>
        /// <param name="client">Client to be revoked</param>
        /// <returns>Async Task</returns>
        Task RevokeClientAsync(AuthorizedClient client);

        /// <summary>
        /// Get the list of linked devices
        /// </summary>
        /// <returns>List of Devices</returns>
        Task<List<Device>> GetDevicesAsync();

        /// <summary>
        /// Get the list of available devices
        /// </summary>
        /// <returns>List of Device Definitions</returns>
        Task<List<DeviceDefinition>> GetDeviceDefinitionsAsync();

        /// <summary>
        /// Gets a list of predefined colors
        /// </summary>
        /// <returns>List of Colors</returns>
        Task<List<Color>> GetColorsAsync();

        /// <summary>
        /// Get a list of a device's Zones
        /// </summary>
        /// <param name="pid">PID of device</param>
        /// <returns>List of Zones</returns>
        Task<List<Zone>> GetZonesAsync(string pid);

        /// <summary>
        /// Get a list of available Effects
        /// </summary>
        /// <param name="pid">ID of device</param>
        /// <returns>List of Effects</returns>
        Task<List<Effect>> GetEffectsAsync(string pid);

        /// <summary>
        /// Creates a new signal
        /// </summary>
        /// <param name="signal">Signal to be Created</param>
        /// <returns>Async Task</returns>
        Task CreateSignalAsync(Signal signal);

        /// <summary>
        /// Get a list of Signals on a device
        /// </summary>
        /// <param name="afterTime">(Optional) Epoch time</param>
        /// <returns>List of Signals</returns>
        Task<List<Signal>> GetSignalsAsync(int? afterTime = null);

        /// <summary>
        /// Updates an existing Signal
        /// </summary>
        /// <param name="id">Id of Signal to update</param>
        /// <param name="signal">Modified Signal</param>
        /// <returns>Async Task</returns>
        Task UpdateSignalAsync(string id, Signal signal);

        /// <summary>
        /// Deletes an existing Signal
        /// </summary>
        /// <param name="id">Id of the Signal to Delete</param>
        /// <returns>Async Task</returns>
        Task DeleteSignalAsync(string id);

        /// <summary>
        /// Get the Color of a Zone
        /// </summary>
        /// <param name="pid">PID of the device</param>
        /// <param name="zoneId">ZoneId of the device</param>
        /// <returns>Color of the Zone</returns>
        Task<string> GetZoneColorAsync(string pid, string zoneId);

        /// <summary>
        /// Get what is currently displayed on the device
        /// </summary>
        /// <param name="pid">PID of the device</param>
        /// <returns>Device Shadow</returns>
        Task<List<Signal>> GetDeviceShadowAsync(string pid);
    }
}
