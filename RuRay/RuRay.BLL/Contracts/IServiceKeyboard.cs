using System.Threading.Tasks;

namespace RuRay.BLL.Contracts
{
    public interface IServiceKeyboard
    {
        Task<bool> LeftClick(int coordinateIndex);
        Task<bool> SendKey(KeyStrokes sendKey);
    }
}
