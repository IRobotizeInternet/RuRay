using System.Threading.Tasks;

namespace RuRay.BLL.Contracts
{
    /// <summary>
    /// Defines the <see cref="IServiceWindowsScreen" />.
    /// </summary>
    public interface IServiceWindowsScreen
    {
        /// <summary>
        /// Use this to show or hid grid on the screen.
        /// </summary>
        /// <param name="gridVisibility">.</param>
        /// <returns>The <see cref="Task{bool}"/>.</returns>
        Task<bool> WindowGrid(GridVisibility gridVisibility);

        /// <summary>
        /// Use this to click on the screen for a specified location.
        /// </summary>
        /// <param name="gridCoordinates">Coordinate shown in the grid.</param>
        /// <returns>The <see cref="Task{bool}"/>.</returns>
        Task<bool> WindowClick(int gridCoordinates);
    }
}
