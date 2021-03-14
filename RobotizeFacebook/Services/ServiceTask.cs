using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotizeFacebook.Services
{
    public class ServiceTask
    {
        public static void CloseTask(string taskName)
        {
            foreach (var process in Process.GetProcessesByName(taskName))
            {
                process.Kill();
            }
        }
    }
}
