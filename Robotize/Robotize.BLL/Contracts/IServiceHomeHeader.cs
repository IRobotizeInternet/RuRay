using System.Threading.Tasks;

namespace Robotize.BLL.Contracts
{
    public interface IServiceHomeHeader
    {
        /// <summary>
        /// Switch Facebook color mode
        /// </summary>
        /// <param name="mode"></param>
        /// <returns></returns>
        Task<bool> FacebookSwitchMode(Switch mode);
    }
}