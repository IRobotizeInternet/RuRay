using System.Diagnostics;

namespace RobotizeFacebook.Services
{
    public class ServiceTask
    {
        public static void CloseTask(string taskName)
        {
            foreach (var process in Process.GetProcessesByName(taskName)) process.Kill();
        }

        public static void CreateTask(string taskName)
        {
            var p = new Process
            {
                StartInfo = new ProcessStartInfo(taskName)
                {
                    UseShellExecute = true
                }
            };
            p.Start();
        }
    }
}
