namespace Wedge.DasKeyboardQClient
{
    using System;
    using System.Threading.Tasks;
    using Wedge.DasKeyboardQClient.DataContracts;

    /// <summary>
    /// ILocalQClient
    /// </summary>
    public interface ILocalQClient
    {

        /// <summary>
        /// Creates a new signal
        /// </summary>
        /// <param name="signal">Signal to be Created</param>
        /// <returns>Async Task</returns>
        Task CreateSignalAsync(Signal signal);
    }
}
