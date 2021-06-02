using System.Threading.Tasks;

namespace RuRay.BLL.Contracts
{
    /// <summary>
    /// Defines the <see cref="IServiceMouse" />.
    /// </summary>
    public interface IServiceMouse
    {
        /// <summary>
        /// The LeftClickAtPoint.
        /// </summary>
        /// <param name="index">The index<see cref="int"/>.</param>
        /// <returns>The <see cref="Task{bool}"/>.</returns>
        public Task<bool> LeftClickAtPoint(int index);

        /// <summary>
        /// The RightClickAtPoint.
        /// </summary>
        /// <param name="index">The index<see cref="int"/>.</param>
        /// <returns>The <see cref="Task{bool}"/>.</returns>
        public Task<bool> RightClickAtPoint(int index);

        /// <summary>
        /// The GoToXY.
        /// </summary>
        /// <param name="index">The index<see cref="int"/>.</param>
        /// <returns>The <see cref="Task{bool}"/>.</returns>
        public Task<bool> GoToXY(int index);
    }
}
