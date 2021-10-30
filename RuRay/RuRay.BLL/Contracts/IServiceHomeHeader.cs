using System.Threading.Tasks;

namespace RuRay.BLL.Contracts
{
    /// <summary>
    /// Defines the <see cref="IServiceHomeHeader" />.
    /// </summary>
    public interface IServiceHomeHeader
    {
        /// <summary>
        /// Homepage Scroll Down.
        /// </summary>
        /// <returns>.</returns>
        Task<bool> ScrollDown();

        /// <summary>
        /// Homepage Scroll Up
        /// </summary>
        /// <returns></returns>
        Task<bool> ScrollUp();

        /// <summary>
        /// Change Facebook visual mode.
        /// </summary>
        /// <param name="mode">.</param>
        /// <returns>.</returns>
        Task<bool> FacebookChangeVisualMode(Switch mode);
    }
}
