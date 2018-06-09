namespace Wedge.DasKeyboardQClient
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Wedge.DasKeyboardQClient.DataContracts;

    interface IQClient
    {
        Task<List<AuthorizedClient>> GetAuthorizedClientsAsync();

        Task RevokeClientAsync(AuthorizedClient client);

        Task<List<Device>> GetDevicesAsync();

        Task<List<DeviceDefinition>> GetDeviceDefinitionsAsync();

        Task<List<Color>> GetColorsAsync();

        Task<List<Zone>> GetZonesAsync(string pid);

        Task<List<Effect>> GetEffectsAsync(string pid);

        Task CreateSignalAsync(Signal signal);

        Task<List<Signal>> GetSignalsAsync(int? afterTime = null);

        Task UpdateSignalAsync(string id, Signal signal);

        Task DeleteSignalAsync(string id);

        Task<string> GetZoneColorAsync(string pid, string zoneId);

        Task<List<Signal>> GetDeviceShadowAsync(string pid);
    }
}
