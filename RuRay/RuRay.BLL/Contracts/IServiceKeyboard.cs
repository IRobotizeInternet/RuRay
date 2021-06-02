using System.Threading.Tasks;

namespace RuRay.BLL.Contracts
{
    /// <summary>
    /// Defines the <see cref="IServiceKeyboard" />.
    /// </summary>
    public interface IServiceKeyboard
    {
        /// <summary>
        /// The LeftClick.
        /// </summary>
        /// <param name="coordinateIndex">The coordinateIndex<see cref="int"/>.</param>
        /// <returns>The <see cref="Task{bool}"/>.</returns>
        Task<bool> LeftClick(int coordinateIndex);

        /// <summary>
        /// The SendKey.
        /// </summary>
        /// <param name="sendKey">The sendKey<see cref="KeyStrokes"/>.</param>
        /// <returns>The <see cref="Task{bool}"/>.</returns>
        Task<bool> SendKey(KeyStrokes sendKey);
    }
}
