using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;

namespace RuRay.BLL.Contracts
{
    public interface IServiceKeyboard
    {
        Task<bool> LeftClick(int coordinateIndex);
        Task<bool> SendKey(KeyStrokes sendKey);
    }
}
