﻿namespace Wedge.DasKeyboardQClient
{
    using System;
    using System.Threading.Tasks;
    using Wedge.DasKeyboardQClient.DataContracts;

    /// <summary>
    /// Local QClient Class
    /// </summary>
    public class LocalQClient : QClient, ILocalQClient
    {
        private const string DefaultHostName = "localhost";
        private const int DefaultLocalPort = 27301;

        /// <summary>
        /// Creates a QClient on localhost using the default port
        /// </summary>
        public LocalQClient() : this(DefaultLocalPort)
        {
        }

        /// <summary>
        /// Creates a QClient on localhost using a custom port
        /// </summary>
        /// <param name="localPort">Custom Port number</param>
        public LocalQClient(int localPort) : this(DefaultHostName, localPort)
        {
        }

        /// <summary>
        /// Creates a QClient on localhost using a custom hostname and custom port
        /// </summary>
        /// <param name="hostname">Custom Hostname</param>
        /// <param name="localPort">Custom Port number</param>
        /// <param name="useSsl">(Optional) Set true to use SSL</param>
        public LocalQClient(string hostname, int localPort, bool useSsl = false) : base($"{(useSsl ? "https:" : "http:")}//{hostname}:{localPort}")
        {
        }

        /// <summary>
        /// Creates a new signal
        /// </summary>
        /// <param name="signal">Signal to be Created</param>
        /// <returns>Async Task</returns>
        public async Task CreateSignalAsync(Signal signal)
        {
            await HttpPostAsync("signals", signal.ToJSON());
        }
    }
}
