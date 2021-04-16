using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;

namespace Robotize.BLL.Contracts
{
    public interface IServiceKeyboard
    {
        Task<bool> LeftClick(int coordinateIndex);
    }
}
