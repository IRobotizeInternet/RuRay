using System.Threading.Tasks;

namespace Robotize.BLL.Contracts
{
    public interface IServiceHomeHeader
    {
        /// <summary>
        /// Homepage Scroll Down
        /// </summary>
        /// <returns></returns>
        Task<bool> HomePageScrollDown();

        ///// <summary>
        ///// Homepage Scroll Up
        ///// </summary>
        ///// <returns></returns>
        //Task<bool> HomePageScrollUp();

        /// <summary>
        /// Change Facebook visual mode
        /// </summary>
        /// <param name="mode"></param>
        /// <returns></returns>
        Task<bool> FacebookChangeVisualMode(Switch mode);
    }
}