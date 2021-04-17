using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Robotize.BLL.Contracts
{
    public interface IServiceMouse
    {
        public Task<bool> LeftClickAtPoint(int index);

        public Task<bool> RightClickAtPoint(int index);
    }
}
