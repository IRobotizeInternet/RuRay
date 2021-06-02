using System.Threading.Tasks;

namespace RuRay.BLL.Contracts
{
    public interface IServiceMouse
    {
        public Task<bool> LeftClickAtPoint(int index);

        public Task<bool> RightClickAtPoint(int index);

        public Task<bool> GoToXY(int index);
    }
}
