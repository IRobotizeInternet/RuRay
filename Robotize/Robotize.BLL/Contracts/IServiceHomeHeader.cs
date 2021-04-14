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

        /// <summary>
        /// Homepage Scroll Up
        /// </summary>
        /// <returns></returns>
        Task<bool> HomePageScrollUp();
    }
}